#if EXTENJECT_SUPPORT

using Mvvm.Factory;
using UnityEngine;
using Zenject;

namespace Mvvm.External.ZenjectBinder
{
    public class RuntimeViewBinder : MonoBehaviour
    {
        [SerializeField] private View.View view;

        private IViewBinder _binder;
        
        [Inject]
        private void Construct(IViewBinder binder)
        {
            _binder = binder;
        }

        private void Start()
        {
            _binder.BindView(view);
        }
    }
}

#endif
