namespace Forms.MenuForms
{
    partial class SearchPackageForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBoxSearchPackage = new Guna.UI2.WinForms.Guna2TextBox();
            listBox1 = new ListBox();
            labelPanel = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // textBoxSearchPackage
            // 
            textBoxSearchPackage.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxSearchPackage.CustomizableEdges = customizableEdges1;
            textBoxSearchPackage.DefaultText = "";
            textBoxSearchPackage.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxSearchPackage.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxSearchPackage.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearchPackage.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearchPackage.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearchPackage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchPackage.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearchPackage.Location = new Point(547, 67);
            textBoxSearchPackage.Name = "textBoxSearchPackage";
            textBoxSearchPackage.PasswordChar = '\0';
            textBoxSearchPackage.PlaceholderText = "";
            textBoxSearchPackage.SelectedText = "";
            textBoxSearchPackage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textBoxSearchPackage.Size = new Size(273, 36);
            textBoxSearchPackage.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(547, 119);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 229);
            listBox1.TabIndex = 1;
            // 
            // labelPanel
            // 
            labelPanel.CustomizableEdges = customizableEdges3;
            labelPanel.Location = new Point(59, 67);
            labelPanel.Name = "labelPanel";
            labelPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            labelPanel.Size = new Size(406, 500);
            labelPanel.TabIndex = 2;
            // 
            // SearchPackageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(984, 661);
            Controls.Add(labelPanel);
            Controls.Add(listBox1);
            Controls.Add(textBoxSearchPackage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchPackageForm";
            Text = "SearchPackageForm";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBoxSearchPackage;
        private ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Panel labelPanel;
    }
}