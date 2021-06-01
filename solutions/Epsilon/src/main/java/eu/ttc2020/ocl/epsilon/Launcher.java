package eu.ttc2020.ocl.epsilon;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Arrays;

import org.vgu.se.sql.parser.SQLParser;

import ocl.dm.DmPackage;
import ocl.exp.ExpPackage;
import sql.SqlPackage;

public class Launcher {

	public static void main(String[] args) throws Exception {
		if (args.length != 1) {
			System.err.println("Usage: java -jar [...] pathToModelsFolder");
			System.exit(1);
		}

		final String modelsFolderPath = args[0];
		final File modelsFolder = new File(modelsFolderPath);
		if (!modelsFolder.isDirectory()) {
			System.err.println(String.format("'%s' is not a directory", modelsFolderPath));
			System.exit(2);
		}

		// Ensure all static metamodels are registered
		DmPackage.eINSTANCE.getName();
		ExpPackage.eINSTANCE.getName();
		SqlPackage.eINSTANCE.getName();

		File outputFolder = new File("outputs");
		if (outputFolder.isDirectory()) {
			for (File f : outputFolder.listFiles()) {
				f.delete();
			}
		} else {
			outputFolder.mkdirs();
		}

		File[] challengeFiles = modelsFolder.listFiles(f -> f.getName().startsWith("Stage") && f.getName().endsWith(".xmi"));
		Arrays.sort(challengeFiles, (a, b) -> a.getName().compareTo(b.getName()));
		for (File oclXMIFile : challengeFiles) {
			final File sqlXMIFile = new File(outputFolder, oclXMIFile.getName().replaceAll("[.]xmi$", "-sql.xmi"));
			System.out.println(String.format("Transforming %s into %s", oclXMIFile.getPath(), sqlXMIFile.getPath()));
			new OCL2SQL(oclXMIFile, sqlXMIFile).run();

			final String sqlStatement = SQLParser.outputEStatementAsString(sqlXMIFile);
			final File sqlTextFile = new File(outputFolder, oclXMIFile.getName().replaceAll("[.]xmi$", "-default.sql")); 
			System.out.println(String.format("Transforming %s into %s", sqlXMIFile.getPath(), sqlTextFile.getPath()));
			saveStringToFile(sqlStatement, sqlTextFile);

			final File sqlEGLTextFile = new File(outputFolder, oclXMIFile.getName().replaceAll("[.]xmi$", "-egl.sql")); 
			System.out.println(String.format("Transforming %s into %s", sqlXMIFile.getPath(), sqlEGLTextFile.getPath()));
			String eglSQL = new SQL2Text(sqlXMIFile, sqlEGLTextFile).run();
			saveStringToFile(eglSQL, sqlEGLTextFile);
		}
	}

	private static void saveStringToFile(final String sqlStatement, final File sqlTextFile) throws IOException {
		try (FileWriter fw = new FileWriter(sqlTextFile); PrintWriter pw = new PrintWriter(fw)) {
			pw.println(sqlStatement);
		}
	}

}
