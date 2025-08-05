using ProcessExplorer.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessExplorer.WinForms.WinApp
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();

            Version version = ProcessExplorerContext.Version;
            string processExplorerVersion =
                String.Format("Process Explorer v{0}", version.ToString());

            labelProcessExplorerVersion.Text = processExplorerVersion;
        }

        private void ButtonOkay_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
