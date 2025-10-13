using Mvvm.Binding;
using Mvvm.View;
using UnityEngine;

namespace Mvvm.Factory
{
    public class InjectedViewBinder : IViewBinder
    {
        private readonly IResolver _resolver;

        public InjectedViewBinder(IResolver resolver)
        {
            _resolver = resolver;
        }

        public void BindView<T>(T view) where T : Component, IView
        {
            var views = view.gameObject.GetComponentsInChildren<IView>();
            foreach (var childView in views)
            {
                BindViewInstance(childView);
            }
        }

        private void BindViewInstance(IView view)
        {
            var viewModel = _resolver.Resolve(view.ViewModelType);
            var viewBinder = _resolver.Resolve<InstanceBinder>();
            var binder = BinderFactory.Create(view, viewModel);

            viewBinder.Initialize(view, binder);
        }
    }
}
