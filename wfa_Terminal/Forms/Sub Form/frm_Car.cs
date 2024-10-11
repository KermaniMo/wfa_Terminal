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
//-------------------------------
using MaterialSkin.Controls;
using System.Globalization;

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_Car : Forms.Master_Form.frm_SubMaster
    {
        public frm_Car()
        {
            InitializeComponent();
             

        }
        private int activerecord = 0;
        private string date;
        private void GetList()
        {

            if (activerecord != 0)
            {
                Car obj_Car = new Car();
                obj_Car.CarID = activerecord;
                dgv_Car.DataSource = new BusinessCar().Search(obj_Car);
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
            dgv_Car.Enabled = !action;
        }
        //-------------------------------------------
        private void SetSetting()
        {
            dgv_Car.Columns["CarID"].Visible = false;
            dgv_Car.Columns["ID_FK_tbl_CarType"].Visible = false;
            dgv_Car.Columns["CarRegister"].Visible = false;
            dgv_Car.Columns["OwnerNationalCode"].HeaderText = "کد ملی";
            dgv_Car.Columns["OwnerName"].HeaderText = "نام";
            dgv_Car.Columns["OwnerLastName"].HeaderText = "نام خانوادگی";
            dgv_Car.Columns["OwnerMobileNumber"].HeaderText = "موبایل";
            dgv_Car.Columns["OwnerSex"].HeaderText = "جنسیت";
            dgv_Car.Columns["OwnerBirthday"].HeaderText = "تاریخ تولد";
            dgv_Car.Columns["OwnerEmail"].HeaderText = "ایمیل";
            dgv_Car.Columns["CarRegister"].HeaderText = "تاریخ ثبت";
            dgv_Car.Columns["CarBrand"].HeaderText = "برند ماشین";
            dgv_Car.Columns["CarModel"].HeaderText = "مدل ماشین";
            dgv_Car.Columns["CarTag"].HeaderText = "پلاک";
            dgv_Car.Columns["CarDateOfManufacture"].HeaderText = "سال ساخت";
            dgv_Car.Columns["CarCapacity"].HeaderText = "ظرفیت";
            dgv_Car.Columns["TypeName"].HeaderText = "نوع ماشین";
        }
        //-------------------------------------------
        private Car FillData()
        {
            Car obj_Car = new Car();
            obj_Car.CarID = activerecord;
            obj_Car.OwnerNationalCode = txt_NationalCode.Text;
            obj_Car.OwnerName = txt_Name.Text;
            obj_Car.OwnerLastName = txt_LastName.Text;
            obj_Car.OwnerBirthday = dp_Birthday.txtDate.Text;
            obj_Car.OwnerMobileNumber = txt_PhoneNumber.Text;
            obj_Car.CarModel = txt_Model.Text;
            if(activerecord==0)
            obj_Car.CarRegister = DateTime.Now;
            else
             obj_Car.CarRegister = Convert.ToDateTime(date);

            obj_Car.OwnerSex = Convert.ToBoolean(cmb_Sex.SelectedIndex);
            obj_Car.CarBrand = txt_Brand.Text;
            obj_Car.CarCapacity = Convert.ToInt16(txt_Capacity.Text);
            obj_Car.CarTag = txt_Number1.Text + txt_Character.Text + txt_Number2.Text + txt_Iran.Text;
            obj_Car.CarDateOfManufacture = dp_CreateDate.txtDate.Text;
            obj_Car.OwnerEmail = txt_Gmail.Text;
            obj_Car.ID_FK_tbl_CarType = int.Parse(cmb_Type.SelectedValue.ToString());
            return obj_Car;

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
            if (txt_Number1.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Number1.SetErrorState(true);
            }
            if (txt_Number2.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Number2.SetErrorState(true);
            }
            if (txt_Character.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Character.SetErrorState(true);
            }
            if (txt_Iran.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Iran.SetErrorState(true);
            }
            Regex r = new Regex("[0-9]{2}[ا-ی]{1,3}[0-9]{3}[0-9]{2}");
            Match m = r.Match(txt_Number1.Text + txt_Character.Text + txt_Number2.Text + txt_Iran.Text);
            if (!m.Success)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا فرمت پلاک را درست وارد کنید", "باشه", true);
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
            cmb_Type.SelectedIndex = -1;
            lbl_Register.Text = string.Empty;
        }
        //-------------------------------------------
        private void OneRun()
        {
            cmb_Sex.Items.Add("زن");
            cmb_Sex.Items.Add("مرد");
            //-----------------------
            BusinessCarType obj_BusinessCarType = new BusinessCarType();
            cmb_Type.DataSource = obj_BusinessCarType.GetList();
            cmb_Type.DisplayMember = "TypeName";
            cmb_Type.ValueMember = "CarsTypeID";
            if (cmb_Type.Items.Count == 0)
            {
                MsgBox.Show("لطفا از فرم نوع ماشین،نوع ماشینی را اضافه کنید.");
                this.Close();
            }
        }
        //-------------------------------------------
        private string ChangeToPersianDate(string date)
        {
            Regex r = new Regex(".{1,2}/.{1,2}/....");
            Match m = r.Match(date);
            PersianCalendar p = new PersianCalendar();            
            string rawdate = p.GetDateString( Convert.ToDateTime(m.Value));
            return r.Replace(date,rawdate);
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
        }
        //-------------------------------------------//
        //-------------------------------------------//
        private void frm_Car_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Car, 15);
            ActionMode(false);
            OneRun();
            ClearData();
             

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Car_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Car.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            activerecord = 0;
            ActionMode(true);
            ClearData();
            TrueEnable();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (activerecord != 0)
            {
                BusinessCar obj_BusinessCar = new BusinessCar();
                if (TrueData())
                {
                    
                        if (( obj_BusinessCar.Update(FillData())) != 0)
                        {
                            GetList();
                            ClearData();
                            ActionMode(false);
                            FalseEnable();
                            MsgBox.Show("ماشین مورد نظر با موفقیت ویرایش شد.");
                        }
                    
                }
            }
            else
            {
                BusinessCar obj_BusinessCar = new BusinessCar();                 
                if (TrueData())
                {
                     
                        if ((activerecord = obj_BusinessCar.Insert(FillData())) != 0)
                        {
                            GetList();
                            ClearData();
                            ActionMode(false);
                            FalseEnable();
                            MsgBox.Show("ماشین مورد نظر با موفقیت ثبت شد.");
                        }
                     
                     
                }
            }
        }

        private void dgv_Car_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_NationalCode.Tag = dgv_Car.CurrentRow.Cells["CarID"].Value.ToString();
            activerecord =int.Parse( dgv_Car.CurrentRow.Cells["CarID"].Value.ToString());
            txt_NationalCode.Text = dgv_Car.CurrentRow.Cells["OwnerNationalCode"].Value.ToString();
            txt_Name.Text = dgv_Car.CurrentRow.Cells["OwnerName"].Value.ToString();
            txt_LastName.Text = dgv_Car.CurrentRow.Cells["OwnerLastName"].Value.ToString();
            txt_PhoneNumber.Text = dgv_Car.CurrentRow.Cells["OwnerMobileNumber"].Value.ToString();
            cmb_Sex.SelectedIndex =cmb_Sex.FindStringExact( dgv_Car.CurrentRow.Cells["OwnerSex"].Value.ToString());
            cmb_Sex.Enabled = true;
            cmb_Sex.Enabled = false;
            dp_Birthday.txtDate.Text = dgv_Car.CurrentRow.Cells["OwnerBirthday"].Value.ToString();
            txt_Gmail.Text = dgv_Car.CurrentRow.Cells["OwnerEmail"].Value.ToString();
            txt_Brand.Text = dgv_Car.CurrentRow.Cells["CarBrand"].Value.ToString();
            txt_Model.Text = dgv_Car.CurrentRow.Cells["CarModel"].Value.ToString();
            //------------------------------
            string tag = dgv_Car.CurrentRow.Cells["CarTag"].Value.ToString();
            string pattern = "[0-9]{3}";
            Regex re = new Regex(pattern);
            Match m = re.Match(tag);
            txt_Number1.Text = tag.Substring(0, 2);
            txt_Number2.Text = m.Value;
            
            re = new Regex("[ا-ی]{1,3}");
            m = re.Match(tag);
            txt_Character.Text = m.Value;
             
            txt_Iran.Text = tag.Substring(tag.Length-3);
            //-------------------------------
            dp_CreateDate.txtDate.Text = dgv_Car.CurrentRow.Cells["CarDateOfManufacture"].Value.ToString();
            txt_Capacity.Text = dgv_Car.CurrentRow.Cells["CarCapacity"].Value.ToString();
            cmb_Type.SelectedValue = dgv_Car.CurrentRow.Cells["ID_FK_tbl_CarType"].Value.ToString();
            cmb_Type.Enabled = true;
            cmb_Type.Enabled = false;
            lbl_Register.Text=ChangeToPersianDate(date= dgv_Car.CurrentRow.Cells["CarRegister"].Value.ToString());
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
            FalseEnable();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_NationalCode.Tag!=string.Empty)
            {
                ActionMode(true);
                TrueEnable();

            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک ماشین را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_NationalCode.Tag!=string.Empty)
            {
                if (MsgBox.Show("آیا از حذف این ماشین مطمئن هستید؟","",ButtonNumber.OKCancel)==DialogResult.OK)
                {
                    Car obj_Car = new Car();
                    obj_Car.CarID = int.Parse(txt_NationalCode.Tag.ToString());
                    BusinessCar obj_BusinessCar = new BusinessCar();
                    if (obj_BusinessCar.Delete(obj_Car)!=0)
                    {
                        activerecord = 0;
                        FalseEnable();
                        MsgBox.Show("ماشین مورد نظر با موفقیت حذف شد.");
                       
                    }
                }
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک ماشین را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void txt_NationalCode_Click(object sender, EventArgs e)
        {
            txt_NationalCode.SetErrorState(false);
        }

        private void txt_Name_Click(object sender, EventArgs e)
        {
            txt_Name.SetErrorState(false);

        }

        private void txt_LastName_Click(object sender, EventArgs e)
        {
            txt_LastName.SetErrorState(false);

        }

        private void txt_Iran_Click(object sender, EventArgs e)
        {
            txt_Iran.SetErrorState(false);

        }

        private void txt_Number2_Click(object sender, EventArgs e)
        {
            txt_Number2.SetErrorState(false);

        }

        private void txt_Character_Click(object sender, EventArgs e)
        {
            txt_Character.SetErrorState(false);

        }

        private void txt_Number1_Click(object sender, EventArgs e)
        {
            txt_Number1.SetErrorState(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_SearchNationalCode.Text!=string.Empty)
            {
                dgv_Car.DataSource = new BusinessCar().SearchByField("OwnerNationalCode",txt_SearchNationalCode.Text.Trim());
                SetSetting();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_SearchLastName.Text != string.Empty)
            {
                dgv_Car.DataSource = new BusinessCar().SearchByField("OwnerLastName", txt_SearchLastName.Text.Trim());
                SetSetting();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_SearchPhoneNumber.Text != string.Empty)
            {
                dgv_Car.DataSource = new BusinessCar().SearchByField("OwnerMobileNumber", txt_SearchPhoneNumber.Text.Trim());
                SetSetting();
            }
        }

        private void txt_SearchNationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pictureBox1_Click(pic_SearchNationalCode, e2);
            }
        }

        private void txt_SearchLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pictureBox2_Click(pic_SearchLastName, e2);
            }
        }

        private void txt_SearchPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                pictureBox3_Click(pic_SearchPhoneNumber, e2);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            frm_CarSearch f = new frm_CarSearch();
            f.FormName = "جستجوی ماشین";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Car.Rows.Count>0)
                {
                    txt_NationalCode.Tag = f.dgv_Car.CurrentRow.Cells["CarID"].Value.ToString();
                    activerecord = int.Parse(f.dgv_Car.CurrentRow.Cells["CarID"].Value.ToString());
                    txt_NationalCode.Text = f.dgv_Car.CurrentRow.Cells["OwnerNationalCode"].Value.ToString();
                    txt_Name.Text = f.dgv_Car.CurrentRow.Cells["OwnerName"].Value.ToString();
                    txt_LastName.Text = f.dgv_Car.CurrentRow.Cells["OwnerLastName"].Value.ToString();
                    txt_PhoneNumber.Text = f.dgv_Car.CurrentRow.Cells["OwnerMobileNumber"].Value.ToString();
                    cmb_Sex.SelectedIndex = cmb_Sex.FindStringExact(f.dgv_Car.CurrentRow.Cells["OwnerSex"].Value.ToString());
                    cmb_Sex.Enabled = true;
                    cmb_Sex.Enabled = false;
                    dp_Birthday.Text = f.dgv_Car.CurrentRow.Cells["OwnerBirthday"].Value.ToString();
                    txt_Gmail.Text = f.dgv_Car.CurrentRow.Cells["OwnerEmail"].Value.ToString();
                    txt_Brand.Text = f.dgv_Car.CurrentRow.Cells["CarBrand"].Value.ToString();
                    txt_Model.Text = f.dgv_Car.CurrentRow.Cells["CarModel"].Value.ToString();
                    //------------------------------
                    string tag = f.dgv_Car.CurrentRow.Cells["CarTag"].Value.ToString();
                    string pattern = "[0-9]{3}";
                    Regex re = new Regex(pattern);
                    Match m = re.Match(tag);
                    txt_Number1.Text = tag.Substring(0, 2);
                    txt_Number2.Text = m.Value;

                    re = new Regex("[ا-ی]{1,3}");
                    m = re.Match(tag);
                    txt_Character.Text = m.Value;

                    txt_Iran.Text = tag.Substring(tag.Length - 3);
                    //-------------------------------
                    dp_CreateDate.Text = f.dgv_Car.CurrentRow.Cells["CarDateOfManufacture"].Value.ToString();
                    txt_Capacity.Text = f.dgv_Car.CurrentRow.Cells["CarCapacity"].Value.ToString();
                    cmb_Type.SelectedValue = f.dgv_Car.CurrentRow.Cells["ID_FK_tbl_CarType"].Value.ToString();
                    cmb_Type.Enabled = true;
                    cmb_Type.Enabled = false;
                    lbl_Register.Text = ChangeToPersianDate(date = f.dgv_Car.CurrentRow.Cells["CarRegister"].Value.ToString());
                    f.forfill = false;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txt_SearchPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void txt_SearchLastName_Click(object sender, EventArgs e)
        {

        }

        private void txt_SearchNationalCode_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {

        }

        private void txt_Gmail_Click(object sender, EventArgs e)
        {

        }

        private void txt_Capacity_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dp_CreateDate_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Model_Click(object sender, EventArgs e)
        {

        }

        private void txt_Brand_Click(object sender, EventArgs e)
        {

        }

        private void txt_PhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dp_Birthday_Load(object sender, EventArgs e)
        {

        }

        private void cmb_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }
    }
}
