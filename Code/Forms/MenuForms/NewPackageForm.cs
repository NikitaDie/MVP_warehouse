using Forms.Controls;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Microsoft.AspNetCore.Mvc.Filters;
using ModelLayout.Models.Package;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ViewLayout.Views;

namespace Forms.MenuForms
{
    public partial class NewPackageForm : Form, INewPackageView
    {
        OptionPanel? lastBaseOptionPanel;
        Guna2Panel? lastBackOptionPanel;
        List<Package> packageList;

        //OptionPanel savedPanel;
        public NewPackageForm()
        {
            InitializeComponent();

            packageList = new List<Package>();

        }
        private new void Invoke(Action action)
        {
            if (action != null) action();
        }

        public void NameLabel(List<IPackageModel> packages, Label label)
        {
            int i;
            try
            {
                i = Int32.Parse(Regex.Match(label.Name, @"\d+$").Value) - 1; // - 1 cause Names contains numbers from 1
            } catch { return; }

            try
            {
                if (label.Name.ToLower().Contains("price"))
                    label.Text = packages[i].Price.ToString() + " €";
                else if (label.Name.ToLower().Contains("name"))
                    label.Text = packages[i].Name.ToString();
                else if (label.Name.ToLower().Contains("sizedescription"))
                    label.Text = $"max. {packages[i].SizeDescription.Width} x {packages[i].SizeDescription.Length} x {packages[i].SizeDescription.Height} cm";
            }
            catch { return; }
        }

        public void FindLabel(List<IPackageModel> packages, Panel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is Panel)
                    FindLabel(packages, control as Panel);
                else if (control is Label)
                    NameLabel(packages, control as Label);
            }
        }
        public void LoadStartPackages(List<IPackageModel> packages)
        {
            try
            {
                FindLabel(packages, MainPanel as Panel);
            }
            catch { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BackOptionPanel2_MouseEnter(object sender, EventArgs e)
        {
            /*if (enter)
            {
                BackOptionPanel2.ShadowDecoration.Enabled = false;
                enter = false;
            }
            else
            {
                BackOptionPanel2.ShadowDecoration.Enabled = true;
                enter = true;
            }*/


        }


        bool enter;
        private void BackOptionPanel2_MouseLeave(object sender, EventArgs e)
        {
            //BackOptionPanel2.ShadowDecoration.Enabled = false;
        }

        private void NewPackageForm_MouseMove(object sender, MouseEventArgs e)
        {
            //BackOptionPanel2.ShadowDecoration.Enabled = true;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        bool ch;
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (ch)
            {
                ch = false;
                guna2CircleButton1.FillColor = Color.FromArgb(212, 5, 17);
                guna2CircleButton1.Image = Properties.Resources.plus;
                guna2CircleButton1.ImageSize = new Size(16, 16);
            }
            else
            {
                ch = true;
                guna2CircleButton1.FillColor = Color.FromArgb(72, 180, 81);
                guna2CircleButton1.Image = Properties.Resources.galochka;
                guna2CircleButton1.ImageSize = new Size(16, 12);
            }
        }

        private void OptionPanelMask1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void OptionPanelDescription1_Click(object sender, EventArgs e)
        {
        }

        //new
        private void optionPanel_Click(OptionPanel basePanel, Guna2Panel backPanel)
        {
            if (lastBaseOptionPanel != null && lastBackOptionPanel != null)
            {
                lastBaseOptionPanel.Clicked = false;
                lastBackOptionPanel.FillColor = Color.FromArgb(238, 238, 238);
                lastBaseOptionPanel.BorderThickness = 0;
                lastBaseOptionPanel.ShadowDecoration.Enabled = false;
                FluentTransitions.Transition.With(lastBaseOptionPanel, nameof(Top), lastBaseOptionPanel.Location.Y + 10).Accelerate(TimeSpan.FromMilliseconds(200));
            }

            if (lastBaseOptionPanel != basePanel)
            {
                lastBaseOptionPanel = basePanel;
                lastBackOptionPanel = backPanel;
                basePanel.Clicked = true;
                FluentTransitions.Transition.With(basePanel, nameof(Top), lastBaseOptionPanel.Location.Y - 10).HookOnCompletionInUiThread(basePanel, () => basePanel.ShadowDecoration.Enabled = true).Accelerate(TimeSpan.FromMilliseconds(100));
                backPanel.FillColor = Color.FromArgb(223, 239, 217);
                basePanel.BorderThickness = 10;

                //basePanel.SetBounds(basePanel.Location.X, basePanel.Location.Y - 10, basePanel.Width, basePanel.Height);
                //basePanel.ShadowDecoration.Shadow = new Padding(5, 5, 5, 0);
                //basePanel.ShadowDecoration.Enabled = true;
                /*basePanel.UseTransparentBackground = false;
                basePanel.BackColor = Color.AliceBlue;*/
            }
            else
            {
                lastBaseOptionPanel = null;
                lastBackOptionPanel = null;
            }
        }

        private void OptionPanelMask1_Click(object sender, EventArgs e)
        {
            optionPanel_Click(OptionPanelBase1, OptinPanelWhitePanel1);
        }

        private void OptionPanelMask1_MouseHover(object sender, EventArgs e)
        {
            OptionPanelBase1.ShadowDecoration.Depth = 0;
            OptionPanelBase1.ShadowDecoration.Enabled = true;
            FluentTransitions.Transition.With(OptionPanelBase1.ShadowDecoration, nameof(ShadowDecoration.Depth), 30).Accelerate(TimeSpan.FromMilliseconds(100));
        }

        private void OptionPanelMask1_MouseLeave(object sender, EventArgs e)
        {
            OptionPanelBase1.ShadowDecoration.Enabled = false;
            //FluentTransitions.Transition.With(OptionPanelBase1.ShadowDecoration, nameof(ShadowDecoration.Depth), 0).HookOnCompletionInUiThread(OptionPanelBase1, () => OptionPanelBase1.ShadowDecoration.Enabled = false).Accelerate(TimeSpan.FromMilliseconds(200));
        }

        private void OptionPanelButton1_MouseEnter(object sender, EventArgs e)
        {
            //FluentTransitions.Transition.With(OptionPanelBase1.ShadowDecoration, nameof(ShadowDecoration.Depth), 30).Accelerate(TimeSpan.FromMilliseconds(200));
            //OptionPanelBase1.ShadowDecoration.Enabled = true;
        }

        // --optionPanel_Hover
    }
}

