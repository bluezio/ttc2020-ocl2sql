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
    /// The default implementation of the WhenClause class
    /// </summary>
    [XmlNamespaceAttribute("http://www.example.org/sql")]
    [XmlNamespacePrefixAttribute("sql")]
    [ModelRepresentationClassAttribute("http://www.example.org/sql#//WhenClause")]
    public partial class WhenClause : ModelElement, IWhenClause, IModelElement
    {
        
        private static Lazy<ITypedElement> _whenExpReference = new Lazy<ITypedElement>(RetrieveWhenExpReference);
        
        /// <summary>
        /// The backing field for the WhenExp property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IExpression _whenExp;
        
        private static Lazy<ITypedElement> _thenExpReference = new Lazy<ITypedElement>(RetrieveThenExpReference);
        
        /// <summary>
        /// The backing field for the ThenExp property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IExpression _thenExp;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The whenExp property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("whenExp")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IExpression WhenExp
        {
            get
            {
                return this._whenExp;
            }
            set
            {
                if ((this._whenExp != value))
                {
                    IExpression old = this._whenExp;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnWhenExpChanging(e);
                    this.OnPropertyChanging("WhenExp", e, _whenExpReference);
                    this._whenExp = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.ParentChanged -= this.OnResetWhenExp;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetWhenExp;
                    }
                    this.OnWhenExpChanged(e);
                    this.OnPropertyChanged("WhenExp", e, _whenExpReference);
                }
            }
        }
        
        /// <summary>
        /// The thenExp property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("thenExp")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IExpression ThenExp
        {
            get
            {
                return this._thenExp;
            }
            set
            {
                if ((this._thenExp != value))
                {
                    IExpression old = this._thenExp;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnThenExpChanging(e);
                    this.OnPropertyChanging("ThenExp", e, _thenExpReference);
                    this._thenExp = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.ParentChanged -= this.OnResetThenExp;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetThenExp;
                    }
                    this.OnThenExpChanged(e);
                    this.OnPropertyChanged("ThenExp", e, _thenExpReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new WhenClauseChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new WhenClauseReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/sql#//WhenClause")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the WhenExp property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WhenExpChanging;
        
        /// <summary>
        /// Gets fired when the WhenExp property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> WhenExpChanged;
        
        /// <summary>
        /// Gets fired before the ThenExp property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThenExpChanging;
        
        /// <summary>
        /// Gets fired when the ThenExp property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ThenExpChanged;
        
        private static ITypedElement RetrieveWhenExpReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Sql.WhenClause.ClassInstance)).Resolve("whenExp")));
        }
        
        /// <summary>
        /// Raises the WhenExpChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWhenExpChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WhenExpChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the WhenExpChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnWhenExpChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.WhenExpChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the WhenExp property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetWhenExp(object sender, System.EventArgs eventArgs)
        {
            this.WhenExp = null;
        }
        
        private static ITypedElement RetrieveThenExpReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Sql.WhenClause.ClassInstance)).Resolve("thenExp")));
        }
        
        /// <summary>
        /// Raises the ThenExpChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThenExpChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThenExpChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ThenExpChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThenExpChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ThenExpChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ThenExp property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetThenExp(object sender, System.EventArgs eventArgs)
        {
            this.ThenExp = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.WhenExp))
            {
                return ModelHelper.CreatePath("WhenExp");
            }
            if ((element == this.ThenExp))
            {
                return ModelHelper.CreatePath("ThenExp");
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
            if ((reference == "WHENEXP"))
            {
                return this.WhenExp;
            }
            if ((reference == "THENEXP"))
            {
                return this.ThenExp;
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
            if ((feature == "WHENEXP"))
            {
                this.WhenExp = ((IExpression)(value));
                return;
            }
            if ((feature == "THENEXP"))
            {
                this.ThenExp = ((IExpression)(value));
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
            if ((reference == "WHENEXP"))
            {
                return new WhenExpProxy(this);
            }
            if ((reference == "THENEXP"))
            {
                return new ThenExpProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/sql#//WhenClause")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the WhenClause class
        /// </summary>
        public class WhenClauseChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private WhenClause _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public WhenClauseChildrenCollection(WhenClause parent)
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
                    if ((this._parent.WhenExp != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ThenExp != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.WhenExpChanged += this.PropagateValueChanges;
                this._parent.ThenExpChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.WhenExpChanged -= this.PropagateValueChanges;
                this._parent.ThenExpChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.WhenExp == null))
                {
                    IExpression whenExpCasted = item.As<IExpression>();
                    if ((whenExpCasted != null))
                    {
                        this._parent.WhenExp = whenExpCasted;
                        return;
                    }
                }
                if ((this._parent.ThenExp == null))
                {
                    IExpression thenExpCasted = item.As<IExpression>();
                    if ((thenExpCasted != null))
                    {
                        this._parent.ThenExp = thenExpCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.WhenExp = null;
                this._parent.ThenExp = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.WhenExp))
                {
                    return true;
                }
                if ((item == this._parent.ThenExp))
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
                if ((this._parent.WhenExp != null))
                {
                    array[arrayIndex] = this._parent.WhenExp;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ThenExp != null))
                {
                    array[arrayIndex] = this._parent.ThenExp;
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
                if ((this._parent.WhenExp == item))
                {
                    this._parent.WhenExp = null;
                    return true;
                }
                if ((this._parent.ThenExp == item))
                {
                    this._parent.ThenExp = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.WhenExp).Concat(this._parent.ThenExp).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the WhenClause class
        /// </summary>
        public class WhenClauseReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private WhenClause _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public WhenClauseReferencedElementsCollection(WhenClause parent)
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
                    if ((this._parent.WhenExp != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ThenExp != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.WhenExpChanged += this.PropagateValueChanges;
                this._parent.ThenExpChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.WhenExpChanged -= this.PropagateValueChanges;
                this._parent.ThenExpChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.WhenExp == null))
                {
                    IExpression whenExpCasted = item.As<IExpression>();
                    if ((whenExpCasted != null))
                    {
                        this._parent.WhenExp = whenExpCasted;
                        return;
                    }
                }
                if ((this._parent.ThenExp == null))
                {
                    IExpression thenExpCasted = item.As<IExpression>();
                    if ((thenExpCasted != null))
                    {
                        this._parent.ThenExp = thenExpCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.WhenExp = null;
                this._parent.ThenExp = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.WhenExp))
                {
                    return true;
                }
                if ((item == this._parent.ThenExp))
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
                if ((this._parent.WhenExp != null))
                {
                    array[arrayIndex] = this._parent.WhenExp;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ThenExp != null))
                {
                    array[arrayIndex] = this._parent.ThenExp;
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
                if ((this._parent.WhenExp == item))
                {
                    this._parent.WhenExp = null;
                    return true;
                }
                if ((this._parent.ThenExp == item))
                {
                    this._parent.ThenExp = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.WhenExp).Concat(this._parent.ThenExp).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the whenExp property
        /// </summary>
        private sealed class WhenExpProxy : ModelPropertyChange<IWhenClause, IExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public WhenExpProxy(IWhenClause modelElement) : 
                    base(modelElement, "whenExp")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IExpression Value
            {
                get
                {
                    return this.ModelElement.WhenExp;
                }
                set
                {
                    this.ModelElement.WhenExp = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the thenExp property
        /// </summary>
        private sealed class ThenExpProxy : ModelPropertyChange<IWhenClause, IExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ThenExpProxy(IWhenClause modelElement) : 
                    base(modelElement, "thenExp")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IExpression Value
            {
                get
                {
                    return this.ModelElement.ThenExp;
                }
                set
                {
                    this.ModelElement.ThenExp = value;
                }
            }
        }
    }
}

