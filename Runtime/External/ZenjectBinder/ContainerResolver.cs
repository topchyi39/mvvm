#if EXTENJECT_SUPPORT

using System;
using Zenject;
using Mvvm.Factory;

namespace Mvvm.External.ZenjectBinder
{
    public class ContainerResolver : IResolver
    {
        private readonly DiContainer _container;

        public ContainerResolver(DiContainer container)
        {
            _container = container;
        }

        public T Resolve<T>() => _container.Resolve<T>();
        public object Resolve(Type type) => _container.Resolve(type);
    }
}

#endif