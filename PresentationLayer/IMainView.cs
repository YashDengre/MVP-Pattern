using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public interface IMainView
    {
        event EventHandler DepartmentListBtnClickEventRaised;
        event EventHandler HelpAboutMenuClickEventRaised;
        event EventHandler MainViewLoadedEventRaised;
        event EventHandler NewsBtnClickEventRaised;
        event EventHandler PlantsListBtnClickEventRaised;
        event EventHandler EmployeeListBtnClickEventRaised;

        void ExpandUserControlPanel();
        Panel GetOptionsPanel();
        Panel GetUserControlPanel();
        void ResetUserControlPanelSizeandLocation();
        void ShowMainView();
    }
}