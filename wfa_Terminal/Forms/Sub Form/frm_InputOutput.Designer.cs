
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_InputOutput
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
            this.dgv_InputOutput = new System.Windows.Forms.DataGridView();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tp_Time = new System.Windows.Forms.DateTimePicker();
            this.Switch_Date = new MaterialSkin.Controls.MaterialSwitch();
            this.txt_Description = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.Switch_Time = new MaterialSkin.Controls.MaterialSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dp_Time = new PersianDate.DatePicker();
            this.txt_NameLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmb_Status = new MaterialSkin.Controls.MaterialComboBox();
            this.pic_Search = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_Submit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Insert = new MaterialSkin.Controls.MaterialButton();
            this.txt_PersonnelCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InputOutput)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1409, 39);
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 582);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_InputOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 582);
            this.panel2.TabIndex = 2;
            // 
            // dgv_InputOutput
            // 
            this.dgv_InputOutput.AllowUserToAddRows = false;
            this.dgv_InputOutput.AllowUserToDeleteRows = false;
            this.dgv_InputOutput.AllowUserToResizeColumns = false;
            this.dgv_InputOutput.AllowUserToResizeRows = false;
            this.dgv_InputOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InputOutput.BackgroundColor = System.Drawing.Color.White;
            this.dgv_InputOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_InputOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_InputOutput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_InputOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_InputOutput.ColumnHeadersHeight = 38;
            this.dgv_InputOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_InputOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCount});
            this.dgv_InputOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_InputOutput.EnableHeadersVisualStyles = false;
            this.dgv_InputOutput.GridColor = System.Drawing.Color.White;
            this.dgv_InputOutput.Location = new System.Drawing.Point(0, 0);
            this.dgv_InputOutput.MultiSelect = false;
            this.dgv_InputOutput.Name = "dgv_InputOutput";
            this.dgv_InputOutput.ReadOnly = true;
            this.dgv_InputOutput.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_InputOutput.RowHeadersVisible = false;
            this.dgv_InputOutput.RowHeadersWidth = 51;
            this.dgv_InputOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_InputOutput.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_InputOutput.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_InputOutput.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_InputOutput.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgv_InputOutput.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_InputOutput.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_InputOutput.RowTemplate.DividerHeight = 1;
            this.dgv_InputOutput.RowTemplate.Height = 35;
            this.dgv_InputOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_InputOutput.Size = new System.Drawing.Size(958, 582);
            this.dgv_InputOutput.TabIndex = 0;
            this.dgv_InputOutput.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_InputOutput_CellClick);
            this.dgv_InputOutput.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_InputOutput_CellFormatting);
            // 
            // RowCount
            // 
            this.RowCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RowCount.FillWeight = 20F;
            this.RowCount.HeaderText = "ردیف";
            this.RowCount.MinimumWidth = 6;
            this.RowCount.Name = "RowCount";
            this.RowCount.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tp_Time);
            this.panel3.Controls.Add(this.Switch_Date);
            this.panel3.Controls.Add(this.txt_Description);
            this.panel3.Controls.Add(this.Switch_Time);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dp_Time);
            this.panel3.Controls.Add(this.txt_NameLastName);
            this.panel3.Controls.Add(this.cmb_Status);
            this.panel3.Controls.Add(this.pic_Search);
            this.panel3.Controls.Add(this.btn_Cancel);
            this.panel3.Controls.Add(this.btn_Submit);
            this.panel3.Controls.Add(this.btn_Insert);
            this.panel3.Controls.Add(this.txt_PersonnelCode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(958, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 582);
            this.panel3.TabIndex = 1;
            // 
            // tp_Time
            // 
            this.tp_Time.Enabled = false;
            this.tp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tp_Time.Location = new System.Drawing.Point(172, 281);
            this.tp_Time.Name = "tp_Time";
            this.tp_Time.ShowUpDown = true;
            this.tp_Time.Size = new System.Drawing.Size(200, 26);
            this.tp_Time.TabIndex = 18;
            this.tp_Time.Value = new System.DateTime(2024, 8, 31, 18, 17, 0, 0);
            // 
            // Switch_Date
            // 
            this.Switch_Date.AutoSize = true;
            this.Switch_Date.Depth = 0;
            this.Switch_Date.Enabled = false;
            this.Switch_Date.Location = new System.Drawing.Point(32, 231);
            this.Switch_Date.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Date.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Date.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Date.Name = "Switch_Date";
            this.Switch_Date.Ripple = true;
            this.Switch_Date.Size = new System.Drawing.Size(84, 37);
            this.Switch_Date.TabIndex = 17;
            this.Switch_Date.Text = "تاریخ ";
            this.Switch_Date.UseVisualStyleBackColor = true;
            this.Switch_Date.CheckedChanged += new System.EventHandler(this.Switch_Date_CheckedChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.AnimateReadOnly = false;
            this.txt_Description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Description.Depth = 0;
            this.txt_Description.Enabled = false;
            this.txt_Description.HideSelection = true;
            this.txt_Description.Hint = "توضیحات";
            this.txt_Description.Location = new System.Drawing.Point(175, 315);
            this.txt_Description.MaxLength = 32767;
            this.txt_Description.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.PasswordChar = '\0';
            this.txt_Description.ReadOnly = false;
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Description.SelectedText = "";
            this.txt_Description.SelectionLength = 0;
            this.txt_Description.SelectionStart = 0;
            this.txt_Description.ShortcutsEnabled = true;
            this.txt_Description.Size = new System.Drawing.Size(239, 114);
            this.txt_Description.TabIndex = 16;
            this.txt_Description.TabStop = false;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Description.UseSystemPasswordChar = false;
            // 
            // Switch_Time
            // 
            this.Switch_Time.AutoSize = true;
            this.Switch_Time.Depth = 0;
            this.Switch_Time.Enabled = false;
            this.Switch_Time.Location = new System.Drawing.Point(32, 270);
            this.Switch_Time.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_Time.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_Time.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_Time.Name = "Switch_Time";
            this.Switch_Time.Ripple = true;
            this.Switch_Time.Size = new System.Drawing.Size(78, 37);
            this.Switch_Time.TabIndex = 15;
            this.Switch_Time.Text = "زمان";
            this.Switch_Time.UseVisualStyleBackColor = true;
            this.Switch_Time.CheckedChanged += new System.EventHandler(this.Switch_Back_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "زمان";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "تاریخ ";
            // 
            // dp_Time
            // 
            this.dp_Time.Date = "1403/06/13";
            this.dp_Time.Enabled = false;
            this.dp_Time.FocusColor = System.Drawing.Color.White;
            this.dp_Time.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Time.Location = new System.Drawing.Point(172, 236);
            this.dp_Time.Name = "dp_Time";
            this.dp_Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Time.Size = new System.Drawing.Size(200, 24);
            this.dp_Time.TabIndex = 11;
            // 
            // txt_NameLastName
            // 
            this.txt_NameLastName.AnimateReadOnly = false;
            this.txt_NameLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_NameLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_NameLastName.Depth = 0;
            this.txt_NameLastName.Enabled = false;
            this.txt_NameLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NameLastName.HideSelection = true;
            this.txt_NameLastName.Hint = "نام و نام خانوادگی";
            this.txt_NameLastName.LeadingIcon = null;
            this.txt_NameLastName.Location = new System.Drawing.Point(175, 91);
            this.txt_NameLastName.MaxLength = 32767;
            this.txt_NameLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_NameLastName.Name = "txt_NameLastName";
            this.txt_NameLastName.PasswordChar = '\0';
            this.txt_NameLastName.PrefixSuffixText = null;
            this.txt_NameLastName.ReadOnly = true;
            this.txt_NameLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NameLastName.SelectedText = "";
            this.txt_NameLastName.SelectionLength = 0;
            this.txt_NameLastName.SelectionStart = 0;
            this.txt_NameLastName.ShortcutsEnabled = true;
            this.txt_NameLastName.ShowAssistiveText = true;
            this.txt_NameLastName.Size = new System.Drawing.Size(238, 64);
            this.txt_NameLastName.TabIndex = 7;
            this.txt_NameLastName.TabStop = false;
            this.txt_NameLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NameLastName.TrailingIcon = null;
            this.txt_NameLastName.UseSystemPasswordChar = false;
            // 
            // cmb_Status
            // 
            this.cmb_Status.AutoResize = false;
            this.cmb_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Status.Depth = 0;
            this.cmb_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Status.DropDownHeight = 174;
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.DropDownWidth = 121;
            this.cmb_Status.Enabled = false;
            this.cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Hint = "وضعیت";
            this.cmb_Status.IntegralHeight = false;
            this.cmb_Status.ItemHeight = 43;
            this.cmb_Status.Location = new System.Drawing.Point(175, 161);
            this.cmb_Status.MaxDropDownItems = 4;
            this.cmb_Status.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(238, 49);
            this.cmb_Status.StartIndex = 0;
            this.cmb_Status.TabIndex = 8;
            // 
            // pic_Search
            // 
            this.pic_Search.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_Search.Location = new System.Drawing.Point(115, 21);
            this.pic_Search.Name = "pic_Search";
            this.pic_Search.Size = new System.Drawing.Size(54, 53);
            this.pic_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Search.TabIndex = 6;
            this.pic_Search.TabStop = false;
            this.pic_Search.Click += new System.EventHandler(this.pic_Search_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Cancel.Depth = 0;
            this.btn_Cancel.HighEmphasis = true;
            this.btn_Cancel.Icon = global::wfa_Terminal.Properties.Resources.cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(306, 499);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Cancel.Size = new System.Drawing.Size(66, 36);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "لغو";
            this.btn_Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Cancel.UseAccentColor = false;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
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
            this.btn_Submit.Location = new System.Drawing.Point(217, 499);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Submit.Size = new System.Drawing.Size(71, 36);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "تایید";
            this.btn_Submit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Submit.UseAccentColor = false;
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Visible = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Insert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Insert.Depth = 0;
            this.btn_Insert.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.HighEmphasis = true;
            this.btn_Insert.Icon = global::wfa_Terminal.Properties.Resources.row;
            this.btn_Insert.Location = new System.Drawing.Point(233, 449);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Insert.Size = new System.Drawing.Size(114, 36);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "ثبت وضعیت";
            this.btn_Insert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Insert.UseAccentColor = true;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_PersonnelCode
            // 
            this.txt_PersonnelCode.AnimateReadOnly = false;
            this.txt_PersonnelCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_PersonnelCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_PersonnelCode.Depth = 0;
            this.txt_PersonnelCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersonnelCode.HideSelection = true;
            this.txt_PersonnelCode.Hint = "کد پرسنلی";
            this.txt_PersonnelCode.LeadingIcon = null;
            this.txt_PersonnelCode.Location = new System.Drawing.Point(175, 21);
            this.txt_PersonnelCode.MaxLength = 32767;
            this.txt_PersonnelCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_PersonnelCode.Name = "txt_PersonnelCode";
            this.txt_PersonnelCode.PasswordChar = '\0';
            this.txt_PersonnelCode.PrefixSuffixText = null;
            this.txt_PersonnelCode.ReadOnly = false;
            this.txt_PersonnelCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_PersonnelCode.SelectedText = "";
            this.txt_PersonnelCode.SelectionLength = 0;
            this.txt_PersonnelCode.SelectionStart = 0;
            this.txt_PersonnelCode.ShortcutsEnabled = true;
            this.txt_PersonnelCode.ShowAssistiveText = true;
            this.txt_PersonnelCode.Size = new System.Drawing.Size(238, 64);
            this.txt_PersonnelCode.TabIndex = 0;
            this.txt_PersonnelCode.TabStop = false;
            this.txt_PersonnelCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PersonnelCode.TrailingIcon = null;
            this.txt_PersonnelCode.UseSystemPasswordChar = false;
            this.txt_PersonnelCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PersonnelCode_KeyDown);
            this.txt_PersonnelCode.TextChanged += new System.EventHandler(this.txt_PersonnelCode_TextChanged);
            // 
            // frm_InputOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 779);
            this.Controls.Add(this.panel1);
            this.Name = "frm_InputOutput";
            this.Load += new System.EventHandler(this.frm_InputOutput_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InputOutput)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_InputOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSwitch Switch_Date;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_Description;
        private MaterialSkin.Controls.MaterialSwitch Switch_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PersianDate.DatePicker dp_Time;
        private MaterialSkin.Controls.MaterialTextBox2 txt_NameLastName;
        private MaterialSkin.Controls.MaterialComboBox cmb_Status;
        private System.Windows.Forms.PictureBox pic_Search;
        private MaterialSkin.Controls.MaterialButton btn_Cancel;
        private MaterialSkin.Controls.MaterialButton btn_Submit;
        private MaterialSkin.Controls.MaterialButton btn_Insert;
        private MaterialSkin.Controls.MaterialTextBox2 txt_PersonnelCode;
        private System.Windows.Forms.DateTimePicker tp_Time;
    }
}