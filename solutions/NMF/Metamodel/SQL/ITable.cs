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
using System.Linq;

namespace TTC2021.OclToSql.Sql
{
    
    
    /// <summary>
    /// The public interface for Table
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Table))]
    [XmlDefaultImplementationTypeAttribute(typeof(Table))]
    [ModelRepresentationClassAttribute("http://www.example.org/sql#//Table")]
    public interface ITable : IModelElement, IFromItem
    {
        
        /// <summary>
        /// The name property
        /// </summary>
        [DisplayNameAttribute("name")]
        [CategoryAttribute("Table")]
        [XmlElementNameAttribute("name")]
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// The alias property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("alias")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        IAlias Alias
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        /// <summary>
        /// Gets fired before the Alias property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AliasChanging;
        
        /// <summary>
        /// Gets fired when the Alias property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> AliasChanged;
    }
}
