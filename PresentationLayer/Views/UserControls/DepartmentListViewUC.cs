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
    public partial class DepartmentListViewUC : BaseUserControUC, IDepartmentListViewUC
    {

        public event EventHandler DepartmentListViewLoadEventRaised;
        public event EventHandler EditDepartmentMenuClickEventRaised;
        public event EventHandler AddNewDepartmentMenuClickEventRaised;
        public event EventHandler DeleteDepartmentMenuClickEventRaised;

        public DepartmentListViewUC()
        {
            InitializeComponent();
        }

        private void DepartmentListViewUC_Load(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, DepartmentListViewLoadEventRaised, e);
        }

        public void LoadDepartmentListToGrid(BindingSource departmentListBindingSource, Dictionary<string, string> headingsDictionary, Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight)
        {
            this.DepartmentListDataGridView.RowTemplate.Height = 32;

            this.DepartmentListDataGridView.DataSource = departmentListBindingSource;

            SetGridHeaderText(headingsDictionary);
            DepartmentListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DepartmentListDataGridView.AllowUserToAddRows = false; //Removes blank row at end of grid load
            DepartmentListDataGridView.ReadOnly = true;

            int optionsWidth = 0;
            SetGridColumnWidths(gridColumnWidthsDictionary, ref optionsWidth);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Options";
            imageColumn.Name = "Options";
            imageColumn.Width = optionsWidth;
            imageColumn.Image = Properties.Resources.MoreOptionsBlackDotsOnWhite20x20;
            //int columnIndex = 4;
            if (DepartmentListDataGridView.Columns["Options"] == null)
            {
                DepartmentListDataGridView.Columns.Add(imageColumn);
            }

        }

        private void SetGridHeaderText(Dictionary<string, string> headingsDictionary)
        {
            DepartmentListDataGridView.Columns["DepartmentId"].HeaderText = headingsDictionary["DepartmentId"];
            DepartmentListDataGridView.Columns["DepartmentName"].HeaderText = headingsDictionary["DepartmentName"];
            DepartmentListDataGridView.Columns["CityLocation"].HeaderText = headingsDictionary["CityLocation"];
            DepartmentListDataGridView.Columns["StateLocation"].HeaderText = headingsDictionary["StateLocation"];
        }
        private void SetGridColumnWidths(Dictionary<string, float> gridColumnWidthsDictionary, ref int optionsWidth)
        {
            int GridWidth = (DepartmentListDataGridView.Width - DepartmentListDataGridView.RowHeadersWidth -
                       SystemInformation.VerticalScrollBarWidth);

            DepartmentListDataGridView.Columns["DepartmentId"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["DepartmentId"]);
            DepartmentListDataGridView.Columns["DepartmentName"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["DepartmentName"]);
            DepartmentListDataGridView.Columns["CityLocation"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["CityLocation"]);
            DepartmentListDataGridView.Columns["StateLocation"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["StateLocation"]);

            optionsWidth = (int)((GridWidth) * gridColumnWidthsDictionary["Options"]);
        }

        #region TB
        public void ReloadDepartmentListGrid(BindingSource departmentListBindingSource)
        {
            this.DepartmentListDataGridView.DataSource = departmentListBindingSource;
        }


      
        private void departmentListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DepartmentListDataGridView.Columns["Options"].Index)
            {
                optionsContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnAddNewDepartmentMenuClick(sender, e);
        }

        private void OnAddNewDepartmentMenuClick(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, AddNewDepartmentMenuClickEventRaised, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnUpdateSelectedDepartmentInGridMenuClick(sender, e);
        }

        private void OnUpdateSelectedDepartmentInGridMenuClick(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, EditDepartmentMenuClickEventRaised, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, DeleteDepartmentMenuClickEventRaised, e);
        }



        private void DepartmentListDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (DepartmentListDataGridView.Columns[e.ColumnIndex].Name == "Options")
                {
                    Cursor.Current = Cursors.Hand;
                }
            }
        }

        private void DepartmentListDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (DepartmentListDataGridView.Columns[e.ColumnIndex].Name == "Options")
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        #endregion

    }
}
