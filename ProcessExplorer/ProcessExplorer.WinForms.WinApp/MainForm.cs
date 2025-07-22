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
            treeViewProcesses.Nodes.Clear();
            var roots = Win32ProcessTreeBuilder.Build();
            foreach (var root in roots)
            {
                treeViewProcesses.Nodes.Add(CreateTreeNode(root));
            }
            treeViewProcesses.ExpandAll();
        }

        private TreeNode CreateTreeNode(Win32ProcessTreeNode node)
        {
            var treeNode = new TreeNode($"{node.Name} (ProcessId: {node.ProcessId})");
            foreach (var child in node.Children)
            {
                treeNode.Nodes.Add(CreateTreeNode(child));
            }
            return treeNode;
        }
    }
}
