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

            radioButtonCollapseAll.Checked = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeTreeViewProcesses();
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
    }
}
