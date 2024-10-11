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
    public partial class frm_PayType : Forms.Master_Form.frm_SubMaster
    {
        public frm_PayType()
        {
            InitializeComponent();
        }
        private int ActiveID;

        private void GetList()
        {

            dgv_PayType.DataSource = new BusinessPayType().GetList();
            SetSetting();
            Cleartxt();
        }
        //------------------------------
        private void SetSetting()
        {
            dgv_PayType.Columns["PayTypeID"].Visible = false;
            dgv_PayType.Columns["PayTypeTitle"].HeaderText = "روش پرداخت";

        }
        //------------------------------
        private void Cleartxt()
        {
            txt_PayType.Text = string.Empty;
            txt_PayType.Tag = string.Empty;
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
            txt_PayType.Enabled = action;
            txt_PayType.Focus();
        }
        //-----------------------------------
        private bool TrueData()
        {
            bool result = true;
            if (txt_PayType.Text.Trim() == string.Empty)
            {
                result = false;
                txt_PayType.SetErrorState(true);
            }
            return result;
        }
        private void frm_PayType_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_PayType, 15);
            ActionMode(false);
            GetList();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Cleartxt();
            ActionMode(true);
            ActiveID = 0;
            txt_PayType.SetErrorState(false);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (TrueData() && txt_PayType.Tag != string.Empty)
            {
                txt_PayType.SetErrorState(false);

                ActionMode(true);
                ActiveID = int.Parse(txt_PayType.Tag.ToString());
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (TrueData() && txt_PayType.Tag != string.Empty)
            {
                if (MsgBox.Show("آیا مطمئن هستید که میخواهید این روش پرداخت را حذف کنید؟", "dffg", ButtonNumber.OKCancel) == DialogResult.OK)
                {
                    PayType obj_PayType = new PayType();
                    obj_PayType.PayTypeID = int.Parse(txt_PayType.Tag.ToString());
                    BusinessPayType obj_BusinessPayType = new BusinessPayType();
                    if (obj_BusinessPayType.Delete(obj_PayType) != 0)
                    {
                        GetList();
                        MsgBox.Show("روش پرداخت مورد نظر با موفقیت حذف شد.");
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
                    PayType obj_PayType = new PayType();

                    obj_PayType.PayTypeTitle = txt_PayType.Text.Trim();
                    BusinessPayType obj_BusinessPayType = new BusinessPayType();
                    if (obj_BusinessPayType.Insert(obj_PayType) != 0)
                    {
                        MsgBox.Show("روش پرداخت با موفقیت ثبت شد.");
                        GetList();
                    }
                    ActionMode(false);
                }

            }
            else
            {
                if (TrueData())
                {
                    PayType obj_PayType = new PayType();
                    obj_PayType.PayTypeID = int.Parse(txt_PayType.Tag.ToString());
                    obj_PayType.PayTypeTitle = txt_PayType.Text.Trim();
                    BusinessPayType obj_BusinessPayType = new BusinessPayType();
                    ActionMode(false);
                    if (obj_BusinessPayType.Update(obj_PayType) != 0)
                    {
                        GetList();
                        MsgBox.Show("روش پرداخت با موفقیت ویرایش شد.");
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
            Cleartxt();
        }

        private void dgv_Bank_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_PayType.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void dgv_Bank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_PayType.Text = dgv_PayType.CurrentRow.Cells["PayTypeTitle"].Value.ToString();
            txt_PayType.Tag = dgv_PayType.CurrentRow.Cells["PayTypeID"].Value.ToString();
            txt_PayType.SetErrorState(false);
        }

        private void txt_Bank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                btn_Submit_Click(btn_Submit, e2);

            }
        }
    }
}
