#if EXTENJECT_SUPPORT

using Mvvm.Binding;
using Mvvm.Factory;
using Zenject;

namespace Mvvm.External.ZenjectBinder
{
    public class ViewInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ContainerResolver>().AsSingle();
            
            Container.Bind<InstanceBinder>().AsTransient();
            Container.BindInterfacesTo<InjectedViewBinder>().AsTransient();
        }
    }
}

#endif