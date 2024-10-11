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
    public partial class frm_PassengerSearch : Forms.Master_Form.frm_SubMaster
    {
        public frm_PassengerSearch()
        {
            InitializeComponent();
        }
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
        //--------------------------------
        private void Search(string field, string value)
        {
            dgv_Passenger.DataSource = new BusinessPassenger().SearchByField(field, value);
            SetSetting();
        }
        //--------------------------------
        private void OneRun()
        {
            cmb_Sex.Items.Add("زن");
            cmb_Sex.Items.Add("مرد");

        }
        private void frm_PassengerSearch_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Passenger, 15);
            OneRun();
        }

        private void dgv_Passenger_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Passenger.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void txt_NationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_NationalCode.Text.Trim() != string.Empty)
            {
                Search("PassengerNationalCode", txt_NationalCode.Text.Trim());
            }
        }

        private void txt_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Name.Text.Trim() != string.Empty)
            {
                Search("PassengerNationalCode", txt_Name.Text.Trim());
            }
        }

        private void txt_LastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_LastName.Text.Trim() != string.Empty)
            {
                Search("PassengerNationalCode", txt_LastName.Text.Trim());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Search("PassengerBirthday", dp_Birthday.txtDate.Text);

        }

        private void cmb_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search("PassengerBirthday", cmb_Sex.SelectedIndex.ToString());

        }

        private void txt_PhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_PhoneNumber.Text.Trim() != string.Empty)
            {
                Search("PassengerNationalCode", txt_PhoneNumber.Text.Trim());
            }
        }

        private void txt_Gmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Gmail.Text.Trim() != string.Empty)
            {
                Search("PassengerNationalCode", txt_Gmail.Text.Trim());
            }
        }
        public bool forfill;

        private void dgv_Passenger_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            forfill = true;
            this.Close();
        }
    }
}
