using PresentationLayer.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Employees;
using ServiceLayer.Services.EmployeeServices;
using System.ComponentModel;
using System.Windows.Forms;

namespace PresentationLayer.Presenters.UserControls
{
    public class EmployeeListPresenter : IEmployeeListPresenter
    {
        public event EventHandler EmployeeListYesDeleteBtnClickEventRaised;

        private IEmployeeListViewUC _employeeListViewUC;
        private readonly IEmployeeServices _employeeServices;

        BindingList<EmployeeSelectDto> _employeeSelectDtoBindingList;


        // This BindingSource binds the list to the DataGridView control.
        private BindingSource _employeeSelectDtoBindingSource;

        public EmployeeListPresenter(IEmployeeListViewUC employeeListViewUC, IEmployeeServices employeeServices)//, IDepartmentService departmentServices)//, IDepartmentDetailPresenter departmentDetailPresenter, IDepartmentListDeleteView departmentListDeleteView)
        {
            _employeeListViewUC = employeeListViewUC;
            _employeeServices = employeeServices;
           // SubscribeToEventsSetup();
        }

        public IEmployeeListViewUC GetEmployeeListViewUC()
        {
            return _employeeListViewUC;
        }

        private void SubscribeToEventsSetup()
        {
            //_employeeListViewUC.DeleteDepartmentMenuClickEventRaised += new EventHandler(OnDeleteSelectedDepartmentInGridMenuClickEventRaised);

            //_departmentListViewUC.EditDepartmentMenuClickEventRaised += new EventHandler(OnUpdateSelectedDepartmentInGridMenuClickEventRaised);

            //_departmentListViewUC.AddNewDepartmentMenuClickEventRaised += new EventHandler(OnAddNewDepartmentMenuClickEventRaised);

            //_departmentListDeleteView.DepartmentListYesDeleteBtnClickEventRaised += new EventHandler(OnDepartmentListYesDeleteBtnClickEventRaised);
        }

        public void LoadAllEmployeesFromDbToGrid()
        {

            int rowHeight = 17;

            BuildDatasourceForAllEmployeesList();

            Dictionary<string, float> gridColumnWidthsDictionary = new Dictionary<string, float>();
            SetDepartmentListViewGridColumnWidths(gridColumnWidthsDictionary);

            Dictionary<string, string> headingsDictionary = new Dictionary<string, string>();
            SetDepartmentListViewGridHeadings(headingsDictionary);

            _employeeListViewUC.LoadEmployeeListToGrid(_employeeSelectDtoBindingSource, headingsDictionary, gridColumnWidthsDictionary, rowHeight);

        }
        private void BuildDatasourceForAllEmployeesList()
        {
            IEnumerable<EmployeeSelectDto> allEmployees = _employeeServices.GetEmployeeSelectList();

            _employeeSelectDtoBindingList = new BindingList<EmployeeSelectDto>();
            foreach (EmployeeSelectDto emplyeeMinimumDetailDto in allEmployees)
            {
                _employeeSelectDtoBindingList.Add(emplyeeMinimumDetailDto);
            };

            _employeeSelectDtoBindingSource = new BindingSource();//Reset

            this._employeeSelectDtoBindingSource.DataSource = _employeeSelectDtoBindingList;
        }

        private void SetDepartmentListViewGridColumnWidths(Dictionary<string, float> gridColumnWidthsDictionary)
        {
            gridColumnWidthsDictionary["EmployeeID"] = (float)(.10);
            gridColumnWidthsDictionary["Name"] = (float)(.20);
            gridColumnWidthsDictionary["Country"] = (float)(.10);
            gridColumnWidthsDictionary["Designation"] = (float)(.20);
            gridColumnWidthsDictionary["DepartmentId"] = (float)(.20);

        }

        private void SetDepartmentListViewGridHeadings(Dictionary<string, string> headingsDictionary)
        {
            headingsDictionary["EmployeeID"] = "ID";
            headingsDictionary["Name"] = "Employee Name";
            headingsDictionary["Country"] = "Country";
            headingsDictionary["Designation"] = "Designation";
            headingsDictionary["DepartmentId"] = "Department Id";
        }
    }
}
