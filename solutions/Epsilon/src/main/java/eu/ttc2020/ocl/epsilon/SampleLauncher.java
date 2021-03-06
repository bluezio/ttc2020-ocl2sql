package eu.ttc2020.ocl.epsilon;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Arrays;

import org.eclipse.epsilon.emc.emf.EmfModel;

import eu.ttc2020.ocl.epsilon.tx.OCL2SQL;
import eu.ttc2020.ocl.epsilon.tx.SQL2Text;
import ocl.dm.DmPackage;
import ocl.exp.ExpPackage;
import sql.SqlPackage;

public class SampleLauncher {

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
			final long nanoStart = System.nanoTime();
			EmfModel emfModel = new OCL2SQL(oclXMIFile).run();
			final File sqlEGLTextFile = new File(outputFolder, oclXMIFile.getName().replaceAll("[.]xmi$", "-egl.sql")); 
			System.out.println(String.format("Transforming %s into %s", oclXMIFile.getPath(), sqlEGLTextFile.getPath()));
			String eglSQL = new SQL2Text(emfModel.getResource()).run();
			System.out.println(String.format("Transformed in %.2f seconds", (System.nanoTime() - nanoStart)/1.e9));

			saveStringToFile(eglSQL, sqlEGLTextFile);
		}
	}

	private static void saveStringToFile(final String sqlStatement, final File sqlTextFile) throws IOException {
		try (FileWriter fw = new FileWriter(sqlTextFile); PrintWriter pw = new PrintWriter(fw)) {
			pw.println(sqlStatement);
		}
	}

}
