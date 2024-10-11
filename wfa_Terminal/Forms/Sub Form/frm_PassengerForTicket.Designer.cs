
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_PassengerForTicket
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
            this.txt_Gmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_LastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_PhoneNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dp_Birthday = new PersianDate.DatePicker();
            this.cmb_Sex = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_Name = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_NationalCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_MoreSearch = new MaterialSkin.Controls.MaterialButton();
            this.btn_Insert = new MaterialSkin.Controls.MaterialButton();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1340, 39);
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
            // txt_Gmail
            // 
            this.txt_Gmail.AnimateReadOnly = false;
            this.txt_Gmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Gmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Gmail.Depth = 0;
            this.txt_Gmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gmail.HideSelection = true;
            this.txt_Gmail.Hint = "ایمیل";
            this.txt_Gmail.LeadingIcon = null;
            this.txt_Gmail.Location = new System.Drawing.Point(1074, 199);
            this.txt_Gmail.MaxLength = 32767;
            this.txt_Gmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Gmail.Name = "txt_Gmail";
            this.txt_Gmail.PasswordChar = '\0';
            this.txt_Gmail.PrefixSuffixText = null;
            this.txt_Gmail.ReadOnly = false;
            this.txt_Gmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Gmail.SelectedText = "";
            this.txt_Gmail.SelectionLength = 0;
            this.txt_Gmail.SelectionStart = 0;
            this.txt_Gmail.ShortcutsEnabled = true;
            this.txt_Gmail.ShowAssistiveText = true;
            this.txt_Gmail.Size = new System.Drawing.Size(248, 64);
            this.txt_Gmail.TabIndex = 26;
            this.txt_Gmail.TabStop = false;
            this.txt_Gmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Gmail.TrailingIcon = null;
            this.txt_Gmail.UseSystemPasswordChar = false;
            // 
            // txt_LastName
            // 
            this.txt_LastName.AnimateReadOnly = false;
            this.txt_LastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_LastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_LastName.Depth = 0;
            this.txt_LastName.ErrorMessage = "نامعتبر";
            this.txt_LastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.HideSelection = true;
            this.txt_LastName.Hint = "نام خانوادگی";
            this.txt_LastName.LeadingIcon = null;
            this.txt_LastName.Location = new System.Drawing.Point(832, 129);
            this.txt_LastName.MaxLength = 32767;
            this.txt_LastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.PasswordChar = '\0';
            this.txt_LastName.PrefixSuffixText = null;
            this.txt_LastName.ReadOnly = false;
            this.txt_LastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_LastName.SelectedText = "";
            this.txt_LastName.SelectionLength = 0;
            this.txt_LastName.SelectionStart = 0;
            this.txt_LastName.ShortcutsEnabled = true;
            this.txt_LastName.ShowAssistiveText = true;
            this.txt_LastName.Size = new System.Drawing.Size(115, 64);
            this.txt_LastName.TabIndex = 21;
            this.txt_LastName.TabStop = false;
            this.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_LastName.TrailingIcon = null;
            this.txt_LastName.UseSystemPasswordChar = false;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.AllowPromptAsInput = true;
            this.txt_PhoneNumber.AnimateReadOnly = false;
            this.txt_PhoneNumber.AsciiOnly = false;
            this.txt_PhoneNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_PhoneNumber.BeepOnError = false;
            this.txt_PhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_PhoneNumber.Depth = 0;
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PhoneNumber.HidePromptOnLeave = true;
            this.txt_PhoneNumber.HideSelection = false;
            this.txt_PhoneNumber.Hint = "شماره تلفن";
            this.txt_PhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_PhoneNumber.LeadingIcon = global::wfa_Terminal.Properties.Resources.round_phone_black_24dp;
            this.txt_PhoneNumber.Location = new System.Drawing.Point(19, 129);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PhoneNumber.Mask = "00000000000";
            this.txt_PhoneNumber.MaxLength = 32767;
            this.txt_PhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.PasswordChar = '\0';
            this.txt_PhoneNumber.PrefixSuffixText = null;
            this.txt_PhoneNumber.PromptChar = '_';
            this.txt_PhoneNumber.ReadOnly = false;
            this.txt_PhoneNumber.RejectInputOnFirstFailure = true;
            this.txt_PhoneNumber.ResetOnPrompt = true;
            this.txt_PhoneNumber.ResetOnSpace = true;
            this.txt_PhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_PhoneNumber.SelectedText = "";
            this.txt_PhoneNumber.SelectionLength = 0;
            this.txt_PhoneNumber.SelectionStart = 0;
            this.txt_PhoneNumber.ShortcutsEnabled = true;
            this.txt_PhoneNumber.Size = new System.Drawing.Size(248, 48);
            this.txt_PhoneNumber.SkipLiterals = true;
            this.txt_PhoneNumber.TabIndex = 24;
            this.txt_PhoneNumber.TabStop = false;
            this.txt_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_PhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_PhoneNumber.TrailingIcon = null;
            this.txt_PhoneNumber.UseSystemPasswordChar = false;
            this.txt_PhoneNumber.ValidatingType = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "تاریخ تولد";
            // 
            // dp_Birthday
            // 
            this.dp_Birthday.Date = "1403/06/15";
            this.dp_Birthday.FocusColor = System.Drawing.Color.White;
            this.dp_Birthday.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Birthday.Location = new System.Drawing.Point(292, 142);
            this.dp_Birthday.Name = "dp_Birthday";
            this.dp_Birthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Birthday.Size = new System.Drawing.Size(200, 24);
            this.dp_Birthday.TabIndex = 23;
            // 
            // cmb_Sex
            // 
            this.cmb_Sex.AutoResize = false;
            this.cmb_Sex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Sex.Depth = 0;
            this.cmb_Sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Sex.DropDownHeight = 174;
            this.cmb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sex.DropDownWidth = 121;
            this.cmb_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Sex.FormattingEnabled = true;
            this.cmb_Sex.Hint = "جنسیت";
            this.cmb_Sex.IntegralHeight = false;
            this.cmb_Sex.ItemHeight = 43;
            this.cmb_Sex.Location = new System.Drawing.Point(578, 129);
            this.cmb_Sex.MaxDropDownItems = 4;
            this.cmb_Sex.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Sex.Name = "cmb_Sex";
            this.cmb_Sex.Size = new System.Drawing.Size(248, 49);
            this.cmb_Sex.StartIndex = 0;
            this.cmb_Sex.TabIndex = 22;
            // 
            // txt_Name
            // 
            this.txt_Name.AnimateReadOnly = false;
            this.txt_Name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Name.Depth = 0;
            this.txt_Name.ErrorMessage = "نامعتبر";
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.HideSelection = true;
            this.txt_Name.Hint = "نام";
            this.txt_Name.LeadingIcon = null;
            this.txt_Name.Location = new System.Drawing.Point(953, 129);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.PrefixSuffixText = null;
            this.txt_Name.ReadOnly = false;
            this.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Name.SelectedText = "";
            this.txt_Name.SelectionLength = 0;
            this.txt_Name.SelectionStart = 0;
            this.txt_Name.ShortcutsEnabled = true;
            this.txt_Name.ShowAssistiveText = true;
            this.txt_Name.Size = new System.Drawing.Size(115, 64);
            this.txt_Name.TabIndex = 20;
            this.txt_Name.TabStop = false;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Name.TrailingIcon = null;
            this.txt_Name.UseSystemPasswordChar = false;
            // 
            // txt_NationalCode
            // 
            this.txt_NationalCode.AnimateReadOnly = false;
            this.txt_NationalCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_NationalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_NationalCode.Depth = 0;
            this.txt_NationalCode.ErrorMessage = "نامعتبر";
            this.txt_NationalCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NationalCode.HideSelection = true;
            this.txt_NationalCode.Hint = "کد ملی";
            this.txt_NationalCode.LeadingIcon = null;
            this.txt_NationalCode.Location = new System.Drawing.Point(1074, 129);
            this.txt_NationalCode.MaxLength = 10;
            this.txt_NationalCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_NationalCode.Name = "txt_NationalCode";
            this.txt_NationalCode.PasswordChar = '\0';
            this.txt_NationalCode.PrefixSuffixText = null;
            this.txt_NationalCode.ReadOnly = false;
            this.txt_NationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NationalCode.SelectedText = "";
            this.txt_NationalCode.SelectionLength = 0;
            this.txt_NationalCode.SelectionStart = 0;
            this.txt_NationalCode.ShortcutsEnabled = true;
            this.txt_NationalCode.ShowAssistiveText = true;
            this.txt_NationalCode.Size = new System.Drawing.Size(248, 64);
            this.txt_NationalCode.TabIndex = 19;
            this.txt_NationalCode.TabStop = false;
            this.txt_NationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NationalCode.TrailingIcon = null;
            this.txt_NationalCode.UseSystemPasswordChar = false;
            this.txt_NationalCode.TextChanged += new System.EventHandler(this.txt_NationalCode_TextChanged);
            // 
            // btn_MoreSearch
            // 
            this.btn_MoreSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_MoreSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_MoreSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_MoreSearch.Depth = 0;
            this.btn_MoreSearch.HighEmphasis = true;
            this.btn_MoreSearch.Icon = null;
            this.btn_MoreSearch.Location = new System.Drawing.Point(19, 227);
            this.btn_MoreSearch.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_MoreSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_MoreSearch.Name = "btn_MoreSearch";
            this.btn_MoreSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_MoreSearch.Size = new System.Drawing.Size(102, 36);
            this.btn_MoreSearch.TabIndex = 28;
            this.btn_MoreSearch.Text = "جستجوی بیشتر";
            this.btn_MoreSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_MoreSearch.UseAccentColor = false;
            this.btn_MoreSearch.UseVisualStyleBackColor = false;
            this.btn_MoreSearch.Click += new System.EventHandler(this.btn_MoreSearch_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Insert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Insert.Depth = 0;
            this.btn_Insert.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.HighEmphasis = true;
            this.btn_Insert.Icon = global::wfa_Terminal.Properties.Resources.row;
            this.btn_Insert.Location = new System.Drawing.Point(162, 227);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Insert.Size = new System.Drawing.Size(68, 36);
            this.btn_Insert.TabIndex = 29;
            this.btn_Insert.Text = "ثبت";
            this.btn_Insert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Insert.UseAccentColor = true;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // frm_PassengerForTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 333);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_MoreSearch);
            this.Controls.Add(this.txt_Gmail);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dp_Birthday);
            this.Controls.Add(this.cmb_Sex);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_NationalCode);
            this.Name = "frm_PassengerForTicket";
            this.Load += new System.EventHandler(this.frm_PassengerForTicket_Load);
            this.Controls.SetChildIndex(this.txt_NationalCode, 0);
            this.Controls.SetChildIndex(this.txt_Name, 0);
            this.Controls.SetChildIndex(this.cmb_Sex, 0);
            this.Controls.SetChildIndex(this.dp_Birthday, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_PhoneNumber, 0);
            this.Controls.SetChildIndex(this.txt_LastName, 0);
            this.Controls.SetChildIndex(this.txt_Gmail, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.Controls.SetChildIndex(this.btn_MoreSearch, 0);
            this.Controls.SetChildIndex(this.btn_Insert, 0);
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txt_Gmail;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label1;
        private PersianDate.DatePicker dp_Birthday;
        private MaterialSkin.Controls.MaterialComboBox cmb_Sex;
        private MaterialSkin.Controls.MaterialButton btn_MoreSearch;
        private MaterialSkin.Controls.MaterialButton btn_Insert;
        public MaterialSkin.Controls.MaterialTextBox2 txt_LastName;
        public MaterialSkin.Controls.MaterialTextBox2 txt_Name;
        public MaterialSkin.Controls.MaterialTextBox2 txt_NationalCode;
    }
}