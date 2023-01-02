namespace progress_tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.designPanelUpper = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.githubShillLabel = new System.Windows.Forms.LinkLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.designPanelSide = new System.Windows.Forms.Panel();
            this.historyTabButton = new System.Windows.Forms.Button();
            this.workTabButton = new System.Windows.Forms.Button();
            this.projectsTabButton = new System.Windows.Forms.Button();
            this.projectsPanel = new System.Windows.Forms.Panel();
            this.loadProjectButton = new System.Windows.Forms.Button();
            this.existingProjectsLabel = new System.Windows.Forms.Label();
            this.newProjectLabel = new System.Windows.Forms.Label();
            this.projectNameTextLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.projectsView = new System.Windows.Forms.ListView();
            this.workPanel = new System.Windows.Forms.Panel();
            this.sessionNotesLabel = new System.Windows.Forms.Label();
            this.sessionNotes = new System.Windows.Forms.RichTextBox();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.sessionControlButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.historyPanel = new System.Windows.Forms.Panel();
            this.sessionNotesTextBoxHistory = new System.Windows.Forms.RichTextBox();
            this.timeSpentHistoryLabel = new System.Windows.Forms.Label();
            this.sessionDateLabel = new System.Windows.Forms.Label();
            this.numberOfSessionsLabel = new System.Windows.Forms.Label();
            this.sessionsList = new System.Windows.Forms.ListBox();
            this.timeSpentLabel = new System.Windows.Forms.Label();
            this.projectHistoryTitleLabel = new System.Windows.Forms.Label();
            this.designPanelUpper.SuspendLayout();
            this.designPanelSide.SuspendLayout();
            this.projectsPanel.SuspendLayout();
            this.workPanel.SuspendLayout();
            this.historyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // designPanelUpper
            // 
            this.designPanelUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(73)))), ((int)(((byte)(58)))));
            this.designPanelUpper.Controls.Add(this.exitButton);
            this.designPanelUpper.Controls.Add(this.githubShillLabel);
            this.designPanelUpper.Controls.Add(this.titleLabel);
            this.designPanelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.designPanelUpper.Location = new System.Drawing.Point(0, 0);
            this.designPanelUpper.Name = "designPanelUpper";
            this.designPanelUpper.Size = new System.Drawing.Size(979, 79);
            this.designPanelUpper.TabIndex = 0;
            this.designPanelUpper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnWindowDragged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(893, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // githubShillLabel
            // 
            this.githubShillLabel.AutoSize = true;
            this.githubShillLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.githubShillLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.githubShillLabel.Location = new System.Drawing.Point(682, 5);
            this.githubShillLabel.Name = "githubShillLabel";
            this.githubShillLabel.Size = new System.Drawing.Size(205, 25);
            this.githubShillLabel.TabIndex = 1;
            this.githubShillLabel.TabStop = true;
            this.githubShillLabel.Text = "Made by Nolan Burkhart";
            this.githubShillLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.githubShillLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(175)))), ((int)(((byte)(172)))));
            this.githubShillLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(447, 67);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Progress Tracker";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // designPanelSide
            // 
            this.designPanelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(162)))), ((int)(((byte)(174)))));
            this.designPanelSide.Controls.Add(this.historyTabButton);
            this.designPanelSide.Controls.Add(this.workTabButton);
            this.designPanelSide.Controls.Add(this.projectsTabButton);
            this.designPanelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.designPanelSide.Location = new System.Drawing.Point(0, 79);
            this.designPanelSide.Name = "designPanelSide";
            this.designPanelSide.Size = new System.Drawing.Size(213, 570);
            this.designPanelSide.TabIndex = 1;
            // 
            // historyTabButton
            // 
            this.historyTabButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(162)))), ((int)(((byte)(174)))));
            this.historyTabButton.FlatAppearance.BorderSize = 0;
            this.historyTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyTabButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.historyTabButton.Location = new System.Drawing.Point(0, 390);
            this.historyTabButton.Name = "historyTabButton";
            this.historyTabButton.Size = new System.Drawing.Size(213, 98);
            this.historyTabButton.TabIndex = 2;
            this.historyTabButton.Text = "History";
            this.historyTabButton.UseVisualStyleBackColor = true;
            this.historyTabButton.Click += new System.EventHandler(this.historyTabButton_Click);
            // 
            // workTabButton
            // 
            this.workTabButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(162)))), ((int)(((byte)(174)))));
            this.workTabButton.FlatAppearance.BorderSize = 0;
            this.workTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workTabButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.workTabButton.Location = new System.Drawing.Point(0, 215);
            this.workTabButton.Name = "workTabButton";
            this.workTabButton.Size = new System.Drawing.Size(213, 104);
            this.workTabButton.TabIndex = 1;
            this.workTabButton.Text = "Work";
            this.workTabButton.UseVisualStyleBackColor = true;
            this.workTabButton.Click += new System.EventHandler(this.workTabButton_Click);
            // 
            // projectsTabButton
            // 
            this.projectsTabButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(162)))), ((int)(((byte)(174)))));
            this.projectsTabButton.FlatAppearance.BorderSize = 0;
            this.projectsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsTabButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectsTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.projectsTabButton.Location = new System.Drawing.Point(0, 39);
            this.projectsTabButton.Name = "projectsTabButton";
            this.projectsTabButton.Size = new System.Drawing.Size(213, 109);
            this.projectsTabButton.TabIndex = 0;
            this.projectsTabButton.Text = "Projects";
            this.projectsTabButton.UseVisualStyleBackColor = true;
            this.projectsTabButton.Click += new System.EventHandler(this.projectsTabButton_Click);
            // 
            // projectsPanel
            // 
            this.projectsPanel.Controls.Add(this.loadProjectButton);
            this.projectsPanel.Controls.Add(this.existingProjectsLabel);
            this.projectsPanel.Controls.Add(this.newProjectLabel);
            this.projectsPanel.Controls.Add(this.projectNameTextLabel);
            this.projectsPanel.Controls.Add(this.projectNameTextBox);
            this.projectsPanel.Controls.Add(this.createProjectButton);
            this.projectsPanel.Controls.Add(this.projectsView);
            this.projectsPanel.Location = new System.Drawing.Point(213, 79);
            this.projectsPanel.Name = "projectsPanel";
            this.projectsPanel.Size = new System.Drawing.Size(766, 570);
            this.projectsPanel.TabIndex = 2;
            // 
            // loadProjectButton
            // 
            this.loadProjectButton.Location = new System.Drawing.Point(26, 483);
            this.loadProjectButton.Name = "loadProjectButton";
            this.loadProjectButton.Size = new System.Drawing.Size(682, 75);
            this.loadProjectButton.TabIndex = 6;
            this.loadProjectButton.Text = "Load Project";
            this.loadProjectButton.UseVisualStyleBackColor = true;
            this.loadProjectButton.Click += new System.EventHandler(this.loadProjectButton_Click);
            // 
            // existingProjectsLabel
            // 
            this.existingProjectsLabel.AutoSize = true;
            this.existingProjectsLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.existingProjectsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.existingProjectsLabel.Location = new System.Drawing.Point(26, 184);
            this.existingProjectsLabel.Name = "existingProjectsLabel";
            this.existingProjectsLabel.Size = new System.Drawing.Size(177, 28);
            this.existingProjectsLabel.TabIndex = 5;
            this.existingProjectsLabel.Text = "Existing Projects";
            // 
            // newProjectLabel
            // 
            this.newProjectLabel.AutoSize = true;
            this.newProjectLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newProjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.newProjectLabel.Location = new System.Drawing.Point(26, 3);
            this.newProjectLabel.Name = "newProjectLabel";
            this.newProjectLabel.Size = new System.Drawing.Size(132, 28);
            this.newProjectLabel.TabIndex = 4;
            this.newProjectLabel.Text = "New Project";
            // 
            // projectNameTextLabel
            // 
            this.projectNameTextLabel.AutoSize = true;
            this.projectNameTextLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectNameTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.projectNameTextLabel.Location = new System.Drawing.Point(26, 39);
            this.projectNameTextLabel.Name = "projectNameTextLabel";
            this.projectNameTextLabel.Size = new System.Drawing.Size(145, 28);
            this.projectNameTextLabel.TabIndex = 3;
            this.projectNameTextLabel.Text = "Project Name";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(190, 39);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(518, 31);
            this.projectNameTextBox.TabIndex = 2;
            // 
            // createProjectButton
            // 
            this.createProjectButton.Location = new System.Drawing.Point(26, 85);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(682, 75);
            this.createProjectButton.TabIndex = 1;
            this.createProjectButton.Text = "Create Project";
            this.createProjectButton.UseVisualStyleBackColor = true;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // projectsView
            // 
            this.projectsView.Location = new System.Drawing.Point(26, 215);
            this.projectsView.Name = "projectsView";
            this.projectsView.Size = new System.Drawing.Size(682, 254);
            this.projectsView.TabIndex = 0;
            this.projectsView.UseCompatibleStateImageBehavior = false;
            this.projectsView.View = System.Windows.Forms.View.List;
            // 
            // workPanel
            // 
            this.workPanel.Controls.Add(this.sessionNotesLabel);
            this.workPanel.Controls.Add(this.sessionNotes);
            this.workPanel.Controls.Add(this.elapsedTimeLabel);
            this.workPanel.Controls.Add(this.sessionControlButton);
            this.workPanel.Controls.Add(this.projectNameLabel);
            this.workPanel.Location = new System.Drawing.Point(213, 79);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(766, 570);
            this.workPanel.TabIndex = 3;
            this.workPanel.Visible = false;
            // 
            // sessionNotesLabel
            // 
            this.sessionNotesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sessionNotesLabel.AutoSize = true;
            this.sessionNotesLabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessionNotesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.sessionNotesLabel.Location = new System.Drawing.Point(16, 191);
            this.sessionNotesLabel.Name = "sessionNotesLabel";
            this.sessionNotesLabel.Size = new System.Drawing.Size(222, 41);
            this.sessionNotesLabel.TabIndex = 5;
            this.sessionNotesLabel.Text = "Session Notes";
            this.sessionNotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sessionNotes
            // 
            this.sessionNotes.Location = new System.Drawing.Point(26, 235);
            this.sessionNotes.Name = "sessionNotes";
            this.sessionNotes.Size = new System.Drawing.Size(716, 320);
            this.sessionNotes.TabIndex = 3;
            this.sessionNotes.Text = "";
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.elapsedTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.elapsedTimeLabel.Location = new System.Drawing.Point(16, 85);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(358, 41);
            this.elapsedTimeLabel.TabIndex = 2;
            this.elapsedTimeLabel.Text = "Elapsed Time: 00:00:00";
            this.elapsedTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sessionControlButton
            // 
            this.sessionControlButton.Location = new System.Drawing.Point(25, 129);
            this.sessionControlButton.Name = "sessionControlButton";
            this.sessionControlButton.Size = new System.Drawing.Size(349, 59);
            this.sessionControlButton.TabIndex = 1;
            this.sessionControlButton.Text = "Start Session";
            this.sessionControlButton.UseVisualStyleBackColor = true;
            this.sessionControlButton.Click += new System.EventHandler(this.sessionControlButton_Click);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.projectNameLabel.Location = new System.Drawing.Point(6, 8);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(429, 67);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Example Project";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.UpdateText);
            // 
            // historyPanel
            // 
            this.historyPanel.Controls.Add(this.sessionNotesTextBoxHistory);
            this.historyPanel.Controls.Add(this.timeSpentHistoryLabel);
            this.historyPanel.Controls.Add(this.sessionDateLabel);
            this.historyPanel.Controls.Add(this.numberOfSessionsLabel);
            this.historyPanel.Controls.Add(this.sessionsList);
            this.historyPanel.Controls.Add(this.timeSpentLabel);
            this.historyPanel.Controls.Add(this.projectHistoryTitleLabel);
            this.historyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyPanel.Location = new System.Drawing.Point(213, 79);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(766, 570);
            this.historyPanel.TabIndex = 4;
            this.historyPanel.Visible = false;
            // 
            // sessionNotesTextBoxHistory
            // 
            this.sessionNotesTextBoxHistory.Location = new System.Drawing.Point(289, 241);
            this.sessionNotesTextBoxHistory.Name = "sessionNotesTextBoxHistory";
            this.sessionNotesTextBoxHistory.ReadOnly = true;
            this.sessionNotesTextBoxHistory.Size = new System.Drawing.Size(456, 283);
            this.sessionNotesTextBoxHistory.TabIndex = 6;
            this.sessionNotesTextBoxHistory.Text = "";
            // 
            // timeSpentHistoryLabel
            // 
            this.timeSpentHistoryLabel.AutoSize = true;
            this.timeSpentHistoryLabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeSpentHistoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.timeSpentHistoryLabel.Location = new System.Drawing.Point(289, 188);
            this.timeSpentHistoryLabel.Name = "timeSpentHistoryLabel";
            this.timeSpentHistoryLabel.Size = new System.Drawing.Size(264, 41);
            this.timeSpentHistoryLabel.TabIndex = 5;
            this.timeSpentHistoryLabel.Text = "Time Spent: N/A";
            // 
            // sessionDateLabel
            // 
            this.sessionDateLabel.AutoSize = true;
            this.sessionDateLabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sessionDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.sessionDateLabel.Location = new System.Drawing.Point(289, 147);
            this.sessionDateLabel.Name = "sessionDateLabel";
            this.sessionDateLabel.Size = new System.Drawing.Size(167, 41);
            this.sessionDateLabel.TabIndex = 4;
            this.sessionDateLabel.Text = "Date: N/A";
            // 
            // numberOfSessionsLabel
            // 
            this.numberOfSessionsLabel.AutoSize = true;
            this.numberOfSessionsLabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberOfSessionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.numberOfSessionsLabel.Location = new System.Drawing.Point(6, 95);
            this.numberOfSessionsLabel.Name = "numberOfSessionsLabel";
            this.numberOfSessionsLabel.Size = new System.Drawing.Size(320, 41);
            this.numberOfSessionsLabel.TabIndex = 3;
            this.numberOfSessionsLabel.Text = "Number of Sessions:";
            // 
            // sessionsList
            // 
            this.sessionsList.FormattingEnabled = true;
            this.sessionsList.ItemHeight = 25;
            this.sessionsList.Location = new System.Drawing.Point(16, 145);
            this.sessionsList.Name = "sessionsList";
            this.sessionsList.Size = new System.Drawing.Size(255, 379);
            this.sessionsList.TabIndex = 2;
            this.sessionsList.SelectedIndexChanged += new System.EventHandler(this.sessionsList_SelectedIndexChanged);
            // 
            // timeSpentLabel
            // 
            this.timeSpentLabel.AutoSize = true;
            this.timeSpentLabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeSpentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.timeSpentLabel.Location = new System.Drawing.Point(6, 54);
            this.timeSpentLabel.Name = "timeSpentLabel";
            this.timeSpentLabel.Size = new System.Drawing.Size(195, 41);
            this.timeSpentLabel.TabIndex = 1;
            this.timeSpentLabel.Text = "Time Spent:";
            // 
            // projectHistoryTitleLabel
            // 
            this.projectHistoryTitleLabel.AutoSize = true;
            this.projectHistoryTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectHistoryTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.projectHistoryTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.projectHistoryTitleLabel.Name = "projectHistoryTitleLabel";
            this.projectHistoryTitleLabel.Size = new System.Drawing.Size(318, 54);
            this.projectHistoryTitleLabel.TabIndex = 0;
            this.projectHistoryTitleLabel.Text = "Project History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(979, 649);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.projectsPanel);
            this.Controls.Add(this.designPanelSide);
            this.Controls.Add(this.designPanelUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Progress Tracker";
            this.designPanelUpper.ResumeLayout(false);
            this.designPanelUpper.PerformLayout();
            this.designPanelSide.ResumeLayout(false);
            this.projectsPanel.ResumeLayout(false);
            this.projectsPanel.PerformLayout();
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            this.historyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel designPanelUpper;
        private LinkLabel githubShillLabel;
        private Label titleLabel;
        private Panel designPanelSide;
        private Button historyTabButton;
        private Button workTabButton;
        private Button projectsTabButton;
        private Panel projectsPanel;
        private Label projectNameTextLabel;
        private TextBox projectNameTextBox;
        private Button createProjectButton;
        private ListView projectsView;
        private Button loadProjectButton;
        private Label existingProjectsLabel;
        private Label newProjectLabel;
        private Panel workPanel;
        private Label projectNameLabel;
        private Label elapsedTimeLabel;
        private Button sessionControlButton;
        private System.Windows.Forms.Timer timer1;
        private Label sessionNotesLabel;
        private RichTextBox sessionNotes;
        private Panel historyPanel;
        private RichTextBox sessionNotesTextBoxHistory;
        private Label timeSpentHistoryLabel;
        private Label sessionDateLabel;
        private Label numberOfSessionsLabel;
        private ListBox sessionsList;
        private Label timeSpentLabel;
        private Label projectHistoryTitleLabel;
        private Button exitButton;
    }
}