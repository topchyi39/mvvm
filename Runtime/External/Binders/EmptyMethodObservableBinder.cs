#if R3_SUPPORT

using System;
using R3;

namespace Mvvm.External.Binders
{
    public class EmptyMethodObservableBinder<T> : ObservableBinder<Action, T>
    {
        private IDisposable _disposable;
        
        public EmptyMethodObservableBinder(Action view, Observable<T> model) : base(view, model) { }

        public override void Bind()
        {
            _disposable = Model.Subscribe(Invoke);
        }

        public override void Unbind()
        {
            _disposable.Dispose();
        }

        private void Invoke(T value)
        {
            View();
        }
    }
}
#endif