#if VCONTAINER_SUPPORT

using System;
using Mvvm.Factory;
using VContainer;

namespace Mvvm.External.VContainer
{
    public class ScopeResolver : IResolver
    {
        private readonly IObjectResolver _resolver;

        public ScopeResolver(IObjectResolver resolver)
        {
            _resolver = resolver;
        }
        
        public T Resolve<T>() => _resolver.Resolve<T>();
        public object Resolve(Type type) => _resolver.Resolve(type);
    }
}

#endif