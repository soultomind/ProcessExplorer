using ProcessExplorer.Core;
using System.Diagnostics;
using System.Management;

namespace ProcessExplorer.WinForms.WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonGetProcessList_Click(object sender, EventArgs e)
        {
            ManagementWin32Processes? win32Processes = null;
            if (ManagementWin32Processes.TryGetProcesses(out win32Processes))
            {
                win32Processes.Processes.ForEach(p =>
                {
                    Debug.WriteLine($"Process Name: {p.Name}, Process ID: {p.ProcessId}, Parent Process ID: {p.ParentProcessId}");
                });
            }
        }
    }
}
