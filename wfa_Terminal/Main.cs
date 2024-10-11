using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------
using System.Threading;
using System.Runtime.InteropServices;

namespace wfa_Terminal
{
    public partial class frm_Main : Forms.Master_Form.frm_Master
    {
        public frm_Main()
        {
            InitializeComponent();

        }
        private async Task CloseNav()
        {

            pnl_Active.Visible = false;



            while (pnl_Draw.Left <this.Width-30)
            {

                pnl_Draw.Left += 20;
                await Task.Delay(3);
            }

            pnl_Draw.Visible = false;
            //pnl_Draw.Width = 20;
            // pnl_Sensor.BackColor = Color.FromArgb(236, 240, 241);

        }
        //-----------------------------
        private async Task OpenNav()
        {
            //  pnl_Sensor.BackColor = Color.FromArgb(41, 128, 185);

            pnl_Draw.Visible = true;



            while (pnl_Draw.Left > this.Width-pnl_Sensor.Width-190)
            {
                pnl_Draw.Left -= 20;
                await Task.Delay(3);
            }
            pnl_Draw.Left = this.Width - pnl_Sensor.Width - 190;
            //pnl_Draw.Width = 190;
            Option(activebtn);
            pnl_Active.Visible = true;

        }
        //-----------------------------
        private async void ShowForminPanel(Form frm)
        {
            pnl_Active.Parent=this;
            pnl_Draw.Parent=this;
            pnl_Form.Controls.Clear();
            pnl_Active.Parent = pnl_Form;
            pnl_Draw.Parent = pnl_Form;


            frm.TopLevel = false;

            // تنظیم فرم به حالت نمایش درون پنل
            frm.FormBorderStyle = FormBorderStyle.None;

            // تنظیم Dock فرم به Fill تا کاملاً پنل را پر کند
            frm.Dock = DockStyle.Fill;

            // اضافه کردن فرم فرزند به پنل
            pnl_Form.Controls.Add(frm);
            frm.MouseMove += new MouseEventHandler(async delegate (object sender, MouseEventArgs e2)
            {

                if (e2.X < pnl_Form.Width - 190)
                {
                    await CloseNav();
                }
            });
            // نمایش فرم فرزند
            frm.Show();
        }
        private Button activebtn;
        //------------------------------------
    

        //------------------------------------
        private async void Form1_Load(object sender, EventArgs e)
        {
            Option(btn_Dashboard);
            activebtn = btn_Dashboard;
             
            RoundControl(pnl_Form,10);
            await CloseNav();
            ShowForminPanel(new Forms.Grand_Forms.frm_Dashboard());
            pnl_Draw.Left = this.Width;
            pnl_Draw.Height=pnl_Form.Height;
            pnl_Draw.Width = 190;
            

        }
        private void Option(Button btn)
        {
            pnl_Active.Height = btn.Height;
            pnl_Active.Top = btn.Top;
            pnl_Active.Left = btn.Left + this.Width - pnl_Draw.Width-pnl_Sensor.Width;
            pnl_Active.BackColor = Color.FromArgb(231, 76, 60);
        }
        private void materialExpansionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private async void btn_Dashboard_Click(object sender, EventArgs e)
        {
            pnl_Form.Controls.Clear();

            Option(btn_Dashboard);
            activebtn = btn_Dashboard;
            ShowForminPanel(new Forms.Grand_Forms.frm_Dashboard());
            await CloseNav();

        }

        private async void btn_Trip_Click(object sender, EventArgs e)
        {
            
            Option(btn_Trip);
            activebtn = btn_Trip;
            ShowForminPanel(new Forms.Grand_Forms.frm_Trip());
            await CloseNav();

        }

        private async void btn_Permisan_Click(object sender, EventArgs e)
        {
            pnl_Form.Controls.Clear();

            Option(btn_Permisan);
            activebtn = btn_Permisan;
            await CloseNav();

        }

        private void pnl_Draw_MouseHover(object sender, EventArgs e)
        {

        }

        private void pnl_Draw_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private async void pnl_Form_MouseMove(object sender, MouseEventArgs e)
        {


            if (e.X < pnl_Form.Width - 190)
            {
                await CloseNav();
            }
        }

        private void frm_Main_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private async void pnl_sensor_MouseMove(object sender, MouseEventArgs e)
        {
            if (!pnl_Draw.Visible)
            {
                await OpenNav();
            }
        }
    }
}
