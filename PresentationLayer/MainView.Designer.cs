
namespace PresentationLayer
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.userPanel = new System.Windows.Forms.Panel();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.notificationPictureBox = new System.Windows.Forms.PictureBox();
            this.userInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.moreOptionsPictureBox = new System.Windows.Forms.PictureBox();
            this.newsBtn = new System.Windows.Forms.Button();
            this.plantsBtn = new System.Windows.Forms.Button();
            this.departmentsBtn = new System.Windows.Forms.Button();
            this.gardenPictureBox = new System.Windows.Forms.PictureBox();
            this.underlineLabel = new System.Windows.Forms.Label();
            this.moreOptionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentDetailTimer = new System.Windows.Forms.Timer(this.components);
            this.empBtn = new System.Windows.Forms.Button();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moreOptionsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gardenPictureBox)).BeginInit();
            this.moreOptionsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // userPanel
            // 
            this.userPanel.Location = new System.Drawing.Point(4, 222);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(404, 291);
            this.userPanel.TabIndex = 0;
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackgroundImage = global::PresentationLayer.Properties.Resources.GlobalPlantsBanner;
            this.optionsPanel.Controls.Add(this.notificationPictureBox);
            this.optionsPanel.Controls.Add(this.userInfoPictureBox);
            this.optionsPanel.Controls.Add(this.moreOptionsPictureBox);
            this.optionsPanel.Location = new System.Drawing.Point(1, 1);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(407, 64);
            this.optionsPanel.TabIndex = 1;
            this.optionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.optionsPanel_Paint);
            // 
            // notificationPictureBox
            // 
            this.notificationPictureBox.BackgroundImage = global::PresentationLayer.Properties.Resources.Bell_Notification;
            this.notificationPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notificationPictureBox.Location = new System.Drawing.Point(303, 11);
            this.notificationPictureBox.Name = "notificationPictureBox";
            this.notificationPictureBox.Size = new System.Drawing.Size(28, 28);
            this.notificationPictureBox.TabIndex = 7;
            this.notificationPictureBox.TabStop = false;
            // 
            // userInfoPictureBox
            // 
            this.userInfoPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userInfoPictureBox.BackgroundImage = global::PresentationLayer.Properties.Resources.UserIconWhiteSpheres;
            this.userInfoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userInfoPictureBox.Location = new System.Drawing.Point(337, 11);
            this.userInfoPictureBox.Name = "userInfoPictureBox";
            this.userInfoPictureBox.Size = new System.Drawing.Size(28, 28);
            this.userInfoPictureBox.TabIndex = 6;
            this.userInfoPictureBox.TabStop = false;
            // 
            // moreOptionsPictureBox
            // 
            this.moreOptionsPictureBox.BackColor = System.Drawing.Color.White;
            this.moreOptionsPictureBox.BackgroundImage = global::PresentationLayer.Properties.Resources.MoreOptionsBlackDotsOnWhite20x20;
            this.moreOptionsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moreOptionsPictureBox.Location = new System.Drawing.Point(371, 11);
            this.moreOptionsPictureBox.Name = "moreOptionsPictureBox";
            this.moreOptionsPictureBox.Size = new System.Drawing.Size(28, 28);
            this.moreOptionsPictureBox.TabIndex = 5;
            this.moreOptionsPictureBox.TabStop = false;
            this.moreOptionsPictureBox.Click += new System.EventHandler(this.moreOptionsPictureBox_Click);
            // 
            // newsBtn
            // 
            this.newsBtn.Location = new System.Drawing.Point(4, 180);
            this.newsBtn.Name = "newsBtn";
            this.newsBtn.Size = new System.Drawing.Size(91, 23);
            this.newsBtn.TabIndex = 2;
            this.newsBtn.Text = "News";
            this.newsBtn.UseVisualStyleBackColor = true;
            // 
            // plantsBtn
            // 
            this.plantsBtn.Location = new System.Drawing.Point(101, 180);
            this.plantsBtn.Name = "plantsBtn";
            this.plantsBtn.Size = new System.Drawing.Size(91, 23);
            this.plantsBtn.TabIndex = 3;
            this.plantsBtn.Text = "Plants";
            this.plantsBtn.UseVisualStyleBackColor = true;
            // 
            // departmentsBtn
            // 
            this.departmentsBtn.Location = new System.Drawing.Point(198, 180);
            this.departmentsBtn.Name = "departmentsBtn";
            this.departmentsBtn.Size = new System.Drawing.Size(98, 23);
            this.departmentsBtn.TabIndex = 4;
            this.departmentsBtn.Text = "Departments";
            this.departmentsBtn.UseVisualStyleBackColor = true;
            this.departmentsBtn.Click += new System.EventHandler(this.DepartmentsBtn_Click);
            // 
            // gardenPictureBox
            // 
            this.gardenPictureBox.BackgroundImage = global::PresentationLayer.Properties.Resources.FlowerShrubLine;
            this.gardenPictureBox.Location = new System.Drawing.Point(1, 60);
            this.gardenPictureBox.Name = "gardenPictureBox";
            this.gardenPictureBox.Size = new System.Drawing.Size(407, 114);
            this.gardenPictureBox.TabIndex = 8;
            this.gardenPictureBox.TabStop = false;
            // 
            // underlineLabel
            // 
            this.underlineLabel.AutoSize = true;
            this.underlineLabel.BackColor = System.Drawing.Color.Black;
            this.underlineLabel.Location = new System.Drawing.Point(12, 202);
            this.underlineLabel.Name = "underlineLabel";
            this.underlineLabel.Size = new System.Drawing.Size(0, 17);
            this.underlineLabel.TabIndex = 9;
            // 
            // moreOptionsContextMenuStrip
            // 
            this.moreOptionsContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.moreOptionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.moreOptionsContextMenuStrip.Name = "moreOptionsContextMenuStrip";
            this.moreOptionsContextMenuStrip.Size = new System.Drawing.Size(156, 76);
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.helpAboutToolStripMenuItem.Text = "Help About";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.helpAboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // empBtn
            // 
            this.empBtn.Location = new System.Drawing.Point(303, 179);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(90, 23);
            this.empBtn.TabIndex = 10;
            this.empBtn.Text = "Employees";
            this.empBtn.UseVisualStyleBackColor = true;
            this.empBtn.Click += new System.EventHandler(this.empBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 506);
            this.Controls.Add(this.empBtn);
            this.Controls.Add(this.underlineLabel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.gardenPictureBox);
            this.Controls.Add(this.departmentsBtn);
            this.Controls.Add(this.plantsBtn);
            this.Controls.Add(this.newsBtn);
            this.Controls.Add(this.userPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model View Presenter";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.optionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notificationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moreOptionsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gardenPictureBox)).EndInit();
            this.moreOptionsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button newsBtn;
        private System.Windows.Forms.Button plantsBtn;
        private System.Windows.Forms.Button departmentsBtn;
        private System.Windows.Forms.PictureBox moreOptionsPictureBox;
        private System.Windows.Forms.PictureBox userInfoPictureBox;
        private System.Windows.Forms.PictureBox notificationPictureBox;
        private System.Windows.Forms.PictureBox gardenPictureBox;
        private System.Windows.Forms.Label underlineLabel;
        private System.Windows.Forms.ContextMenuStrip moreOptionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer DepartmentDetailTimer;
        private System.Windows.Forms.Button empBtn;
    }
}

