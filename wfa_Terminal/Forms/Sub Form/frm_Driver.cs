using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------
using MaterialSkin.Controls;
using System.Globalization;
using System.Text.RegularExpressions;

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_Driver : Forms.Master_Form.frm_SubMaster
    {
        public frm_Driver()
        {
            InitializeComponent();
        }
        private bool IsCreatePersonnelCode = false;
        private int activerecord = 0;
        private void GetList()
        {

            if (activerecord != 0)
            {
                Driver obj_Driver = new Driver();
                obj_Driver.DriverID = activerecord;
                dgv_Driver.DataSource = new BusinessDriver().Search(obj_Driver);
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
            dgv_Driver.Enabled = !action;
        }
        //-------------------------------------------
        private void SetSetting()
        {
            dgv_Driver.Columns["DriverID"].Visible = false;
            dgv_Driver.Columns["ID_FK_tbl_Degree"].Visible = false;             
            dgv_Driver.Columns["DriverNationalCode"].HeaderText = "کد ملی";
            dgv_Driver.Columns["DriverName"].HeaderText = "نام";
            dgv_Driver.Columns["DriverLastName"].HeaderText = "نام خانوادگی";
            dgv_Driver.Columns["DriverMobileNumber"].HeaderText = "موبایل";
            dgv_Driver.Columns["DriverSex"].HeaderText = "جنسیت";
            dgv_Driver.Columns["DriverBirthday"].HeaderText = "تاریخ تولد";
            dgv_Driver.Columns["DriverEmail"].HeaderText = "ایمیل";
            dgv_Driver.Columns["DriverLicenseNumber"].HeaderText = "شماره گواهینامه";
            dgv_Driver.Columns["DriverDateEmploy"].HeaderText = "تاریخ بکارگیری";
            dgv_Driver.Columns["DriverMaritalStatuse"].HeaderText = "وضعیت تاهل";
            dgv_Driver.Columns["DriverLicenseType"].HeaderText = "نوع گواهینامه";
            dgv_Driver.Columns["DriverDateOfExpirationCertificate"].HeaderText = "تاریخ انقضا";
            dgv_Driver.Columns["Address"].HeaderText = "آدرس";
            dgv_Driver.Columns["DriverPersonnelCode"].HeaderText = "کد پرسنلی";
            dgv_Driver.Columns["DegreeTitle"].HeaderText = "مدرک";
        }
        //-------------------------------------------
        private Driver FillData()
        {
            Driver obj_Driver = new Driver();
            obj_Driver.DriverID = activerecord;
            obj_Driver.DriverNationalCode = txt_NationalCode.Text;
            obj_Driver.DriverName = txt_Name.Text;
            obj_Driver.DriverLastName = txt_LastName.Text;
            obj_Driver.DriverBirthday = dp_Birthday.txtDate.Text;
            obj_Driver.DriverMobileNumber = txt_PhoneNumber.Text;
            obj_Driver.DriverLicenseNumber = txt_LicenseNumber.Text;          
            obj_Driver.DriverSex = Convert.ToBoolean(cmb_Sex.SelectedIndex);
            obj_Driver.DriverLicenseType = (byte)(cmb_LicenseType.SelectedIndex+1);
            obj_Driver.ID_FK_tbl_Degree =int.Parse(cmb_Degree.SelectedValue.ToString());
            obj_Driver.DriverDateEmploy =dp_Employ.txtDate.Text ;
            obj_Driver.DriverDateOfExpirationCertificate = dp_EXPLicense.txtDate.Text;
            obj_Driver.DriverEmail = txt_Gmail.Text;
            obj_Driver.DriverMaritalStatuse = chk_MaritalStatuse.Checked;
            obj_Driver.Address = txt_Address.Text;
            obj_Driver.DriverPersonnelCode = lbl_PersonnelCode.Text;
            return obj_Driver;

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
            }if (cmb_Degree.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا مدرک را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }if (cmb_LicenseType.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا نوع گواهینامه را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
            
            return result;
        }
        //-------------------------------------------
        private void ClearData()
        {
            foreach (Control c in pnl_TXT.Controls)
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
            cmb_Degree.SelectedIndex = -1;
            cmb_LicenseType.SelectedIndex = -1;
            lbl_PersonnelCode.Text = string.Empty;
            txt_Address.Text = string.Empty;
        }
        //-------------------------------------------
        private void OneRun()
        {
            cmb_Sex.Items.Add("زن");
            cmb_Sex.Items.Add("مرد");
            //-----------------------
            BusinessDegree obj_BusinessDegree = new BusinessDegree();
            cmb_Degree.DataSource = obj_BusinessDegree.GetList();
            cmb_Degree.DisplayMember = "DegreeTitle";
            cmb_Degree.ValueMember = "DegreeID";
            if (cmb_Degree.Items.Count==0)
            {
                MsgBox.Show("لطفا از فرم مدرک،مدرکی را اضافه کنید.");
                this.Close();
            }
            //-----------------------
            cmb_LicenseType.Items.Add("پایه یک");
            cmb_LicenseType.Items.Add("پایه دو");
            cmb_LicenseType.Items.Add("پایه سه");
        }
        //-------------------------------------------
  
        private void FalseEnable()
        {
            foreach (Control item in pnl_TXT.Controls)
            {
                if (!(item is MaterialButton))
                    item.Enabled = false;
            }
        }
        //-------------------------------------------
        private void TrueEnable()
        {
            foreach (Control item in pnl_TXT.Controls)
            {
                item.Enabled = true;
            }
            txt_NationalCode.Enabled = !IsCreatePersonnelCode;
            txt_LicenseNumber.Enabled = !IsCreatePersonnelCode;
            dp_Birthday.Enabled = !IsCreatePersonnelCode;
            dp_Employ.Enabled = !IsCreatePersonnelCode;
            btn_CreatePersonnelCode.Enabled = false;
        }
        //-------------------------------------------
        private bool ReadyForPersonnelCode()
        {
            bool result = true;
            //if (txt_Address.Text.Trim()==string.Empty && txt_LicenseNumber.Text.Trim() == string.Empty && cmb_Degree.SelectedIndex==-1 &&cmb_LicenseType.SelectedIndex==-1)
            //{
            //    result = false;
            //}
            foreach (Control item in pnl_TXT.Controls)
            {
                if (item is MaterialMultiLineTextBox2 || item is MaterialTextBox2)
                {
                    if (item.Name != "txt_Gmail")
                    {
                        if (item.Text.Trim() == string.Empty)
                        {
                            result = false;
                        }
                    }
                }
            }
            return result;
        }
        //-------------------------------------------
        private string CreatePersonnelCode()
        {
            return dp_Employ.txtDate.Text.Substring(2, 3) + txt_NationalCode.Text.Substring(txt_NationalCode.Text.Length - 4, txt_NationalCode.Text.Length) + dp_Birthday.txtDate.Text.Substring(2, 3) + txt_NationalCode.Tag.ToString();

        }
        //-------------------------------------------//
        //-------------------------------------------//
        private void frm_Driver_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Driver, 15);
            ActionMode(false);
            OneRun();
            ClearData();
          
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            BusinessDriver obj_BusinessDriver = new BusinessDriver();
            
                if (activerecord != 0)
                {
                    if (TrueData())
                    {

                        if ((obj_BusinessDriver.Update(FillData())) != 0)
                        {
                            GetList();
                            ClearData();
                            ActionMode(false);
                            FalseEnable();
                            MsgBox.Show("راننده مورد نظر با موفقیت ویرایش شد.");
                        }

                    }
                }
                else
                {

                    if (TrueData())
                    {
                         
                    bool national = obj_BusinessDriver.SearchByField("DriverNationalCode", txt_NationalCode.Text.Trim()).Rows.Count == 0;

                    if (national)
                    {
                        if ((activerecord = obj_BusinessDriver.Insert(FillData())) != 0)
                        {
                            GetList();
                            ClearData();
                            ActionMode(false);
                            FalseEnable();
                            MsgBox.Show("راننده مورد نظر با موفقیت ثبت شد.");
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
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک راننده را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_NationalCode.Tag != string.Empty)
            {
                if (MsgBox.Show("آیا از حذف این راننده مطمئن هستید؟", "", ButtonNumber.OKCancel) == DialogResult.OK)
                {
                    Driver obj_Driver = new Driver();
                    obj_Driver.DriverID = int.Parse(txt_NationalCode.Tag.ToString());
                    BusinessDriver obj_BusinessDriver = new BusinessDriver();
                    if (obj_BusinessDriver.Delete(obj_Driver) != 0)
                    {
                        activerecord = 0;
                        FalseEnable();
                        dgv_Driver.DataSource = null;
                        ClearData();
                        MsgBox.Show("راننده مورد نظر با موفقیت حذف شد.");
                    }
                }
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک راننده را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void dgv_Driver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_NationalCode.Tag = dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString();
            activerecord = int.Parse(dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString());
            txt_NationalCode.Text = dgv_Driver.CurrentRow.Cells["DriverNationalCode"].Value.ToString();
            txt_Name.Text = dgv_Driver.CurrentRow.Cells["DriverName"].Value.ToString();
            txt_LastName.Text = dgv_Driver.CurrentRow.Cells["DriverLastName"].Value.ToString();
            txt_PhoneNumber.Text = dgv_Driver.CurrentRow.Cells["DriverMobileNumber"].Value.ToString();
            cmb_Sex.SelectedIndex = cmb_Sex.FindStringExact(dgv_Driver.CurrentRow.Cells["DriverSex"].Value.ToString());
            cmb_Sex.Enabled = true;
            cmb_Sex.Enabled = false;
            cmb_LicenseType.SelectedIndex = cmb_LicenseType.FindStringExact(dgv_Driver.CurrentRow.Cells["DriverLicenseType"].Value.ToString());
            cmb_LicenseType.Enabled = true;
            cmb_LicenseType.Enabled = false;
            dp_Birthday.txtDate.Text = dgv_Driver.CurrentRow.Cells["DriverBirthday"].Value.ToString();
            txt_Gmail.Text = dgv_Driver.CurrentRow.Cells["DriverEmail"].Value.ToString();
            txt_LicenseNumber.Text = dgv_Driver.CurrentRow.Cells["DriverLicenseNumber"].Value.ToString();
            cmb_Degree.SelectedValue = dgv_Driver.CurrentRow.Cells["ID_FK_tbl_Degree"].Value.ToString();
            cmb_Degree.Enabled = true;
            cmb_Degree.Enabled = false;
            dp_Employ.txtDate.Text = dgv_Driver.CurrentRow.Cells["DriverDateEmploy"].Value.ToString();
            dp_EXPLicense.txtDate.Text = dgv_Driver.CurrentRow.Cells["DriverDateOfExpirationCertificate"].Value.ToString();
            txt_Address.Text = dgv_Driver.CurrentRow.Cells["Address"].Value.ToString();
            chk_MaritalStatuse.Checked = dgv_Driver.CurrentRow.Cells["DriverMaritalStatuse"].Value.ToString()=="متاهل";
            lbl_PersonnelCode.Text = dgv_Driver.CurrentRow.Cells["DriverPersonnelCode"].Value.ToString();
            btn_CreatePersonnelCode.Enabled = dgv_Driver.CurrentRow.Cells["DriverPersonnelCode"].Value.ToString()==string.Empty;
            
        }

        private void txt_CreatePersonnelCode_Click(object sender, EventArgs e)
        {
            Driver obj_Drive = new Driver();

            if (ReadyForPersonnelCode())
            {
                if (MsgBox.Show("آیا از ساخت کد پرسنلی مطمئن هستید؟\n با انجام این کار برخی فیلد ها قابل ویرایش نیستند.", "", ButtonNumber.OKCancel) == DialogResult.OK)
                {
                    string code;
                    obj_Drive = FillData();
                    code= obj_Drive.DriverPersonnelCode = dp_Employ.txtDate.Text.Substring(2, 2) + txt_NationalCode.Text.Substring(txt_NationalCode.Text.Length - 4, 4) + dp_Birthday.txtDate.Text.Substring(2, 2) + txt_NationalCode.Tag.ToString();
                    BusinessDriver obj_BusinessDriver = new BusinessDriver();
                    obj_BusinessDriver.Update(obj_Drive);
                    IsCreatePersonnelCode = true;
                    GetList();
                    ActionMode(false);
                    FalseEnable();
                    MsgBox.Show($"کد پرسنلی{code} با موفقیت ساخته شد.");
                    btn_CreatePersonnelCode.Enabled = false;
                    ManageDriver obj_ManageDriver = new ManageDriver();
                    obj_ManageDriver.ID_FK_tbl_Driver = activerecord;
                    obj_ManageDriver.ManageDriverStatus = "در حال کار";
                    obj_ManageDriver.ManageDriverDateOfLeave = "";
                    obj_ManageDriver.ManageDriverDateOfBack = "";
                    obj_ManageDriver.ManageDriverDescription = "";
                    BusinessManageDriver obj_BusinessManageDriver = new BusinessManageDriver();
                    obj_BusinessManageDriver.Insert(obj_ManageDriver);
                    ClearData();

                }
            }
            else
            {
                MsgBox.Show("لطفا برای انجام این کار تمام مقادیر را کامل کنید.");
            }
        }

        private void dgv_Driver_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Driver.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void pic_SearchNationalCode_Click(object sender, EventArgs e)
        {
            if (txt_SearchNationalCode.Text != string.Empty)
            {
                dgv_Driver.DataSource = new BusinessDriver().SearchByField("DriverNationalCode", txt_SearchNationalCode.Text.Trim());
                SetSetting();
            }
        }

        private void pic_SearchLastName_Click(object sender, EventArgs e)
        {
            if (txt_SearchLastName.Text != string.Empty)
            {
                dgv_Driver.DataSource = new BusinessDriver().SearchByField("DriverLastName", txt_SearchLastName.Text.Trim());
                SetSetting();
            }
        }

        private void pic_SearchPhoneNumber_Click(object sender, EventArgs e)
        {
            if (txt_SearchPhoneNumber.Text != string.Empty)
            {
                dgv_Driver.DataSource = new BusinessDriver().SearchByField("DriverMobileNumber", txt_SearchPhoneNumber.Text.Trim());
                SetSetting();
            }
        }

        private void btn_MoreSearch_Click(object sender, EventArgs e)
        {
            frm_DriverSearch f = new frm_DriverSearch();
            f.FormName = "جستجوی راننده";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Driver.Rows.Count > 0)
                {
                    txt_NationalCode.Tag = f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString();
                    activerecord = int.Parse(f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString());
                    txt_NationalCode.Text = f.dgv_Driver.CurrentRow.Cells["DriverNationalCode"].Value.ToString();
                    txt_Name.Text = f.dgv_Driver.CurrentRow.Cells["DriverName"].Value.ToString();
                    txt_LastName.Text = f.dgv_Driver.CurrentRow.Cells["DriverLastName"].Value.ToString();
                    txt_PhoneNumber.Text = f.dgv_Driver.CurrentRow.Cells["DriverMobileNumber"].Value.ToString();
                    cmb_Sex.SelectedIndex = cmb_Sex.FindStringExact(f.dgv_Driver.CurrentRow.Cells["DriverSex"].Value.ToString());
                    cmb_Sex.Enabled = true;
                    cmb_Sex.Enabled = false;
                    cmb_LicenseType.SelectedIndex = cmb_LicenseType.FindStringExact(f.dgv_Driver.CurrentRow.Cells["DriverLicenseType"].Value.ToString());
                    cmb_LicenseType.Enabled = true;
                    cmb_LicenseType.Enabled = false;
                    dp_Birthday.txtDate.Text = f.dgv_Driver.CurrentRow.Cells["DriverBirthday"].Value.ToString();
                    txt_Gmail.Text = f.dgv_Driver.CurrentRow.Cells["DriverEmail"].Value.ToString();
                    txt_LicenseNumber.Text = f.dgv_Driver.CurrentRow.Cells["DriverLicenseNumber"].Value.ToString();
                    cmb_Degree.SelectedValue = f.dgv_Driver.CurrentRow.Cells["ID_FK_tbl_Degree"].Value.ToString();
                    cmb_Degree.Enabled = true;
                    cmb_Degree.Enabled = false;
                    dp_Employ.txtDate.Text = f.dgv_Driver.CurrentRow.Cells["DriverDateEmploy"].Value.ToString();
                    dp_EXPLicense.txtDate.Text = f.dgv_Driver.CurrentRow.Cells["DriverDateOfExpirationCertificate"].Value.ToString();
                    txt_Address.Text = f.dgv_Driver.CurrentRow.Cells["Address"].Value.ToString();
                    chk_MaritalStatuse.Checked = f.dgv_Driver.CurrentRow.Cells["DriverMaritalStatuse"].Value.ToString() == "متاهل";
                    lbl_PersonnelCode.Text = f.dgv_Driver.CurrentRow.Cells["DriverPersonnelCode"].Value.ToString();
                    btn_CreatePersonnelCode.Enabled = f.dgv_Driver.CurrentRow.Cells["DriverPersonnelCode"].Value.ToString() == string.Empty;

                }
            }
                }

        private void txt_SearchNationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
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
                pic_SearchLastName_Click(pic_SearchLastName, e2);
            }
        }

        private void txt_SearchPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pic_SearchPhoneNumber_Click(pic_SearchPhoneNumber, e2);
            }
        }
    }
}
