using System;
using Cysharp.Threading.Tasks;
using Mvvm.Binding;
using R3;
using UnityEngine.UI;

namespace Mvvm.External.Binders.UniTaskBinders
{
    public class ButtonUniTaskVoidBinder : Binder<Button, Func<UniTaskVoid>>
    {
        private IDisposable _disposable;
        
        public ButtonUniTaskVoidBinder(Button view, Func<UniTaskVoid> model) : base(view, model) { }

        public override void Bind()
        {
            _disposable = View.OnClickAsObservable().Subscribe(_ =>
            {
                Model.Invoke().Forget();
            });
        }

        public override void Unbind()
        {
            _disposable?.Dispose();
        }
    }
}