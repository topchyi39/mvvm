using Cysharp.Threading.Tasks;
using Mvvm.View;
using UnityEngine;

namespace Mvvm.Factory
{
    public interface IViewFactory
    {
        UniTask<T> Instantiate<T>(Transform parent = null) where T : Component, IView;
    }
}