using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_Terminal.Forms.Sub_Form
{
    public partial class frm_PassengerForTicket : Forms.Master_Form.frm_SubMaster
    {
        public frm_PassengerForTicket()
        {
            InitializeComponent();
        }
        private bool TrueData()
        {
            bool result = true;
            if (txt_NationalCode.Text.Trim() == string.Empty)
            {
                result = false;
                txt_NationalCode.SetErrorState(true);
            }
            if (txt_Name.Text.Trim() == string.Empty)
            {
                result = false;
                txt_Name.SetErrorState(true);
            }
            if (txt_LastName.Text.Trim() == string.Empty)
            {
                result = false;
                txt_LastName.SetErrorState(true);
            }

            if (cmb_Sex.SelectedIndex == -1)
            {
                result = false;
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("لطفا جنسیت را مشخص کنید", "باشه", true);
                SnackBarMessage.Show(this);
            }
            if (txt_PhoneNumber.Text.Trim() == string.Empty)
            {
                result = false;
                txt_PhoneNumber.SetErrorState(true);
            }


            return result;
        }
        //-----------------------------
        private void OneRun()
        {
            cmb_Sex.Items.Add("زن");
            cmb_Sex.Items.Add("مرد");

        }
        
        private void frm_PassengerForTicket_Load(object sender, EventArgs e)
        {
            OneRun();
            pic_Exit.Click += new EventHandler( delegate (object sender2, EventArgs e2)
            {
                forfill = false;
            });

        }
        public int ID=0;
        private void txt_NationalCode_TextChanged(object sender, EventArgs e)
        {
            if (txt_NationalCode.Text.Length==10)
            {
                DataTable dtable_Passenger = new BusinessPassenger().SearchByField("PassengerNationalCode", txt_NationalCode.Text.Trim());
                if (dtable_Passenger.Rows.Count>0)
                {
                    txt_Name.Text = dtable_Passenger.Rows[0].Field<string>("PassengerName");
                    txt_LastName.Text = dtable_Passenger.Rows[0].Field<string>("PassengerLastName");
                    txt_PhoneNumber.Text = dtable_Passenger.Rows[0].Field<string>("PassengerMobileNumber");
                    cmb_Sex.SelectedIndex = cmb_Sex.FindStringExact(dtable_Passenger.Rows[0].Field<string>("PassengerSex"));
                    dp_Birthday.txtDate.Text = dtable_Passenger.Rows[0].Field<string>("PassengerBirthday");
                    txt_Gmail.Text = dtable_Passenger.Rows[0].Field<string>("PassengerEmail");
                    ID = dtable_Passenger.Rows[0].Field<int>("PassengerID");
                    cmb_Sex.Enabled = false;
                    cmb_Sex.Enabled = true;
                }
            }
            else
            {
                txt_NationalCode.Tag = string.Empty;
                txt_Name.Text = string.Empty;
                txt_LastName.Text = string.Empty;
                txt_Gmail.Text = string.Empty;
                txt_PhoneNumber.Text = string.Empty;
                cmb_Sex.SelectedIndex = -1;
                cmb_Sex.Enabled = false;
                cmb_Sex.Enabled = true;
                ID = 0;
            }
        }
        public bool forfill=false;

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (ID==0)
            {
                Passenger obj_Passenger = new Passenger();
                obj_Passenger.PassengerBirthday = dp_Birthday.txtDate.Text;
                obj_Passenger.PassengerEmail = txt_Gmail.Text;
                obj_Passenger.PassengerLastName = txt_LastName.Text.Trim();
                obj_Passenger.PassengerMobileNumber = txt_PhoneNumber.Text.Trim();
                obj_Passenger.PassengerName = txt_Name.Text.Trim();
                obj_Passenger.PassengerNationalCode = txt_NationalCode.Text.Trim();
                //------------------------
                PersianCalendar p = new PersianCalendar();
                obj_Passenger.PassengerRegister = p.GetDateString(DateTime.Now) + " " + DateTime.Now.TimeOfDay;
                //------------------------
                obj_Passenger.PassengerSex = cmb_Sex.SelectedIndex == 1;
                BusinessPassenger obj_BusinessPassenger = new BusinessPassenger();
                if ((ID=obj_BusinessPassenger.Insert(obj_Passenger))!=0)
                {
                    MsgBox.Show("مسافر مورد نظر با موفقیت ثبت شد.");
                    forfill = true;
                    this.Close();
                }
            }
            else
            {
                forfill = true;
                this.Close();
            }
        }

        private void btn_MoreSearch_Click(object sender, EventArgs e)
        {
            frm_PassengerSearch f = new frm_PassengerSearch();
            f.FormName = "جستجوی مسافر";
            f.ShowDialog();
            if (f.forfill)
            {
                if (f.dgv_Passenger.Rows.Count > 0)
                {
                    txt_NationalCode.Tag = f.dgv_Passenger.CurrentRow.Cells["PassengerID"].Value.ToString();
                    ID = int.Parse(f.dgv_Passenger.CurrentRow.Cells["PassengerID"].Value.ToString());
                    txt_NationalCode.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerNationalCode"].Value.ToString();
                    txt_Name.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerName"].Value.ToString();
                    txt_LastName.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerLastName"].Value.ToString();
                    txt_PhoneNumber.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerMobileNumber"].Value.ToString();
                    cmb_Sex.SelectedIndex = cmb_Sex.FindStringExact(f.dgv_Passenger.CurrentRow.Cells["PassengerSex"].Value.ToString());                   
                    dp_Birthday.txtDate.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerBirthday"].Value.ToString();
                    txt_Gmail.Text = f.dgv_Passenger.CurrentRow.Cells["PassengerEmail"].Value.ToString();
                    forfill = true;
                    cmb_Sex.Enabled = false;
                    cmb_Sex.Enabled = true;
                }
            }
        }
    }
}
