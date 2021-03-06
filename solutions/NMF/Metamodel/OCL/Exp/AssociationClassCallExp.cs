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
    /// The default implementation of the AssociationClassCallExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.example.org/ocl/exp")]
    [XmlNamespacePrefixAttribute("EXP")]
    [ModelRepresentationClassAttribute("http://www.example.org/ocl#//exp/AssociationClassCallExp")]
    public partial class AssociationClassCallExp : CallExp, IAssociationClassCallExp, IModelElement
    {
        
        private static Lazy<ITypedElement> _referredAssociationEndsReference = new Lazy<ITypedElement>(RetrieveReferredAssociationEndsReference);
        
        /// <summary>
        /// The backing field for the ReferredAssociationEnds property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IAssociationEnd _referredAssociationEnds;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The referredAssociationEnds property
        /// </summary>
        [DisplayNameAttribute("referredAssociationEnds")]
        [CategoryAttribute("AssociationClassCallExp")]
        [XmlElementNameAttribute("referredAssociationEnds")]
        [XmlAttributeAttribute(true)]
        public IAssociationEnd ReferredAssociationEnds
        {
            get
            {
                return this._referredAssociationEnds;
            }
            set
            {
                if ((this._referredAssociationEnds != value))
                {
                    IAssociationEnd old = this._referredAssociationEnds;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReferredAssociationEndsChanging(e);
                    this.OnPropertyChanging("ReferredAssociationEnds", e, _referredAssociationEndsReference);
                    this._referredAssociationEnds = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetReferredAssociationEnds;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetReferredAssociationEnds;
                    }
                    this.OnReferredAssociationEndsChanged(e);
                    this.OnPropertyChanged("ReferredAssociationEnds", e, _referredAssociationEndsReference);
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
                return base.ReferencedElements.Concat(new AssociationClassCallExpReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/AssociationClassCallExp")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ReferredAssociationEnds property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferredAssociationEndsChanging;
        
        /// <summary>
        /// Gets fired when the ReferredAssociationEnds property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferredAssociationEndsChanged;
        
        private static ITypedElement RetrieveReferredAssociationEndsReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Ocl.Exp.AssociationClassCallExp.ClassInstance)).Resolve("referredAssociationEnds")));
        }
        
        /// <summary>
        /// Raises the ReferredAssociationEndsChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredAssociationEndsChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferredAssociationEndsChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReferredAssociationEndsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredAssociationEndsChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferredAssociationEndsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ReferredAssociationEnds property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetReferredAssociationEnds(object sender, System.EventArgs eventArgs)
        {
            this.ReferredAssociationEnds = null;
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "REFERREDASSOCIATIONENDS"))
            {
                return this.ReferredAssociationEnds;
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
            if ((feature == "REFERREDASSOCIATIONENDS"))
            {
                this.ReferredAssociationEnds = ((IAssociationEnd)(value));
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
            if ((reference == "REFERREDASSOCIATIONENDS"))
            {
                return new ReferredAssociationEndsProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/AssociationClassCallExp")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AssociationClassCallExp class
        /// </summary>
        public class AssociationClassCallExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AssociationClassCallExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AssociationClassCallExpReferencedElementsCollection(AssociationClassCallExp parent)
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
                    if ((this._parent.ReferredAssociationEnds != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReferredAssociationEndsChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReferredAssociationEndsChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ReferredAssociationEnds == null))
                {
                    IAssociationEnd referredAssociationEndsCasted = item.As<IAssociationEnd>();
                    if ((referredAssociationEndsCasted != null))
                    {
                        this._parent.ReferredAssociationEnds = referredAssociationEndsCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReferredAssociationEnds = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ReferredAssociationEnds))
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
                if ((this._parent.ReferredAssociationEnds != null))
                {
                    array[arrayIndex] = this._parent.ReferredAssociationEnds;
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
                if ((this._parent.ReferredAssociationEnds == item))
                {
                    this._parent.ReferredAssociationEnds = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReferredAssociationEnds).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the referredAssociationEnds property
        /// </summary>
        private sealed class ReferredAssociationEndsProxy : ModelPropertyChange<IAssociationClassCallExp, IAssociationEnd>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferredAssociationEndsProxy(IAssociationClassCallExp modelElement) : 
                    base(modelElement, "referredAssociationEnds")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAssociationEnd Value
            {
                get
                {
                    return this.ModelElement.ReferredAssociationEnds;
                }
                set
                {
                    this.ModelElement.ReferredAssociationEnds = value;
                }
            }
        }
    }
}

