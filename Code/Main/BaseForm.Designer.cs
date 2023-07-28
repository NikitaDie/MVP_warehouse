namespace Main
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            panel_MainLoader = new Panel();
            SuspendLayout();
            // 
            // panel_MainLoader
            // 
            panel_MainLoader.Dock = DockStyle.Fill;
            panel_MainLoader.Location = new Point(0, 0);
            panel_MainLoader.Name = "panel_MainLoader";
            panel_MainLoader.Size = new Size(1200, 700);
            panel_MainLoader.TabIndex = 0;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 30, 49);
            ClientSize = new Size(1200, 700);
            Controls.Add(panel_MainLoader);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NovaPoshta";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_MainLoader;
    }
}