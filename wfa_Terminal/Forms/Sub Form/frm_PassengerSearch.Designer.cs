
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_PassengerSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Passenger = new System.Windows.Forms.DataGridView();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Control = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Passenger)).BeginInit();
            this.pnl_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1349, 39);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnl_Control);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 477);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Passenger);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1349, 273);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Passenger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgv_Passenger.Size = new System.Drawing.Size(1349, 273);
            this.dgv_Passenger.TabIndex = 1;
            this.dgv_Passenger.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Passenger_CellDoubleClick);
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
            this.pnl_Control.Size = new System.Drawing.Size(1349, 204);
            this.pnl_Control.TabIndex = 0;
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
            this.txt_Gmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Gmail_KeyDown);
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
            this.txt_LastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_LastName_KeyDown);
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
            this.txt_PhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PhoneNumber_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(512, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "تاریخ تولد";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dp_Birthday
            // 
            this.dp_Birthday.Date = "1403/06/12";
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
            this.cmb_Sex.SelectedIndexChanged += new System.EventHandler(this.cmb_Sex_SelectedIndexChanged);
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
            this.txt_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Name_KeyDown);
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
            this.txt_NationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NationalCode_KeyDown);
            // 
            // frm_PassengerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 649);
            this.Controls.Add(this.panel1);
            this.Name = "frm_PassengerSearch";
            this.Load += new System.EventHandler(this.frm_PassengerSearch_Load);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Passenger)).EndInit();
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
        private System.Windows.Forms.Panel pnl_Control;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Gmail;
        private MaterialSkin.Controls.MaterialTextBox2 txt_LastName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label1;
        private PersianDate.DatePicker dp_Birthday;
        private MaterialSkin.Controls.MaterialComboBox cmb_Sex;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Name;
        private MaterialSkin.Controls.MaterialTextBox2 txt_NationalCode;
        public System.Windows.Forms.DataGridView dgv_Passenger;
    }
}