#if VCONTAINER_SUPPORT

using Mvvm.Factory;
using VContainer;

namespace Mvvm.External.VContainer
{
    public static class VContainerExtensions
    {
        public static void RegisterResolver(this IContainerBuilder builder)
        {
            builder.Register<IResolver, ScopeResolver>(Lifetime.Scoped);
        }
    }
}

#endif