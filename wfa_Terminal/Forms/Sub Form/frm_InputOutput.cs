using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---------------------------------
using System.Globalization;
using System.Text.RegularExpressions;
using MaterialSkin.Controls;

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_InputOutput : Forms.Master_Form.frm_SubMaster
    {
        public frm_InputOutput()
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
            dgv_InputOutput.Enabled = !action;
            //---------------//

            Switch_Date.Enabled = action;
            Switch_Time.Enabled = action;
            txt_PersonnelCode.Enabled = !action;
            txt_Description.Enabled = action;
            cmb_Status.Enabled = action;
            Switch_Date.Checked = false;
            Switch_Time.Checked = false;
            pic_Search.Enabled = !action;
        }
        //-----------------------------------------
        private void OneRun()
        {
            cmb_Status.Items.Add("ورودی");
            cmb_Status.Items.Add("خروجی");
             
        }
        //----------------------------------------
        private void FillControl()
        {
            if (txt_PersonnelCode.Tag != string.Empty)
            {
                DataTable dtable = new BusinessInputOutput().SearchByField("ID_FK_tbl_Driver", txt_PersonnelCode.Tag.ToString());
                if (dtable.Rows.Count > 0)
                {
                    cmb_Status.SelectedIndex = cmb_Status.FindStringExact(dtable.Rows[0].Field<string>("InputOutputStatus"));
                    cmb_Status.Enabled = true;
                    cmb_Status.Enabled = false;
                    //---------------------------------
                    string datetimeinou = dtable.Rows[0].Field<string>("InputOutputDateTime");
                    Regex r = new Regex("[0-9]{4}/[0-9]{1,2}/[0-9]{1,2}");
                    Match m = r.Match(datetimeinou);
                    dp_Time.txtDate.Text = m.Value;
                    r = new Regex("[0-9]{1,2}:[0-9]{1,9}:[0-9]{1,2}");
                    m = r.Match(datetimeinou);
                    tp_Time.Text = m.Value;
                    //---------------------------------
                    txt_Description.Text = dtable.Rows[0].Field<string>("InputOutputDescription");
                    txt_NameLastName.Tag = dtable.Rows[0].Field<int>("InputOutputID").ToString();
                }
            }
        }
        //-----------------------------------------
        private void GetList()
        {
            if (txt_PersonnelCode.Tag != string.Empty)
            {
                dgv_InputOutput.DataSource = new BusinessInputOutput().SearchByField("ID_FK_tbl_Driver", txt_PersonnelCode.Tag.ToString());
                SetSetting();
            }
        }
        //-----------------------------------------
        private InputOutput FillDataInputOutput()
        {
            InputOutput obj_InputOutput = new InputOutput();
            //obj_InputOutput.InputOutputID = int.Parse(txt_NameLastName.Tag.ToString());
            obj_InputOutput.InputOutputStatus = Convert.ToInt32(cmb_Status.SelectedIndex.ToString())==1;
            if (Switch_Date.Checked)
                obj_InputOutput.InputOutputDateTime = dp_Time.txtDate.Text;
            else
            {
                PersianCalendar p = new PersianCalendar();
                obj_InputOutput.InputOutputDateTime = p.GetDateString(DateTime.Now);
            }
            if (Switch_Time.Checked)
                obj_InputOutput.InputOutputDateTime +=" "+ tp_Time.Value.TimeOfDay.ToString();
            else
                obj_InputOutput.InputOutputDateTime +=" "+ DateTime.Now.TimeOfDay;
            obj_InputOutput.ID_FK_tbl_Driver = int.Parse(txt_PersonnelCode.Tag.ToString());
            obj_InputOutput.InputOutputDescription = txt_Description.Text;
            return obj_InputOutput;
        }
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
            dgv_InputOutput.Columns["InputOutputID"].Visible = false;
            dgv_InputOutput.Columns["ID_FK_tbl_Driver"].Visible = false;             
            dgv_InputOutput.Columns["DriverNationalCode"].HeaderText = "کد ملی";
            dgv_InputOutput.Columns["NameLastName"].HeaderText = "نام و نام خوانوادگی";
            dgv_InputOutput.Columns["InputOutputStatus"].HeaderText = "وضعیت";
            dgv_InputOutput.Columns["InputOutputDateTime"].HeaderText = "تاریخ و ساعت";         
            dgv_InputOutput.Columns["InputOutputDescription"].HeaderText = "توضیحات";
            //--------------
            dgv_InputOutput.Columns["RowCount"].Width = 45;
            dgv_InputOutput.Columns["InputOutputDateTime"].Width = 170;
            
        }
        //-----------------------------------------//
        //-----------------------------------------//
         
        private void frm_InputOutput_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_InputOutput, 15);
            txt_PersonnelCode.Tag = string.Empty;
            txt_NameLastName.Tag = string.Empty;
            OneRun();
        }

        private void Switch_Back_CheckedChanged(object sender, EventArgs e)
        {
            tp_Time.Enabled = Switch_Time.Checked;
        }

        private void Switch_Date_CheckedChanged(object sender, EventArgs e)
        {
            dp_Time.Enabled = Switch_Date.Checked;
        }

        private void pic_Search_Click(object sender, EventArgs e)
        {
            frm_DriverSearch f = new frm_DriverSearch();
            f.FormName = "جستجوی رانندگان";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Driver.Rows.Count > 0)
                {
                    if (f.dgv_Driver.CurrentRow.Cells["DriverPersonnelCode"].Value.ToString() != string.Empty)
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

        private void txt_PersonnelCode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_PersonnelCode_TextChanged(object sender, EventArgs e)
        {
            if (txt_PersonnelCode.Tag != string.Empty)
            {
                txt_NameLastName.Text = string.Empty;
                txt_PersonnelCode.Tag = string.Empty;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_PersonnelCode.Tag != string.Empty)
            {
                ActionMode(true);
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا راننده را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            BusinessInputOutput obj_BusinessInputOutput = new BusinessInputOutput();
            if (obj_BusinessInputOutput.Insert(FillDataInputOutput()) == 1)
            {
                GetList();
                ClearDate();
                ActionMode(false);
                MsgBox.Show("ورودی خروجی جدید با موفقیت ثبت شد.");
            }
        }

        private void dgv_InputOutput_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_InputOutput.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
           
        }

        private void dgv_InputOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
