#if R3_SUPPORT

using System;
using R3;
using UnityEngine.UI;

namespace Mvvm.External.Binders
{
    public class ButtonObservableBinder : SubjectBinder<Button, Unit>
    {
        private IDisposable _disposable;


        public ButtonObservableBinder(Button view, ISubject<Unit> model) : base(view, model)
        {
        }

        public override void Bind()
        {
            _disposable = View.OnClickAsObservable().Subscribe(Model.OnNext);
        }

        public override void Unbind()
        {
            _disposable?.Dispose();
        }
    }
}
#endif