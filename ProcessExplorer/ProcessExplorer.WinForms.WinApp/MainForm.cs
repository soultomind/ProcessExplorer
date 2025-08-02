using ProcessExplorer.Core;
using System.Diagnostics;
using System.Management;
using System.Xml.Linq;

namespace ProcessExplorer.WinForms.WinApp
{
    public partial class MainForm : Form
    {
        public TreeViewShowUIProcesses TreeViewShowUIProcesses { get; set; } = TreeViewShowUIProcesses.CollapseAll;
        public MainForm()
        {
            InitializeComponent();

            Text = String.Format("{0}[{1}\\{2}]",
                Text, Environment.UserDomainName, Environment.UserName);

            radioButtonCollapseAll.Checked = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeTreeViewProcesses();
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                HelpProcess();
            }
        }

        private void ButtonGetProcesses_Click(object sender, EventArgs e)
        {
            InitializeTreeViewProcesses();
        }

        private void RadioButton_InitializeTreeViewProcesses(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                switch (radioButton.Name)
                {
                    case nameof(radioButtonCollapseAll):
                        TreeViewShowUIProcesses = TreeViewShowUIProcesses.CollapseAll;
                        break;
                    case nameof(radioButtonExpandAll):
                        TreeViewShowUIProcesses = TreeViewShowUIProcesses.ExpandAll;
                        break;
                    default:
                        throw new NotSupportedException($"Unsupported radio button: {radioButton.Name}");
                }
            }
        }

        private void Sub1HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpProcess();
        }

        private void Sub1AboutProcessExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutDialog aboutDialog = new AboutDialog())
            {
                if (aboutDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Do nothing, just close the dialog
                }
            }
        }
    }
}
