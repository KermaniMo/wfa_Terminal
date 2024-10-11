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
    public partial class frm_MakeTicket : Forms.Master_Form.frm_SubMaster
    {
        public frm_MakeTicket()
        {
            InitializeComponent();
        }
        private int activerecord = 0;

        private void ActionMode(bool action)
        {
            btn_Cancel.Visible = action;
            btn_Submit.Visible = action;
            //---------------//
            btn_Insert.Visible = !action;
            btn_Edit.Visible = !action;
            btn_Delete.Visible = !action;
            //---------------//
            dgv_Trip.Enabled = !action;
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
        private void GetList()
        {

            if (activerecord != 0)
            {
                Trip obj_Trip = new Trip();
                obj_Trip.TripID = activerecord;
                dgv_Trip.DataSource = new BusinessTrip().Search(obj_Trip);
                SetSetting();
            }
        }
        //-----------------------------------------
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
        private Trip FillData()
        {
            Trip obj_Trip = new Trip();
            obj_Trip.TripID = activerecord;
            obj_Trip.TripCapacity = Convert.ToInt16(txt_Capacity.Text);
            obj_Trip.fi_ID_FK_tbl_Driver = int.Parse(txt_FirstDriver.Tag.ToString());
            obj_Trip.se_ID_FK_tbl_Driver = int.Parse(txt_SecondDriver.Tag.ToString());
            obj_Trip.Or_ID_FK_tbl_City = int.Parse(cmb_FirstCity.SelectedValue.ToString());
            obj_Trip.De_ID_FK_tbl_City = int.Parse(cmb_SecondCity.SelectedValue.ToString());
            obj_Trip.ID_FK_tbl_Car = int.Parse(txt_Car.Tag.ToString());
            obj_Trip.TripDateOfMove = dp_Move.txtDate.Text + " " + tp_Move.Value.TimeOfDay.ToString();
            obj_Trip.TripDateOfArrive = dp_Arrive.txtDate.Text + " " + tp_Arrive.Value.TimeOfDay.ToString();
            obj_Trip.TripStatus = cmb_Status.SelectedIndex == 1;
            obj_Trip.TripPrice = Convert.ToDecimal(txt_Price.Text.Trim());
            obj_Trip.TripDescription = txt_Description.Text.Trim();
            return obj_Trip;
        }
        //-----------------------------------------
        private bool TrueData()
        {
            bool result = true;
            if (txt_FirstDriver.Text.Trim() == string.Empty)
            {
                result = false;
                txt_FirstDriver.SetErrorState(true);
            }
            if (txt_SecondDriver.Text.Trim() == string.Empty)
            {
                result = false;
                txt_SecondDriver.SetErrorState(true);
            }
            if (txt_Capacity.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Capacity.SetErrorState(true);
            }
            if (txt_Price.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Price.SetErrorState(true);
            }
            if (txt_Car.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Car.SetErrorState(true);
            }

            if (cmb_Status.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا وضعیت را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
            if (cmb_FirstCity.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا شهر مبدا را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
            if (cmb_SecondCity.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا شهر مقصد را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }

            return result;
        }
        //-----------------------------------------
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
            txt_FirstDriver.Tag = string.Empty;
            txt_SecondDriver.Tag = string.Empty;
            txt_Car.Tag = string.Empty;
            txt_Capacity.Tag = string.Empty;
            cmb_FirstCity.SelectedIndex = -1;
            cmb_SecondCity.SelectedIndex = -1;
            cmb_Status.SelectedIndex = -1;
            cmb_FirstProvince.SelectedIndex = -1;
            cmb_SecondProvince.SelectedIndex = -1;

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
        //-----------------------------------------//
        //-----------------------------------------//
        private void frm_MakeTicket_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Trip, 15);
            ActionMode(false);
            OneRun();
            ClearData();
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

        private void cmb_SecondProvice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmb_SecondProvince.SelectedValue == null))
            {
                cmb_SecondCity.DataSource = new BusinessCity().SearchByField("ID_FK_tbl_Province", cmb_SecondProvince.SelectedValue.ToString());
                cmb_SecondCity.DisplayMember = "CityName";
                cmb_SecondCity.ValueMember = "CityID";
            }
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
            if (txt_Capacity.Tag != string.Empty)
            {
                ActionMode(true);
                TrueEnable();

            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک بلیط را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_Capacity.Tag != string.Empty)
            {
                if (MsgBox.Show("آیا از حذف این بلیط مطمئن هستید؟", "", ButtonNumber.OKCancel) == DialogResult.OK)
                {
                    Trip obj_Trip = new Trip();
                    obj_Trip.TripID = int.Parse(txt_Capacity.Tag.ToString());
                    BusinessTrip obj_BusinessTrip = new BusinessTrip();
                    if (obj_BusinessTrip.Delete(obj_Trip) != 0)
                    {
                        activerecord = 0;
                        FalseEnable();
                        dgv_Trip.DataSource = null;
                        ClearData();
                        MsgBox.Show("بلیط مورد نظر با موفقیت حذف شد.");
                    }
                }
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک بلیط را انتخاب کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            BusinessTrip obj_BusinessTrip = new BusinessTrip();

            if (activerecord != 0)
            {
                if (TrueData())
                {

                    if ((obj_BusinessTrip.Update(FillData())) != 0)
                    {
                        GetList();
                        ClearData();
                        ActionMode(false);
                        FalseEnable();
                        MsgBox.Show("بلیط مورد نظر با موفقیت ویرایش شد.");
                    }

                }
            }
            else
            {

                if (TrueData())
                {

                    if ((activerecord = obj_BusinessTrip.Insert(FillData())) != 0)
                    {
                        GetList();
                        ClearData();
                        ActionMode(false);
                        FalseEnable();
                        MsgBox.Show("بلیط مورد نظر با موفقیت ثبت شد.");
                    }



                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
            FalseEnable();
            ClearData();
        }

        private void txt_FirstDriver_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_FirstDriver_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_FirstDriver_Enter(object sender, EventArgs e)
        {
            frm_DriverSearch f = new frm_DriverSearch();
            f.FormName = "جستجوی راننده";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Driver.Rows.Count > 0)
                {
                    txt_FirstDriver.Text = f.dgv_Driver.CurrentRow.Cells["DriverName"].Value.ToString() + " " + f.dgv_Driver.CurrentRow.Cells["DriverLastName"].Value.ToString();
                    txt_FirstDriver.Tag = f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString();
                }
            }
        }

        private void txt_SecondDriver_Enter(object sender, EventArgs e)
        {
            frm_DriverSearch f = new frm_DriverSearch();
            f.FormName = "جستجوی راننده";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Driver.Rows.Count > 0)
                {
                    txt_SecondDriver.Text = f.dgv_Driver.CurrentRow.Cells["DriverName"].Value.ToString() + " " + f.dgv_Driver.CurrentRow.Cells["DriverLastName"].Value.ToString();
                    txt_SecondDriver.Tag = f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString();
                }
            }
        }

        private void txt_Car_Enter(object sender, EventArgs e)
        {
            frm_CarSearch f = new frm_CarSearch();
            f.FormName = "جستجوی ماشین";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Car.Rows.Count > 0)
                {
                    txt_Car.Tag = f.dgv_Car.CurrentRow.Cells["CarID"].Value.ToString();
                    txt_Capacity.Text = f.dgv_Car.CurrentRow.Cells["CarCapacity"].Value.ToString();
                    txt_Car.Text = f.dgv_Car.CurrentRow.Cells["CarBrand"].Value.ToString() + " " + f.dgv_Car.CurrentRow.Cells["CarModel"].Value.ToString();
                }
            }
        }

        private void dgv_Trip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_FirstDriver.Tag = dgv_Trip.CurrentRow.Cells["fi_ID_FK_tbl_Driver"].Value.ToString();
            txt_SecondDriver.Tag = dgv_Trip.CurrentRow.Cells["se_ID_FK_tbl_Driver"].Value.ToString();
            //-----------------------------------
            BusinessProvince obj_BusinessProvince = new BusinessProvince();
            BusinessCity obj_BusinessCity = new BusinessCity();
            string City1 = dgv_Trip.CurrentRow.Cells["Or_ID_FK_tbl_City"].Value.ToString();
            cmb_FirstProvince.SelectedIndex = cmb_FirstProvince.FindStringExact(obj_BusinessProvince.SearchByField("ProvinceID", obj_BusinessCity.SearchByField("CityID", City1).Rows[0].Field<int>("ID_FK_tbl_Province").ToString()).Rows[0].Field<string>("ProvinceName"));
            string City2 = dgv_Trip.CurrentRow.Cells["De_ID_FK_tbl_City"].Value.ToString();
            cmb_SecondProvince.SelectedIndex = cmb_SecondProvince.FindStringExact(obj_BusinessProvince.SearchByField("ProvinceID", obj_BusinessCity.SearchByField("CityID", City2).Rows[0].Field<int>("ID_FK_tbl_Province").ToString()).Rows[0].Field<string>("ProvinceName"));
            //-----------------------------------
            txt_Car.Tag = dgv_Trip.CurrentRow.Cells["ID_FK_tbl_Car"].Value.ToString();
            txt_Capacity.Tag = dgv_Trip.CurrentRow.Cells["TripID"].Value.ToString();
            activerecord=int.Parse( dgv_Trip.CurrentRow.Cells["TripID"].Value.ToString());
            txt_FirstDriver.Text = dgv_Trip.CurrentRow.Cells["Driver1"].Value.ToString();
            txt_SecondDriver.Text = dgv_Trip.CurrentRow.Cells["Driver2"].Value.ToString();
            cmb_FirstCity.SelectedIndex = cmb_FirstCity.FindStringExact(dgv_Trip.CurrentRow.Cells["City1"].Value.ToString());
            cmb_SecondCity.SelectedIndex = cmb_SecondCity.FindStringExact(dgv_Trip.CurrentRow.Cells["City2"].Value.ToString());
            cmb_Status.SelectedIndex = cmb_FirstCity.FindStringExact(dgv_Trip.CurrentRow.Cells["TripStatus"].Value.ToString());
            txt_Car.Text = dgv_Trip.CurrentRow.Cells["Car"].Value.ToString();
            txt_Price.Text = dgv_Trip.CurrentRow.Cells["TripPrice"].Value.ToString();
            txt_Capacity.Text = dgv_Trip.CurrentRow.Cells["TripCapacity"].Value.ToString();
            //-------------------------------
            string datetimeinou = dgv_Trip.CurrentRow.Cells["TripDateOfMove"].Value.ToString();
            Regex r = new Regex("[0-9]{4}/[0-9]{1,2}/[0-9]{1,2}");
            Match m = r.Match(datetimeinou);
            dp_Move.txtDate.Text = m.Value;
            r = new Regex("[0-9]{1,2}:[0-9]{1,9}:[0-9]{1,2}");
            m = r.Match(datetimeinou);
            tp_Move.Text = m.Value;
            //--------------------------
            datetimeinou = dgv_Trip.CurrentRow.Cells["TripDateOfArrive"].Value.ToString();
            r = new Regex("[0-9]{4}/[0-9]{1,2}/[0-9]{1,2}");
            m = r.Match(datetimeinou);
            dp_Arrive.txtDate.Text = m.Value;
            r = new Regex("[0-9]{1,2}:[0-9]{1,9}:[0-9]{1,2}");
            m = r.Match(datetimeinou);
            tp_Arrive.Text = m.Value;

            //-------------------------------
            txt_Description.Text = dgv_Trip.CurrentRow.Cells["TripDescription"].Value.ToString();
            foreach (Control cmb in pnl_Control.Controls)
            {
                if (cmb is MaterialComboBox)
                {
                    cmb.Enabled = true;
                    cmb.Enabled = false;
                }
            }
        }

        private void btn_MoreSearch_Click(object sender, EventArgs e)
        {
            frm_TripSearch f = new frm_TripSearch();
            f.FormName = "جستجوی ماشین";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Trip.Rows.Count > 0)
                {
                    txt_FirstDriver.Tag = f.dgv_Trip.CurrentRow.Cells["fi_ID_FK_tbl_Driver"].Value.ToString();
                    txt_SecondDriver.Tag = f.dgv_Trip.CurrentRow.Cells["se_ID_FK_tbl_Driver"].Value.ToString();
                    //-----------------------------------
                    BusinessProvince obj_BusinessProvince = new BusinessProvince();
                    BusinessCity obj_BusinessCity = new BusinessCity();
                    string City1 = f.dgv_Trip.CurrentRow.Cells["Or_ID_FK_tbl_City"].Value.ToString();
                    cmb_FirstProvince.SelectedIndex = cmb_FirstProvince.FindStringExact(obj_BusinessProvince.SearchByField("ProvinceID", obj_BusinessCity.SearchByField("CityID",City1).Rows[0].Field<int>("ID_FK_tbl_Province").ToString()).Rows[0].Field<string>("ProvinceName"));
                    string City2 = f.dgv_Trip.CurrentRow.Cells["De_ID_FK_tbl_City"].Value.ToString();
                    cmb_SecondProvince.SelectedIndex = cmb_SecondProvince.FindStringExact(obj_BusinessProvince.SearchByField("ProvinceID", obj_BusinessCity.SearchByField("CityID", City2).Rows[0].Field<int>("ID_FK_tbl_Province").ToString()).Rows[0].Field<string>("ProvinceName"));                    
                    //-----------------------------------
                    txt_Car.Tag = f.dgv_Trip.CurrentRow.Cells["ID_FK_tbl_Car"].Value.ToString();
                    txt_Capacity.Tag = f.dgv_Trip.CurrentRow.Cells["TripID"].Value.ToString();
                    activerecord = int.Parse(f.dgv_Trip.CurrentRow.Cells["TripID"].Value.ToString());
                    txt_FirstDriver.Text = f.dgv_Trip.CurrentRow.Cells["Driver1"].Value.ToString();
                    txt_SecondDriver.Text = f.dgv_Trip.CurrentRow.Cells["Driver2"].Value.ToString();
                    cmb_FirstCity.SelectedIndex = cmb_FirstCity.FindStringExact(f.dgv_Trip.CurrentRow.Cells["City1"].Value.ToString());
                    cmb_SecondCity.SelectedIndex = cmb_SecondCity.FindStringExact(f.dgv_Trip.CurrentRow.Cells["City2"].Value.ToString());
                    cmb_Status.SelectedIndex = cmb_FirstCity.FindStringExact(f.dgv_Trip.CurrentRow.Cells["TripStatus"].Value.ToString());
                    txt_Car.Text = f.dgv_Trip.CurrentRow.Cells["Car"].Value.ToString();
                    txt_Price.Text = f.dgv_Trip.CurrentRow.Cells["TripPrice"].Value.ToString();
                    txt_Capacity.Text = f.dgv_Trip.CurrentRow.Cells["TripCapacity"].Value.ToString();
                    //-------------------------------
                    string datetimeinou = f.dgv_Trip.CurrentRow.Cells["TripDateOfMove"].Value.ToString();
                    Regex r = new Regex("[0-9]{4}/[0-9]{1,2}/[0-9]{1,2}");
                    Match m = r.Match(datetimeinou);
                    dp_Move.txtDate.Text = m.Value;
                    r = new Regex("[0-9]{1,2}:[0-9]{1,9}:[0-9]{1,2}");
                    m = r.Match(datetimeinou);
                    tp_Move.Text = m.Value;
                    //--------------------------
                    datetimeinou = f.dgv_Trip.CurrentRow.Cells["TripDateOfArrive"].Value.ToString();
                    r = new Regex("[0-9]{4}/[0-9]{1,2}/[0-9]{1,2}");
                     m = r.Match(datetimeinou);
                    dp_Arrive.txtDate.Text = m.Value;
                    r = new Regex("[0-9]{1,2}:[0-9]{1,9}:[0-9]{1,2}");
                    m = r.Match(datetimeinou);
                    tp_Arrive.Text = m.Value;
                     
                    //-------------------------------
                    txt_Description.Text = f.dgv_Trip.CurrentRow.Cells["TripDescription"].Value.ToString();
                    foreach (Control cmb in pnl_Control.Controls)
                    {
                        if (cmb is MaterialComboBox)
                        {
                            cmb.Enabled = true;
                            cmb.Enabled = false;
                        }
                    }
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
                    txt_FirstDriver.Tag = f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString();
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
                    txt_SecondDriver.Tag = f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString();
                }
            }
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
                    txt_Car.Tag = f.dgv_Car.CurrentRow.Cells["CarID"].Value.ToString();
                    txt_Capacity.Text = f.dgv_Car.CurrentRow.Cells["CarCapacity"].Value.ToString();
                    txt_Car.Text = f.dgv_Car.CurrentRow.Cells["CarBrand"].Value.ToString() + " " + f.dgv_Car.CurrentRow.Cells["CarModel"].Value.ToString();
                }
            }
        }

        private void dgv_Trip_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Trip.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }
    }
}
