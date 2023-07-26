using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Guna.UI2.WinForms;
using ViewLayout.Views;

namespace Forms.MenuForms.NewPackage
{
    public partial class NewPackageFinalLabelForm : Form, INewPackageFinalLabelView
    {
        public NewPackageFinalLabelForm()
        {
            InitializeComponent();

            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
        }

        public void SetBarcode(string path)
        {
            imgBarcode.ImageLocation = path;
        }

        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            Print(LabelPanel);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
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

        /*protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(MemoryImage, 0, 0);
            base.OnPaint(e);
        }*/

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
