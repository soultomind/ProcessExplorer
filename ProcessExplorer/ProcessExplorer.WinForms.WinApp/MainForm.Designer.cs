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
            SuspendLayout();
            // 
            // buttonGetProcesses
            // 
            buttonGetProcesses.Location = new Point(12, 12);
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
            treeViewProcesses.Location = new Point(12, 51);
            treeViewProcesses.Name = "treeViewProcesses";
            treeViewProcesses.SelectedImageIndex = 0;
            treeViewProcesses.Size = new Size(776, 387);
            treeViewProcesses.TabIndex = 1;
            // 
            // processImageList
            // 
            processImageList.ColorDepth = ColorDepth.Depth32Bit;
            processImageList.ImageSize = new Size(16, 16);
            processImageList.TransparentColor = Color.Transparent;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeViewProcesses);
            Controls.Add(buttonGetProcesses);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGetProcesses;
        private TreeView treeViewProcesses;
        private ImageList processImageList;
    }
}
