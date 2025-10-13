using System;
using R3;
using UnityEngine;

namespace Mvvm.View
{
    public abstract class View : MonoBehaviour, IView
    {
        private ReactiveProperty<bool> _isActive = new ();
        
        public abstract Type ViewModelType { get; }
        public ReadOnlyReactiveProperty<bool> IsActive => _isActive;

        private void OnEnable()
        {
            _isActive.Value = true;
            OnEnableInternal();
        }

        private void OnDisable()
        {
            _isActive.Value = false;
            OnDisableInternal();
        }
        
        protected virtual void OnEnableInternal() {}
        protected virtual void OnDisableInternal() {}
    }

    public abstract class View<T> : View, IView
    {
        public override Type ViewModelType => typeof(T);
    } 
}