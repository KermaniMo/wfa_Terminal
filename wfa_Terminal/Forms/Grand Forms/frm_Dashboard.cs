using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;


namespace wfa_Terminal.Forms.Grand_Forms
{
    public partial class frm_Dashboard : Forms.Master_Form.frm_Master
    {
        public frm_Dashboard()
        {
            InitializeComponent();
            pic_Exit.Visible = false;
            pic_Min.Visible = false;
            pnl_Top.Visible = false;
            RoundControl(btn_Car, 10);
            RoundControl(btn_City, 10);
            RoundControl(btn_Degree, 10);
            RoundControl(btn_Driver, 10);
            RoundControl(btn_InputOutput, 10);
            RoundControl(btn_DriverManagment, 10);
            RoundControl(btn_CarType, 10);
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
             
        }

        private void frm_Dashboard_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btn_Car_Click(object sender, EventArgs e)
        {

        }

        private void btn_Degree_Click(object sender, EventArgs e)
        {
            Forms.Sub_Form.frm_Degree f = new Sub_Form.frm_Degree();
            f.FormName = "مدرک";

            f.ShowDialog();
        }

        private void btn_City_Click(object sender, EventArgs e)
        {
            Forms.Sub_Form.frm_City f = new Sub_Form.frm_City();
            f.FormName = "شهر و استان";
            f.ShowDialog();
        }

        private void btn_Car_Click_1(object sender, EventArgs e)
        {
            Sub_Form.frm_Car f = new Sub_Form.frm_Car();
            f.FormName = "ثبت ماشین";
            f.ShowDialog();
        }

        private void btn_CarType_Click(object sender, EventArgs e)
        {
            Sub_Form.frm_CarType f = new Sub_Form.frm_CarType();
            f.FormName = "نوع ماشین";
            f.ShowDialog();
        }

        private void btn_Driver_Click(object sender, EventArgs e)
        {
            Sub_Form.frm_Driver f = new Sub_Form.frm_Driver();
            f.FormName = "راننده";
            f.ShowDialog();
        }

        private void btn_DriverManagment_Click(object sender, EventArgs e)
        {
            Sub_Form.frm_ManageDriver f = new Sub_Form.frm_ManageDriver();
            f.FormName = "مدیریت رانندگان";
            f.ShowDialog();
        }

        private void btn_InputOutput_Click(object sender, EventArgs e)
        {
            Sub_Form.frm_InputOutput f = new Sub_Form.frm_InputOutput();
            f.FormName = "ورودی و خروجی";
            f.ShowDialog();
        }
    }
}
