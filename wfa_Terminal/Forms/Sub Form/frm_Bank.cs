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
    public partial class frm_Bank : Forms.Master_Form.frm_SubMaster
    {
        public frm_Bank()
        {
            InitializeComponent();
        }
        private int ActiveID;

        private void GetList()
        {

            dgv_Bank.DataSource = new BusinessBank().GetList();
            SetSetting();
            Cleartxt();
        }
        //------------------------------
        private void SetSetting()
        {
            dgv_Bank.Columns["BankID"].Visible = false;
            dgv_Bank.Columns["BankTitle"].HeaderText = "بانک";

        }
        //------------------------------
        private void Cleartxt()
        {
            txt_Bank.Text = string.Empty;
            txt_Bank.Tag = string.Empty;
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
            txt_Bank.Enabled = action;
            txt_Bank.Focus();
        }
        //-----------------------------------
        private bool TrueData()
        {
            bool result = true;
            if (txt_Bank.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Bank.SetErrorState(true);
            }
            return result;
        }
        private void frm_Bank_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height - pnl_Title.Location.Y - pnl_Title.Height - 10;
            RoundControl(dgv_Bank, 15);
            ActionMode(false);
            GetList();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Cleartxt();
            ActionMode(true);
            ActiveID = 0;
            txt_Bank.SetErrorState (false);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (TrueData() && txt_Bank.Tag != string.Empty)
            {
                txt_Bank.SetErrorState(false);

                ActionMode(true);
                ActiveID = int.Parse(txt_Bank.Tag.ToString());
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (TrueData() && txt_Bank.Tag != string.Empty)
            {
                if (MsgBox.Show("آیا مطمئن هستید که میخواهید این بانک را حذف کنید؟", "dffg", ButtonNumber.OKCancel) == DialogResult.OK)
                {
                    Bank obj_Bank = new Bank();
                    obj_Bank.BankID = int.Parse(txt_Bank.Tag.ToString());
                    BusinessBank obj_BusinessBank = new BusinessBank();
                    if (obj_BusinessBank.Delete(obj_Bank) != 0)
                    {
                        GetList();
                        MsgBox.Show("بانک مورد نظر با موفقیت حذف شد.");
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
                    Bank obj_Bank = new Bank();

                    obj_Bank.BankTitle = txt_Bank.Text.Trim();
                    BusinessBank obj_BusinessBank = new BusinessBank();
                    if (obj_BusinessBank.Insert(obj_Bank) != 0)
                    {
                        MsgBox.Show("بانک با موفقیت ثبت شد.");
                        GetList();
                    }
                    ActionMode(false);
                }

            }
            else
            {
                if (TrueData())
                {
                    Bank obj_Bank = new Bank();
                    obj_Bank.BankID = int.Parse(txt_Bank.Tag.ToString());
                    obj_Bank.BankTitle = txt_Bank.Text.Trim();
                    BusinessBank obj_BusinessBank = new BusinessBank();
                    ActionMode(false);
                    if (obj_BusinessBank.Update(obj_Bank) != 0)
                    {
                        GetList();
                        MsgBox.Show("بانک با موفقیت ویرایش شد.");
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
            Cleartxt();
        }

        private void dgv_Degree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Bank.Text = dgv_Bank.CurrentRow.Cells["BankTitle"].Value.ToString();
            txt_Bank.Tag = dgv_Bank.CurrentRow.Cells["BankID"].Value.ToString();
            txt_Bank.SetErrorState(false);
        }

        private void dgv_Degree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Bank.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;

        }

        private void txt_Bank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                btn_Submit_Click(btn_Submit, e2);

            }
        }

        private void pnl_Title_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
