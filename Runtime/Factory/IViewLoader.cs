using Cysharp.Threading.Tasks;

namespace Mvvm.Factory
{
    public interface IViewLoader
    {
        UniTask<T> Load<T>();
    }
}