using System.Diagnostics;
using System.IO;
using System.Security.Policy;
using Newtonsoft.Json;

namespace progress_tracker
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Projects saveData;
        string savePath;

        Project currentProject;
        float elapsedTime = 0;

        List<Panel> tabs = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            LoadProjects();
            tabs.Add(projectsPanel);
            tabs.Add(workPanel);
            tabs.Add(historyPanel);
        }
        private void ToggleTab(int targetTab)
        {
            for (int i = 0; i < tabs.Count; i++)
            {
                tabs[i].Visible = i == targetTab ? true : false;
            }
        }
        private void projectsTabButton_Click(object sender, EventArgs e)
        {
            ToggleTab(0);
        }

        private void workTabButton_Click(object sender, EventArgs e)
        {
            if (currentProject == null)
            {
                MessageBox.Show("Please load a project first.", "Error");
                return;
            }

            projectNameLabel.Text = currentProject.name;

            ToggleTab(1);
        }

        private void historyTabButton_Click(object sender, EventArgs e)
        {
            if (currentProject == null)
            {
                MessageBox.Show("Please load a project first.", "Error");
                return;
            }

            TimeSpan t = TimeSpan.FromSeconds(currentProject.totaltime);
            timeSpentLabel.Text = "Time Spent: " + string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}",
                t.Days, t.Hours, t.Minutes, t.Seconds);

            numberOfSessionsLabel.Text = "Number of Sessions: " + currentProject.sessions.Count;

            sessionsList.Items.Clear();

            foreach (var session in currentProject.sessions)
            {
                sessionsList.Items.Add(session.date);
            }
            if (sessionsList.Items.Count > 0)
            {
                HistoryUpdateSelection(0);
            }

            ToggleTab(2);
        }

        private void CreateInitialSave(string path)
        {
            var file = File.Create(path);

            file.Close();

            Projects new_projects = new Projects();
            new_projects.projects = new List<Project>();

            File.WriteAllText(path, JsonConvert.SerializeObject(new_projects));
        }
        private void Save()
        {
            File.WriteAllText(savePath, JsonConvert.SerializeObject(saveData));
        }
        private void LoadProjects()
        {
            string app_data_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); //Get AppData

            var nolan_burkhart_folder = app_data_path + "\\Nolan Burkhart"; //Check if Nolan Burkhart folder exists
            if (!Directory.Exists(nolan_burkhart_folder))
                Directory.CreateDirectory(nolan_burkhart_folder); //Create if it does not

            savePath = nolan_burkhart_folder + "\\progress_tracker.json";
            if (!File.Exists(savePath))
                CreateInitialSave(savePath);

            saveData = JsonConvert.DeserializeObject<Projects>(File.ReadAllText(savePath));

            foreach (Project proj in saveData.projects)
                projectsView.Items.Add(proj.name);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://github.com/Nolan-Burkhart/") { UseShellExecute = true }); // <3
        }
        private void createProjectButton_Click(object sender, EventArgs e)
        {
            Project new_project = new Project();

            new_project.totaltime = 0;
            new_project.sessions = new List<Session>();
            new_project.name = projectNameTextBox.Text;

            saveData.projects.Add(new_project);
            projectsView.Items.Add(new_project.name);

            Save();
        }
        private void loadProjectButton_Click(object sender, EventArgs e)
        {
            if (projectsView.SelectedIndices.Count == 0)
                return;

            currentProject = saveData.projects[projectsView.SelectedIndices[0]];
        }
        private void UpdateText(object sender, EventArgs e)
        {
            TimeSpan t = TimeSpan.FromSeconds(elapsedTime);
            elapsedTimeLabel.Text = "Elapsed Time: " + string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds);

            elapsedTime += 1;
        }
        private void SaveSession()
        {
            Session commit = new Session();

            commit.date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            commit.timespent = elapsedTime;
            commit.information = sessionNotes.Text;

            currentProject.sessions.Add(commit);
            currentProject.totaltime += elapsedTime;

            Save();
        }
        private void OnWindowDragged(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void sessionControlButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                SaveSession();

                timer1.Stop();
                elapsedTime = 0;

                sessionControlButton.Text = "Start Session";
                sessionNotes.Text = "";

                UpdateText(null, null);

                MessageBox.Show("Session Saved! Great work!", "Session Saved");
            }
            else
            {
                elapsedTime = 0;
                timer1.Start();

                sessionControlButton.Text = "End Session";
            }
        }

        private void HistoryUpdateSelection(int index)
        {
            var session = currentProject.sessions[index];
            sessionDateLabel.Text = "Date: " + session.date;

            TimeSpan t = TimeSpan.FromSeconds(session.timespent);
            timeSpentHistoryLabel.Text = "Time Spent: " + string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);

            sessionNotesTextBoxHistory.Text = session.information;
        }

        private void sessionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HistoryUpdateSelection(sessionsList.SelectedIndex);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Session
    {
        public string date
        {
            get;
            set;
        }
        public float timespent
        {
            get;
            set;
        }
        public string information
        {
            get;
            set;
        }
    }
    public class Project
    {
        public string name { 
            get; 
            set; 
        }
        public float totaltime
        {
            get;
            set;
        }
        public List<Session> sessions
        {
            get;
            set;
        }
    }
    public class Projects
    {
        public List<Project> projects
        {
            get;
            set;
        }
    }
}