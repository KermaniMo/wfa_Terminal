using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------------------------


namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_Degree : Forms.Master_Form.frm_SubMaster
    {
        public frm_Degree()
        {
            InitializeComponent();
             

        }
        private int ActiveID;

        private void GetList()
        {

            dgv_Degree.DataSource = new BusinessDegree().GetList();
            SetSetting();
            Cleartxt();
        }
        //------------------------------
        private void SetSetting()
        {
            dgv_Degree.Columns["DegreeID"].Visible = false;
            dgv_Degree.Columns["DegreeTitle"].HeaderText = "مدرک";

        }
        //------------------------------
        private void Cleartxt()
        {
            txt_Degree.Text = string.Empty;
            txt_Degree.Tag = string.Empty;
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
            txt_Degree.Enabled = action;
            txt_Degree.Focus();
        }
        //-----------------------------------
        private bool TrueData()
        {
            bool result = true;
            if (txt_Degree.Text.Trim()==string.Empty)
            {
                result = false;
                txt_Degree.SetErrorState(true);
            }
            return result;
        }

        private void frm_Degree2_Load(object sender, EventArgs e)
        {
             
            panel1.Height =this.Height- pnl_Title.Location.Y-pnl_Title.Height-10 ;
            RoundControl(dgv_Degree,15);
            ActionMode(false);
            GetList();
        }

        private void dgv_Degree_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgv_Degree.Rows[e.RowIndex].Cells["RowCount"].Value = e.RowIndex + 1;
        }

        private void dgv_Degree_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Degree.Text = dgv_Degree.CurrentRow.Cells["DegreeTitle"].Value.ToString();
            txt_Degree.Tag =  dgv_Degree.CurrentRow.Cells["DegreeID"].Value.ToString();
            txt_Degree.SetErrorState(false);
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Cleartxt();
            ActionMode(true);
            ActiveID = 0;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (ActiveID == 0)
            {
                if (TrueData())
                {
                    Degree obj_Degree = new Degree();

                    obj_Degree.DegreeTitle = txt_Degree.Text.Trim();
                    BusinessDegree obj_BusinessDegree = new BusinessDegree();
                    if (obj_BusinessDegree.Insert(obj_Degree) != 0)
                    {
                        MsgBox.Show("مدرک با موفقیت ثبت شد.");
                        GetList();
                    }
                    ActionMode(false);
                }

            }
            else
            {
                if (TrueData())
                {
                    Degree obj_Degree = new Degree();
                    obj_Degree.DegreeID = int.Parse(txt_Degree.Tag.ToString());
                    obj_Degree.DegreeTitle = txt_Degree.Text.Trim();
                    BusinessDegree obj_BusinessDegree = new BusinessDegree();
                    ActionMode(false);
                    if (obj_BusinessDegree.Update(obj_Degree) != 0)
                    {
                        GetList();
                        MsgBox.Show("مدرک با موفقیت ویرایش شد.");
                    }
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (TrueData() && txt_Degree.Tag != string.Empty)
            {
                ActionMode(true);
                ActiveID = int.Parse(txt_Degree.Tag.ToString());
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActionMode(false);
            Cleartxt();
        }

        private void txt_Degree_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (TrueData()  && txt_Degree.Tag!=string.Empty)
            {
                if( MsgBox.Show("آیا مطمئن هستید که میخواهید این مدرک را حذف کنید؟", "dffg", ButtonNumber.OKCancel) == DialogResult.OK)
                {
                    Degree obj_Degree = new Degree();
                    obj_Degree.DegreeID = int.Parse(txt_Degree.Tag.ToString());
                    BusinessDegree obj_BusinessDegree = new BusinessDegree();
                    if(obj_BusinessDegree.Delete(obj_Degree)!=0)
                    {
                        GetList();                         
                        MsgBox.Show("مدرک مورد نظر با موفقیت حذف شد.");
                    }
                }
            }
        }

        private void txt_Degree_Enter(object sender, EventArgs e)
        {
            txt_Degree.SetErrorState(false);
        }

        private void txt_Degree_KeyPress(object sender, KeyPressEventArgs e)
        {
              
        }

        private void txt_Degree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                EventArgs e2 = new EventArgs();
                btn_Submit_Click(btn_Submit, e2);

            }
        }
    }
}
