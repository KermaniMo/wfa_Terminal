using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------------------------
using MaterialSkin;
using MaterialSkin.Controls;


namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_City : Forms.Master_Form.frm_SubMaster
    {
        public frm_City()
        {
            InitializeComponent();



        }
        private void GetList()
        {
            dgv_Province.DataSource = new BusinessProvince().GetList();
            dtprovince = (DataTable)dgv_Province.DataSource;
            SetSetting();
        }
        //private bool CityOrProvince;
        //--------------------------
        private void SetSetting()
        {
            dgv_Province.Columns["ProvinceID"].Visible = false;
            dgv_Province.Columns["ProvinceName"].HeaderText = "استان";
            if (dgv_City.DataSource != null)
            {
                dgv_City.Columns["CityID"].Visible = false;
                dgv_City.Columns["ID_FK_tbl_Province"].Visible = false;
                dgv_City.Columns["CityName"].HeaderText = "شهر";

            }
          
        }
        //---------------------------------
        private void Cleartxt()
        {
            txt_Province.Text = string.Empty;
            txt_Province.Tag = string.Empty;
            txt_City.Text = string.Empty;
            txt_City.Tag = string.Empty;
        }

        //---------------------------------
        private void frm_City_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Province, 15);
            RoundControl(dgv_City, 15);
            GetList();
            txt_Province.Tag = string.Empty;
            txt_City.Tag = string.Empty;
        }

        private void dgv_Province_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Province.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void dgv_City_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_City.Rows[e.RowIndex].Cells["RowCountCity"].Value = e.RowIndex + 1;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
          //  CityOrProvince = Switch_City.Checked;
            txt_City.Visible = Switch_City.Checked;
            txt_Province.Enabled = !Switch_City.Checked;
            //SaveProvince = !Switch_City.Checked;
        }
        DataTable dtable = new DataTable();
        DataTable dtprovince = new DataTable();
        DataTable dtcity = new DataTable();
        bool SaveProvince = false;
        bool SaveCity = false;
        private void materialButton5_Click(object sender, EventArgs e)
        {
            if (!Switch_City.Checked)
            {
                if (txt_Province.Text.Trim() != string.Empty)
                {
                    if (dtable.Columns.Count == 0)
                    {
                        dtable.Columns.Add("ProvinceName");
                    }
                    dtable.Rows.Add(txt_Province.Text.Trim());
                    dtprovince.Rows.Add(-15, txt_Province.Text.Trim());
                    dgv_Province.DataSource = dtprovince;
                    SaveProvince = true;
                    txt_Province.Text = string.Empty;
                    txt_Province.Focus();
                    Switch_City.Enabled = false;
                    btn_Delete.Enabled = false;

                }
            }
            else
            {
                if (dtable.Columns.Count == 0)
                {
                    dtable.Columns.Add("CityName");
                    dtable.Columns.Add("ID_FK_tbl_Province");
                }
                dtable.Rows.Add(txt_City.Text.Trim(),txt_Province.Tag.ToString());
                dtcity.Rows.Add(-15, txt_City.Text.Trim());
                dgv_City.DataSource = dtcity;
                SaveCity = true;
                txt_City.Text = string.Empty;
                txt_City.Focus();
                Switch_City.Enabled = false;
                btn_Delete.Enabled = false;

            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (SaveProvince)
            {
                if (dtable.Rows.Count > 0)
                {
                    BusinessProvince obj_BusinessProvince = new BusinessProvince();
                    if (obj_BusinessProvince.GroupInsert(dtable) > 0)
                    {
                        btn_Delete.Enabled = true;

                        MsgBox.Show("استان (ها) با موفقیت ثبت شدند.");
                        GetList();
                        dtable.Clear();
                        Switch_City.Enabled = true;
                        SaveProvince = false;
                        Cleartxt();
                        dgv_City.DataSource = null;
                    }
                }
            }
            else if (SaveCity)
            {
                if (dtable.Rows.Count > 0)
                {
                    BusinessCity obj_BusinessCity = new BusinessCity();
                    if (obj_BusinessCity.GroupInsert(dtable) > 0)
                    {
                        btn_Delete.Enabled = true;
                        MsgBox.Show("شهر (ها) با موفقیت ثبت شدند.");
                        dgv_City.DataSource = new BusinessCity().SearchByField("ID_FK_tbl_Province", txt_Province.Tag.ToString());
                        SetSetting();
                        dtable.Clear();
                        Switch_City.Enabled = true;
                        SaveCity = false;
                        SaveProvince = false;
                        Cleartxt();
                        dgv_City.DataSource = null;

                    }
                }
            }
        }
        private void ClearCity()
        {
            txt_City.Text = string.Empty;
            txt_City.Tag = string.Empty;
        }
        private void dgv_Province_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!SaveProvince)
            {

                txt_Province.Text = dgv_Province.CurrentRow.Cells["ProvinceName"].Value.ToString();
                txt_Province.Tag = dgv_Province.CurrentRow.Cells["ProvinceID"].Value.ToString();
                dgv_City.DataSource = new BusinessCity().SearchByField("ID_FK_tbl_Province", txt_Province.Tag.ToString());
                SetSetting();
                Switch_City.Enabled = true;
                dtcity = (DataTable)dgv_City.DataSource;
                btn_Delete.Enabled = true;
                ClearCity();
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            if (!Switch_City.Checked)
            {
                if (txt_Province.Tag!=string.Empty &&txt_Province.Text.Trim()!=string.Empty)
                {
                    if (MsgBox.Show("آیا از ویرایش این استان مطمئن هستید؟","",ButtonNumber.OKCancel)==DialogResult.OK)
                    {
                        Province obj_Province = new Province();
                        obj_Province.ProvinceID = int.Parse(txt_Province.Tag.ToString());
                        obj_Province.ProvinceName = txt_Province.Text.Trim();
                        BusinessProvince obj_BusinessProvince = new BusinessProvince();
                        if (obj_BusinessProvince.Update(obj_Province) != 0)
                        {
                            Cleartxt();
                            MsgBox.Show("استان مورد نظر با موفقیت ویرایش شد.");
                            GetList();
                        }
                    }
                    
                }
                else
                {
                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک استان را انتخاب کنید", "باشه", true);
                    SnackBarMessage.Show(this);
                }
            }
            else
            {
                if (txt_Province.Tag != string.Empty && txt_City.Text.Trim() != string.Empty)
                {
                    if (MsgBox.Show("آیا از ویرایش این شهر مطمئن هستید؟", "", ButtonNumber.OKCancel) == DialogResult.OK)
                    {
                        City obj_City = new City();
                        obj_City.CityID = int.Parse(txt_City.Tag.ToString());
                        obj_City.CityName = txt_City.Text.Trim();
                        obj_City.ID_FK_tbl_Province = int.Parse(txt_Province.Tag.ToString());
                        BusinessCity obj_BusinessCity = new BusinessCity();
                        if (obj_BusinessCity.Update(obj_City) != 0)
                        {
                            dgv_City.DataSource = obj_BusinessCity.SearchByField("ID_FK_tbl_Province", txt_Province.Tag.ToString());

                            ClearCity();

                            MsgBox.Show("شهر مورد نظر با موفقیت ویرایش شد.");
                            SetSetting();
                        }
                    }

                }
                else
                {
                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک شهر را انتخاب کنید", "باشه", true);
                    SnackBarMessage.Show(this);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
             
          
            if (!Switch_City.Checked)
            {
                if (txt_Province.Tag != string.Empty && txt_Province.Text.Trim() != string.Empty)
                {
                    if (MsgBox.Show("آیا از حذف این استان مطمئن هستید؟", "", ButtonNumber.OKCancel) == DialogResult.OK)
                    {
                        Province obj_Province = new Province();
                        obj_Province.ProvinceID = int.Parse(txt_Province.Tag.ToString());
                        BusinessProvince obj_BusinessProvince = new BusinessProvince();
                        if (obj_BusinessProvince.Delete(obj_Province) != 0)
                        {
                            Cleartxt();
                            MsgBox.Show("استان مورد نظر با موفقیت حذف شد.");
                            GetList();
                        }
                    }
                }
                else
                {
                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک استان را انتخاب کنید", "باشه", true);
                    SnackBarMessage.Show(this);
                }
            }
            else
            {
                if (txt_City.Tag != string.Empty && txt_City.Text.Trim() != string.Empty)
                {
                    if (MsgBox.Show("آیا از حذف این شهر مطمئن هستید؟", "", ButtonNumber.OKCancel) == DialogResult.OK)
                    {
                        City obj_City = new City();
                        obj_City.CityID = int.Parse(txt_City.Tag.ToString());
                        BusinessCity obj_BusinessCity = new BusinessCity();
                        if (obj_BusinessCity.Delete(obj_City) != 0)
                        {
                            dgv_City.DataSource = obj_BusinessCity.SearchByField("ID_FK_tbl_Province", txt_Province.Tag.ToString());

                            ClearCity();

                            MsgBox.Show("شهر مورد نظر با موفقیت حذف شد.");
                            GetList();
                        }
                    }
                }
                else
                {
                    MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا یک شهر را انتخاب کنید", "باشه", true);
                    SnackBarMessage.Show(this);
                }
            }
        }

        private void txt_Province_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                materialButton5_Click(btn_Insert, e2);
                txt_Province.Focus();
            }
        }

        private void txt_City_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                materialButton5_Click(btn_Insert, e2);
                txt_City.Focus();
            }
        }

        private void txt_Province_TextChanged(object sender, EventArgs e)
        {
            if (txt_Province.Tag!=string.Empty)
            {
                btn_Delete.Enabled = false;
            }
            else
            {
                btn_Delete.Enabled = true;

            }
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dgv_City_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!SaveCity)
            {

                txt_City.Text = dgv_City.CurrentRow.Cells["CityName"].Value.ToString();
                txt_City.Tag = dgv_City.CurrentRow.Cells["CityID"].Value.ToString();
                Switch_City.Checked = true;
            }
        }
    }
}