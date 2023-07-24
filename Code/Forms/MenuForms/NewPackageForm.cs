using Forms.Controls;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Microsoft.AspNetCore.Mvc.Filters;
using ModelLayout.Models.Package;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ViewLayout.Views;
using Label = System.Windows.Forms.Label;

namespace Forms.MenuForms
{
    public partial class NewPackageForm : Form, INewPackageView
    {
        string packageFormMask = "mask";
        string packageFormBack = "white";
        string packageFormParent = "base";

        OptionPanel? lastBaseOptionPanel;
        Guna2Panel? lastBackOptionPanel;
        Panel main;
        public Dictionary<Panel, IPackageModel> PanelsToPackages { get; set; }

        public event Action NextPage;
        //OptionPanel savedPanel;
        public NewPackageForm()
        {
            InitializeComponent();
            main = MainPanel;

            PanelsToPackages = new Dictionary<Panel, IPackageModel>();

            btnNextPage.Click += (sender, args) => Invoke(NextPage);


            foreach (Control parentControl in main.Controls)
            {
                if (parentControl is not Panel)
                    continue;

                string name2 = parentControl.Name;

                Guna2Button? optionPanelButton = null;
                Panel? optionPanelBack = null;
                Panel? optionPanelMask = null;

                try
                {
                    foreach (Panel control in parentControl.Controls)
                    {
                        string name = control.Name;
                        if (control.Name.ToLower().Contains(packageFormMask))
                        {
                            optionPanelMask = control;

                            foreach (Control maskControl in control.Controls)
                            {
                                if (maskControl is Guna2Button)
                                {
                                    optionPanelButton = maskControl as Guna2Button;
                                    break;
                                }
                            }
                        }
                        else if (control.Name.ToLower().Contains(packageFormBack))
                            optionPanelBack = control;
                    }

                    if (optionPanelButton != null && optionPanelBack != null)
                        optionPanelButton.Click += (sender, args) => optionPanel_Click(parentControl as OptionPanel, optionPanelBack as Guna2Panel);

                    if (optionPanelMask != null && optionPanelBack != null)
                        optionPanelMask.Click += (sender, args) => optionPanel_Click(parentControl as OptionPanel, optionPanelBack as Guna2Panel);
                    //else call Admin, write logs
                }
                catch { }

            }
        }
        private new void Invoke(Action action)
        {
            try
            {
                if (action != null) action();
            }
            catch { throw; };
        }

        private void FillPanelsToPackages(List<IPackageModel> packages, Control.ControlCollection panels)
        {
            foreach (var control in panels)
            {
                if (control is not Panel)
                    continue;

                int i;
                Package package;
                try
                {
                    Panel panel = control as Panel;

                    i = Int32.Parse(Regex.Match(panel.Name, @"\d+$").Value) - 1; // - 1 cause Names contains numbers from 1

                    PanelsToPackages.Add(panel, packages[i]);
                }
                catch { continue; }

            }
        }

        private void NameLabel(Label label, Panel superParent)
        {
            try
            {
                if (label.Name.ToLower().Contains("price"))
                    label.Text = PanelsToPackages[superParent].Price.ToString() + " €";
                else if (label.Name.ToLower().Contains("name"))
                    label.Text = PanelsToPackages[superParent].Name.ToString();
                else if (label.Name.ToLower().Contains("sizedescription"))
                    label.Text = $"max. {PanelsToPackages[superParent].SizeDescription.Width} x {PanelsToPackages[superParent].SizeDescription.Length} x {PanelsToPackages[superParent].SizeDescription.Height} cm";
            }
            catch { return; }
        }

        private void Find<T>(Panel panel, ref List<T> list)
            where T : Control
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Panel)
                    Find<T>(control as Panel, ref list);
                else if (control is T)
                    list.Add(control as T);
            }
        }
        public void LoadStartPackages(List<IPackageModel> packages)
        {
            try
            {
                FillPanelsToPackages(packages, main.Controls);
            }
            catch { return; }

            try
            {
                foreach (Control control in main.Controls)
                {
                    if (control is not Panel)
                        continue;

                    List<Label> list = new List<Label>();
                    Find<Label>(control as Panel, ref list);

                    foreach (Label label in list)
                        NameLabel(label, control as Panel);

                }
            }
            catch { }
        }


        public IPackageModel GetSelectedPackage()
        {
            try
            {
                return PanelsToPackages[lastBaseOptionPanel];
            }
            catch { throw; }; // where is throiwing?

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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // --optionPanel_Hover
    }
}

