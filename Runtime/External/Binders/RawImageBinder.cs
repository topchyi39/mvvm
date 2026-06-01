using System;
using R3;
using UnityEngine;
using UnityEngine.UI;

namespace Mvvm.External.Binders
{
    public class RawImageBinder : ObservableBinder<RawImage, Texture2D>
    {
        private IDisposable _disposable;
    
        public RawImageBinder(RawImage view, Observable<Texture2D> model) : base(view, model)
        {
        }

        public override void Bind()
        {
            _disposable = Model.Subscribe(Invoke);
        }

        public override void Unbind()
        {
            _disposable?.Dispose();
        }

        private void Invoke(Texture2D data)
        {
            View.texture = data;
        }
    }
}