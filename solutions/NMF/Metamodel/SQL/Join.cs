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
    /// The default implementation of the Join class
    /// </summary>
    [XmlNamespaceAttribute("http://www.example.org/sql")]
    [XmlNamespacePrefixAttribute("sql")]
    [ModelRepresentationClassAttribute("http://www.example.org/sql#//Join")]
    public partial class Join : ModelElement, IJoin, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Left property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private Nullable<bool> _left;
        
        private static Lazy<ITypedElement> _leftAttribute = new Lazy<ITypedElement>(RetrieveLeftAttribute);
        
        private static Lazy<ITypedElement> _rightItemReference = new Lazy<ITypedElement>(RetrieveRightItemReference);
        
        /// <summary>
        /// The backing field for the RightItem property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IFromItem _rightItem;
        
        private static Lazy<ITypedElement> _onExpReference = new Lazy<ITypedElement>(RetrieveOnExpReference);
        
        /// <summary>
        /// The backing field for the OnExp property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IExpression _onExp;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The left property
        /// </summary>
        [DisplayNameAttribute("left")]
        [CategoryAttribute("Join")]
        [XmlElementNameAttribute("left")]
        [XmlAttributeAttribute(true)]
        public Nullable<bool> Left
        {
            get
            {
                return this._left;
            }
            set
            {
                if ((this._left != value))
                {
                    Nullable<bool> old = this._left;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLeftChanging(e);
                    this.OnPropertyChanging("Left", e, _leftAttribute);
                    this._left = value;
                    this.OnLeftChanged(e);
                    this.OnPropertyChanged("Left", e, _leftAttribute);
                }
            }
        }
        
        /// <summary>
        /// The rightItem property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("rightItem")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IFromItem RightItem
        {
            get
            {
                return this._rightItem;
            }
            set
            {
                if ((this._rightItem != value))
                {
                    IFromItem old = this._rightItem;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRightItemChanging(e);
                    this.OnPropertyChanging("RightItem", e, _rightItemReference);
                    this._rightItem = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.ParentChanged -= this.OnResetRightItem;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetRightItem;
                    }
                    this.OnRightItemChanged(e);
                    this.OnPropertyChanged("RightItem", e, _rightItemReference);
                }
            }
        }
        
        /// <summary>
        /// The onExp property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("onExp")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IExpression OnExp
        {
            get
            {
                return this._onExp;
            }
            set
            {
                if ((this._onExp != value))
                {
                    IExpression old = this._onExp;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOnExpChanging(e);
                    this.OnPropertyChanging("OnExp", e, _onExpReference);
                    this._onExp = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.ParentChanged -= this.OnResetOnExp;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetOnExp;
                    }
                    this.OnOnExpChanged(e);
                    this.OnPropertyChanged("OnExp", e, _onExpReference);
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
                return base.Children.Concat(new JoinChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new JoinReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/sql#//Join")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Left property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LeftChanging;
        
        /// <summary>
        /// Gets fired when the Left property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LeftChanged;
        
        /// <summary>
        /// Gets fired before the RightItem property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RightItemChanging;
        
        /// <summary>
        /// Gets fired when the RightItem property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RightItemChanged;
        
        /// <summary>
        /// Gets fired before the OnExp property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OnExpChanging;
        
        /// <summary>
        /// Gets fired when the OnExp property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OnExpChanged;
        
        private static ITypedElement RetrieveLeftAttribute()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Sql.Join.ClassInstance)).Resolve("left")));
        }
        
        /// <summary>
        /// Raises the LeftChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeftChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LeftChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LeftChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeftChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LeftChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRightItemReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Sql.Join.ClassInstance)).Resolve("rightItem")));
        }
        
        /// <summary>
        /// Raises the RightItemChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRightItemChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RightItemChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RightItemChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRightItemChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RightItemChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the RightItem property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRightItem(object sender, System.EventArgs eventArgs)
        {
            this.RightItem = null;
        }
        
        private static ITypedElement RetrieveOnExpReference()
        {
            return ((ITypedElement)(((ModelElement)(TTC2021.OclToSql.Sql.Join.ClassInstance)).Resolve("onExp")));
        }
        
        /// <summary>
        /// Raises the OnExpChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOnExpChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OnExpChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OnExpChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOnExpChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OnExpChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OnExp property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOnExp(object sender, System.EventArgs eventArgs)
        {
            this.OnExp = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.RightItem))
            {
                return ModelHelper.CreatePath("RightItem");
            }
            if ((element == this.OnExp))
            {
                return ModelHelper.CreatePath("OnExp");
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
            if ((reference == "RIGHTITEM"))
            {
                return this.RightItem;
            }
            if ((reference == "ONEXP"))
            {
                return this.OnExp;
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
            if ((attribute == "LEFT"))
            {
                return this.Left;
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
            if ((feature == "RIGHTITEM"))
            {
                this.RightItem = ((IFromItem)(value));
                return;
            }
            if ((feature == "ONEXP"))
            {
                this.OnExp = ((IExpression)(value));
                return;
            }
            if ((feature == "LEFT"))
            {
                this.Left = ((bool)(value));
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
            if ((attribute == "LEFT"))
            {
                return Observable.Box(new LeftProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "RIGHTITEM"))
            {
                return new RightItemProxy(this);
            }
            if ((reference == "ONEXP"))
            {
                return new OnExpProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.example.org/sql#//Join")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Join class
        /// </summary>
        public class JoinChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Join _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public JoinChildrenCollection(Join parent)
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
                    if ((this._parent.RightItem != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OnExp != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RightItemChanged += this.PropagateValueChanges;
                this._parent.OnExpChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RightItemChanged -= this.PropagateValueChanges;
                this._parent.OnExpChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.RightItem == null))
                {
                    IFromItem rightItemCasted = item.As<IFromItem>();
                    if ((rightItemCasted != null))
                    {
                        this._parent.RightItem = rightItemCasted;
                        return;
                    }
                }
                if ((this._parent.OnExp == null))
                {
                    IExpression onExpCasted = item.As<IExpression>();
                    if ((onExpCasted != null))
                    {
                        this._parent.OnExp = onExpCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RightItem = null;
                this._parent.OnExp = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.RightItem))
                {
                    return true;
                }
                if ((item == this._parent.OnExp))
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
                if ((this._parent.RightItem != null))
                {
                    array[arrayIndex] = this._parent.RightItem;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OnExp != null))
                {
                    array[arrayIndex] = this._parent.OnExp;
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
                if ((this._parent.RightItem == item))
                {
                    this._parent.RightItem = null;
                    return true;
                }
                if ((this._parent.OnExp == item))
                {
                    this._parent.OnExp = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RightItem).Concat(this._parent.OnExp).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Join class
        /// </summary>
        public class JoinReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Join _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public JoinReferencedElementsCollection(Join parent)
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
                    if ((this._parent.RightItem != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OnExp != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RightItemChanged += this.PropagateValueChanges;
                this._parent.OnExpChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RightItemChanged -= this.PropagateValueChanges;
                this._parent.OnExpChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.RightItem == null))
                {
                    IFromItem rightItemCasted = item.As<IFromItem>();
                    if ((rightItemCasted != null))
                    {
                        this._parent.RightItem = rightItemCasted;
                        return;
                    }
                }
                if ((this._parent.OnExp == null))
                {
                    IExpression onExpCasted = item.As<IExpression>();
                    if ((onExpCasted != null))
                    {
                        this._parent.OnExp = onExpCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RightItem = null;
                this._parent.OnExp = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.RightItem))
                {
                    return true;
                }
                if ((item == this._parent.OnExp))
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
                if ((this._parent.RightItem != null))
                {
                    array[arrayIndex] = this._parent.RightItem;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OnExp != null))
                {
                    array[arrayIndex] = this._parent.OnExp;
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
                if ((this._parent.RightItem == item))
                {
                    this._parent.RightItem = null;
                    return true;
                }
                if ((this._parent.OnExp == item))
                {
                    this._parent.OnExp = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RightItem).Concat(this._parent.OnExp).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the left property
        /// </summary>
        private sealed class LeftProxy : ModelPropertyChange<IJoin, Nullable<bool>>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LeftProxy(IJoin modelElement) : 
                    base(modelElement, "left")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Nullable<bool> Value
            {
                get
                {
                    return this.ModelElement.Left;
                }
                set
                {
                    this.ModelElement.Left = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the rightItem property
        /// </summary>
        private sealed class RightItemProxy : ModelPropertyChange<IJoin, IFromItem>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RightItemProxy(IJoin modelElement) : 
                    base(modelElement, "rightItem")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IFromItem Value
            {
                get
                {
                    return this.ModelElement.RightItem;
                }
                set
                {
                    this.ModelElement.RightItem = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the onExp property
        /// </summary>
        private sealed class OnExpProxy : ModelPropertyChange<IJoin, IExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OnExpProxy(IJoin modelElement) : 
                    base(modelElement, "onExp")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IExpression Value
            {
                get
                {
                    return this.ModelElement.OnExp;
                }
                set
                {
                    this.ModelElement.OnExp = value;
                }
            }
        }
    }
}
