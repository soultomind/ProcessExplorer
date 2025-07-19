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
            buttonGetProcessList = new Button();
            SuspendLayout();
            // 
            // buttonGetProcessList
            // 
            buttonGetProcessList.Location = new Point(28, 28);
            buttonGetProcessList.Name = "buttonGetProcessList";
            buttonGetProcessList.Size = new Size(75, 23);
            buttonGetProcessList.TabIndex = 0;
            buttonGetProcessList.Text = "목록보기";
            buttonGetProcessList.UseVisualStyleBackColor = true;
            buttonGetProcessList.Click += ButtonGetProcessList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGetProcessList);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGetProcessList;
    }
}
