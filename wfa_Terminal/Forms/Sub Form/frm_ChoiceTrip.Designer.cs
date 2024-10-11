
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_ChoiceTrip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Price = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmb_PayType = new MaterialSkin.Controls.MaterialComboBox();
            this.lbl_NameLastName = new System.Windows.Forms.Label();
            this.lbl_NationalCode = new System.Windows.Forms.Label();
            this.lbl_InsertPassenger = new System.Windows.Forms.Label();
            this.btn_Insert = new MaterialSkin.Controls.MaterialButton();
            this.txt_SeatNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmb_Bank = new MaterialSkin.Controls.MaterialComboBox();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1363, 39);
            // 
            // pic_Min
            // 
            this.pic_Min.Location = new System.Drawing.Point(1082, 1);
            // 
            // pic_Exit
            // 
            this.pic_Exit.Location = new System.Drawing.Point(1121, 1);
            // 
            // pnl_Title
            // 
            this.pnl_Title.Location = new System.Drawing.Point(10, 55);
            this.pnl_Title.Size = new System.Drawing.Size(1134, 56);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(1124, 27);
            this.lbl_Title.Size = new System.Drawing.Size(0, 21);
            this.lbl_Title.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.cmb_PayType);
            this.panel1.Controls.Add(this.lbl_NameLastName);
            this.panel1.Controls.Add(this.lbl_NationalCode);
            this.panel1.Controls.Add(this.lbl_InsertPassenger);
            this.panel1.Controls.Add(this.btn_Insert);
            this.panel1.Controls.Add(this.txt_SeatNumber);
            this.panel1.Controls.Add(this.cmb_Bank);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 237);
            this.panel1.TabIndex = 6;
            // 
            // txt_Price
            // 
            this.txt_Price.AnimateReadOnly = false;
            this.txt_Price.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Price.Depth = 0;
            this.txt_Price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.HideSelection = true;
            this.txt_Price.Hint = "قیمت";
            this.txt_Price.LeadingIcon = null;
            this.txt_Price.Location = new System.Drawing.Point(1047, 119);
            this.txt_Price.MaxLength = 32767;
            this.txt_Price.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PrefixSuffixText = null;
            this.txt_Price.ReadOnly = false;
            this.txt_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Price.SelectedText = "";
            this.txt_Price.SelectionLength = 0;
            this.txt_Price.SelectionStart = 0;
            this.txt_Price.ShortcutsEnabled = true;
            this.txt_Price.ShowAssistiveText = true;
            this.txt_Price.Size = new System.Drawing.Size(248, 64);
            this.txt_Price.TabIndex = 121;
            this.txt_Price.TabStop = false;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Price.TrailingIcon = null;
            this.txt_Price.UseSystemPasswordChar = false;
            // 
            // cmb_PayType
            // 
            this.cmb_PayType.AutoResize = false;
            this.cmb_PayType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_PayType.Depth = 0;
            this.cmb_PayType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_PayType.DropDownHeight = 174;
            this.cmb_PayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PayType.DropDownWidth = 121;
            this.cmb_PayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_PayType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_PayType.FormattingEnabled = true;
            this.cmb_PayType.Hint = "روش پرداخت";
            this.cmb_PayType.IntegralHeight = false;
            this.cmb_PayType.ItemHeight = 43;
            this.cmb_PayType.Location = new System.Drawing.Point(330, 48);
            this.cmb_PayType.MaxDropDownItems = 4;
            this.cmb_PayType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_PayType.Name = "cmb_PayType";
            this.cmb_PayType.Size = new System.Drawing.Size(248, 49);
            this.cmb_PayType.StartIndex = 0;
            this.cmb_PayType.TabIndex = 120;
            // 
            // lbl_NameLastName
            // 
            this.lbl_NameLastName.AutoSize = true;
            this.lbl_NameLastName.Location = new System.Drawing.Point(949, 68);
            this.lbl_NameLastName.Name = "lbl_NameLastName";
            this.lbl_NameLastName.Size = new System.Drawing.Size(0, 18);
            this.lbl_NameLastName.TabIndex = 118;
            // 
            // lbl_NationalCode
            // 
            this.lbl_NationalCode.AutoSize = true;
            this.lbl_NationalCode.Location = new System.Drawing.Point(1075, 68);
            this.lbl_NationalCode.Name = "lbl_NationalCode";
            this.lbl_NationalCode.Size = new System.Drawing.Size(0, 18);
            this.lbl_NationalCode.TabIndex = 117;
            // 
            // lbl_InsertPassenger
            // 
            this.lbl_InsertPassenger.AutoSize = true;
            this.lbl_InsertPassenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_InsertPassenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lbl_InsertPassenger.Location = new System.Drawing.Point(1206, 68);
            this.lbl_InsertPassenger.Name = "lbl_InsertPassenger";
            this.lbl_InsertPassenger.Size = new System.Drawing.Size(92, 18);
            this.lbl_InsertPassenger.TabIndex = 116;
            this.lbl_InsertPassenger.Text = "افزودن مسافر";
            this.lbl_InsertPassenger.Click += new System.EventHandler(this.lbl_InsertPassenger_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Insert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Insert.Depth = 0;
            this.btn_Insert.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.HighEmphasis = true;
            this.btn_Insert.Icon = global::wfa_Terminal.Properties.Resources.row;
            this.btn_Insert.Location = new System.Drawing.Point(76, 137);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Insert.Size = new System.Drawing.Size(86, 36);
            this.btn_Insert.TabIndex = 109;
            this.btn_Insert.Text = "ثبت";
            this.btn_Insert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Insert.UseAccentColor = true;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_SeatNumber
            // 
            this.txt_SeatNumber.AnimateReadOnly = false;
            this.txt_SeatNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_SeatNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SeatNumber.Depth = 0;
            this.txt_SeatNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SeatNumber.HideSelection = true;
            this.txt_SeatNumber.Hint = "شماره صندلی";
            this.txt_SeatNumber.LeadingIcon = null;
            this.txt_SeatNumber.Location = new System.Drawing.Point(76, 49);
            this.txt_SeatNumber.MaxLength = 32767;
            this.txt_SeatNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_SeatNumber.Name = "txt_SeatNumber";
            this.txt_SeatNumber.PasswordChar = '\0';
            this.txt_SeatNumber.PrefixSuffixText = null;
            this.txt_SeatNumber.ReadOnly = false;
            this.txt_SeatNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SeatNumber.SelectedText = "";
            this.txt_SeatNumber.SelectionLength = 0;
            this.txt_SeatNumber.SelectionStart = 0;
            this.txt_SeatNumber.ShortcutsEnabled = true;
            this.txt_SeatNumber.ShowAssistiveText = true;
            this.txt_SeatNumber.Size = new System.Drawing.Size(248, 64);
            this.txt_SeatNumber.TabIndex = 108;
            this.txt_SeatNumber.TabStop = false;
            this.txt_SeatNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SeatNumber.TrailingIcon = null;
            this.txt_SeatNumber.UseSystemPasswordChar = false;
            // 
            // cmb_Bank
            // 
            this.cmb_Bank.AutoResize = false;
            this.cmb_Bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Bank.Depth = 0;
            this.cmb_Bank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Bank.DropDownHeight = 174;
            this.cmb_Bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bank.DropDownWidth = 121;
            this.cmb_Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Bank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Bank.FormattingEnabled = true;
            this.cmb_Bank.Hint = "بانک";
            this.cmb_Bank.IntegralHeight = false;
            this.cmb_Bank.ItemHeight = 43;
            this.cmb_Bank.Location = new System.Drawing.Point(584, 48);
            this.cmb_Bank.MaxDropDownItems = 4;
            this.cmb_Bank.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Bank.Name = "cmb_Bank";
            this.cmb_Bank.Size = new System.Drawing.Size(248, 49);
            this.cmb_Bank.StartIndex = 0;
            this.cmb_Bank.TabIndex = 107;
            // 
            // frm_ChoiceTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 368);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ChoiceTrip";
            this.Load += new System.EventHandler(this.frm_ChoiceTrip_Load);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialComboBox cmb_PayType;
        private System.Windows.Forms.Label lbl_NameLastName;
        private System.Windows.Forms.Label lbl_NationalCode;
        private System.Windows.Forms.Label lbl_InsertPassenger;
        private MaterialSkin.Controls.MaterialButton btn_Insert;
        private MaterialSkin.Controls.MaterialComboBox cmb_Bank;
        public MaterialSkin.Controls.MaterialTextBox2 txt_Price;
        public MaterialSkin.Controls.MaterialTextBox2 txt_SeatNumber;
    }
}