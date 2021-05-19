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
    /// The default implementation of the BooleanLiteralExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.example.org/ocl/exp")]
    [XmlNamespacePrefixAttribute("EXP")]
    [ModelRepresentationClassAttribute("http://www.example.org/ocl#//exp/BooleanLiteralExp")]
    public partial class BooleanLiteralExp : OclExpression, IBooleanLiteralExp, IModelElement
    {
        
        /// <summary>
        /// The backing field for the BooleanValue property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private Nullable<bool> _booleanValue;
        
        private static Lazy<ITypedElement> _booleanValueAttribute = new Lazy<ITypedElement>(RetrieveBooleanValueAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The booleanValue property
        /// </summary>
        [DisplayNameAttribute("booleanValue")]
        [CategoryAttribute("BooleanLiteralExp")]
        [XmlElementNameAttribute("booleanValue")]
        [XmlAttributeAttribute(true)]
        public Nullable<bool> BooleanValue
        {
            get
            {
                return this._booleanValue;
            }
            set
            {
                if ((this._booleanValue != value))
                {
                    Nullable<bool> old = this._booleanValue;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBooleanValueChanging(e);
                    this.OnPropertyChanging("BooleanValue", e, _booleanValueAttribute);
                    this._booleanValue = value;
                    this.OnBooleanValueChanged(e);
                    this.OnPropertyChanged("BooleanValue", e, _booleanValueAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/BooleanLiteralExp")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the BooleanValue property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BooleanValueChanging;
        
        /// <summary>
        /// Gets fired when the BooleanValue property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BooleanValueChanged;
        
        private static ITypedElement RetrieveBooleanValueAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Ocl.Exp.BooleanLiteralExp.ClassInstance)).Resolve("booleanValue")));
        }
        
        /// <summary>
        /// Raises the BooleanValueChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBooleanValueChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BooleanValueChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BooleanValueChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBooleanValueChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BooleanValueChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "BOOLEANVALUE"))
            {
                return this.BooleanValue;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "BOOLEANVALUE"))
            {
                this.BooleanValue = ((bool)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "BOOLEANVALUE"))
            {
                return Observable.Box(new BooleanValueProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/BooleanLiteralExp")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the booleanValue property
        /// </summary>
        private sealed class BooleanValueProxy : ModelPropertyChange<IBooleanLiteralExp, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BooleanValueProxy(IBooleanLiteralExp modelElement) : 
                    base(modelElement, "booleanValue")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.BooleanValue;
                }
                set
                {
                    this.ModelElement.BooleanValue = value;
                }
            }
        }
    }
}
