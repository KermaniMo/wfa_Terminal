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

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_ManageDriver : Forms.Master_Form.frm_SubMaster
    {
        public frm_ManageDriver()
        {
            InitializeComponent();
        }

        private void ActionMode(bool action)
        {
            btn_Cancel.Visible = action;
            btn_Submit.Visible = action;
            //---------------//
            btn_Insert.Visible = !action;             
            //---------------//
            dgv_ManageDriver.Enabled = !action;
            //---------------//
             
            Switch_Back.Enabled = action;
            Switch_Leave.Enabled = action;
            txt_PersonnelCode.Enabled = !action;
            txt_Description.Enabled = action;
            cmb_Status.Enabled = action;
            Switch_Back.Checked = false;
            Switch_Leave.Checked = false;
            pic_Search.Enabled = !action;
        }
        //-----------------------------------------
        private void OneRun()
        {
            cmb_Status.Items.Add("در حال کار");
            cmb_Status.Items.Add("مرخصی");
            cmb_Status.Items.Add("تعلیق");
        }
        //----------------------------------------
        private void FillControl()
        {
            if (txt_PersonnelCode.Tag!=string.Empty)
            {
                DataTable dtable = new BusinessManageDriver().SearchByField("ID_FK_tbl_Driver", txt_PersonnelCode.Tag.ToString());
                cmb_Status.SelectedIndex = cmb_Status.FindStringExact(dtable.Rows[0].Field<string>("ManageDriverStatus"));
                cmb_Status.Enabled = true;
                cmb_Status.Enabled = false;
                if(dtable.Rows[0].Field<string>("ManageDriverDateOfBack")!=string.Empty)
                dp_Back.txtDate.Text = dtable.Rows[0].Field<string>("ManageDriverDateOfBack");
                if (dtable.Rows[0].Field<string>("ManageDriverDateOfLeave") != string.Empty)
                    dp_Leave.txtDate.Text = dtable.Rows[0].Field<string>("ManageDriverDateOfLeave");
                txt_Description.Text = dtable.Rows[0].Field<string>("ManageDriverDescription");
                txt_NameLastName.Tag= dtable.Rows[0].Field<int>("ManageDriverID").ToString();
            }
        }
        //-----------------------------------------
        private void GetList()
        {
            if (txt_PersonnelCode.Tag != string.Empty)
            {
                dgv_ManageDriver.DataSource = new BusinessSaveActivity().SearchByField("ID_FK_tbl_Driver",txt_PersonnelCode.Tag.ToString());
                SetSetting();
            }
        }
        //-----------------------------------------
        private ManageDriver FillDataManageDriver()
        {
            ManageDriver obj_ManageDriver = new ManageDriver();
            obj_ManageDriver.ManageDriverID = int.Parse(txt_NameLastName.Tag.ToString());
            obj_ManageDriver.ManageDriverStatus = cmb_Status.SelectedItem.ToString() ;
            if (Switch_Leave.Checked)
                obj_ManageDriver.ManageDriverDateOfLeave = dp_Leave.txtDate.Text;
            else
                obj_ManageDriver.ManageDriverDateOfLeave = "";
            if (Switch_Back.Checked)
            obj_ManageDriver.ManageDriverDateOfBack = dp_Back.txtDate.Text;
            else
            obj_ManageDriver.ManageDriverDateOfBack = "";
            obj_ManageDriver.ID_FK_tbl_Driver = int.Parse(txt_PersonnelCode.Tag.ToString());
            obj_ManageDriver.ManageDriverDescription = txt_Description.Text;
            return obj_ManageDriver;
        }
        //-----------------------------------------
        //private SaveActivity FillDataSaveActivity()
        //{
        //    SaveActivity obj_SaveActivity = new SaveActivity();
        //    obj_SaveActivity.SaveActivityID = 0;
        //    obj_SaveActivity.SaveActivityStatus = cmb_Status.SelectedText;
        //    obj_SaveActivity.SaveActivityDateOfLeave = dp_Leave.txtDate.Text;
        //    if (Switch_Back.Checked)
        //        obj_SaveActivity.SaveActivityDateOfBack = dp_Back.txtDate.Text;
        //    obj_SaveActivity.ID_FK_tbl_Driver = int.Parse(txt_PersonnelCode.Tag.ToString());
        //    obj_SaveActivity.SaveActivityDescription = txt_Description.Text;
        //    obj_SaveActivity.ID_FK_tbl_ManageDriver = int.Parse(txt_NameLastName.Tag.ToString()); ;
        //    return obj_SaveActivity;
        //}
        //-----------------------------------------
        private void ClearDate()
        {
            txt_PersonnelCode.Text = string.Empty;
            txt_PersonnelCode.Tag = string.Empty;
            txt_NameLastName.Text = string.Empty;
            txt_NameLastName.Tag = string.Empty;
            txt_Description.Text = string.Empty;
            cmb_Status.SelectedIndex = -1;
        }
        //-----------------------------------------
        private void SetSetting()
        {
            dgv_ManageDriver.Columns["SaveActivityID"].Visible = false;
            dgv_ManageDriver.Columns["ID_FK_tbl_Driver"].Visible = false;
            dgv_ManageDriver.Columns["ID_FK_tbl_ManageDriver"].Visible = false;
            dgv_ManageDriver.Columns["DriverNationalCode"].HeaderText ="کد ملی";
            dgv_ManageDriver.Columns["NameLastName"].HeaderText ="نام و نام خوانوادگی";
            dgv_ManageDriver.Columns["SaveActivityStatus"].HeaderText ="وضعیت";
            dgv_ManageDriver.Columns["SaveActivityDateOfLeave"].HeaderText ="تاریخ خروج";
            dgv_ManageDriver.Columns["SaveActivityDateOfBack"].HeaderText ="تاریخ برگشت";
            dgv_ManageDriver.Columns["SaveActivityDescription"].HeaderText ="توضیحات";
            //--------------
            dgv_ManageDriver.Columns["RowCount"].Width = 45;
        }
        //-----------------------------------------//
        //-----------------------------------------//
        private void frm_ManageDriver_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_ManageDriver, 15);
            txt_PersonnelCode.Tag = string.Empty;
            txt_NameLastName.Tag = string.Empty;
            OneRun();
        }

        private void Switch_Back_CheckedChanged(object sender, EventArgs e)
        {
            dp_Back.Enabled = Switch_Back.Checked;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_PersonnelCode.Tag!=string.Empty)
            {
                ActionMode(true);
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا راننده را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
        }

        private void pic_Search_Click(object sender, EventArgs e)
        {
            frm_DriverSearch f = new frm_DriverSearch();
            f.FormName ="جستجوی رانندگان";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Driver.Rows.Count > 0)
                {
                    if (f.dgv_Driver.CurrentRow.Cells["DriverPersonnelCode"].Value.ToString()!=string.Empty)
                    {
                        txt_PersonnelCode.Text = f.dgv_Driver.CurrentRow.Cells["DriverPersonnelCode"].Value.ToString();
                        txt_NameLastName.Text = f.dgv_Driver.CurrentRow.Cells["DriverName"].Value.ToString() + " " + f.dgv_Driver.CurrentRow.Cells["DriverLastName"].Value.ToString(); ;
                        txt_PersonnelCode.Tag = f.dgv_Driver.CurrentRow.Cells["DriverID"].Value.ToString();
                        FillControl();
                        GetList();
                    }
                    else
                    {
                        MsgBox.Show("این راننده کد پرسنلی ندارد.");
                    }
                }
            }
        }

        private void dgv_ManageDriver_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_ManageDriver.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void txt_PersonnelCode_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_PersonnelCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                BusinessDriver obj_BusinessDriver = new BusinessDriver();
                DataTable dtable = obj_BusinessDriver.SearchByField("DriverPersonnelCode",txt_PersonnelCode.Text.Trim());
                if (dtable.Rows.Count==1)
                {
                    txt_PersonnelCode.Text = dtable.Rows[0].Field<string>("DriverPersonnelCode");
                    txt_PersonnelCode.Tag = dtable.Rows[0].Field<int>("DriverID");
                    txt_NameLastName.Text = dtable.Rows[0].Field<string>("DriverName") +" "+dtable.Rows[0].Field<string>("DriverLastName");
                    FillControl();
                    GetList();
                }
            }
        }

        private void txt_PersonnelCode_TextChanged(object sender, EventArgs e)
        {
            if (txt_PersonnelCode.Tag != string.Empty)
            {
                txt_NameLastName.Text = string.Empty;
                txt_PersonnelCode.Tag = string.Empty;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            BusinessManageDriver obj_BusinessManageDriver = new BusinessManageDriver();
            if (obj_BusinessManageDriver.Update(FillDataManageDriver())==1)
            {
                GetList();
                ClearDate();
                ActionMode(false);
                MsgBox.Show("وضعیت جدید با موفقیت ثبت شد.");
            }
        }

        private void Switch_Leave_CheckedChanged(object sender, EventArgs e)
        {
            dp_Leave.Enabled = Switch_Leave.Checked;

        }

        private void dgv_ManageDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Description.Text = dgv_ManageDriver.CurrentRow.Cells["SaveActivityDescription"].Value.ToString();
        }
    }
}
