#if R3_SUPPORT

using System;
using Mvvm.Binding;
using R3;
using UnityEngine.UI;

namespace Mvvm.External.Binders
{
    public class ButtonMethodBinder : Binder<Button, Action>
    {
        private IDisposable _disposable;
        
        public ButtonMethodBinder(Button view, Action model) : base(view, model) { }

        public override void Bind()
        {
            _disposable = View.OnClickAsObservable().Subscribe(_ => Model.Invoke());
        }

        public override void Unbind()
        {
            _disposable?.Dispose();
        }
    }
}

#endif