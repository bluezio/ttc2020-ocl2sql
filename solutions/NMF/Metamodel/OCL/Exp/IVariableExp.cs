//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using TTC2021.OclToSql.Ocl.Dm;

namespace TTC2021.OclToSql.Ocl.Exp
{
    
    
    /// <summary>
    /// The public interface for VariableExp
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(VariableExp))]
    [XmlDefaultImplementationTypeAttribute(typeof(VariableExp))]
    [ModelRepresentationClassAttribute("http://www.example.org/ocl#//exp/VariableExp")]
    public interface IVariableExp : IModelElement, IOclExpression
    {
        
        /// <summary>
        /// The referredVariable property
        /// </summary>
        [DisplayNameAttribute("referredVariable")]
        [CategoryAttribute("VariableExp")]
        [XmlElementNameAttribute("referredVariable")]
        [XmlAttributeAttribute(true)]
        IVariable ReferredVariable
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ReferredVariable property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReferredVariableChanging;
        
        /// <summary>
        /// Gets fired when the ReferredVariable property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ReferredVariableChanged;
    }
}

