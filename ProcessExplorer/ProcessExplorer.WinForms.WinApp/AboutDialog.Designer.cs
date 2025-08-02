namespace ProcessExplorer.WinForms.WinApp
{
    partial class AboutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            pictureBoxProcessExplorer = new PictureBox();
            labelProcessExplorerVersion = new Label();
            buttonOkay = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcessExplorer).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProcessExplorer
            // 
            pictureBoxProcessExplorer.Image = Resources.Img_ProcessExplorer_32px;
            pictureBoxProcessExplorer.Location = new Point(12, 10);
            pictureBoxProcessExplorer.Name = "pictureBoxProcessExplorer";
            pictureBoxProcessExplorer.Size = new Size(32, 32);
            pictureBoxProcessExplorer.TabIndex = 0;
            pictureBoxProcessExplorer.TabStop = false;
            // 
            // labelProcessExplorerVersion
            // 
            labelProcessExplorerVersion.AutoSize = true;
            labelProcessExplorerVersion.Location = new Point(50, 10);
            labelProcessExplorerVersion.Name = "labelProcessExplorerVersion";
            labelProcessExplorerVersion.Size = new Size(151, 15);
            labelProcessExplorerVersion.TabIndex = 1;
            labelProcessExplorerVersion.Text = "Process Explorer v1.0.0.0.0";
            // 
            // buttonOkay
            // 
            buttonOkay.Location = new Point(304, 12);
            buttonOkay.Name = "buttonOkay";
            buttonOkay.Size = new Size(75, 23);
            buttonOkay.TabIndex = 2;
            buttonOkay.Text = "확인";
            buttonOkay.UseVisualStyleBackColor = true;
            buttonOkay.Click += ButtonOkay_Click;
            // 
            // AboutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 76);
            Controls.Add(buttonOkay);
            Controls.Add(labelProcessExplorerVersion);
            Controls.Add(pictureBoxProcessExplorer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Process Explorer";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProcessExplorer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProcessExplorer;
        private Label labelProcessExplorerVersion;
        private Button buttonOkay;
    }
}