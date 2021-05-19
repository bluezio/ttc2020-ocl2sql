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
    /// The default implementation of the OperationCallExp class
    /// </summary>
    [XmlNamespaceAttribute("http://www.example.org/ocl/exp")]
    [XmlNamespacePrefixAttribute("EXP")]
    [ModelRepresentationClassAttribute("http://www.example.org/ocl#//exp/OperationCallExp")]
    public partial class OperationCallExp : CallExp, IOperationCallExp, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ReferredOperation property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private Operator _referredOperation;
        
        private static Lazy<ITypedElement> _referredOperationAttribute = new Lazy<ITypedElement>(RetrieveReferredOperationAttribute);
        
        private static Lazy<ITypedElement> _argumentReference = new Lazy<ITypedElement>(RetrieveArgumentReference);
        
        /// <summary>
        /// The backing field for the Argument property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private OperationCallExpArgumentCollection _argument;
        
        private static IClass _classInstance;
        
        public OperationCallExp()
        {
            this._argument = new OperationCallExpArgumentCollection(this);
            this._argument.CollectionChanging += this.ArgumentCollectionChanging;
            this._argument.CollectionChanged += this.ArgumentCollectionChanged;
        }
        
        /// <summary>
        /// The referredOperation property
        /// </summary>
        [DisplayNameAttribute("referredOperation")]
        [CategoryAttribute("OperationCallExp")]
        [XmlElementNameAttribute("referredOperation")]
        [XmlAttributeAttribute(true)]
        public Operator ReferredOperation
        {
            get
            {
                return this._referredOperation;
            }
            set
            {
                if ((this._referredOperation != value))
                {
                    object old = this._referredOperation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReferredOperationChanging(e);
                    this.OnPropertyChanging("ReferredOperation", e, _referredOperationAttribute);
                    this._referredOperation = value;
                    this.OnReferredOperationChanged(e);
                    this.OnPropertyChanged("ReferredOperation", e, _referredOperationAttribute);
                }
            }
        }
        
        /// <summary>
        /// The argument property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("argument")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("parentCall")]
        [ConstantAttribute()]
        public IOrderedSetExpression<IOclExpression> Argument
        {
            get
            {
                return this._argument;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new OperationCallExpChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new OperationCallExpReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/OperationCallExp")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ReferredOperation property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferredOperationChanging;
        
        /// <summary>
        /// Gets fired when the ReferredOperation property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReferredOperationChanged;
        
        private static ITypedElement RetrieveReferredOperationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Ocl.Exp.OperationCallExp.ClassInstance)).Resolve("referredOperation")));
        }
        
        /// <summary>
        /// Raises the ReferredOperationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredOperationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferredOperationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReferredOperationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferredOperationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReferredOperationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveArgumentReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Ocl.Exp.OperationCallExp.ClassInstance)).Resolve("argument")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Argument property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ArgumentCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Argument", e, _argumentReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Argument property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ArgumentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Argument", e, _argumentReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int argumentIndex = ModelHelper.IndexOfReference(this.Argument, element);
            if ((argumentIndex != -1))
            {
                return ModelHelper.CreatePath("argument", argumentIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "ARGUMENT"))
            {
                if ((index < this.Argument.Count))
                {
                    return this.Argument[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "REFERREDOPERATION"))
            {
                return this.ReferredOperation;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ARGUMENT"))
            {
                return this._argument;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REFERREDOPERATION"))
            {
                this.ReferredOperation = ((Operator)(value));
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
            if ((attribute == "REFERREDOPERATION"))
            {
                return Observable.Box(new ReferredOperationProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._argument))
            {
                return "argument";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/OperationCallExp")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OperationCallExp class
        /// </summary>
        public class OperationCallExpChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OperationCallExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OperationCallExpChildrenCollection(OperationCallExp parent)
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
                    count = (count + this._parent.Argument.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Argument.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Argument.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IOclExpression argumentCasted = item.As<IOclExpression>();
                if ((argumentCasted != null))
                {
                    this._parent.Argument.Add(argumentCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Argument.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Argument.Contains(item))
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
                IEnumerator<IModelElement> argumentEnumerator = this._parent.Argument.GetEnumerator();
                try
                {
                    for (
                    ; argumentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = argumentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    argumentEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IOclExpression oclExpressionItem = item.As<IOclExpression>();
                if (((oclExpressionItem != null) 
                            && this._parent.Argument.Remove(oclExpressionItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Argument).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OperationCallExp class
        /// </summary>
        public class OperationCallExpReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OperationCallExp _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OperationCallExpReferencedElementsCollection(OperationCallExp parent)
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
                    count = (count + this._parent.Argument.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Argument.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Argument.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IOclExpression argumentCasted = item.As<IOclExpression>();
                if ((argumentCasted != null))
                {
                    this._parent.Argument.Add(argumentCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Argument.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Argument.Contains(item))
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
                IEnumerator<IModelElement> argumentEnumerator = this._parent.Argument.GetEnumerator();
                try
                {
                    for (
                    ; argumentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = argumentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    argumentEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IOclExpression oclExpressionItem = item.As<IOclExpression>();
                if (((oclExpressionItem != null) 
                            && this._parent.Argument.Remove(oclExpressionItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Argument).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the referredOperation property
        /// </summary>
        private sealed class ReferredOperationProxy : ModelPropertyChange<IOperationCallExp, Operator>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferredOperationProxy(IOperationCallExp modelElement) : 
                    base(modelElement, "referredOperation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Operator Value
            {
                get
                {
                    return this.ModelElement.ReferredOperation;
                }
                set
                {
                    this.ModelElement.ReferredOperation = value;
                }
            }
        }
    }
}
