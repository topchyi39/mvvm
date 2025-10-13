using Mvvm.Internal;

namespace Mvvm.Binding
{
    public static class BinderFactory
    {
        public static IBinder Create(object view, object viewModel) => InternalBinderFactory.Create(view, viewModel);
    }
}