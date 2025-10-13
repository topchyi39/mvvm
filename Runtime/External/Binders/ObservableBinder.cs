#if R3_SUPPORT

using Mvvm.Binding;
using R3;

namespace Mvvm.External.Binders
{
    public abstract class ObservableBinder<TV, TM> : Binder<TV, Observable<TM>>
    {
        public ObservableBinder(TV view, Observable<TM> model) : base(view, model) { }
    }
}

#endif
