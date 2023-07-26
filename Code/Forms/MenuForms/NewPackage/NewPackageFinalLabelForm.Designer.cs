namespace Forms.MenuForms.NewPackage
{
    partial class NewPackageFinalLabelForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnPrintLabel = new Guna.UI2.WinForms.Guna2Button();
            btnNewPackage = new Guna.UI2.WinForms.Guna2Button();
            LabelPanel = new Guna.UI2.WinForms.Guna2Panel();
            imgBarcode = new PictureBox();
            panel1 = new Panel();
            ReceiverCountry = new Label();
            label14 = new Label();
            ReceiverStreet = new Label();
            SenderCountry = new Label();
            ReceiverLocation = new Label();
            panel6 = new Panel();
            ReceiverName = new Label();
            label5 = new Label();
            SenderStreet = new Label();
            SenderLocation = new Label();
            SenderName = new Label();
            LabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBarcode).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrintLabel
            // 
            btnPrintLabel.Animated = true;
            btnPrintLabel.BorderColor = Color.Transparent;
            btnPrintLabel.BorderRadius = 3;
            btnPrintLabel.BorderThickness = 2;
            btnPrintLabel.CheckedState.BorderColor = Color.FromArgb(212, 5, 17);
            btnPrintLabel.CheckedState.FillColor = SystemColors.Control;
            btnPrintLabel.CheckedState.ForeColor = Color.FromArgb(212, 5, 17);
            btnPrintLabel.CustomizableEdges = customizableEdges1;
            btnPrintLabel.DisabledState.BorderColor = Color.DarkGray;
            btnPrintLabel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrintLabel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrintLabel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrintLabel.FillColor = Color.FromArgb(212, 5, 17);
            btnPrintLabel.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintLabel.ForeColor = Color.White;
            btnPrintLabel.HoverState.BorderColor = Color.FromArgb(212, 5, 17);
            btnPrintLabel.HoverState.FillColor = Color.Transparent;
            btnPrintLabel.HoverState.ForeColor = Color.FromArgb(212, 5, 17);
            btnPrintLabel.Location = new Point(491, 167);
            btnPrintLabel.Name = "btnPrintLabel";
            btnPrintLabel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPrintLabel.Size = new Size(345, 39);
            btnPrintLabel.TabIndex = 12;
            btnPrintLabel.Text = "Print label";
            btnPrintLabel.Click += btnPrintLabel_Click;
            // 
            // btnNewPackage
            // 
            btnNewPackage.Animated = true;
            btnNewPackage.BorderColor = Color.Transparent;
            btnNewPackage.BorderRadius = 3;
            btnNewPackage.BorderThickness = 2;
            btnNewPackage.CheckedState.BorderColor = Color.FromArgb(212, 5, 17);
            btnNewPackage.CheckedState.FillColor = SystemColors.Control;
            btnNewPackage.CheckedState.ForeColor = Color.FromArgb(212, 5, 17);
            btnNewPackage.CustomizableEdges = customizableEdges3;
            btnNewPackage.DisabledState.BorderColor = Color.DarkGray;
            btnNewPackage.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNewPackage.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNewPackage.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNewPackage.FillColor = Color.FromArgb(212, 5, 17);
            btnNewPackage.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewPackage.ForeColor = Color.White;
            btnNewPackage.HoverState.BorderColor = Color.FromArgb(212, 5, 17);
            btnNewPackage.HoverState.FillColor = Color.Transparent;
            btnNewPackage.HoverState.ForeColor = Color.FromArgb(212, 5, 17);
            btnNewPackage.Location = new Point(491, 246);
            btnNewPackage.Name = "btnNewPackage";
            btnNewPackage.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNewPackage.Size = new Size(345, 39);
            btnNewPackage.TabIndex = 13;
            btnNewPackage.Text = "New package";
            // 
            // LabelPanel
            // 
            LabelPanel.BackColor = Color.Transparent;
            LabelPanel.BorderColor = Color.White;
            LabelPanel.BorderRadius = 9;
            LabelPanel.BorderThickness = 1;
            LabelPanel.Controls.Add(imgBarcode);
            LabelPanel.Controls.Add(panel1);
            LabelPanel.CustomizableEdges = customizableEdges5;
            LabelPanel.FillColor = SystemColors.Control;
            LabelPanel.Location = new Point(23, 26);
            LabelPanel.Name = "LabelPanel";
            LabelPanel.ShadowDecoration.BorderRadius = 8;
            LabelPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            LabelPanel.ShadowDecoration.Depth = 15;
            LabelPanel.ShadowDecoration.Enabled = true;
            LabelPanel.Size = new Size(406, 504);
            LabelPanel.TabIndex = 14;
            LabelPanel.UseTransparentBackground = true;
            // 
            // imgBarcode
            // 
            imgBarcode.Location = new Point(53, 382);
            imgBarcode.Name = "imgBarcode";
            imgBarcode.Size = new Size(300, 100);
            imgBarcode.TabIndex = 15;
            imgBarcode.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ReceiverCountry);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(ReceiverStreet);
            panel1.Controls.Add(SenderCountry);
            panel1.Controls.Add(ReceiverLocation);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(ReceiverName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(SenderStreet);
            panel1.Controls.Add(SenderLocation);
            panel1.Controls.Add(SenderName);
            panel1.Location = new Point(17, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 110);
            panel1.TabIndex = 15;
            // 
            // ReceiverCountry
            // 
            ReceiverCountry.AutoSize = true;
            ReceiverCountry.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiverCountry.ForeColor = SystemColors.ControlText;
            ReceiverCountry.Location = new Point(203, 85);
            ReceiverCountry.Name = "ReceiverCountry";
            ReceiverCountry.Size = new Size(68, 20);
            ReceiverCountry.TabIndex = 19;
            ReceiverCountry.Text = "Germany";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(50, 50, 50);
            label14.Location = new Point(189, 3);
            label14.Name = "label14";
            label14.Size = new Size(40, 25);
            label14.TabIndex = 25;
            label14.Text = "To:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReceiverStreet
            // 
            ReceiverStreet.AutoSize = true;
            ReceiverStreet.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiverStreet.ForeColor = SystemColors.ControlText;
            ReceiverStreet.Location = new Point(203, 45);
            ReceiverStreet.Name = "ReceiverStreet";
            ReceiverStreet.Size = new Size(97, 20);
            ReceiverStreet.TabIndex = 16;
            ReceiverStreet.Text = "Priver Drive 4";
            // 
            // SenderCountry
            // 
            SenderCountry.AutoSize = true;
            SenderCountry.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SenderCountry.ForeColor = SystemColors.ControlText;
            SenderCountry.Location = new Point(12, 85);
            SenderCountry.Name = "SenderCountry";
            SenderCountry.Size = new Size(68, 20);
            SenderCountry.TabIndex = 14;
            SenderCountry.Text = "Germany";
            // 
            // ReceiverLocation
            // 
            ReceiverLocation.AutoSize = true;
            ReceiverLocation.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiverLocation.ForeColor = SystemColors.ControlText;
            ReceiverLocation.Location = new Point(203, 65);
            ReceiverLocation.Name = "ReceiverLocation";
            ReceiverLocation.Size = new Size(149, 20);
            ReceiverLocation.TabIndex = 18;
            ReceiverLocation.Text = "RG12 Little Whinging";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlText;
            panel6.Location = new Point(186, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 110);
            panel6.TabIndex = 24;
            // 
            // ReceiverName
            // 
            ReceiverName.AutoSize = true;
            ReceiverName.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReceiverName.ForeColor = SystemColors.ControlText;
            ReceiverName.Location = new Point(203, 25);
            ReceiverName.Name = "ReceiverName";
            ReceiverName.Size = new Size(89, 20);
            ReceiverName.TabIndex = 17;
            ReceiverName.Text = "Harry Potter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(50, 50, 50);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 10;
            label5.Text = "From:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SenderStreet
            // 
            SenderStreet.AutoSize = true;
            SenderStreet.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SenderStreet.ForeColor = SystemColors.ControlText;
            SenderStreet.Location = new Point(12, 45);
            SenderStreet.Name = "SenderStreet";
            SenderStreet.Size = new Size(142, 20);
            SenderStreet.TabIndex = 11;
            SenderStreet.Text = "Farmington Ave 351";
            // 
            // SenderLocation
            // 
            SenderLocation.AutoSize = true;
            SenderLocation.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SenderLocation.ForeColor = SystemColors.ControlText;
            SenderLocation.Location = new Point(12, 65);
            SenderLocation.Name = "SenderLocation";
            SenderLocation.Size = new Size(110, 20);
            SenderLocation.TabIndex = 13;
            SenderLocation.Text = "52525 Hartford";
            // 
            // SenderName
            // 
            SenderName.AutoSize = true;
            SenderName.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SenderName.ForeColor = SystemColors.ControlText;
            SenderName.Location = new Point(12, 25);
            SenderName.Name = "SenderName";
            SenderName.Size = new Size(85, 20);
            SenderName.TabIndex = 12;
            SenderName.Text = "Mark Twain";
            // 
            // NewPackageFinalLabelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(984, 561);
            Controls.Add(LabelPanel);
            Controls.Add(btnNewPackage);
            Controls.Add(btnPrintLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewPackageFinalLabelForm";
            Text = "NewPackageFinalLabelForm";
            LabelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgBarcode).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPrintLabel;
        private Guna.UI2.WinForms.Guna2Button btnNewPackage;
        private Guna.UI2.WinForms.Guna2Panel LabelPanel;
        private Panel panel1;
        private Label label5;
        private Label SenderCountry;
        private Label SenderLocation;
        private Label SenderName;
        private Label SenderStreet;
        private Panel panel6;
        private Label label14;
        private Label ReceiverCountry;
        private Label ReceiverStreet;
        private Label ReceiverLocation;
        private Label ReceiverName;
        private PictureBox imgBarcode;
    }
}