
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_Passenger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_MoreSearch = new MaterialSkin.Controls.MaterialButton();
            this.txt_SearchPhoneNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pic_SearchPhoneNumber = new System.Windows.Forms.PictureBox();
            this.pic_SearchLastName = new System.Windows.Forms.PictureBox();
            this.pic_SearchNationalCode = new System.Windows.Forms.PictureBox();
            this.txt_SearchLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_SearchNationalCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Passenger = new System.Windows.Forms.DataGridView();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Control = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.btn_Cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_Submit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Delete = new MaterialSkin.Controls.MaterialButton();
            this.btn_Edit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Insert = new MaterialSkin.Controls.MaterialButton();
            this.txt_Gmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_LastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_PhoneNumber = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dp_Birthday = new PersianDate.DatePicker();
            this.cmb_Sex = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_Name = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_NationalCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchNationalCode)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Passenger)).BeginInit();
            this.pnl_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1368, 39);
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnl_Control);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 612);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_MoreSearch);
            this.panel3.Controls.Add(this.txt_SearchPhoneNumber);
            this.panel3.Controls.Add(this.pic_SearchPhoneNumber);
            this.panel3.Controls.Add(this.pic_SearchLastName);
            this.panel3.Controls.Add(this.pic_SearchNationalCode);
            this.panel3.Controls.Add(this.txt_SearchLastName);
            this.panel3.Controls.Add(this.txt_SearchNationalCode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1368, 122);
            this.panel3.TabIndex = 2;
            // 
            // btn_MoreSearch
            // 
            this.btn_MoreSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_MoreSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_MoreSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_MoreSearch.Depth = 0;
            this.btn_MoreSearch.HighEmphasis = true;
            this.btn_MoreSearch.Icon = null;
            this.btn_MoreSearch.Location = new System.Drawing.Point(55, 44);
            this.btn_MoreSearch.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_MoreSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_MoreSearch.Name = "btn_MoreSearch";
            this.btn_MoreSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_MoreSearch.Size = new System.Drawing.Size(102, 36);
            this.btn_MoreSearch.TabIndex = 27;
            this.btn_MoreSearch.Text = "جستجوی بیشتر";
            this.btn_MoreSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_MoreSearch.UseAccentColor = false;
            this.btn_MoreSearch.UseVisualStyleBackColor = false;
            this.btn_MoreSearch.Click += new System.EventHandler(this.btn_MoreSearch_Click);
            // 
            // txt_SearchPhoneNumber
            // 
            this.txt_SearchPhoneNumber.AllowPromptAsInput = true;
            this.txt_SearchPhoneNumber.AnimateReadOnly = false;
            this.txt_SearchPhoneNumber.AsciiOnly = false;
            this.txt_SearchPhoneNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_SearchPhoneNumber.BeepOnError = false;
            this.txt_SearchPhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_SearchPhoneNumber.Depth = 0;
            this.txt_SearchPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_SearchPhoneNumber.HidePromptOnLeave = true;
            this.txt_SearchPhoneNumber.HideSelection = false;
            this.txt_SearchPhoneNumber.Hint = "شماره تلفن";
            this.txt_SearchPhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_SearchPhoneNumber.LeadingIcon = global::wfa_Terminal.Properties.Resources.round_phone_black_24dp;
            this.txt_SearchPhoneNumber.Location = new System.Drawing.Point(325, 32);
            this.txt_SearchPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchPhoneNumber.Mask = "00000000000";
            this.txt_SearchPhoneNumber.MaxLength = 32767;
            this.txt_SearchPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_SearchPhoneNumber.Name = "txt_SearchPhoneNumber";
            this.txt_SearchPhoneNumber.PasswordChar = '\0';
            this.txt_SearchPhoneNumber.PrefixSuffixText = null;
            this.txt_SearchPhoneNumber.PromptChar = '_';
            this.txt_SearchPhoneNumber.ReadOnly = false;
            this.txt_SearchPhoneNumber.RejectInputOnFirstFailure = true;
            this.txt_SearchPhoneNumber.ResetOnPrompt = true;
            this.txt_SearchPhoneNumber.ResetOnSpace = true;
            this.txt_SearchPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_SearchPhoneNumber.SelectedText = "";
            this.txt_SearchPhoneNumber.SelectionLength = 0;
            this.txt_SearchPhoneNumber.SelectionStart = 0;
            this.txt_SearchPhoneNumber.ShortcutsEnabled = true;
            this.txt_SearchPhoneNumber.Size = new System.Drawing.Size(248, 48);
            this.txt_SearchPhoneNumber.SkipLiterals = true;
            this.txt_SearchPhoneNumber.TabIndex = 26;
            this.txt_SearchPhoneNumber.TabStop = false;
            this.txt_SearchPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SearchPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_SearchPhoneNumber.TrailingIcon = null;
            this.txt_SearchPhoneNumber.UseSystemPasswordChar = false;
            this.txt_SearchPhoneNumber.ValidatingType = null;
            this.txt_SearchPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SearchPhoneNumber_KeyDown);
            // 
            // pic_SearchPhoneNumber
            // 
            this.pic_SearchPhoneNumber.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchPhoneNumber.Location = new System.Drawing.Point(264, 32);
            this.pic_SearchPhoneNumber.Name = "pic_SearchPhoneNumber";
            this.pic_SearchPhoneNumber.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchPhoneNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchPhoneNumber.TabIndex = 25;
            this.pic_SearchPhoneNumber.TabStop = false;
            this.pic_SearchPhoneNumber.Click += new System.EventHandler(this.pic_SearchPhoneNumber_Click);
            // 
            // pic_SearchLastName
            // 
            this.pic_SearchLastName.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchLastName.Location = new System.Drawing.Point(653, 32);
            this.pic_SearchLastName.Name = "pic_SearchLastName";
            this.pic_SearchLastName.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchLastName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchLastName.TabIndex = 24;
            this.pic_SearchLastName.TabStop = false;
            this.pic_SearchLastName.Click += new System.EventHandler(this.pic_SearchLastName_Click);
            // 
            // pic_SearchNationalCode
            // 
            this.pic_SearchNationalCode.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchNationalCode.Location = new System.Drawing.Point(1028, 32);
            this.pic_SearchNationalCode.Name = "pic_SearchNationalCode";
            this.pic_SearchNationalCode.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchNationalCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchNationalCode.TabIndex = 23;
            this.pic_SearchNationalCode.TabStop = false;
            this.pic_SearchNationalCode.Click += new System.EventHandler(this.pic_SearchNationalCode_Click);
            // 
            // txt_SearchLastName
            // 
            this.txt_SearchLastName.AnimateReadOnly = false;
            this.txt_SearchLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_SearchLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SearchLastName.Depth = 0;
            this.txt_SearchLastName.ErrorMessage = "نامعتبر";
            this.txt_SearchLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchLastName.HideSelection = true;
            this.txt_SearchLastName.Hint = "نام خانوادگی";
            this.txt_SearchLastName.LeadingIcon = null;
            this.txt_SearchLastName.Location = new System.Drawing.Point(713, 32);
            this.txt_SearchLastName.MaxLength = 32767;
            this.txt_SearchLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_SearchLastName.Name = "txt_SearchLastName";
            this.txt_SearchLastName.PasswordChar = '\0';
            this.txt_SearchLastName.PrefixSuffixText = null;
            this.txt_SearchLastName.ReadOnly = false;
            this.txt_SearchLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SearchLastName.SelectedText = "";
            this.txt_SearchLastName.SelectionLength = 0;
            this.txt_SearchLastName.SelectionStart = 0;
            this.txt_SearchLastName.ShortcutsEnabled = true;
            this.txt_SearchLastName.ShowAssistiveText = true;
            this.txt_SearchLastName.Size = new System.Drawing.Size(248, 64);
            this.txt_SearchLastName.TabIndex = 22;
            this.txt_SearchLastName.TabStop = false;
            this.txt_SearchLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SearchLastName.TrailingIcon = null;
            this.txt_SearchLastName.UseSystemPasswordChar = false;
            this.txt_SearchLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SearchLastName_KeyDown);
            // 
            // txt_SearchNationalCode
            // 
            this.txt_SearchNationalCode.AnimateReadOnly = false;
            this.txt_SearchNationalCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_SearchNationalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SearchNationalCode.Depth = 0;
            this.txt_SearchNationalCode.ErrorMessage = "نامعتبر";
            this.txt_SearchNationalCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchNationalCode.HideSelection = true;
            this.txt_SearchNationalCode.Hint = "کد ملی ";
            this.txt_SearchNationalCode.LeadingIcon = null;
            this.txt_SearchNationalCode.Location = new System.Drawing.Point(1088, 32);
            this.txt_SearchNationalCode.MaxLength = 10;
            this.txt_SearchNationalCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_SearchNationalCode.Name = "txt_SearchNationalCode";
            this.txt_SearchNationalCode.PasswordChar = '\0';
            this.txt_SearchNationalCode.PrefixSuffixText = null;
            this.txt_SearchNationalCode.ReadOnly = false;
            this.txt_SearchNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SearchNationalCode.SelectedText = "";
            this.txt_SearchNationalCode.SelectionLength = 0;
            this.txt_SearchNationalCode.SelectionStart = 0;
            this.txt_SearchNationalCode.ShortcutsEnabled = true;
            this.txt_SearchNationalCode.ShowAssistiveText = true;
            this.txt_SearchNationalCode.Size = new System.Drawing.Size(248, 64);
            this.txt_SearchNationalCode.TabIndex = 21;
            this.txt_SearchNationalCode.TabStop = false;
            this.txt_SearchNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SearchNationalCode.TrailingIcon = null;
            this.txt_SearchNationalCode.UseSystemPasswordChar = false;
            this.txt_SearchNationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SearchNationalCode_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Passenger);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 246);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 366);
            this.panel2.TabIndex = 1;
            // 
            // dgv_Passenger
            // 
            this.dgv_Passenger.AllowUserToAddRows = false;
            this.dgv_Passenger.AllowUserToDeleteRows = false;
            this.dgv_Passenger.AllowUserToResizeColumns = false;
            this.dgv_Passenger.AllowUserToResizeRows = false;
            this.dgv_Passenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Passenger.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Passenger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Passenger.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Passenger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Passenger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Passenger.ColumnHeadersHeight = 29;
            this.dgv_Passenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Passenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCount});
            this.dgv_Passenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Passenger.EnableHeadersVisualStyles = false;
            this.dgv_Passenger.GridColor = System.Drawing.Color.White;
            this.dgv_Passenger.Location = new System.Drawing.Point(0, 0);
            this.dgv_Passenger.MultiSelect = false;
            this.dgv_Passenger.Name = "dgv_Passenger";
            this.dgv_Passenger.ReadOnly = true;
            this.dgv_Passenger.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Passenger.RowHeadersVisible = false;
            this.dgv_Passenger.RowHeadersWidth = 51;
            this.dgv_Passenger.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Passenger.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Passenger.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Passenger.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Passenger.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgv_Passenger.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_Passenger.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Passenger.RowTemplate.DividerHeight = 1;
            this.dgv_Passenger.RowTemplate.Height = 35;
            this.dgv_Passenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Passenger.Size = new System.Drawing.Size(1368, 366);
            this.dgv_Passenger.TabIndex = 1;
            this.dgv_Passenger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Passenger_CellClick);
            this.dgv_Passenger.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Passenger_CellFormatting);
            // 
            // RowCount
            // 
            this.RowCount.FillWeight = 40F;
            this.RowCount.HeaderText = "ردیف";
            this.RowCount.MinimumWidth = 40;
            this.RowCount.Name = "RowCount";
            this.RowCount.ReadOnly = true;
            // 
            // pnl_Control
            // 
            this.pnl_Control.Controls.Add(this.label5);
            this.pnl_Control.Controls.Add(this.lbl_Register);
            this.pnl_Control.Controls.Add(this.btn_Cancel);
            this.pnl_Control.Controls.Add(this.btn_Submit);
            this.pnl_Control.Controls.Add(this.btn_Delete);
            this.pnl_Control.Controls.Add(this.btn_Edit);
            this.pnl_Control.Controls.Add(this.btn_Insert);
            this.pnl_Control.Controls.Add(this.txt_Gmail);
            this.pnl_Control.Controls.Add(this.txt_LastName);
            this.pnl_Control.Controls.Add(this.txt_PhoneNumber);
            this.pnl_Control.Controls.Add(this.label1);
            this.pnl_Control.Controls.Add(this.dp_Birthday);
            this.pnl_Control.Controls.Add(this.cmb_Sex);
            this.pnl_Control.Controls.Add(this.txt_Name);
            this.pnl_Control.Controls.Add(this.txt_NationalCode);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(1368, 246);
            this.pnl_Control.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1004, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 97;
            this.label5.Text = "زمان ثبت";
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Location = new System.Drawing.Point(825, 124);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(0, 18);
            this.lbl_Register.TabIndex = 96;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Cancel.Depth = 0;
            this.btn_Cancel.HighEmphasis = true;
            this.btn_Cancel.Icon = global::wfa_Terminal.Properties.Resources.cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(175, 185);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Cancel.Size = new System.Drawing.Size(66, 36);
            this.btn_Cancel.TabIndex = 25;
            this.btn_Cancel.Text = "لغو";
            this.btn_Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Cancel.UseAccentColor = false;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_Submit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Submit.Depth = 0;
            this.btn_Submit.HighEmphasis = true;
            this.btn_Submit.Icon = global::wfa_Terminal.Properties.Resources.accept;
            this.btn_Submit.Location = new System.Drawing.Point(86, 185);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Submit.Size = new System.Drawing.Size(71, 36);
            this.btn_Submit.TabIndex = 24;
            this.btn_Submit.Text = "تایید";
            this.btn_Submit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Submit.UseAccentColor = false;
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Delete.Depth = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.HighEmphasis = true;
            this.btn_Delete.Icon = global::wfa_Terminal.Properties.Resources.folder__1_;
            this.btn_Delete.Location = new System.Drawing.Point(241, 114);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Delete.Size = new System.Drawing.Size(76, 36);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Delete.UseAccentColor = true;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Edit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Edit.Depth = 0;
            this.btn_Edit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.HighEmphasis = true;
            this.btn_Edit.Icon = global::wfa_Terminal.Properties.Resources.edit_button;
            this.btn_Edit.Location = new System.Drawing.Point(129, 114);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Edit.Size = new System.Drawing.Size(89, 36);
            this.btn_Edit.TabIndex = 22;
            this.btn_Edit.Text = "ویرایش";
            this.btn_Edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Edit.UseAccentColor = true;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Insert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Insert.Depth = 0;
            this.btn_Insert.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.HighEmphasis = true;
            this.btn_Insert.Icon = global::wfa_Terminal.Properties.Resources.row;
            this.btn_Insert.Location = new System.Drawing.Point(21, 114);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Insert.Size = new System.Drawing.Size(86, 36);
            this.btn_Insert.TabIndex = 21;
            this.btn_Insert.Text = "افزودن";
            this.btn_Insert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Insert.UseAccentColor = true;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Gmail
            // 
            this.txt_Gmail.AnimateReadOnly = false;
            this.txt_Gmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Gmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Gmail.Depth = 0;
            this.txt_Gmail.Enabled = false;
            this.txt_Gmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gmail.HideSelection = true;
            this.txt_Gmail.Hint = "ایمیل";
            this.txt_Gmail.LeadingIcon = null;
            this.txt_Gmail.Location = new System.Drawing.Point(1088, 104);
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
            this.txt_Gmail.TabIndex = 18;
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
            this.txt_LastName.Enabled = false;
            this.txt_LastName.ErrorMessage = "نامعتبر";
            this.txt_LastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.HideSelection = true;
            this.txt_LastName.Hint = "نام خانوادگی";
            this.txt_LastName.LeadingIcon = null;
            this.txt_LastName.Location = new System.Drawing.Point(846, 34);
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
            this.txt_LastName.TabIndex = 13;
            this.txt_LastName.TabStop = false;
            this.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_LastName.TrailingIcon = null;
            this.txt_LastName.UseSystemPasswordChar = false;
            this.txt_LastName.Enter += new System.EventHandler(this.txt_LastName_Enter);
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
            this.txt_PhoneNumber.Enabled = false;
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_PhoneNumber.HidePromptOnLeave = true;
            this.txt_PhoneNumber.HideSelection = false;
            this.txt_PhoneNumber.Hint = "شماره تلفن";
            this.txt_PhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_PhoneNumber.LeadingIcon = global::wfa_Terminal.Properties.Resources.round_phone_black_24dp;
            this.txt_PhoneNumber.Location = new System.Drawing.Point(33, 34);
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
            this.txt_PhoneNumber.TabIndex = 16;
            this.txt_PhoneNumber.TabStop = false;
            this.txt_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_PhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_PhoneNumber.TrailingIcon = null;
            this.txt_PhoneNumber.UseSystemPasswordChar = false;
            this.txt_PhoneNumber.ValidatingType = null;
            this.txt_PhoneNumber.Enter += new System.EventHandler(this.txt_PhoneNumber_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "تاریخ تولد";
            // 
            // dp_Birthday
            // 
            this.dp_Birthday.Date = "1403/06/12";
            this.dp_Birthday.Enabled = false;
            this.dp_Birthday.FocusColor = System.Drawing.Color.White;
            this.dp_Birthday.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Birthday.Location = new System.Drawing.Point(306, 47);
            this.dp_Birthday.Name = "dp_Birthday";
            this.dp_Birthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Birthday.Size = new System.Drawing.Size(200, 24);
            this.dp_Birthday.TabIndex = 15;
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
            this.cmb_Sex.Enabled = false;
            this.cmb_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Sex.FormattingEnabled = true;
            this.cmb_Sex.Hint = "جنسیت";
            this.cmb_Sex.IntegralHeight = false;
            this.cmb_Sex.ItemHeight = 43;
            this.cmb_Sex.Location = new System.Drawing.Point(592, 34);
            this.cmb_Sex.MaxDropDownItems = 4;
            this.cmb_Sex.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Sex.Name = "cmb_Sex";
            this.cmb_Sex.Size = new System.Drawing.Size(248, 49);
            this.cmb_Sex.StartIndex = 0;
            this.cmb_Sex.TabIndex = 14;
            // 
            // txt_Name
            // 
            this.txt_Name.AnimateReadOnly = false;
            this.txt_Name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Name.Depth = 0;
            this.txt_Name.Enabled = false;
            this.txt_Name.ErrorMessage = "نامعتبر";
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.HideSelection = true;
            this.txt_Name.Hint = "نام";
            this.txt_Name.LeadingIcon = null;
            this.txt_Name.Location = new System.Drawing.Point(967, 34);
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
            this.txt_Name.TabIndex = 12;
            this.txt_Name.TabStop = false;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Name.TrailingIcon = null;
            this.txt_Name.UseSystemPasswordChar = false;
            this.txt_Name.Enter += new System.EventHandler(this.txt_Name_Enter);
            // 
            // txt_NationalCode
            // 
            this.txt_NationalCode.AnimateReadOnly = false;
            this.txt_NationalCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_NationalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_NationalCode.Depth = 0;
            this.txt_NationalCode.Enabled = false;
            this.txt_NationalCode.ErrorMessage = "نامعتبر";
            this.txt_NationalCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NationalCode.HideSelection = true;
            this.txt_NationalCode.Hint = "کد ملی";
            this.txt_NationalCode.LeadingIcon = null;
            this.txt_NationalCode.Location = new System.Drawing.Point(1088, 34);
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
            this.txt_NationalCode.TabIndex = 11;
            this.txt_NationalCode.TabStop = false;
            this.txt_NationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NationalCode.TrailingIcon = null;
            this.txt_NationalCode.UseSystemPasswordChar = false;
            this.txt_NationalCode.Click += new System.EventHandler(this.txt_NationalCode_Click);
            this.txt_NationalCode.Enter += new System.EventHandler(this.txt_NationalCode_Enter);
            // 
            // frm_Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 754);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Passenger";
            this.Load += new System.EventHandler(this.frm_Passenger_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchNationalCode)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Passenger)).EndInit();
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Control;
        private MaterialSkin.Controls.MaterialTextBox2 txt_LastName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label1;
        private PersianDate.DatePicker dp_Birthday;
        private MaterialSkin.Controls.MaterialComboBox cmb_Sex;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Name;
        private MaterialSkin.Controls.MaterialTextBox2 txt_NationalCode;
        private System.Windows.Forms.DataGridView dgv_Passenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Gmail;
        private MaterialSkin.Controls.MaterialButton btn_Cancel;
        private MaterialSkin.Controls.MaterialButton btn_Submit;
        private MaterialSkin.Controls.MaterialButton btn_Delete;
        private MaterialSkin.Controls.MaterialButton btn_Edit;
        private MaterialSkin.Controls.MaterialButton btn_Insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton btn_MoreSearch;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_SearchPhoneNumber;
        private System.Windows.Forms.PictureBox pic_SearchPhoneNumber;
        private System.Windows.Forms.PictureBox pic_SearchLastName;
        private System.Windows.Forms.PictureBox pic_SearchNationalCode;
        private MaterialSkin.Controls.MaterialTextBox2 txt_SearchLastName;
        private MaterialSkin.Controls.MaterialTextBox2 txt_SearchNationalCode;
    }
}