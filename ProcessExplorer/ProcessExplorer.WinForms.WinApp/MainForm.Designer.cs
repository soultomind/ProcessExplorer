namespace ProcessExplorer.WinForms.WinApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonGetProcesses = new Button();
            treeViewProcesses = new TreeView();
            processImageList = new ImageList(components);
            groupBoxTest = new GroupBox();
            radioButtonCollapseAll = new RadioButton();
            radioButtonExpandAll = new RadioButton();
            menuStrip = new MenuStrip();
            mainHelpToolStripMenuItem = new ToolStripMenuItem();
            sub1HelpToolStripMenuItem = new ToolStripMenuItem();
            sub1AboutProcessExplorerToolStripMenuItem = new ToolStripMenuItem();
            groupBoxTest.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGetProcesses
            // 
            buttonGetProcesses.Location = new Point(6, 22);
            buttonGetProcesses.Name = "buttonGetProcesses";
            buttonGetProcesses.Size = new Size(75, 23);
            buttonGetProcesses.TabIndex = 0;
            buttonGetProcesses.Text = "목록보기";
            buttonGetProcesses.UseVisualStyleBackColor = true;
            buttonGetProcesses.Click += ButtonGetProcesses_Click;
            // 
            // treeViewProcesses
            // 
            treeViewProcesses.ImageIndex = 0;
            treeViewProcesses.ImageList = processImageList;
            treeViewProcesses.Location = new Point(12, 142);
            treeViewProcesses.Name = "treeViewProcesses";
            treeViewProcesses.SelectedImageIndex = 0;
            treeViewProcesses.Size = new Size(776, 296);
            treeViewProcesses.TabIndex = 1;
            // 
            // processImageList
            // 
            processImageList.ColorDepth = ColorDepth.Depth32Bit;
            processImageList.ImageSize = new Size(16, 16);
            processImageList.TransparentColor = Color.Transparent;
            // 
            // groupBoxTest
            // 
            groupBoxTest.Controls.Add(radioButtonCollapseAll);
            groupBoxTest.Controls.Add(radioButtonExpandAll);
            groupBoxTest.Controls.Add(buttonGetProcesses);
            groupBoxTest.Location = new Point(12, 35);
            groupBoxTest.Name = "groupBoxTest";
            groupBoxTest.Size = new Size(776, 100);
            groupBoxTest.TabIndex = 2;
            groupBoxTest.TabStop = false;
            groupBoxTest.Text = "프로세스 목록";
            // 
            // radioButtonCollapseAll
            // 
            radioButtonCollapseAll.AutoSize = true;
            radioButtonCollapseAll.Location = new Point(199, 26);
            radioButtonCollapseAll.Name = "radioButtonCollapseAll";
            radioButtonCollapseAll.Size = new Size(84, 19);
            radioButtonCollapseAll.TabIndex = 2;
            radioButtonCollapseAll.TabStop = true;
            radioButtonCollapseAll.Tag = "CollapseAll";
            radioButtonCollapseAll.Text = "CollapseAll";
            radioButtonCollapseAll.UseVisualStyleBackColor = true;
            radioButtonCollapseAll.CheckedChanged += RadioButton_InitializeTreeViewProcesses;
            // 
            // radioButtonExpandAll
            // 
            radioButtonExpandAll.AutoSize = true;
            radioButtonExpandAll.Location = new Point(98, 26);
            radioButtonExpandAll.Name = "radioButtonExpandAll";
            radioButtonExpandAll.Size = new Size(78, 19);
            radioButtonExpandAll.TabIndex = 1;
            radioButtonExpandAll.TabStop = true;
            radioButtonExpandAll.Tag = "ExpandAll";
            radioButtonExpandAll.Text = "ExpandAll";
            radioButtonExpandAll.UseVisualStyleBackColor = true;
            radioButtonExpandAll.CheckedChanged += RadioButton_InitializeTreeViewProcesses;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { mainHelpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // mainHelpToolStripMenuItem
            // 
            mainHelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sub1HelpToolStripMenuItem, sub1AboutProcessExplorerToolStripMenuItem });
            mainHelpToolStripMenuItem.Name = "mainHelpToolStripMenuItem";
            mainHelpToolStripMenuItem.Size = new Size(44, 20);
            mainHelpToolStripMenuItem.Text = "Help";
            // 
            // sub1HelpToolStripMenuItem
            // 
            sub1HelpToolStripMenuItem.Name = "sub1HelpToolStripMenuItem";
            sub1HelpToolStripMenuItem.Size = new Size(198, 22);
            sub1HelpToolStripMenuItem.Text = "Help";
            sub1HelpToolStripMenuItem.Click += Sub1HelpToolStripMenuItem_Click;
            // 
            // sub1AboutProcessExplorerToolStripMenuItem
            // 
            sub1AboutProcessExplorerToolStripMenuItem.Name = "sub1AboutProcessExplorerToolStripMenuItem";
            sub1AboutProcessExplorerToolStripMenuItem.Size = new Size(198, 22);
            sub1AboutProcessExplorerToolStripMenuItem.Text = "About Process Explorer";
            sub1AboutProcessExplorerToolStripMenuItem.Click += Sub1AboutProcessExplorerToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            Controls.Add(groupBoxTest);
            Controls.Add(treeViewProcesses);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Process Explorer";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            groupBoxTest.ResumeLayout(false);
            groupBoxTest.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetProcesses;
        private TreeView treeViewProcesses;
        private ImageList processImageList;
        private GroupBox groupBoxTest;
        private RadioButton radioButtonCollapseAll;
        private RadioButton radioButtonExpandAll;
        private ContextMenuStrip contextMenuStrip;
        private MenuStrip menuStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem mainHelpToolStripMenuItem;
        private ToolStripMenuItem sub1AboutProcessExplorerToolStripMenuItem;
        private ToolStripMenuItem sub1HelpToolStripMenuItem;
    }
}
