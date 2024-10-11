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
    public partial class frm_DriverSearch : Forms.Master_Form.frm_SubMaster
    {
        public frm_DriverSearch()
        {
            InitializeComponent();
        }
        private void OneRun()
        {
            cmb_Sex.Items.Add("زن");
            cmb_Sex.Items.Add("مرد");
            //-----------------------
            BusinessDegree obj_BusinessDegree = new BusinessDegree();
            cmb_Degree.DataSource = obj_BusinessDegree.GetList();
            cmb_Degree.DisplayMember = "DegreeTitle";
            cmb_Degree.ValueMember = "DegreeID";
            //-----------------------
            cmb_LicenseType.Items.Add("پایه یک");
            cmb_LicenseType.Items.Add("پایه دو");
            cmb_LicenseType.Items.Add("پایه سه");
        }
        //--------------------------------
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
        //--------------------------------
        private void Search(string field, string value)
        {
            dgv_Driver.DataSource = new BusinessDriver().SearchByField(field, value);
            SetSetting();
        }
        //--------------------------
        private void frm_DriverSearch_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Driver, 15);            
            OneRun();
        }

        private void txt_NationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_NationalCode.Text.Trim() != string.Empty)
            {
                Search("DriverNationalCode", txt_NationalCode.Text.Trim());
            }
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Name.Text.Trim() != string.Empty)
            {
                Search("DriverName", txt_Name.Text.Trim());
            }
        }

        private void txt_LastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_LastName.Text.Trim() != string.Empty)
            {
                Search("DriverLastName", txt_LastName.Text.Trim());
            }
        }

        private void cmb_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
             
                Search("DriverSex", cmb_Sex.SelectedIndex.ToString());
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

            Search("DriverBirthday", dp_Birthday.txtDate.Text);
             
        }

        private void txt_PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_PhoneNumber.Text.Trim() != string.Empty)
            {
                Search("DriverMobileNumber", txt_PhoneNumber.Text.Trim());
            }
        }

        private void txt_LicenseNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_LicenseNumber.Text.Trim() != string.Empty)
            {
                Search("DriverLicenseNumber", txt_LicenseNumber.Text.Trim());
            }
        }

        private void cmb_LicenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
             
                Search("DriverLicenseType", (cmb_LicenseType.SelectedIndex + 1).ToString());
             

             
        }

        private void cmb_Degree_SelectedIndexChanged(object sender, EventArgs e)
        {
             
                Search("ID_FK_tbl_Degree", cmb_Degree.SelectedValue.ToString());
             
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Search("DriverDateEmploy", dp_Employ.txtDate.Text);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Search("DriverDateOfExpirationCertificate", dp_EXPLicense.txtDate.Text);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Search("DriverMaritalStatuse", Convert.ToByte(chk_MaritalStatuse.Checked).ToString());

        }

        private void txt_Gmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Gmail.Text.Trim() != string.Empty)
            {
                Search("DriverEmail", txt_Gmail.Text.Trim());
            }
        }

        private void dgv_Driver_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Driver.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void txt_PersonnelCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_PersonnelCode.Text.Trim() != string.Empty)
            {
                Search("DriverPersonnelCode", txt_PersonnelCode.Text.Trim());
            }
        }
        public bool forfill;

        private void dgv_Driver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            forfill = true;
            this.Close();
        }
    }
}
