using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_Terminal.Forms.Grand_Forms
{
    public partial class frm_Trip : Forms.Master_Form.frm_Master
    {
        public frm_Trip()
        {
            InitializeComponent();
            pic_Exit.Visible = false;
            pic_Min.Visible = false;
            pnl_Top.Visible = false;
            RoundControl(btn_Bank, 10);
            RoundControl(btn_Passenger, 10);
            RoundControl(btn_PayType, 10);
            RoundControl(btn_TicketBook, 10);
            RoundControl(btn_TicketManage, 10);
            RoundControl(btn_MakeTicket, 10);



        }

        private void frm_Trip_Load(object sender, EventArgs e)
        {

        }

        private void btn_Bank_Click(object sender, EventArgs e)
        {
            Forms.Sub_Form.frm_Bank f = new Sub_Form.frm_Bank();
            f.FormName = "بانک";
            f.ShowDialog();
        }

        private void btn_PayType_Click(object sender, EventArgs e)
        {
            Forms.Sub_Form.frm_PayType f = new Sub_Form.frm_PayType();
            f.FormName = "روش پرداخت";
            f.ShowDialog();
        }

        private void btn_Passenger_Click(object sender, EventArgs e)
        {
            Forms.Sub_Form.frm_Passenger f = new Sub_Form.frm_Passenger();
            f.FormName = "مسافر";
            f.ShowDialog();
        }

        private void btn_TicketManage_Click(object sender, EventArgs e)
        {
            Forms.Sub_Form.frm_ManageTicket f = new Sub_Form.frm_ManageTicket();
            f.FormName = "مدیریت بلیط ها";
            f.ShowDialog();
        }

        private void btn_MakeTicket_Click(object sender, EventArgs e)
        {
            Forms.Sub_Form.frm_MakeTicket f = new Sub_Form.frm_MakeTicket();
            f.FormName = "ساخت بلیط";
            f.ShowDialog();
        }

        private void btn_TicketBook_Click(object sender, EventArgs e)
        {
            Forms.Sub_Form.frm_BookTicket f = new Sub_Form.frm_BookTicket();
            f.FormName = "رزرو بلیط";
            f.ShowDialog();
        }
    }
}
