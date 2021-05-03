using System;

namespace PresentationLayer.Presenters
{
    public interface IMainPresenter
    {
        event EventHandler DepartmentDetailViewBindingDoneEventRaised;

        IMainView GetMainView();
    }
}