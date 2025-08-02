using ProcessExplorer.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessExplorer.WinForms.WinApp
{
    public partial class MainForm
    {
        #region ContextMenuStrip

        #region MainHelp

        

        #endregion

        #endregion

        private void HelpProcess()
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "http://www.github.com/soultomind/ProcessExplorer",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"브라우저 실행 중 오류가 발생했습니다: {ex.Message}",
                    "오류",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ClearTreeViewProcesses()
        {
            treeViewProcesses.Nodes.Clear();
            processImageList.Images.Clear();
        }
        private void InitializeTreeViewProcesses()
        {
            ClearTreeViewProcesses();

            var roots = Win32ProcessTreeBuilder.Build();
            foreach (var root in roots)
            {
                treeViewProcesses.Nodes.Add(CreateTreeNodeProcessImage(root));
            }

            switch (TreeViewShowUIProcesses)
            {
                case TreeViewShowUIProcesses.ExpandAll:
                    treeViewProcesses.ExpandAll();
                    break;
                case TreeViewShowUIProcesses.CollapseAll:
                    treeViewProcesses.CollapseAll();
                    break;
                default:
                    break;
            }
        }

        private TreeNode CreateTreeNode(Win32ProcessTreeNode node)
        {
            var treeNode = new TreeNode($"{node.Name} (PID: {node.ProcessId})");
            foreach (var child in node.Children)
            {
                treeNode.Nodes.Add(CreateTreeNode(child));
            }
            return treeNode;
        }

        private TreeNode CreateTreeNodeProcessImage(Win32ProcessTreeNode treeNode)
        {
            string imageKey = treeNode.ProcessId.ToString();
            // 아이콘 추출 및 ImageList에 추가
            if (!processImageList.Images.ContainsKey(imageKey))
            {
                Icon? icon = null;
                try
                {
                    if (treeNode.ProcessId > 0)
                    {
                        using (var proc = Process.GetProcessById(treeNode.ProcessId))
                        {
                            string? filePath = null;

                            try
                            {
                                filePath = proc.MainModule?.FileName;
                            }
                            catch (Exception)
                            {

                            }

                            if (!string.IsNullOrEmpty(filePath))
                            {
                                icon = Icon.ExtractAssociatedIcon(filePath);
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }

                if (icon == null)
                {
                    icon = SystemIcons.Application;
                }
                processImageList.Images.Add(imageKey, icon);
            }

            var newTreeNode = new TreeNode($"{treeNode.Name} (PID: {treeNode.ProcessId})")
            {
                ImageKey = imageKey,
                SelectedImageKey = imageKey
            };

            foreach (var child in treeNode.Children)
            {
                newTreeNode.Nodes.Add(CreateTreeNodeProcessImage(child));
            }
            return newTreeNode;
        }
    }
}
