using PresentationLayer.Views.UserControls;
using System;

namespace PresentationLayer.Presenters.UserControls
{
    public interface IEmployeeListPresenter
    {
        event EventHandler EmployeeListYesDeleteBtnClickEventRaised;

        IEmployeeListViewUC GetEmployeeListViewUC();

        void LoadAllEmployeesFromDbToGrid();
    }
}