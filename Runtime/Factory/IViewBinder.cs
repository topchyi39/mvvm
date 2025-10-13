using Mvvm.View;
using UnityEngine;

namespace Mvvm.Factory
{
    public interface IViewBinder
    {
        void BindView<T>(T view) where T : Component, IView;
    }
}