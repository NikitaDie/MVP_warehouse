using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.Controls;
using ViewLayout.Views;
using ModelLayout.Models.Package;

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

        public void LoadStartPackages(List<IPackageModel> packages)
        {
            try
            {
                for (int i = 0; i < packages.Count; ++i)
                {
                    OptionPanelSizeDescription)
                }
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

        private void OptionPanelButton2_Click(object sender, EventArgs e)
        {
            optionPanel_Click(OptionPanelBase3, OptinPanelWhitePanel3);
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

