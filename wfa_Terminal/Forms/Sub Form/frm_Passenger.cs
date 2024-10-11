using MaterialSkin.Controls;
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
using System.Globalization;

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_Passenger : Forms.Master_Form.frm_SubMaster
    {
        public frm_Passenger()
        {
            InitializeComponent();
        }
        private int activerecord = 0;
        private void GetList()
        {

            if (activerecord != 0)
            {
                Passenger obj_Passenger = new Passenger();
                obj_Passenger.PassengerID = activerecord;
                dgv_Passenger.DataSource = new BusinessPassenger().Search(obj_Passenger);
                SetSetting();
            }
        }
        //-------------------------------------------
        private void ActionMode(bool action)
        {
            btn_Cancel.Visible = action;
            btn_Submit.Visible = action;
            //---------------//
            btn_Insert.Visible = !action;
            btn_Edit.Visible = !action;
            btn_Delete.Visible = !action;
            //---------------//
            dgv_Passenger.Enabled = !action;
        }
        //-------------------------------------------
        private void SetSetting()
        {
            dgv_Passenger.Columns["PassengerID"].Visible = false;
            dgv_Passenger.Columns["PassengerRegister"].Visible = false;
            dgv_Passenger.Columns["PassengerNationalCode"].HeaderText = "کد ملی";
            dgv_Passenger.Columns["PassengerName"].HeaderText = "نام";
            dgv_Passenger.Columns["PassengerLastName"].HeaderText = "نام خانوادگی";
            dgv_Passenger.Columns["PassengerMobileNumber"].HeaderText = "موبایل";
            dgv_Passenger.Columns["PassengerSex"].HeaderText = "جنسیت";
            dgv_Passenger.Columns["PassengerBirthday"].HeaderText = "تاریخ تولد";
            dgv_Passenger.Columns["PassengerEmail"].HeaderText = "ایمیل";

        }
        //-------------------------------------------
        private Passenger FillData()
        {
            Passenger obj_Passenger = new Passenger();
            obj_Passenger.PassengerID = activerecord;
            obj_Passenger.PassengerNationalCode = txt_NationalCode.Text;
            obj_Passenger.PassengerName = txt_Name.Text;
            obj_Passenger.PassengerLastName = txt_LastName.Text;
            obj_Passenger.PassengerBirthday = dp_Birthday.txtDate.Text;
            obj_Passenger.PassengerMobileNumber = txt_PhoneNumber.Text;
            obj_Passenger.PassengerSex = Convert.ToBoolean(cmb_Sex.SelectedIndex);
            obj_Passenger.PassengerEmail = txt_Gmail.Text;
            if (lbl_Register.Text == string.Empty)
            {
                PersianCalendar p = new PersianCalendar();

                obj_Passenger.PassengerRegister = p.GetDateString(DateTime.Now) + " " + DateTime.Now.TimeOfDay;
            }
            else
            {
                obj_Passenger.PassengerRegister = lbl_Register.Text;
            }
            return obj_Passenger;

        }
        //-------------------------------------------
        private bool TrueData()
        {
            bool result = true;
            if (txt_NationalCode.Text.Trim() == string.Empty)
            {
                result = false;
                txt_NationalCode.SetErrorState(true);
            }
            if (txt_Name.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Name.SetErrorState(true);
            }
            if (txt_LastName.Text.Trim() == string.Empty)
            {
                result = false;
                txt_LastName.SetErrorState(true);
            }

            if (cmb_Sex.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا جنسیت را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
            if (txt_PhoneNumber.Text.Trim() == string.Empty)
            {
                result = false;
                txt_PhoneNumber.SetErrorState(true);
            }


            return result;
        }
        //-------------------------------------------
        private void ClearData()
        {
            foreach (Control c in pnl_Control.Controls)
            {
                if (c is MaterialTextBox2)
                {
                    c.Tag = string.Empty;
                    c.Text = string.Empty;
                }

            }
            txt_NationalCode.Tag = string.Empty;
            txt_PhoneNumber.Text = string.Empty;
            cmb_Sex.SelectedIndex = -1;

        }
        //-------------------------------------------
        private void OneRun()
        {
            cmb_Sex.Items.Add("زن");
            cmb_Sex.Items.Add("مرد");

        }
        //-------------------------------------------

        private void FalseEnable()
        {
            foreach (Control item in pnl_Control.Controls)
            {
                if (!(item is MaterialButton))
                    item.Enabled = false;
            }
        }
        //-------------------------------------------
        private void TrueEnable()
        {
            foreach (Control item in pnl_Control.Controls)
            {
                item.Enabled = true;
            }

        }
        //-------------------------------------------
       
        //------------------------------------------//
        //------------------------------------------//
        private void frm_Passenger_Load(object sender, EventArgs e)
        {

            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Passenger, 15);
            ActionMode(false);
            OneRun();
            ClearData();
        }

        private void txt_NationalCode_Click(object sender, EventArgs e)
        {

        }

        private void txt_NationalCode_Enter(object sender, EventArgs e)
        {
            txt_NationalCode.SetErrorState(false);
        }

        private void txt_Name_Enter(object sender, EventArgs e)
        {
            txt_Name.SetErrorState(false);

        }

        private void txt_LastName_Enter(object sender, EventArgs e)
        {
            txt_LastName.SetErrorState(false);

        }

        private void txt_PhoneNumber_Enter(object sender, EventArgs e)
        {
            txt_PhoneNumber.SetErrorState(false);

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            BusinessPassenger obj_BusinessPassenger = new BusinessPassenger();

            if (activerecord != 0)
            {
                if (TrueData())
                {

                    if ((obj_BusinessPassenger.Update(FillData())) != 0)
                    {
                        GetList();
                        ClearData();
                        ActionMode(false);
                        FalseEnable();
                        MsgBox.Show("مسافر مورد نظر با موفقیت ویرایش شد.");
                    }

                }
            }
            else
            {

                if (TrueData())
                {

                    bool national = obj_BusinessPassenger.SearchByField("PassengerNationalCode", txt_NationalCode.Text.Trim()).Rows.Count == 0;

                    if (national)
                    {
                        if ((activerecord = obj_BusinessPassenger.Insert(FillData())) != 0)
                        {
                            GetList();
                            ClearData();
                            ActionMode(false);
                            FalseEnable();
                            MsgBox.Show("مسافر مورد نظر با موفقیت ثبت شد.");
                        }
                    }
                    else
                    {
                        MsgBox.Show("این کد ملی قبلا ثبت شده است.");
                    }

                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
            FalseEnable();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            activerecord = 0;
            ActionMode(true);
            ClearData();
            TrueEnable();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_NationalCode.Tag != string.Empty)
            {
                ActionMode(true);
                TrueEnable();

            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک مسافر را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_NationalCode.Tag != string.Empty)
            {
                if (MsgBox.Show("آیا از حذف این مسافر مطمئن هستید؟", "", ButtonNumber.OKCancel) == DialogResult.OK)
                {
                    Passenger obj_Passenger = new Passenger();
                    obj_Passenger.PassengerID = int.Parse(txt_NationalCode.Tag.ToString());
                    BusinessPassenger obj_BusinessPassenger = new BusinessPassenger();
                    if (obj_BusinessPassenger.Delete(obj_Passenger) != 0)
                    {
                        activerecord = 0;
                        FalseEnable();
                        dgv_Passenger.DataSource = null;
                        ClearData();
                        MsgBox.Show("مسافر مورد نظر با موفقیت حذف شد.");
                    }
                }
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک مسافر را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void dgv_Passenger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_NationalCode.Tag = dgv_Passenger.CurrentRow.Cells["PassengerID"].Value.ToString();
            activerecord = int.Parse(dgv_Passenger.CurrentRow.Cells["PassengerID"].Value.ToString());
            txt_NationalCode.Text = dgv_Passenger.CurrentRow.Cells["PassengerNationalCode"].Value.ToString();
            txt_Name.Text = dgv_Passenger.CurrentRow.Cells["PassengerName"].Value.ToString();
            txt_LastName.Text = dgv_Passenger.CurrentRow.Cells["PassengerLastName"].Value.ToString();
            txt_PhoneNumber.Text = dgv_Passenger.CurrentRow.Cells["PassengerMobileNumber"].Value.ToString();
            cmb_Sex.SelectedIndex = cmb_Sex.FindStringExact(dgv_Passenger.CurrentRow.Cells["PassengerSex"].Value.ToString());
            cmb_Sex.Enabled = true;
            cmb_Sex.Enabled = false;
            dp_Birthday.txtDate.Text = dgv_Passenger.CurrentRow.Cells["PassengerBirthday"].Value.ToString();
            txt_Gmail.Text = dgv_Passenger.CurrentRow.Cells["PassengerEmail"].Value.ToString();
            lbl_Register.Text = dgv_Passenger.CurrentRow.Cells["PassengerRegister"].Value.ToString();

        }

        private void pic_SearchNationalCode_Click(object sender, EventArgs e)
        {
            if (txt_SearchNationalCode.Text != string.Empty)
            {
                dgv_Passenger.DataSource = new BusinessPassenger().SearchByField("PassengerNationalCode", txt_SearchNationalCode.Text.Trim());
                SetSetting();
            }
        }

        private void pic_SearchLastName_Click(object sender, EventArgs e)
        {
            if (txt_SearchLastName.Text != string.Empty)
            {
                dgv_Passenger.DataSource = new BusinessPassenger().SearchByField("PassengerNationalCode", txt_SearchLastName.Text.Trim());
                SetSetting();
            }
        }

        private void pic_SearchPhoneNumber_Click(object sender, EventArgs e)
        {
            if (txt_SearchPhoneNumber.Text != string.Empty)
            {
                dgv_Passenger.DataSource = new BusinessPassenger().SearchByField("PassengerNationalCode", txt_SearchPhoneNumber.Text.Trim());
                SetSetting();
            }
        }

        private void txt_SearchNationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_SearchNationalCode_Click(pic_SearchNationalCode, e2);
            }
        }

        private void txt_SearchLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_SearchLastName_Click(pic_SearchNationalCode, e2);
            }
        }

        private void txt_SearchPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_SearchPhoneNumber_Click(pic_SearchNationalCode, e2);
            }
        }

        private void dgv_Passenger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Passenger.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void btn_MoreSearch_Click(object sender, EventArgs e)
        {
            frm_PassengerSearch f = new frm_PassengerSearch();
            f.FormName = "جستجوی مسافر";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Passenger.Rows.Count > 0)
                {
                    txt_NationalCode.Tag = f.dgv_Passenger.CurrentRow.Cells["PassengerID"].Value.ToString();
                    activerecord = int.Parse(f.dgv_Passenger.CurrentRow.Cells["PassengerID"].Value.ToString());
                    txt_NationalCode.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerNationalCode"].Value.ToString();
                    txt_Name.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerName"].Value.ToString();
                    txt_LastName.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerLastName"].Value.ToString();
                    txt_PhoneNumber.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerMobileNumber"].Value.ToString();
                    cmb_Sex.SelectedIndex = cmb_Sex.FindStringExact(f.dgv_Passenger.CurrentRow.Cells["PassengerSex"].Value.ToString());
                    cmb_Sex.Enabled = true;
                    cmb_Sex.Enabled = false;
                    dp_Birthday.txtDate.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerBirthday"].Value.ToString();
                    txt_Gmail.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerEmail"].Value.ToString();
                    lbl_Register.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerRegister"].Value.ToString();
                }
            }
        }
    }
}
