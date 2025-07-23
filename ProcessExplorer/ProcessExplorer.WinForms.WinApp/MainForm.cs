using ProcessExplorer.Core;
using System.Diagnostics;
using System.Management;
using System.Xml.Linq;

namespace ProcessExplorer.WinForms.WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // TreeView¿¡ ImageList ¿¬°á
            /*
            treeViewProcesses.ImageList = processImageList;
            processImageList.ColorDepth = ColorDepth.Depth32Bit;
            processImageList.ImageSize = new Size(16, 16);
            */
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeTreeViewProcesses();
        }

        private void ButtonGetProcessList_Click(object sender, EventArgs e)
        {
            InitializeTreeViewProcesses();
        }
    }
}
