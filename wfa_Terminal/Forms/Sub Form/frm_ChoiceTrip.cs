using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_ChoiceTrip : Forms.Master_Form.frm_SubMaster
    {
        public frm_ChoiceTrip()
        {
            InitializeComponent();
        }


        //-------------------------------------------

        //-------------------------------------------

        //-------------------------------------------
        //private Passenger FillData()
        //{
        //    Passenger obj_Passenger = new Passenger();
        //    obj_Passenger.PassengerID = activerecord;
        //    obj_Passenger.PassengerNationalCode = txt_NationalCode.Text;
        //    obj_Passenger.PassengerName = txt_Name.Text;
        //    obj_Passenger.PassengerLastName = txt_LastName.Text;
        //    obj_Passenger.PassengerBirthday = dp_Birthday.txtDate.Text;
        //    obj_Passenger.PassengerMobileNumber = txt_PhoneNumber.Text;
        //    obj_Passenger.PassengerSex = Convert.ToBoolean(cmb_Sex.SelectedIndex);
        //    obj_Passenger.PassengerEmail = txt_Gmail.Text;
        //    if (lbl_Register.Text == string.Empty)
        //    {
        //        PersianCalendar p = new PersianCalendar();

        //        obj_Passenger.PassengerRegister = p.GetDateString(DateTime.Now) + " " + DateTime.Now.TimeOfDay;
        //    }
        //    else
        //    {
        //        obj_Passenger.PassengerRegister = lbl_Register.Text;
        //    }
        //    return obj_Passenger;

        //}
        ////-------------------------------------------
        private bool TrueData()
        {
            ChoiceTrip obj_ChoiceTrip = new ChoiceTrip();
            BusinessChoiceTrip obj_BusinessChoiceTrip = new BusinessChoiceTrip();
            bool result = true;
            if (txt_Price.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Price.SetErrorState(true);
            }
            if (txt_SeatNumber.Text.Trim() == string.Empty)
            {
                result = false;
                txt_SeatNumber.SetErrorState(true);
            }
            DataTable dtable = new DataTable();
            obj_BusinessChoiceTrip.FreeNumber(int.Parse(txt_Price.Tag.ToString()), int.Parse(txt_SeatNumber.Text.Trim()), ref dtable);
            if (dtable.Rows.Count!=0)
            {
                result = false;
                txt_SeatNumber.SetErrorState(true);
            }

            if (cmb_Bank.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا بانک را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
            if (cmb_PayType.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا نوع پرداخت را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
            


            return result;
        }
        //-------------------------------------------
        private string GenerateTicketCode()
        {
            Guid guid = Guid.NewGuid();
            string uniqueCode = guid.ToString("N").Substring(0, 10);
            return uniqueCode;
        }

        //-------------------------------------------
        //private void ClearData()
        //{
        //    foreach (Control c in pnl_Control.Controls)
        //    {
        //        if (c is MaterialTextBox2)
        //        {
        //            c.Tag = string.Empty;
        //            c.Text = string.Empty;
        //        }

        //    }
        //    txt_NationalCode.Tag = string.Empty;
        //    txt_PhoneNumber.Text = string.Empty;
        //    cmb_Sex.SelectedIndex = -1;

        //}
        ////-------------------------------------------
        private void OneRun()
        {
            cmb_Bank.DataSource = new BusinessBank().GetList();
            cmb_Bank.ValueMember = "BankID";
            cmb_Bank.DisplayMember = "BankTitle";
            //------------------------------
            cmb_PayType.DataSource = new BusinessPayType().GetList();
            cmb_PayType.ValueMember = "PayTypeID";
            cmb_PayType.DisplayMember = "PayTypeTitle";
            //------------------------------
            
        }
        ////-------------------------------------------

        //private void FalseEnable()
        //{
        //    foreach (Control item in pnl_Control.Controls)
        //    {
        //        if (!(item is MaterialButton))
        //            item.Enabled = false;
        //    }
        //}
        ////-------------------------------------------
        //private void TrueEnable()
        //{
        //    foreach (Control item in pnl_Control.Controls)
        //    {
        //        item.Enabled = true;
        //    }

        //}
        //-------------------------------------------

        //------------------------------------------//
        //------------------------------------------//
        public bool isregister = false;
        private void frm_ChoiceTrip_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            OneRun();
            lbl_NationalCode.Tag = string.Empty;
        }

        private void txt_Passenger_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lbl_InsertPassenger_Click(object sender, EventArgs e)
        {
            frm_PassengerForTicket f = new frm_PassengerForTicket();
            f.FormName = "مسافر";
            f.ShowDialog();            
            if (f.forfill)
            {
                lbl_NationalCode.Text = f.txt_NationalCode.Text;
                lbl_NameLastName.Text = f.txt_Name.Text + " " + f.txt_LastName.Text;
                lbl_NationalCode.Tag = f.ID.ToString();
              
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (TrueData())
            {
                ChoiceTrip obj_ChoiceTrip = new ChoiceTrip();
                BusinessChoiceTrip obj_BusinessChoiceTrip = new BusinessChoiceTrip();

                while ((obj_BusinessChoiceTrip.CheckTicketCode((obj_ChoiceTrip.ChoiceTripTicketCode=GenerateTicketCode())))==0)
                {

                }
                obj_ChoiceTrip.ChoiceTripSeatNumber =Convert.ToInt16( txt_SeatNumber.Text.Trim());
                obj_ChoiceTrip.ChoiceTripPrice = Convert.ToDecimal(txt_Price.Text.Trim());
                obj_ChoiceTrip.ChoiceTripTicketState = false;
                obj_ChoiceTrip.ID_FK_tbl_Bank = int.Parse(cmb_Bank.SelectedValue.ToString());
                obj_ChoiceTrip.ID_FK_tbl_PayType = int.Parse(cmb_PayType.SelectedValue.ToString());
                obj_ChoiceTrip.ID_FK_tbl_Passenger = int.Parse(lbl_NationalCode.Tag.ToString());
                obj_ChoiceTrip.ID_FK_tbl_Trip = int.Parse(txt_Price.Tag.ToString());
                //-----------------------------------
                PersianCalendar p = new PersianCalendar();
                obj_ChoiceTrip.ChoiceTripDateOfBook = p.GetDateString(DateTime.Now) + " " + DateTime.Now.TimeOfDay;
                //-----------------------------------
                if (obj_BusinessChoiceTrip.Insert(obj_ChoiceTrip)!=0)
                {
                    MsgBox.Show("بلیط مورد نظر با موفقیت رزرو شد.\n" +
                        $"کد رهگیری این بلیط: {obj_ChoiceTrip.ChoiceTripTicketCode}" +
                        $"\n کد رهگیری کپی شد.");
                    Clipboard.SetText(obj_ChoiceTrip.ChoiceTripTicketCode);
                    isregister = true;
                    this.Close();
                }
            }
        }
    }
}
