using CommonComponents;
using PresentationLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler MainViewLoadedEventRaised;
        public event EventHandler NewsBtnClickEventRaised;
        public event EventHandler PlantsListBtnClickEventRaised;
        public event EventHandler DepartmentListBtnClickEventRaised;
        public event EventHandler HelpAboutMenuClickEventRaised;

        public event EventHandler EmployeeListBtnClickEventRaised;

        private Point _userControlPanelMovingLocation;
        private int _userControlPanelTimerLoopCount = 0;
        private const int _userControlPanelStretchIncrement = 55;
        private const int _userControlPanelEndingStretchTopYPos = 60;

        private Panel _userControlPanelOrigValues = null;

        private List<Button> NavigationButtonList = null;

        public MainView()
        {
            InitializeComponent();
        }

        /*
        public PictureBox GetUserInfoPictureBox()
        {
            return userInfoPictureBox;
        }
        */

        private void MainView_Load(object sender, EventArgs e)
        {
            NavigationButtonList = new List<Button>() { departmentsBtn, plantsBtn, newsBtn, empBtn };

            ButtonHelper.SetGroupToBorderless(NavigationButtonList);

            PictureBoxHelper.SetClickableBehavior(moreOptionsPictureBox);
            PictureBoxHelper.SetClickableBehavior(userInfoPictureBox);
           // PictureBoxHelper.SetClickableBehavior(notificationBellPictureBox);

            _userControlPanelOrigValues = new Panel();

            _userControlPanelOrigValues.Height = userPanel.Height;
            _userControlPanelOrigValues.Width = userPanel.Width;
            _userControlPanelOrigValues.Location = new Point(userPanel.Location.X, userPanel.Location.Y);

            ButtonHelper.SetUnderlinePosition(newsBtn, underlineLabel);

            FormHelper.SetFormAppearance(this);

            EventHelpers.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: MainViewLoadedEventRaised, eventArgs: e);
        }

        public Panel GetOptionsPanel()
        {
            return optionsPanel;
        }

        public void ResetUserControlPanelSizeandLocation()
        {
            userPanel.Height = _userControlPanelOrigValues.Height;
            userPanel.Width = _userControlPanelOrigValues.Width;
            userPanel.Location = _userControlPanelOrigValues.Location;
            SetVisibilityOfControlsForPanelSliding(true);
        }
        public void ShowMainView()
        {
            this.Show();
        }

        public void ExpandUserControlPanel()
        {
            SetVisibilityOfControlsForPanelSliding(false);

            DepartmentDetailTimer.Enabled = true;
        }
        public Panel GetUserControlPanel()
        {
            return userPanel;
        }

        private void SetVisibilityOfControlsForPanelSliding(bool visibility)
        {
            ButtonHelper.SetVisibilityOfButtons(NavigationButtonList, visibility, underlineLabel);

            gardenPictureBox.Visible = visibility;
        }
      

        private void PlantsBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: PlantsListBtnClickEventRaised, eventArgs: e);

            ButtonHelper.SetUnderlinePosition(plantsBtn, underlineLabel);
        }

        private void NewsBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: NewsBtnClickEventRaised, eventArgs: e);

            ButtonHelper.SetUnderlinePosition(newsBtn, underlineLabel);
        }

        private void DepartmentsBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, DepartmentListBtnClickEventRaised, e);

            ButtonHelper.SetUnderlinePosition(departmentsBtn, underlineLabel);
        }

        /*
        private void userPictureBox_Click(object sender, EventArgs e)
        {
            UserInfoView userInfoView = new UserInfoView(this);

            userInfoView.ShowDialog();
        }
        */
        private void departmentDetailTimer_Tick(object sender, EventArgs e)
        {
            if (_userControlPanelTimerLoopCount == 0)
            {
                _userControlPanelTimerLoopCount++;
                userPanel.Location = new Point(5, this.Height);

                _userControlPanelMovingLocation = new Point(_userControlPanelOrigValues.Location.X, _userControlPanelOrigValues.Location.Y);
            }

            if (_userControlPanelMovingLocation.Y > _userControlPanelEndingStretchTopYPos)
            {
                _userControlPanelMovingLocation.Y = _userControlPanelMovingLocation.Y - _userControlPanelStretchIncrement;
                userPanel.Location = _userControlPanelMovingLocation;
                userPanel.Height += _userControlPanelStretchIncrement;
            }
            else
            {
                _userControlPanelTimerLoopCount = 0;
                DepartmentDetailTimer.Enabled = false;
            }
        }

        private void moreOptionsPictureBox_Click(object sender, EventArgs e)
        {
            PictureBoxHelper.DisplayContextMenu(moreOptionsPictureBox, moreOptionsContextMenuStrip, this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, HelpAboutMenuClickEventRaised, e);
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(this, EmployeeListBtnClickEventRaised, e);
        }

        private void optionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
