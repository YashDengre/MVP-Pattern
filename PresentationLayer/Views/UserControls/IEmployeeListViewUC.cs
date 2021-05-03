using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationLayer.Views.UserControls
{
    public interface IEmployeeListViewUC
    {
        event EventHandler EmployeeListViewLoadEventRaised;
        void LoadEmployeeListToGrid(BindingSource employeeListBindingSource, 
            Dictionary<string, string> headingsDictionary, Dictionary<string, float> gridColumnWidthsDictionary, 
            int rowHeight);
        

    }
}