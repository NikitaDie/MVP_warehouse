using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Controls
{
    public class AdvancedTextBox : Guna2TextBox
    {
        private Label defaultText; 
        public AdvancedTextBox()
        {
            //MouseHover += (sender, args) => ExposeShadow();
            //MouseLeave += (sender, args) => HideShadow();
            GotFocus += (sender, args) => OnFocus();
            //defaultText = new Label();
            
            defaultText = new Label();
            defaultText.Font = this.Font;
            defaultText.Text = "Name";
            defaultText.Dock = DockStyle.Fill;
            
        }

        public override string DefaultText { get => defaultText.Text; set => value = defaultText.Text; }
        private void AdvancedTextBox_GotFocus(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnFocus()
        {
            this.defaultText.Font = new Font(this.defaultText.Font.Name, 4);
        }

        private void ExposeShadow()
        {
            ShadowDecoration.Depth = 0;
            ShadowDecoration.Enabled = true;
            FluentTransitions.Transition.With(ShadowDecoration, nameof(ShadowDecoration.Depth), 30).Spring(TimeSpan.FromMilliseconds(10));
        }

        private void HideShadow()
        {
            FluentTransitions.Transition.With(ShadowDecoration, nameof(ShadowDecoration.Depth), 0).HookOnCompletion(() => ShadowDecoration.Enabled = false).Accelerate(TimeSpan.FromMilliseconds(10));
        }
    }
}
