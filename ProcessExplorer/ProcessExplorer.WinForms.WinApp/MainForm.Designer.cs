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
            buttonGetProcesses = new Button();
            treeViewProcesses = new TreeView();
            processImageList = new ImageList(components);
            groupBox1 = new GroupBox();
            radioButtonExpandAll = new RadioButton();
            radioButtonCollapseAll = new RadioButton();
            groupBox1.SuspendLayout();
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
            treeViewProcesses.Location = new Point(12, 114);
            treeViewProcesses.Name = "treeViewProcesses";
            treeViewProcesses.SelectedImageIndex = 0;
            treeViewProcesses.Size = new Size(776, 324);
            treeViewProcesses.TabIndex = 1;
            // 
            // processImageList
            // 
            processImageList.ColorDepth = ColorDepth.Depth32Bit;
            processImageList.ImageSize = new Size(16, 16);
            processImageList.TransparentColor = Color.Transparent;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonCollapseAll);
            groupBox1.Controls.Add(radioButtonExpandAll);
            groupBox1.Controls.Add(buttonGetProcesses);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "프로세스 목록";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(treeViewProcesses);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGetProcesses;
        private TreeView treeViewProcesses;
        private ImageList processImageList;
        private GroupBox groupBox1;
        private RadioButton radioButtonCollapseAll;
        private RadioButton radioButtonExpandAll;
    }
}
