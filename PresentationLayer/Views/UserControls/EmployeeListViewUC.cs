using CommonComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views.UserControls
{
    public partial class EmployeeListViewUC : BaseUserControUC, IEmployeeListViewUC
    {
        public event EventHandler EmployeeListViewLoadEventRaised;
        public EmployeeListViewUC()
        {
            InitializeComponent();
        }

        private void EmployeeListViewUC_Load(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, EmployeeListViewLoadEventRaised, e);
        }

        public void LoadEmployeeListToGrid(BindingSource employeeListBindingSource, Dictionary<string, string> headingsDictionary, Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight)
        {
            this.empListGridView.RowTemplate.Height = 32;

            this.empListGridView.DataSource = employeeListBindingSource;

            SetGridHeaderText(headingsDictionary);
            empListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            empListGridView.AllowUserToAddRows = false; //Removes blank row at end of grid load
            empListGridView.ReadOnly = true;
            empListGridView.ScrollBars = ScrollBars.Both;
            SetGridColumnWidths(gridColumnWidthsDictionary);
        }


        private void SetGridHeaderText(Dictionary<string, string> headingsDictionary)
        {
            empListGridView.Columns["Id"].HeaderText = headingsDictionary["EmployeeID"];
            empListGridView.Columns["Name"].HeaderText = headingsDictionary["Name"];
            empListGridView.Columns["Country"].HeaderText = headingsDictionary["Country"];
            empListGridView.Columns["Designation"].HeaderText = headingsDictionary["Designation"];

        }
        private void SetGridColumnWidths(Dictionary<string, float> gridColumnWidthsDictionary)
        {
            int GridWidth = (empListGridView.Width - empListGridView.RowHeadersWidth -
                       SystemInformation.VerticalScrollBarWidth);

            empListGridView.Columns["Id"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["EmployeeID"]);
            empListGridView.Columns["Name"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["Name"]);
            empListGridView.Columns["Country"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["Country"]);
            empListGridView.Columns["Designation"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["Designation"]);
            empListGridView.Columns["DepartmentId"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["DepartmentId"]);

        }

    }
}
