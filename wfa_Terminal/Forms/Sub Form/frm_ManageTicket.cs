using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_ManageTicket : Forms.Master_Form.frm_SubMaster
    {
        public frm_ManageTicket()
        {
            InitializeComponent();
        }
        private void SetSetting()
        {
            dgv_ManageTicket.Columns["ChoiceTripID"].Visible = false;
            dgv_ManageTicket.Columns["ID_FK_tbl_Passenger"].Visible = false;
            dgv_ManageTicket.Columns["ID_FK_tbl_Trip"].Visible = false;
            dgv_ManageTicket.Columns["TripStatus"].Visible = false;
            dgv_ManageTicket.Columns["ChoiceTripDateOfBook"].Visible = false;
            dgv_ManageTicket.Columns["ID_FK_tbl_Bank"].Visible = false;
            dgv_ManageTicket.Columns["ID_FK_tbl_PayType"].Visible = false;
            dgv_ManageTicket.Columns["ChoiceTripTicketCode"].HeaderText = "کد رهگیری";
            dgv_ManageTicket.Columns["PassengerNationalCode"].HeaderText = "کدملی";
            dgv_ManageTicket.Columns["NameLastName"].HeaderText = "نام و نام خانوادگی";
            dgv_ManageTicket.Columns["TripDateOfMove"].HeaderText = "تاریخ حرکت";
            dgv_ManageTicket.Columns["TripDateOfArrive"].HeaderText = "تاریخ رسیدن";
            dgv_ManageTicket.Columns["BankTitle"].HeaderText = "بانک";
            dgv_ManageTicket.Columns["PayTypeTitle"].HeaderText = "روش پرداخت";
            dgv_ManageTicket.Columns["City1"].HeaderText = "مبدا";
            dgv_ManageTicket.Columns["City2"].HeaderText = "مقصد";
            dgv_ManageTicket.Columns["ChoiceTripSeatNumber"].HeaderText = "شماره صندلی";
            dgv_ManageTicket.Columns["ChoiceTripPrice"].HeaderText = "هزینه";
            dgv_ManageTicket.Columns["ChoiceTripTicketState"].HeaderText = "وضعیت";
            
        }
        //------------------------------------
        private void ClearData()
        {
            txt_TicketCode.Tag = string.Empty;
            lbl_NationalCode.Text = string.Empty;
            lbl_NameLastName.Text = string.Empty;
            txt_City1.Text = string.Empty;
            txt_City2.Text = string.Empty;
        }
        //------------------------------------
        private void frm_ManageTicket_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_ManageTicket, 15);
            txt_TicketCode.Tag = string.Empty;
        }

        private void txt_TicketCode_TextChanged(object sender, EventArgs e)
        {
            if (txt_TicketCode.Text.Length == 10)
            {
                DataTable dtable_ChoiceTrip = new BusinessChoiceTrip().SearchByField("ChoiceTripTicketCode", txt_TicketCode.Text.Trim());
                if (dtable_ChoiceTrip.Rows.Count > 0)
                {
                    txt_TicketCode.Tag = dtable_ChoiceTrip.Rows[0].Field<int>("ChoiceTripID").ToString();
                    lbl_NationalCode.Text = dtable_ChoiceTrip.Rows[0].Field<string>("PassengerNationalCode").ToString();
                    lbl_NameLastName.Text = dtable_ChoiceTrip.Rows[0].Field<string>("NameLastName").ToString();
                    txt_City1.Text = dtable_ChoiceTrip.Rows[0].Field<string>("City1").ToString();
                    txt_City2.Text = dtable_ChoiceTrip.Rows[0].Field<string>("City2").ToString();
                    string datetimeinou = dtable_ChoiceTrip.Rows[0].Field<string>("TripDateOfMove").ToString();
                    Regex r = new Regex("[0-9]{4}/[0-9]{1,2}/[0-9]{1,2}");
                    Match m = r.Match(datetimeinou);
                    dp_Move.txtDate.Text = m.Value;
                    datetimeinou = dtable_ChoiceTrip.Rows[0].Field<string>("TripDateOfArrive").ToString();
                    m = r.Match(datetimeinou);
                    dp_Arrive.txtDate.Text = m.Value;
                    if (dtable_ChoiceTrip.Rows[0].Field<string>("ChoiceTripTicketState").ToString()=="فعال")
                    {
                        btn_Extradition.Enabled = true;
                    }
                    else
                    {
                        btn_Extradition.Enabled = false;

                    }
                }
                else
                {
                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("بلیط مورد نظر پیدا نشد", "باشه", true);
                    SnackBarMessage.Show(this);
                }
            }
            else
            {
                ClearData();
                dgv_ManageTicket.DataSource = null;
            }
           
        }

        private void lbl_InsertPassenger_Click(object sender, EventArgs e)
        {
            frm_PassengerSearch f = new frm_PassengerSearch();
            f.FormName = "جستجوی مسافر";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Passenger.Rows.Count > 0)
                {
                    dgv_ManageTicket.DataSource = new BusinessChoiceTrip().SearchByField("PassengerID", f.dgv_Passenger.CurrentRow.Cells["PassengerID"].Value.ToString());
                    SetSetting();

                }
            }
        }

        private void dgv_ManageTicket_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_ManageTicket.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void pic_SearchCity1_Click(object sender, EventArgs e)
        {
            if (txt_City1.Text.Trim() != string.Empty)
            {
                dgv_ManageTicket.DataSource = new BusinessChoiceTrip().SearchByField("City.CityName", txt_City1.Text.Trim());
                SetSetting();
            }
        }

        private void pic_SearchCity2_Click(object sender, EventArgs e)
        {
            if (txt_City2.Text.Trim() != string.Empty)
            {
                dgv_ManageTicket.DataSource = new BusinessChoiceTrip().SearchByField("#City2.CityName", txt_City2.Text.Trim());
                SetSetting();
            }
        }

        private void pic_SearchMove_Click(object sender, EventArgs e)
        {
            dgv_ManageTicket.DataSource = new BusinessChoiceTrip().SearchByField("TripDateOfMove", dp_Move.txtDate.Text);
            SetSetting();
        }

        private void pic_SearchArrive_Click(object sender, EventArgs e)
        {
            dgv_ManageTicket.DataSource = new BusinessChoiceTrip().SearchByField("TripDateOfArrive", dp_Arrive.txtDate.Text);
            SetSetting();
        }

        private void txt_City1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_SearchCity1_Click(pic_SearchCity1, e2);
            }
        }

        private void txt_City2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_SearchCity2_Click(pic_SearchCity2, e2);
            }
        }

        private void dgv_ManageTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TicketCode.Text = dgv_ManageTicket.CurrentRow.Cells["ChoiceTripTicketCode"].Value.ToString();
            txt_TicketCode.Tag = dgv_ManageTicket.CurrentRow.Cells["ChoiceTripID"].Value.ToString();
            txt_City1.Text= dgv_ManageTicket.CurrentRow.Cells["City1"].Value.ToString();
            txt_City2.Text= dgv_ManageTicket.CurrentRow.Cells["City2"].Value.ToString();
            //--------------------------------------
            string datetimeinou = dgv_ManageTicket.CurrentRow.Cells["TripDateOfMove"].Value.ToString();
            Regex r = new Regex("[0-9]{4}/[0-9]{1,2}/[0-9]{1,2}");
            Match m = r.Match(datetimeinou);
            dp_Move.txtDate.Text = m.Value;
            datetimeinou = dgv_ManageTicket.CurrentRow.Cells["TripDateOfArrive"].Value.ToString();
            m = r.Match(datetimeinou);
            dp_Arrive.txtDate.Text = m.Value;
            //--------------------------------------
            if (dgv_ManageTicket.CurrentRow.Cells["ChoiceTripTicketState"].Value.ToString() == "فعال")
            {
                btn_Extradition.Enabled = true;
            }
            else
            {
                btn_Extradition.Enabled = false;

            }
        }

        private void btn_Extradition_Click(object sender, EventArgs e)
        {
            if (txt_TicketCode.Tag!=string.Empty)
            {
                DataTable dtable_ChoiceTrip = new DataTable();
                BusinessChoiceTrip obj_BusinessChoiceTrip = new BusinessChoiceTrip();
                dtable_ChoiceTrip = obj_BusinessChoiceTrip.SearchByField("ChoiceTripID", txt_TicketCode.Tag.ToString());
                ChoiceTrip obj_ChoiceTrip = new ChoiceTrip();
                obj_ChoiceTrip.ChoiceTripID = int.Parse(txt_TicketCode.Tag.ToString());
                obj_ChoiceTrip.ChoiceTripPrice = dtable_ChoiceTrip.Rows[0].Field<decimal>("ChoiceTripPrice");
                obj_ChoiceTrip.ChoiceTripSeatNumber = dtable_ChoiceTrip.Rows[0].Field<Int16>("ChoiceTripSeatNumber");
                obj_ChoiceTrip.ChoiceTripTicketCode = dtable_ChoiceTrip.Rows[0].Field<string>("ChoiceTripTicketCode");
                obj_ChoiceTrip.ChoiceTripTicketState = true;
                obj_ChoiceTrip.ID_FK_tbl_Bank = dtable_ChoiceTrip.Rows[0].Field<int>("ID_FK_tbl_Bank");
                obj_ChoiceTrip.ID_FK_tbl_Passenger = dtable_ChoiceTrip.Rows[0].Field<int>("ID_FK_tbl_Passenger");
                obj_ChoiceTrip.ID_FK_tbl_PayType = dtable_ChoiceTrip.Rows[0].Field<int>("ID_FK_tbl_PayType");
                obj_ChoiceTrip.ID_FK_tbl_Trip = dtable_ChoiceTrip.Rows[0].Field<int>("ID_FK_tbl_Trip");
                obj_ChoiceTrip.ChoiceTripDateOfBook = dtable_ChoiceTrip.Rows[0].Field<string>("ChoiceTripDateOfBook");
                if (MsgBox.Show("آیا از برگشت زدن این بلیط مطمئن هستید؟ \n بعد از این کار بلیط از این بخش قابل رزرو نیست.","",ButtonNumber.OKCancel)==DialogResult.OK)
                {
                    if (obj_BusinessChoiceTrip.Update(obj_ChoiceTrip) != 0)
                    {
                        txt_TicketCode.Text = string.Empty;
                        dgv_ManageTicket.DataSource = obj_BusinessChoiceTrip.SearchByField("ChoiceTripID", txt_TicketCode.Tag.ToString());
                        ClearData();
                        SetSetting();
                        MsgBox.Show("بلیط مورد نظر با موفقیت برگشت خورد.");
                    }
                }
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک بلیط را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }
    }
}
