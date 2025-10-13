using Cysharp.Threading.Tasks;
using Mvvm.View;
using UnityEngine;

namespace Mvvm.Factory
{
    public class ViewFactory : IViewFactory
    {
        private readonly IViewBinder _viewBinder;
        private readonly IViewLoader _viewLoader;
        
        public ViewFactory(IViewLoader viewLoader, IViewBinder viewBinder)
        {
            _viewLoader = viewLoader;
            _viewBinder = viewBinder;
        }
        
        public async UniTask<T> Instantiate<T>(Transform parent = null) where T : Component, IView
        {
            var asset = await _viewLoader.Load<T>();
            var instance = Object.Instantiate(asset, parent);
            _viewBinder.BindView(instance);
            
            return instance;
        }
    }
}