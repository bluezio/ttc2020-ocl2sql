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
    /// The default implementation of the PropertyCallExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.example.org/ocl/exp")]
    [XmlNamespacePrefixAttribute("EXP")]
    [ModelRepresentationClassAttribute("http://www.example.org/ocl#//exp/PropertyCallExp")]
    public partial class PropertyCallExp : CallExp, IPropertyCallExp, IModelElement
    {
        
        private static Lazy<ITypedElement> _referredPropertyReference = new Lazy<ITypedElement>(RetrieveReferredPropertyReference);
        
        /// <summary>
        /// The backing field for the ReferredProperty property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private TTC2021.OclToSql.Ocl.Dm.IAttribute _referredProperty;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The referredProperty property
        /// </summary>
        [DisplayNameAttribute("referredProperty")]
        [CategoryAttribute("PropertyCallExp")]
        [XmlElementNameAttribute("referredProperty")]
        [XmlAttributeAttribute(true)]
        public TTC2021.OclToSql.Ocl.Dm.IAttribute ReferredProperty
        {
            get
            {
                return this._referredProperty;
            }
            set
            {
                if ((this._referredProperty != value))
                {
                    TTC2021.OclToSql.Ocl.Dm.IAttribute old = this._referredProperty;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReferredPropertyChanging(e);
                    this.OnPropertyChanging("ReferredProperty", e, _referredPropertyReference);
                    this._referredProperty = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetReferredProperty;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetReferredProperty;
                    }
                    this.OnReferredPropertyChanged(e);
                    this.OnPropertyChanged("ReferredProperty", e, _referredPropertyReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new PropertyCallExpReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/PropertyCallExp")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ReferredProperty property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferredPropertyChanging;
        
        /// <summary>
        /// Gets fired when the ReferredProperty property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferredPropertyChanged;
        
        private static ITypedElement RetrieveReferredPropertyReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Ocl.Exp.PropertyCallExp.ClassInstance)).Resolve("referredProperty")));
        }
        
        /// <summary>
        /// Raises the ReferredPropertyChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredPropertyChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferredPropertyChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReferredPropertyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredPropertyChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferredPropertyChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ReferredProperty property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetReferredProperty(object sender, System.EventArgs eventArgs)
        {
            this.ReferredProperty = null;
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "REFERREDPROPERTY"))
            {
                return this.ReferredProperty;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REFERREDPROPERTY"))
            {
                this.ReferredProperty = ((TTC2021.OclToSql.Ocl.Dm.IAttribute)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "REFERREDPROPERTY"))
            {
                return new ReferredPropertyProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/PropertyCallExp")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the PropertyCallExp class
        /// </summary>
        public class PropertyCallExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private PropertyCallExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public PropertyCallExpReferencedElementsCollection(PropertyCallExp parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.ReferredProperty != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReferredPropertyChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReferredPropertyChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ReferredProperty == null))
                {
                    TTC2021.OclToSql.Ocl.Dm.IAttribute referredPropertyCasted = item.As<TTC2021.OclToSql.Ocl.Dm.IAttribute>();
                    if ((referredPropertyCasted != null))
                    {
                        this._parent.ReferredProperty = referredPropertyCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReferredProperty = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ReferredProperty))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.ReferredProperty != null))
                {
                    array[arrayIndex] = this._parent.ReferredProperty;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ReferredProperty == item))
                {
                    this._parent.ReferredProperty = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReferredProperty).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the referredProperty property
        /// </summary>
        private sealed class ReferredPropertyProxy : ModelPropertyChange<IPropertyCallExp, TTC2021.OclToSql.Ocl.Dm.IAttribute>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferredPropertyProxy(IPropertyCallExp modelElement) : 
                    base(modelElement, "referredProperty")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override TTC2021.OclToSql.Ocl.Dm.IAttribute Value
            {
                get
                {
                    return this.ModelElement.ReferredProperty;
                }
                set
                {
                    this.ModelElement.ReferredProperty = value;
                }
            }
        }
    }
}

