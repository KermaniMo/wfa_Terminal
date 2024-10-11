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
    public partial class frm_CarType : Forms.Master_Form.frm_SubMaster
    {
        public frm_CarType()
        {
            InitializeComponent();
        }
        private int ActiveID;

        private void GetList()
        {

            dgv_CarType.DataSource = new BusinessCarType().GetList();
            SetSetting();
            Cleartxt();
        }
        //------------------------------
        private void SetSetting()
        {
            dgv_CarType.Columns["CarsTypeID"].Visible = false;
            dgv_CarType.Columns["TypeName"].HeaderText = "نوع ماشین";

        }
        //------------------------------
        private void Cleartxt()
        {
            txt_CarType.Text = string.Empty;
            txt_CarType.Tag = string.Empty;
        }
        //------------------------------
        private void ActionMode(bool action)
        {
            btn_Cancel.Visible = action;
            btn_Submit.Visible = action;
            //---------------//
            btn_Insert.Visible = !action;
            btn_Edit.Visible = !action;
            btn_Delete.Visible = !action;
            //---------------//
            txt_CarType.Enabled = action;
            txt_CarType.Focus();
        }
        //-----------------------------------
        private bool TrueData()
        {
            bool result = true;
            if (txt_CarType.Text.Trim() == string.Empty)
            {
                result = false;
                txt_CarType.SetErrorState(true);
            }
            return result;
        }
        private void frm_CarType_Load(object sender, EventArgs e)
        {

            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_CarType, 15);
            ActionMode(false);
            GetList();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Cleartxt();
            ActionMode(true);
            ActiveID = 0;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (TrueData() && txt_CarType.Tag != string.Empty)
            {
                ActionMode(true);
                ActiveID = int.Parse(txt_CarType.Tag.ToString());
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (TrueData() && txt_CarType.Tag != string.Empty)
            {
                if (MsgBox.Show("آیا مطمئن هستید که میخواهید این نوع ماشین را حذف کنید؟", "dffg", ButtonNumber.OKCancel) == DialogResult.OK)
                {
                    
                    CarType obj_CarType = new CarType();
                    obj_CarType.CarsTypeID = int.Parse(txt_CarType.Tag.ToString());
                    BusinessCarType obj_BusinessCarType = new BusinessCarType();
                    if (obj_BusinessCarType.Delete(obj_CarType) != 0)
                    {
                        GetList();
                        MsgBox.Show("نوع ماشین مورد نظر با موفقیت حذف شد.");
                    }
                }
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (ActiveID == 0)
            {
                if (TrueData())
                {
                    CarType obj_CarType = new CarType();

                    obj_CarType.TypeName = txt_CarType.Text.Trim();
                    BusinessCarType obj_BusinessCarType = new BusinessCarType();
                    if (obj_BusinessCarType.Insert(obj_CarType) != 0)
                    {
                        MsgBox.Show("نوع ماشین با موفقیت ثبت شد.");
                        GetList();
                    }
                    ActionMode(false);
                }

            }
            else
            {
                if (TrueData())
                {
                    CarType obj_CarType = new CarType();
                    obj_CarType.CarsTypeID = int.Parse(txt_CarType.Tag.ToString());
                    obj_CarType.TypeName = txt_CarType.Text.Trim();
                    BusinessCarType obj_BusinessCarType = new BusinessCarType();
                    ActionMode(false);
                    if (obj_BusinessCarType.Update(obj_CarType) != 0)
                    {
                        GetList();
                        MsgBox.Show("نوع ماشین با موفقیت ویرایش شد.");
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
            Cleartxt();
        }

        private void dgv_CarType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CarType.Text = dgv_CarType.CurrentRow.Cells["TypeName"].Value.ToString();
            txt_CarType.Tag = dgv_CarType.CurrentRow.Cells["CarsTypeID"].Value.ToString();
            txt_CarType.SetErrorState(false);
        }

        private void dgv_CarType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_CarType.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void txt_CarType_Enter(object sender, EventArgs e)
        {
            txt_CarType.SetErrorState(false);

        }

        private void txt_CarType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                btn_Submit_Click(btn_Submit, e2);

            }
        }
    }
}
