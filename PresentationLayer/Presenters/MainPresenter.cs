using PresentationLayer.Presenters.UserControls;
using PresentationLayer.Views;
using PresentationLayer.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Presenters
{
    public class MainPresenter : BasePresenter, IMainPresenter
    {
        public event EventHandler DepartmentDetailViewBindingDoneEventRaised;
        Panel _userControlPanel;
        IMainView _mainView;
        IHelpAboutPresenter _helpAboutPresenter;
        private IDepartmentListPresenter _departmentListPresenter;
        private IEmployeeListPresenter _employeeListPresenter;
        private List<UserControl> _userControList;

        public IMainView GetMainView() { return _mainView; }
        public MainPresenter(IMainView mainView, IErrorMessageView errorMessageView, IHelpAboutPresenter helpAboutPresenter, 
            IDepartmentListPresenter departmentListPresenter, IEmployeeListPresenter employeeListPresenter) : base(errorMessageView)
        {
            _mainView = mainView;
            _userControlPanel = _mainView.GetUserControlPanel();
            _helpAboutPresenter = helpAboutPresenter;
            _departmentListPresenter = departmentListPresenter;
            _employeeListPresenter = employeeListPresenter;
            SubscribeToEventSetup();
        }

        public void SubscribeToEventSetup()
        {
            _mainView.HelpAboutMenuClickEventRaised += new EventHandler(OnHelpAboutMenuClickEventRaised);

            _mainView.DepartmentListBtnClickEventRaised += new EventHandler(OnDepartmentListBtnClickEventRaised);
            _mainView.EmployeeListBtnClickEventRaised += new EventHandler(OnEmployeeListClickEventRaised);
            _mainView.MainViewLoadedEventRaised += new EventHandler(OnMainViewLoadedEventRaised);
        }


        public void OnMainViewLoadedEventRaised(object sender, System.EventArgs e)
        {
            _userControList = new List<UserControl>();
            _userControList.Add((UserControl)_departmentListPresenter.GetDepartmentListViewUC());
            _userControList.Add((UserControl)_employeeListPresenter.GetEmployeeListViewUC());
           
             AssignUserControlToMainViewPanel((BaseUserControUC)_departmentListPresenter.GetDepartmentListViewUC());
             AssignUserControlToMainViewPanel((BaseUserControUC)_employeeListPresenter.GetEmployeeListViewUC());


        }

        public void OnEmployeeListClickEventRaised(object sender, System.EventArgs e)
        {
            SetupEmployeeListInPanel();
        }

        public void OnHelpAboutMenuClickEventRaised(object sender, EventArgs e)
        {
            _helpAboutPresenter.GetHelpAboutView().ShowHelpAboutView();
        }
        public void OnDepartmentListBtnClickEventRaised(object sender, System.EventArgs e)
        {
            SetupDepartmentListInPanel();
        }

        private void SetupDepartmentListInPanel()
        {
            _departmentListPresenter.LoadAllDepartmentsFromDbToGrid();
            SetUserControlVisibleInPanel((UserControl)_departmentListPresenter.GetDepartmentListViewUC());
        }
        private void SetupEmployeeListInPanel()
        {
            _employeeListPresenter.LoadAllEmployeesFromDbToGrid();
            SetUserControlVisibleInPanel((UserControl)_employeeListPresenter.GetEmployeeListViewUC());
        }

        private void AssignUserControlToMainViewPanel(BaseUserControUC baseUserControl)
        {
            baseUserControl.SetParentSizeLocationAnchor(_userControlPanel);
        }

        private void SetUserControlVisibleInPanel(UserControl userControl)
        {
            foreach (UserControl uc in _userControList)
            {
                if (uc.Name == userControl.Name)
                {
                    userControl.Visible = true;
                }
                else uc.Visible = false;
            }
        }

    }
}
