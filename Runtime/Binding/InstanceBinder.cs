using Mvvm.View;
using R3;

namespace Mvvm.Binding
{
    public class InstanceBinder
    {
        private IView _view;
        private IBinder _binder;

        public void Initialize(IView view, IBinder binder)
        {
            _view = view;
            _binder = binder;
            _view.IsActive.Subscribe(OnActiveChanged);
        }

        private void Bind()
        {
            _binder.Bind();
        }

        private void UnBind()
        {
            _binder.Unbind();
        }
        

        private void OnActiveChanged(bool isActive)
        {
            if (isActive)
            {
                Bind();
            }
            else
            {
                UnBind();
            }
        }
    }
}