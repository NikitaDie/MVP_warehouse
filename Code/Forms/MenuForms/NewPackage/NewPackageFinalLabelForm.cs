using System.Drawing.Printing;
using Guna.UI2.WinForms;
using ViewLayout.Views;
using ViewLayout;

namespace Forms.MenuForms.NewPackage
{
    public partial class NewPackageFinalLabelForm : Form, INewPackageFinalLabelView
    {
        public event Action? NewPackage;

        public NewPackageFinalLabelForm()
        {
            InitializeComponent();

            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            btnNewPackage.Click += (sender, args) => Invoke(NewPackage);
        }

        public int X
        {
            get => Location.X;
            set => Location = new Point(value, Location.Y);
        }

        private new void Invoke(Action? action)
        {
            try
            {
                action?.Invoke();
            }
            catch { throw; };
        }
        public new void Close()
        {
            FluentTransitions.Transition.With(this, nameof(X), Location.X - Width).
                HookOnCompletionInUiThread(this, () => base.Close()).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

        public new void Show()
        {
            Location = new Point(Location.X + Width, Location.Y);
            base.Show();
            FluentTransitions.Transition.With(this, nameof(X), 0).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

        public void LoadNewForm(IView newForm)
        {
            Form _currentForm = newForm as Form;
            _currentForm.TopLevel = false;
            _currentForm.TopMost = true;
            _currentForm.FormBorderStyle = FormBorderStyle.None;
            this.labelPanel.Controls.Add(_currentForm);

            //CurrentForm = newForm;
            newForm.Show();
        }

        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            Print(labelPanel);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.labelPanel.Width / 2), this.labelPanel.Location.Y);
        }

        //Declare following Object Variables
        PrintDocument printdoc1 = new PrintDocument();
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        Panel pannel = null;

        //declare event handler for printing in constructor

        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            Rectangle rect = new Rectangle(0, 0, pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (pannel.Width / 2), pannel.Location.Y);
        }

        public void Print(Guna2Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();
        }

    }
}
