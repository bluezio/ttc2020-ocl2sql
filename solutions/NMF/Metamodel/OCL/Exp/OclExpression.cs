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
    /// The default implementation of the OclExpression class
    /// </summary>
    [XmlNamespaceAttribute("http://www.example.org/ocl/exp")]
    [XmlNamespacePrefixAttribute("EXP")]
    [ModelRepresentationClassAttribute("http://www.example.org/ocl#//exp/OclExpression")]
    public abstract partial class OclExpression : ModelElement, IOclExpression, IModelElement
    {
        
        private static Lazy<ITypedElement> _loopBodyOwnerReference = new Lazy<ITypedElement>(RetrieveLoopBodyOwnerReference);
        
        /// <summary>
        /// The backing field for the LoopBodyOwner property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IIteratorExp _loopBodyOwner;
        
        private static Lazy<ITypedElement> _appliedElementReference = new Lazy<ITypedElement>(RetrieveAppliedElementReference);
        
        /// <summary>
        /// The backing field for the AppliedElement property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private ICallExp _appliedElement;
        
        private static Lazy<ITypedElement> _parentCallReference = new Lazy<ITypedElement>(RetrieveParentCallReference);
        
        /// <summary>
        /// The backing field for the ParentCall property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IOperationCallExp _parentCall;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The loopBodyOwner property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("loopBodyOwner")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("body")]
        public IIteratorExp LoopBodyOwner
        {
            get
            {
                return this._loopBodyOwner;
            }
            set
            {
                if ((this._loopBodyOwner != value))
                {
                    IIteratorExp old = this._loopBodyOwner;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLoopBodyOwnerChanging(e);
                    this.OnPropertyChanging("LoopBodyOwner", e, _loopBodyOwnerReference);
                    this._loopBodyOwner = value;
                    this.Parent = value;
                    if ((old != null))
                    {
                        old.Body = null;
                    }
                    if ((value != null))
                    {
                        value.Body = this;
                    }
                    this.OnLoopBodyOwnerChanged(e);
                    this.OnPropertyChanged("LoopBodyOwner", e, _loopBodyOwnerReference);
                }
            }
        }
        
        /// <summary>
        /// The appliedElement property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("appliedElement")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("source")]
        public ICallExp AppliedElement
        {
            get
            {
                return this._appliedElement;
            }
            set
            {
                if ((this._appliedElement != value))
                {
                    ICallExp old = this._appliedElement;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAppliedElementChanging(e);
                    this.OnPropertyChanging("AppliedElement", e, _appliedElementReference);
                    this._appliedElement = value;
                    this.Parent = value;
                    if ((old != null))
                    {
                        old.Source = null;
                    }
                    if ((value != null))
                    {
                        value.Source = this;
                    }
                    this.OnAppliedElementChanged(e);
                    this.OnPropertyChanged("AppliedElement", e, _appliedElementReference);
                }
            }
        }
        
        /// <summary>
        /// The parentCall property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("parentCall")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("argument")]
        public IOperationCallExp ParentCall
        {
            get
            {
                return this._parentCall;
            }
            set
            {
                if ((this._parentCall != value))
                {
                    IOperationCallExp old = this._parentCall;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnParentCallChanging(e);
                    this.OnPropertyChanging("ParentCall", e, _parentCallReference);
                    this._parentCall = value;
                    this.Parent = value;
                    if ((old != null))
                    {
                        old.Argument.Remove(this);
                    }
                    if ((value != null))
                    {
                        value.Argument.Add(this);
                    }
                    this.OnParentCallChanged(e);
                    this.OnPropertyChanged("ParentCall", e, _parentCallReference);
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
                return base.ReferencedElements.Concat(new OclExpressionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/OclExpression")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the LoopBodyOwner property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LoopBodyOwnerChanging;
        
        /// <summary>
        /// Gets fired when the LoopBodyOwner property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LoopBodyOwnerChanged;
        
        /// <summary>
        /// Gets fired before the AppliedElement property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AppliedElementChanging;
        
        /// <summary>
        /// Gets fired when the AppliedElement property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AppliedElementChanged;
        
        /// <summary>
        /// Gets fired before the ParentCall property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ParentCallChanging;
        
        /// <summary>
        /// Gets fired when the ParentCall property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ParentCallChanged;
        
        private static ITypedElement RetrieveLoopBodyOwnerReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Ocl.Exp.OclExpression.ClassInstance)).Resolve("loopBodyOwner")));
        }
        
        /// <summary>
        /// Raises the LoopBodyOwnerChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoopBodyOwnerChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LoopBodyOwnerChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LoopBodyOwnerChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoopBodyOwnerChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LoopBodyOwnerChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the LoopBodyOwner property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLoopBodyOwner(object sender, System.EventArgs eventArgs)
        {
            this.LoopBodyOwner = null;
        }
        
        private static ITypedElement RetrieveAppliedElementReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Ocl.Exp.OclExpression.ClassInstance)).Resolve("appliedElement")));
        }
        
        /// <summary>
        /// Raises the AppliedElementChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAppliedElementChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AppliedElementChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AppliedElementChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAppliedElementChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AppliedElementChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AppliedElement property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAppliedElement(object sender, System.EventArgs eventArgs)
        {
            this.AppliedElement = null;
        }
        
        private static ITypedElement RetrieveParentCallReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Ocl.Exp.OclExpression.ClassInstance)).Resolve("parentCall")));
        }
        
        /// <summary>
        /// Raises the ParentCallChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentCallChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ParentCallChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ParentCallChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentCallChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ParentCallChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ParentCall property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetParentCall(object sender, System.EventArgs eventArgs)
        {
            this.ParentCall = null;
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "LOOPBODYOWNER"))
            {
                return this.LoopBodyOwner;
            }
            if ((reference == "APPLIEDELEMENT"))
            {
                return this.AppliedElement;
            }
            if ((reference == "PARENTCALL"))
            {
                return this.ParentCall;
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
            if ((feature == "LOOPBODYOWNER"))
            {
                this.LoopBodyOwner = ((IIteratorExp)(value));
                return;
            }
            if ((feature == "APPLIEDELEMENT"))
            {
                this.AppliedElement = ((ICallExp)(value));
                return;
            }
            if ((feature == "PARENTCALL"))
            {
                this.ParentCall = ((IOperationCallExp)(value));
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
            if ((reference == "LOOPBODYOWNER"))
            {
                return new LoopBodyOwnerProxy(this);
            }
            if ((reference == "APPLIEDELEMENT"))
            {
                return new AppliedElementProxy(this);
            }
            if ((reference == "PARENTCALL"))
            {
                return new ParentCallProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/ocl#//exp/OclExpression")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OclExpression class
        /// </summary>
        public class OclExpressionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OclExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OclExpressionReferencedElementsCollection(OclExpression parent)
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
                    if ((this._parent.LoopBodyOwner != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.AppliedElement != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ParentCall != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LoopBodyOwnerChanged += this.PropagateValueChanges;
                this._parent.AppliedElementChanged += this.PropagateValueChanges;
                this._parent.ParentCallChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LoopBodyOwnerChanged -= this.PropagateValueChanges;
                this._parent.AppliedElementChanged -= this.PropagateValueChanges;
                this._parent.ParentCallChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.LoopBodyOwner == null))
                {
                    IIteratorExp loopBodyOwnerCasted = item.As<IIteratorExp>();
                    if ((loopBodyOwnerCasted != null))
                    {
                        this._parent.LoopBodyOwner = loopBodyOwnerCasted;
                        return;
                    }
                }
                if ((this._parent.AppliedElement == null))
                {
                    ICallExp appliedElementCasted = item.As<ICallExp>();
                    if ((appliedElementCasted != null))
                    {
                        this._parent.AppliedElement = appliedElementCasted;
                        return;
                    }
                }
                if ((this._parent.ParentCall == null))
                {
                    IOperationCallExp parentCallCasted = item.As<IOperationCallExp>();
                    if ((parentCallCasted != null))
                    {
                        this._parent.ParentCall = parentCallCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LoopBodyOwner = null;
                this._parent.AppliedElement = null;
                this._parent.ParentCall = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.LoopBodyOwner))
                {
                    return true;
                }
                if ((item == this._parent.AppliedElement))
                {
                    return true;
                }
                if ((item == this._parent.ParentCall))
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
                if ((this._parent.LoopBodyOwner != null))
                {
                    array[arrayIndex] = this._parent.LoopBodyOwner;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.AppliedElement != null))
                {
                    array[arrayIndex] = this._parent.AppliedElement;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ParentCall != null))
                {
                    array[arrayIndex] = this._parent.ParentCall;
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
                if ((this._parent.LoopBodyOwner == item))
                {
                    this._parent.LoopBodyOwner = null;
                    return true;
                }
                if ((this._parent.AppliedElement == item))
                {
                    this._parent.AppliedElement = null;
                    return true;
                }
                if ((this._parent.ParentCall == item))
                {
                    this._parent.ParentCall = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LoopBodyOwner).Concat(this._parent.AppliedElement).Concat(this._parent.ParentCall).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the loopBodyOwner property
        /// </summary>
        private sealed class LoopBodyOwnerProxy : ModelPropertyChange<IOclExpression, IIteratorExp>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LoopBodyOwnerProxy(IOclExpression modelElement) : 
                    base(modelElement, "loopBodyOwner")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IIteratorExp Value
            {
                get
                {
                    return this.ModelElement.LoopBodyOwner;
                }
                set
                {
                    this.ModelElement.LoopBodyOwner = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the appliedElement property
        /// </summary>
        private sealed class AppliedElementProxy : ModelPropertyChange<IOclExpression, ICallExp>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AppliedElementProxy(IOclExpression modelElement) : 
                    base(modelElement, "appliedElement")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICallExp Value
            {
                get
                {
                    return this.ModelElement.AppliedElement;
                }
                set
                {
                    this.ModelElement.AppliedElement = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parentCall property
        /// </summary>
        private sealed class ParentCallProxy : ModelPropertyChange<IOclExpression, IOperationCallExp>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ParentCallProxy(IOclExpression modelElement) : 
                    base(modelElement, "parentCall")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOperationCallExp Value
            {
                get
                {
                    return this.ModelElement.ParentCall;
                }
                set
                {
                    this.ModelElement.ParentCall = value;
                }
            }
        }
    }
}

