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
    public partial class frm_TripSearch : Forms.Master_Form.frm_SubMaster
    {
        public frm_TripSearch()
        {
            InitializeComponent();
        }
        private void SetSetting()
        {
            dgv_Trip.Columns["TripID"].Visible = false;
            dgv_Trip.Columns["fi_ID_FK_tbl_Driver"].Visible = false;
            dgv_Trip.Columns["se_ID_FK_tbl_Driver"].Visible = false;
            dgv_Trip.Columns["Or_ID_FK_tbl_City"].Visible = false;
            dgv_Trip.Columns["De_ID_FK_tbl_City"].Visible = false;
            dgv_Trip.Columns["ID_FK_tbl_Car"].Visible = false;
            dgv_Trip.Columns["Driver1"].HeaderText = "راننده اول";
            dgv_Trip.Columns["Driver2"].HeaderText = "راننده دوم";
            dgv_Trip.Columns["City1"].HeaderText = "شهر مبدا";
            dgv_Trip.Columns["City2"].HeaderText = "شهر مقصد";
            dgv_Trip.Columns["Car"].HeaderText = "ماشین";
            dgv_Trip.Columns["TripPrice"].HeaderText = "قیمت";
            dgv_Trip.Columns["TripCapacity"].HeaderText = "ظرفیت";
            dgv_Trip.Columns["TripDateOfMove"].HeaderText = "تاریخ حرکت";
            dgv_Trip.Columns["TripDateOfArrive"].HeaderText = "تاریخ رسیدن";
            dgv_Trip.Columns["TripStatus"].HeaderText = "وضعیت";
            dgv_Trip.Columns["TripDescription"].HeaderText = "توضیحات";

        }
        //-----------------------------------------
        private void OneRun()
        {
            cmb_Status.Items.Add("غیر فعال");
            cmb_Status.Items.Add("فعال");
            //-----------------------
            BusinessProvince obj_BusinessProvince = new BusinessProvince();
            cmb_FirstProvince.DataSource = obj_BusinessProvince.GetList();
            cmb_FirstProvince.DisplayMember = "ProvinceName";
            cmb_FirstProvince.ValueMember = "ProvinceID";
            cmb_SecondProvince.DataSource = obj_BusinessProvince.GetList();
            cmb_SecondProvince.DisplayMember = "ProvinceName";
            cmb_SecondProvince.ValueMember = "ProvinceID";

        }
        //-----------------------------------------
        private void Search(string field, string value)
        {
            dgv_Trip.DataSource = new BusinessTrip().SearchByField(field, value);
            SetSetting();
        }
        //-----------------------------------------
        private void frm_TripSearch_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Trip, 15);
            OneRun();
        }

        private void txt_FirstDriver_Enter(object sender, EventArgs e)
        {
           
        }

        private void txt_SecondDriver_Enter(object sender, EventArgs e)
        {
            
        }

        private void cmb_FirstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search("Or_ID_FK_tbl_City", cmb_FirstCity.SelectedValue.ToString());

        }

        private void cmb_SecondCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search("De_ID_FK_tbl_City", cmb_SecondCity.SelectedValue.ToString());

        }

        private void txt_Capacity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Capacity.Text.Trim() != string.Empty)
            {
                Search("TripCapacity", txt_Capacity.Text.Trim());
            }
        }

        private void cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search("TripStatus", (cmb_Status.SelectedIndex==1).ToString());

        }

        private void txt_Car_Enter(object sender, EventArgs e)
        {
        }

        private void txt_Car_Click(object sender, EventArgs e)
        {

            frm_CarSearch f = new frm_CarSearch();
            f.FormName = "جستجوی ماشین";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Car.Rows.Count > 0)
                {
                    Search("ID_FK_tbl_Car", f.dgv_Car.CurrentRow.Cells["CarID"].Value.ToString());
                    txt_Car.Text = f.dgv_Car.CurrentRow.Cells["CarBrand"].Value.ToString() + " " + f.dgv_Car.CurrentRow.Cells["CarModel"].Value.ToString();
                }
            }
        }

        private void txt_FirstDriver_Click(object sender, EventArgs e)
        {
            frm_DriverSearch f = new frm_DriverSearch();
            f.FormName = "جستجوی راننده";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Driver.Rows.Count > 0)
                {
                    txt_FirstDriver.Text = f.dgv_Driver.CurrentRow.Cells["DriverName"].Value.ToString() + " " + f.dgv_Driver.CurrentRow.Cells["DriverLastName"].Value.ToString();
                    Search("fi_ID_FK_tbl_Driver", f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString());
                }
            }
        }

        private void txt_SecondDriver_Click(object sender, EventArgs e)
        {
            frm_DriverSearch f = new frm_DriverSearch();
            f.FormName = "جستجوی راننده";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Driver.Rows.Count > 0)
                {
                    txt_SecondDriver.Text = f.dgv_Driver.CurrentRow.Cells["DriverName"].Value.ToString() + " " + f.dgv_Driver.CurrentRow.Cells["DriverLastName"].Value.ToString();
                    Search("se_ID_FK_tbl_Driver", f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString());
                }
            }
        }

        private void txt_Price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Price.Text.Trim() != string.Empty)
            {
                Search("TripPrice", txt_Price.Text.Trim());
            }
        }

        private void txt_Description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Description.Text.Trim() != string.Empty)
            {
                Search("TripDescription", txt_Description.Text.Trim());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Search("TripDateOfMove", dp_Move.txtDate.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Search("TripDateOfMove", tp_Move.Value.TimeOfDay.ToString());

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Search("TripDateOfArrive", tp_Arrive.Value.TimeOfDay.ToString());

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Search("TripDateOfArrive", dp_Arrive.txtDate.Text);

        }
        public bool forfill;

        private void dgv_Trip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            forfill = true;
            this.Close();
        }

        private void dgv_Trip_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Trip.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void txt_FirstDriver_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_SecondProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmb_SecondProvince.SelectedValue == null))
            {
                cmb_SecondCity.DataSource = new BusinessCity().SearchByField("ID_FK_tbl_Province", cmb_SecondProvince.SelectedValue.ToString());
                cmb_SecondCity.DisplayMember = "CityName";
                cmb_SecondCity.ValueMember = "CityID";
            }
        }

        private void cmb_FirstProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmb_FirstProvince.SelectedValue == null))
            {
                cmb_FirstCity.DataSource = new BusinessCity().SearchByField("ID_FK_tbl_Province", cmb_FirstProvince.SelectedValue.ToString());
                cmb_FirstCity.DisplayMember = "CityName";
                cmb_FirstCity.ValueMember = "CityID";
            }
        }
    }
}
