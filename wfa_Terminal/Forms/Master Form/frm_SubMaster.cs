using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------------------------
using System.Drawing.Drawing2D;
using MaterialSkin;
using MaterialSkin.Controls;

namespace wfa_Terminal.Forms.Master_Form
{
    public partial class frm_SubMaster : Form
    {
        public frm_SubMaster()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
    Color.FromArgb(41, 128, 185),   // Primary color (آبی فلت)
    Color.FromArgb(31, 97, 141),    // Darker primary color (یک آبی تیره‌تر)
    Color.FromArgb(84, 153, 199),   // Lighter primary color (یک آبی روشن‌تر)
    Color.FromArgb(231, 76, 60),    // Accent color (نارنجی فلت)
    TextShade.WHITE);
        }
        public string FormName;
        protected void RoundControl(Control ctrl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(ctrl.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(ctrl.Width - radius, ctrl.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, ctrl.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            ctrl.Region = new Region(path);
        }
        private void frm_SubMaster_Load(object sender, EventArgs e)
        {
            pic_Exit.Location = new Point(this.Width - pic_Exit.Width - 3, pnl_Top.Height / 2 - pic_Exit.Height / 2);
            pic_Min.Location = new Point(pnl_Top.Width - pic_Exit.Width - pic_Min.Width - 10, pnl_Top.Height / 2 - pic_Min.Height / 2);
            pnl_Title.Width = this.Width - 20;
            pnl_Title.Height = 50;
            pnl_Title.Left = this.Width / 2 - pnl_Title.Width / 2;
            pnl_Title.Top = pnl_Top.Height+10;
            RoundControl(pnl_Title, 15);
            lbl_Title.Text = FormName;
            lbl_Title.Top = pnl_Title.Top - pnl_Title.Height / 2;
            lbl_Title.Left = pnl_Title.Width-lbl_Title.Width-10; 
            
            //lbl_Title.Top = pnl_Title.Top +pnl_Title.Height/2-lbl_Title.Height/2;
           // lbl_Title.Left = pnl_Title.Right-20;
        }

        private void pic_Exit_Click(object sender, EventArgs e)
        {
             
            this.Close();
        }

        private void pic_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }
    }
}
