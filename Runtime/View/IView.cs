using System;
using R3;

namespace Mvvm.View
{
    public interface IView
    {
        public Type ViewModelType { get; }
        ReadOnlyReactiveProperty<bool> IsActive { get; }
    }
}