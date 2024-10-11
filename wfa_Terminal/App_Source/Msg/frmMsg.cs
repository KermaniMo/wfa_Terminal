using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------
using System.Windows.Forms;
namespace wfa_Zabansara2.App_Source.Additional
{
    
    class frmMsg : wfa_Terminal.Forms.Master_Form.frm_Master
    {
        string _title;
        public string title
        {
            set { _title = value; }
        }
         
        public frmMsg( )
        {
            this.Text = string.Empty;
            this.Width = 514;
            this.Height = 302;
            InitializeComponents( );
        }
         
       public Button btn_OK = new Button();
       public Button btn_Cancel = new Button();
       public Label lbl_Msg = new Label();
         
        public void InitializeComponents( )
        {
            this.pic_Exit.Visible = false;
            this.pic_Min.Visible = false;


            // lbl_Msg
            // 
            lbl_Msg.AutoSize = true;
            lbl_Msg.Location = new System.Drawing.Point(190, 123);
            lbl_Msg.Name = "labMsg";
            lbl_Msg.Size = new System.Drawing.Size(42, 16);
            lbl_Msg.TabIndex = 2;
            lbl_Msg.Text = "label1";
            // 
            // btn_OK
            // 
            btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_OK.Image = global::wfa_Terminal.Properties.Resources.BtnOk; 
            btn_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_OK.Location = new System.Drawing.Point(212, 180);
            btn_OK.Name = "BtnOk";
            btn_OK.Size = new System.Drawing.Size(75, 45);
            btn_OK.TabIndex = 3;
            btn_OK.Text = "تأیید";
            btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += new EventHandler ( delegate (object sender, EventArgs e) { this.Close(); });
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = System.Drawing.Color.White;
            btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Cancel.Image = global::wfa_Terminal.Properties.Resources.x;
            btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_Cancel.Location = new System.Drawing.Point(131, 180);
            btn_Cancel.Name = "BtnCancel";
            btn_Cancel.Size = new System.Drawing.Size(75, 45);
            btn_Cancel.TabIndex = 4;
            btn_Cancel.Text = "لغو";
            btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += new System.EventHandler(delegate (object sender, EventArgs e) { this.Close(); });
            // 
            // FrmMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 249);
            
            this.Controls.Add(btn_OK);
            this.Controls.Add(btn_Cancel);
            this.Controls.Add(lbl_Msg);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMsg";
            this.Load += new System.EventHandler(this.FrmMsg_Load);
            this.Controls.SetChildIndex(lbl_Msg, 0);
            this.Controls.SetChildIndex(btn_OK, 0);
            this.Controls.SetChildIndex(btn_Cancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public int ButtonCount = 1;

        private void FrmMsg_Load(object sender, EventArgs e)
        {
            if (ButtonCount == 1)
            {
                btn_Cancel.Visible = false;
                btn_OK.Left = this.Width / 2 - btn_OK.Width / 2;
            }
            else
            {
                btn_Cancel.Visible = true;
            }
            lbl_Msg.Left = this.Width / 2 - lbl_Msg.Width / 2;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Exit
            // 
            this.pic_Exit.Location = new System.Drawing.Point(867, 1);
            // 
            // pic_Min
            // 
            this.pic_Min.Location = new System.Drawing.Point(830, 1);
            // 
            // frmMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Name = "frmMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMsg_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void frmMsg_Load_1(object sender, EventArgs e)
        {
        }
    }



    }

