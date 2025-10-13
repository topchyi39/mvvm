using System;

namespace Mvvm.Factory
{
    public interface IResolver
    {
        T Resolve<T>();
        object Resolve(Type type);
    }
}