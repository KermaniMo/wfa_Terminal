using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_TicketShow : Form
    {
        public frm_TicketShow()
        {
            InitializeComponent();
        }
        public void FillControls(DataTable dtable, string remaining )
        {
            lbl_City1.Text = dtable.Rows[0].Field<string>("City1");
            lbl_City2.Text = dtable.Rows[0].Field<string>("City2");
            lbl_DateOfMove.Text = dtable.Rows[0].Field<string>("TripDateOfMove");
            lbl_DateOfArrive.Text = dtable.Rows[0].Field<string>("TripDateOfArrive");
            lbl_Car.Text = dtable.Rows[0].Field<string>("Car");
            lbl_Status.Text = dtable.Rows[0].Field<string>("TripStatus");
            lbl_Price.Text = dtable.Rows[0].Field<decimal>("TripPrice").ToString();
            lbl_Remaining.Text =remaining ;
            lbl_Price.Tag= dtable.Rows[0].Field<int>("TripID").ToString();
            if (lbl_Remaining.Text=="0")
            {
                btn_Book.Enabled = false;
            }
        }
        private void frm_TicketShow_Load(object sender, EventArgs e)
        {

        }

        private void btn_Book_Click(object sender, EventArgs e)
        {

        }

        private void btn_Book_Click_1(object sender, EventArgs e)
        {
            frm_ChoiceTrip f = new frm_ChoiceTrip();
            BusinessChoiceTrip obj_BusinessChoiceTrip = new BusinessChoiceTrip();
            BusinessTrip obj_BusinessTrip = new BusinessTrip();
            DataTable dtable = new DataTable();
            f.txt_SeatNumber.Text = obj_BusinessChoiceTrip.FreeNumber(int.Parse(lbl_Price.Tag.ToString()), 0, ref dtable).ToString();
            //f.txt_Price.Text = obj_BusinessTrip.SearchByField("TripID", lbl_Price.Tag.ToString()).Rows[0].Field<decimal>("TripPrice").ToString();
            f.txt_Price.Text = lbl_Price.Text;
            f.txt_Price.Tag = lbl_Price.Tag.ToString();
            f.FormName = "رزرو بلیط";
            f.ShowDialog();
            if (f.isregister)
            {
                TicketBookEvent obj_TicketBookEvent = new TicketBookEvent();
                obj_TicketBookEvent.RunEvent();
            }
        }
    }
}
