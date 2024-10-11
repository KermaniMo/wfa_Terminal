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
    public partial class frm_BookTicket : Forms.Master_Form.frm_SubMaster
    {
        public frm_BookTicket()
        {
            InitializeComponent();
        }
        private PictureBox activepic;
        private delegate void eventpic(object sender, EventArgs e);
        private eventpic activeevent;
        private async void ShowForminPanel(Form frm, Panel pnl_Form)
        {



            frm.TopLevel = false;

            // تنظیم فرم به حالت نمایش درون پنل
            frm.FormBorderStyle = FormBorderStyle.None;

            // تنظیم Dock فرم به Fill تا کاملاً پنل را پر کند
            frm.Dock = DockStyle.Fill;

            // اضافه کردن فرم فرزند به پنل
            pnl_Form.Controls.Add(frm);

            // نمایش فرم فرزند
            frm.Show();
        }
        //----------------------------------------
        private void MakePanel(Panel beforepnl, int counter, DataTable dtable_Trip, string remaining)
        {
            if (counter > 0)
            {
                if (beforepnl == null)
                {
                    Sub_Form.frm_TicketShow f = new frm_TicketShow();

                    Panel pnl_Current = new Panel();
                    pnl_Current.Width = f.Width;
                    pnl_Current.Height = f.Height;
                    pnl_Current.Location = new Point(panel1.Width / 2 - pnl_Current.Width / 2, panel1.Top + 10);
                    panel1.Controls.Add(pnl_Current);
                    f.FillControls(dtable_Trip, remaining);
                    ShowForminPanel(f, pnl_Current);
                    dtable_Trip.Rows[0].Delete();
                    dtable_Trip.AcceptChanges();
                    RoundControl(pnl_Current, 15);
                    MakePanel(pnl_Current, --counter, dtable_Trip, Remaining(dtable_Trip));
                }
                else
                {
                    Sub_Form.frm_TicketShow f = new frm_TicketShow();

                    Panel pnl_Current = new Panel();
                    pnl_Current.Width = f.Width;
                    pnl_Current.Height = f.Height;
                    pnl_Current.Location = new Point(panel1.Width / 2 - pnl_Current.Width / 2, beforepnl.Top + beforepnl.Height + 10);
                    panel1.Controls.Add(pnl_Current);

                    f.FillControls(dtable_Trip, remaining);
                    ShowForminPanel(f, pnl_Current);
                    dtable_Trip.Rows[0].Delete();
                    dtable_Trip.AcceptChanges();
                    RoundControl(pnl_Current, 15);

                    MakePanel(pnl_Current, --counter, dtable_Trip, Remaining(dtable_Trip));
                }
            }
        }
        //--------------------------------------
        private string Remaining(DataTable dtable_Trip)
        {
            if (dtable_Trip.Rows.Count > 0)
            {
                BusinessChoiceTrip obj_BusinessChoiceTrip = new BusinessChoiceTrip();
                DataTable dtable_ChoiceTrip = obj_BusinessChoiceTrip.SearchByField("ID_FK_tbl_Trip", dtable_Trip.Rows[0].Field<int>("TripID").ToString());
                try {
                    return (dtable_Trip.Rows[0].Field<Int16>("TripCapacity") - dtable_ChoiceTrip.AsEnumerable().Where(x => x.Field<string>("ChoiceTripTicketState").Trim() == "فعال").CopyToDataTable().Rows.Count).ToString();
                }
                catch
                {
                    return "0";
                }
                }
            else
                return "";
        }
        //---------------------------------------
        private void RunEvent()
        {
            EventArgs e2 = new EventArgs();
            activeevent(activepic, e2);
        }
        //---------------------------------------
        private void frm_BookTicket_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 20;
            TicketBookEvent.MyActivePic += new TicketBookEvent.MyActive(RunEvent);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_SearchNationalCode_Click(object sender, EventArgs e)
        {
            if (txt_City1.Text.Trim() != string.Empty)
            {
                panel1.Controls.Clear();
                BusinessTrip obj_BusinessTrip = new BusinessTrip();
                DataTable dtable_Trip = new DataTable();
                try
                {
                    dtable_Trip = obj_BusinessTrip.SearchByField("City.CityName", txt_City1.Text.Trim()).AsEnumerable().Where(x => x.Field<string>("TripStatus") == "فعال").CopyToDataTable();
                }
                catch { }
                if (dtable_Trip.Rows.Count == 0)
                {
                    panel1.Controls.Clear();
                }
                else
                    MakePanel(null, dtable_Trip.Rows.Count, dtable_Trip, Remaining(dtable_Trip));
                activepic = pic_SearchCity1;
                activeevent = pic_SearchNationalCode_Click;
            }
        }

        private void pic_City2_Click(object sender, EventArgs e)
        {
            if (txt_City2.Text.Trim() != string.Empty)
            {
                panel1.Controls.Clear();

                BusinessTrip obj_BusinessTrip = new BusinessTrip();
                DataTable dtable_Trip = new DataTable();
                try
                {
                    dtable_Trip = obj_BusinessTrip.SearchByField("#City2.CityName", txt_City2.Text.Trim()).AsEnumerable().Where(x => x.Field<string>("TripStatus") == "فعال").CopyToDataTable();
                }
                catch { }
                if (dtable_Trip.Rows.Count == 0)
                {
                    panel1.Controls.Clear();
                }
                else
                    MakePanel(null, dtable_Trip.Rows.Count, dtable_Trip, Remaining(dtable_Trip));
                activepic = pic_SearchCity2;
                activeevent = pic_City2_Click;
            }
        }

        private void pic_Move_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            BusinessTrip obj_BusinessTrip = new BusinessTrip();
            DataTable dtable_Trip = new DataTable();
            try
            {
                dtable_Trip = obj_BusinessTrip.SearchByField("TripDateOfMove", dp_Move.txtDate.Text.Trim()).AsEnumerable().Where(x => x.Field<string>("TripStatus") == "فعال").CopyToDataTable();
            }
            catch { }
            if (dtable_Trip.Rows.Count == 0)
            {
                panel1.Controls.Clear();
            }
            else
                MakePanel(null, dtable_Trip.Rows.Count, dtable_Trip, Remaining(dtable_Trip));
            activepic = pic_SearchMove;
            activeevent = pic_Move_Click;
        }

        private void txt_City1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_SearchNationalCode_Click(pic_SearchCity1, e2);
            }
        }

        private void txt_City2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_City2_Click(pic_SearchCity2, e2);
            }
        }

        private void dp_Move_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_Move_Click(pic_SearchMove, e2);
            }
        }
    }
}
