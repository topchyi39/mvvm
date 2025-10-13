#if R3_SUPPORT

using Mvvm.Binding;
using R3;

namespace Mvvm.External.Binders
{
    public abstract class SubjectBinder<TV, TM> : Binder<TV, ISubject<TM>>
    {
        public SubjectBinder(TV view, ISubject<TM> model) : base(view, model) { }
    }
}

#endif