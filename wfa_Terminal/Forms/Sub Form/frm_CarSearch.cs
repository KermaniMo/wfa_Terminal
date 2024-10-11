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
    public partial class frm_CarSearch : Forms.Master_Form.frm_SubMaster
    {
        public frm_CarSearch()
        {
            InitializeComponent();
        }
        private void OneRun()
        {
            cmb_Sex.Items.Add("زن");
            cmb_Sex.Items.Add("مرد");
            //-----------------------
            BusinessCarType obj_BusinessCarType = new BusinessCarType();
            cmb_Type.DataSource = obj_BusinessCarType.GetList();
            cmb_Type.DisplayMember = "TypeName";
            cmb_Type.ValueMember = "CarsTypeID";
        }
        //----------------------------------------------
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
        private void Search(string field,string value)
        {
            dgv_Car.DataSource = new BusinessCar().SearchByField(field,value);
            SetSetting();
        }

        private void frm_CarSearch_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Car, 15);
             
            OneRun();
             
        }

        private void dgv_Car_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Car.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void txt_NationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_NationalCode.Text.Trim()!=string.Empty)
            {
                Search("OwnerNationalCode",txt_NationalCode.Text.Trim());
            }
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Name.Text.Trim() != string.Empty)
            {
                Search("OwnerName", txt_Name.Text.Trim());
            }
        }

        private void txt_LastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_LastName.Text.Trim() != string.Empty)
            {
                Search("OwnerLastName", txt_LastName.Text.Trim());
            }
        }

        private void cmb_Sex_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cmb_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search("OwnerSex", cmb_Sex.SelectedIndex.ToString());
        }

        private void dp_Birthday_Load(object sender, EventArgs e)
        {

        }

        private void dp_Birthday_Click(object sender, EventArgs e)
        {

        }

        private void dp_Birthday_KeyDown(object sender, KeyEventArgs e)
        {
             
        }

        private void dp_Birthday_Validated(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Search("OwnerBirthday", dp_Birthday.txtDate.Text);

        }

        private void dp_Birthday_ChangeUICues(object sender, UICuesEventArgs e)
        {
             
        }

        private void txt_PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_PhoneNumber.Text.Trim() != string.Empty)
            {
                Search("OwnerMobileNumber", txt_PhoneNumber.Text.Trim());
            }
        }

        private void txt_Brand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Brand.Text.Trim() != string.Empty)
            {
                Search("CarBrand", txt_Brand.Text.Trim());
            }
        }

        private void txt_Model_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Model.Text.Trim() != string.Empty)
            {
                Search("CarModel", txt_Model.Text.Trim());
            }
        }

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search("ID_FK_tbl_CarType", cmb_Type.SelectedValue.ToString()) ;

        }

        private void txt_Iran_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (txt_Number1.Text.Trim() != string.Empty|| txt_Number2.Text.Trim() != string.Empty|| txt_Character.Text.Trim() != string.Empty|| txt_Iran.Text.Trim() != string.Empty))
            {
                Search("CarTag", txt_Number1.Text.Trim() + txt_Character.Text.Trim() + txt_Number2.Text.Trim() + txt_Iran.Text.Trim());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Search("CarDateOfManufacture", dp_CreateDate.txtDate.Text);

        }

        private void txt_Capacity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Capacity.Text.Trim() != string.Empty)
            {
                Search("CarCapacity", txt_Capacity.Text.Trim());
            }
        }

        private void txt_Gmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Gmail.Text.Trim() != string.Empty)
            {
                Search("OwnerEmail", txt_Gmail.Text.Trim());
            }
        }
        public bool forfill;
        private void dgv_Car_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            forfill = true;
            this.Close();
        }
    }
}
