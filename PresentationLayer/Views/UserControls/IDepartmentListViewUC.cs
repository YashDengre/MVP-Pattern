using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer.Views.UserControls
{
    public interface IDepartmentListViewUC
    {
        event EventHandler AddNewDepartmentMenuClickEventRaised;
        event EventHandler DeleteDepartmentMenuClickEventRaised;
        event EventHandler DepartmentListViewLoadEventRaised;
        event EventHandler EditDepartmentMenuClickEventRaised;

        void LoadDepartmentListToGrid(BindingSource departmentListBindingSource, Dictionary<string, string> headingsDictionary, Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight);
        void ReloadDepartmentListGrid(BindingSource departmentListBindingSource);
    }
}