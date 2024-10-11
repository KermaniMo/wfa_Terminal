
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_CarSearch
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
            this.dgv_Car = new System.Windows.Forms.DataGridView();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_TXT = new System.Windows.Forms.Panel();
            this.txt_Gmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Capacity = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.dp_CreateDate = new PersianDate.DatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Number2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Iran = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Number1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Character = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmb_Type = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_Model = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Brand = new MaterialSkin.Controls.MaterialTextBox2();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Car)).BeginInit();
            this.pnl_TXT.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1794, 39);
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
            this.panel1.Controls.Add(this.pnl_TXT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1794, 983);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Car);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1794, 661);
            this.panel2.TabIndex = 2;
            // 
            // dgv_Car
            // 
            this.dgv_Car.AllowUserToAddRows = false;
            this.dgv_Car.AllowUserToDeleteRows = false;
            this.dgv_Car.AllowUserToResizeColumns = false;
            this.dgv_Car.AllowUserToResizeRows = false;
            this.dgv_Car.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Car.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Car.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Car.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Car.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Car.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Car.ColumnHeadersHeight = 29;
            this.dgv_Car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Car.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCount});
            this.dgv_Car.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Car.EnableHeadersVisualStyles = false;
            this.dgv_Car.GridColor = System.Drawing.Color.White;
            this.dgv_Car.Location = new System.Drawing.Point(0, 0);
            this.dgv_Car.MultiSelect = false;
            this.dgv_Car.Name = "dgv_Car";
            this.dgv_Car.ReadOnly = true;
            this.dgv_Car.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Car.RowHeadersVisible = false;
            this.dgv_Car.RowHeadersWidth = 51;
            this.dgv_Car.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Car.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Car.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Car.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Car.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgv_Car.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_Car.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Car.RowTemplate.DividerHeight = 1;
            this.dgv_Car.RowTemplate.Height = 35;
            this.dgv_Car.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Car.Size = new System.Drawing.Size(1794, 661);
            this.dgv_Car.TabIndex = 0;
            this.dgv_Car.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Car_CellDoubleClick);
            this.dgv_Car.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Car_CellFormatting);
            // 
            // RowCount
            // 
            this.RowCount.FillWeight = 40F;
            this.RowCount.HeaderText = "ردیف";
            this.RowCount.MinimumWidth = 40;
            this.RowCount.Name = "RowCount";
            this.RowCount.ReadOnly = true;
            // 
            // pnl_TXT
            // 
            this.pnl_TXT.Controls.Add(this.txt_Gmail);
            this.pnl_TXT.Controls.Add(this.txt_Capacity);
            this.pnl_TXT.Controls.Add(this.label3);
            this.pnl_TXT.Controls.Add(this.dp_CreateDate);
            this.pnl_TXT.Controls.Add(this.label2);
            this.pnl_TXT.Controls.Add(this.txt_Number2);
            this.pnl_TXT.Controls.Add(this.txt_Iran);
            this.pnl_TXT.Controls.Add(this.txt_Number1);
            this.pnl_TXT.Controls.Add(this.txt_Character);
            this.pnl_TXT.Controls.Add(this.cmb_Type);
            this.pnl_TXT.Controls.Add(this.txt_Model);
            this.pnl_TXT.Controls.Add(this.txt_Brand);
            this.pnl_TXT.Controls.Add(this.txt_LastName);
            this.pnl_TXT.Controls.Add(this.txt_PhoneNumber);
            this.pnl_TXT.Controls.Add(this.label1);
            this.pnl_TXT.Controls.Add(this.dp_Birthday);
            this.pnl_TXT.Controls.Add(this.cmb_Sex);
            this.pnl_TXT.Controls.Add(this.txt_Name);
            this.pnl_TXT.Controls.Add(this.txt_NationalCode);
            this.pnl_TXT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TXT.Location = new System.Drawing.Point(0, 0);
            this.pnl_TXT.Name = "pnl_TXT";
            this.pnl_TXT.Size = new System.Drawing.Size(1794, 322);
            this.pnl_TXT.TabIndex = 1;
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
            this.txt_Gmail.Location = new System.Drawing.Point(1422, 222);
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
            this.txt_Gmail.TabIndex = 15;
            this.txt_Gmail.TabStop = false;
            this.txt_Gmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Gmail.TrailingIcon = null;
            this.txt_Gmail.UseSystemPasswordChar = false;
            this.txt_Gmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Gmail_KeyDown);
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.AnimateReadOnly = false;
            this.txt_Capacity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Capacity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Capacity.Depth = 0;
            this.txt_Capacity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Capacity.HideSelection = true;
            this.txt_Capacity.Hint = "ظرفیت ماشین";
            this.txt_Capacity.LeadingIcon = null;
            this.txt_Capacity.Location = new System.Drawing.Point(112, 128);
            this.txt_Capacity.MaxLength = 32767;
            this.txt_Capacity.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.PasswordChar = '\0';
            this.txt_Capacity.PrefixSuffixText = null;
            this.txt_Capacity.ReadOnly = false;
            this.txt_Capacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Capacity.SelectedText = "";
            this.txt_Capacity.SelectionLength = 0;
            this.txt_Capacity.SelectionStart = 0;
            this.txt_Capacity.ShortcutsEnabled = true;
            this.txt_Capacity.ShowAssistiveText = true;
            this.txt_Capacity.Size = new System.Drawing.Size(248, 64);
            this.txt_Capacity.TabIndex = 14;
            this.txt_Capacity.TabStop = false;
            this.txt_Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Capacity.TrailingIcon = null;
            this.txt_Capacity.UseSystemPasswordChar = false;
            this.txt_Capacity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Capacity_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(640, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 93;
            this.label3.Text = "تاریخ تولید ماشین";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dp_CreateDate
            // 
            this.dp_CreateDate.Date = "1403/06/05";
            this.dp_CreateDate.FocusColor = System.Drawing.Color.White;
            this.dp_CreateDate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_CreateDate.Location = new System.Drawing.Point(434, 143);
            this.dp_CreateDate.Name = "dp_CreateDate";
            this.dp_CreateDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_CreateDate.Size = new System.Drawing.Size(200, 24);
            this.dp_CreateDate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1107, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 91;
            this.label2.Text = "پلاک";
            // 
            // txt_Number2
            // 
            this.txt_Number2.AnimateReadOnly = false;
            this.txt_Number2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Number2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Number2.Depth = 0;
            this.txt_Number2.ErrorMessage = "نامعتبر";
            this.txt_Number2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Number2.HideSelection = true;
            this.txt_Number2.Hint = "عدد";
            this.txt_Number2.LeadingIcon = null;
            this.txt_Number2.Location = new System.Drawing.Point(953, 128);
            this.txt_Number2.MaxLength = 32767;
            this.txt_Number2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Number2.Name = "txt_Number2";
            this.txt_Number2.PasswordChar = '\0';
            this.txt_Number2.PrefixSuffixText = null;
            this.txt_Number2.ReadOnly = false;
            this.txt_Number2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Number2.SelectedText = "";
            this.txt_Number2.SelectionLength = 0;
            this.txt_Number2.SelectionStart = 0;
            this.txt_Number2.ShortcutsEnabled = true;
            this.txt_Number2.ShowAssistiveText = true;
            this.txt_Number2.Size = new System.Drawing.Size(75, 64);
            this.txt_Number2.TabIndex = 11;
            this.txt_Number2.TabStop = false;
            this.txt_Number2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Number2.TrailingIcon = null;
            this.txt_Number2.UseSystemPasswordChar = false;
            this.txt_Number2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Iran_KeyDown);
            // 
            // txt_Iran
            // 
            this.txt_Iran.AnimateReadOnly = false;
            this.txt_Iran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Iran.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Iran.Depth = 0;
            this.txt_Iran.ErrorMessage = "نامعتبر";
            this.txt_Iran.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Iran.HideSelection = true;
            this.txt_Iran.Hint = "ایران";
            this.txt_Iran.LeadingIcon = null;
            this.txt_Iran.Location = new System.Drawing.Point(1034, 128);
            this.txt_Iran.MaxLength = 32767;
            this.txt_Iran.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Iran.Name = "txt_Iran";
            this.txt_Iran.PasswordChar = '\0';
            this.txt_Iran.PrefixSuffixText = null;
            this.txt_Iran.ReadOnly = false;
            this.txt_Iran.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Iran.SelectedText = "";
            this.txt_Iran.SelectionLength = 0;
            this.txt_Iran.SelectionStart = 0;
            this.txt_Iran.ShortcutsEnabled = true;
            this.txt_Iran.ShowAssistiveText = true;
            this.txt_Iran.Size = new System.Drawing.Size(67, 64);
            this.txt_Iran.TabIndex = 12;
            this.txt_Iran.TabStop = false;
            this.txt_Iran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Iran.TrailingIcon = null;
            this.txt_Iran.UseSystemPasswordChar = false;
            this.txt_Iran.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Iran_KeyDown);
            // 
            // txt_Number1
            // 
            this.txt_Number1.AnimateReadOnly = false;
            this.txt_Number1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Number1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Number1.Depth = 0;
            this.txt_Number1.ErrorMessage = "نامعتبر";
            this.txt_Number1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Number1.HideSelection = true;
            this.txt_Number1.Hint = "عدد";
            this.txt_Number1.LeadingIcon = null;
            this.txt_Number1.Location = new System.Drawing.Point(801, 128);
            this.txt_Number1.MaxLength = 32767;
            this.txt_Number1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Number1.Name = "txt_Number1";
            this.txt_Number1.PasswordChar = '\0';
            this.txt_Number1.PrefixSuffixText = null;
            this.txt_Number1.ReadOnly = false;
            this.txt_Number1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Number1.SelectedText = "";
            this.txt_Number1.SelectionLength = 0;
            this.txt_Number1.SelectionStart = 0;
            this.txt_Number1.ShortcutsEnabled = true;
            this.txt_Number1.ShowAssistiveText = true;
            this.txt_Number1.Size = new System.Drawing.Size(70, 64);
            this.txt_Number1.TabIndex = 9;
            this.txt_Number1.TabStop = false;
            this.txt_Number1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Number1.TrailingIcon = null;
            this.txt_Number1.UseSystemPasswordChar = false;
            this.txt_Number1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Iran_KeyDown);
            // 
            // txt_Character
            // 
            this.txt_Character.AnimateReadOnly = false;
            this.txt_Character.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Character.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Character.Depth = 0;
            this.txt_Character.ErrorMessage = "نامعتبر";
            this.txt_Character.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Character.HideSelection = true;
            this.txt_Character.Hint = "حرف";
            this.txt_Character.LeadingIcon = null;
            this.txt_Character.Location = new System.Drawing.Point(877, 128);
            this.txt_Character.MaxLength = 32767;
            this.txt_Character.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Character.Name = "txt_Character";
            this.txt_Character.PasswordChar = '\0';
            this.txt_Character.PrefixSuffixText = null;
            this.txt_Character.ReadOnly = false;
            this.txt_Character.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Character.SelectedText = "";
            this.txt_Character.SelectionLength = 0;
            this.txt_Character.SelectionStart = 0;
            this.txt_Character.ShortcutsEnabled = true;
            this.txt_Character.ShowAssistiveText = true;
            this.txt_Character.Size = new System.Drawing.Size(70, 64);
            this.txt_Character.TabIndex = 10;
            this.txt_Character.TabStop = false;
            this.txt_Character.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Character.TrailingIcon = null;
            this.txt_Character.UseSystemPasswordChar = false;
            this.txt_Character.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Iran_KeyDown);
            // 
            // cmb_Type
            // 
            this.cmb_Type.AutoResize = false;
            this.cmb_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_Type.Depth = 0;
            this.cmb_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_Type.DropDownHeight = 174;
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.DropDownWidth = 121;
            this.cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Hint = "نوع ماشین";
            this.cmb_Type.IntegralHeight = false;
            this.cmb_Type.ItemHeight = 43;
            this.cmb_Type.Location = new System.Drawing.Point(1168, 128);
            this.cmb_Type.MaxDropDownItems = 4;
            this.cmb_Type.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(248, 49);
            this.cmb_Type.StartIndex = 0;
            this.cmb_Type.TabIndex = 8;
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Type_SelectedIndexChanged);
            // 
            // txt_Model
            // 
            this.txt_Model.AnimateReadOnly = false;
            this.txt_Model.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Model.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Model.Depth = 0;
            this.txt_Model.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Model.HideSelection = true;
            this.txt_Model.Hint = "مدل ماشین";
            this.txt_Model.LeadingIcon = null;
            this.txt_Model.Location = new System.Drawing.Point(1422, 128);
            this.txt_Model.MaxLength = 32767;
            this.txt_Model.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.PasswordChar = '\0';
            this.txt_Model.PrefixSuffixText = null;
            this.txt_Model.ReadOnly = false;
            this.txt_Model.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Model.SelectedText = "";
            this.txt_Model.SelectionLength = 0;
            this.txt_Model.SelectionStart = 0;
            this.txt_Model.ShortcutsEnabled = true;
            this.txt_Model.ShowAssistiveText = true;
            this.txt_Model.Size = new System.Drawing.Size(248, 64);
            this.txt_Model.TabIndex = 7;
            this.txt_Model.TabStop = false;
            this.txt_Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Model.TrailingIcon = null;
            this.txt_Model.UseSystemPasswordChar = false;
            this.txt_Model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Model_KeyDown);
            // 
            // txt_Brand
            // 
            this.txt_Brand.AnimateReadOnly = false;
            this.txt_Brand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Brand.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Brand.Depth = 0;
            this.txt_Brand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Brand.HideSelection = true;
            this.txt_Brand.Hint = "برند ماشین";
            this.txt_Brand.LeadingIcon = null;
            this.txt_Brand.Location = new System.Drawing.Point(112, 38);
            this.txt_Brand.MaxLength = 32767;
            this.txt_Brand.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.PasswordChar = '\0';
            this.txt_Brand.PrefixSuffixText = null;
            this.txt_Brand.ReadOnly = false;
            this.txt_Brand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Brand.SelectedText = "";
            this.txt_Brand.SelectionLength = 0;
            this.txt_Brand.SelectionStart = 0;
            this.txt_Brand.ShortcutsEnabled = true;
            this.txt_Brand.ShowAssistiveText = true;
            this.txt_Brand.Size = new System.Drawing.Size(248, 64);
            this.txt_Brand.TabIndex = 6;
            this.txt_Brand.TabStop = false;
            this.txt_Brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Brand.TrailingIcon = null;
            this.txt_Brand.UseSystemPasswordChar = false;
            this.txt_Brand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Brand_KeyDown);
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
            this.txt_LastName.Location = new System.Drawing.Point(1180, 38);
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
            this.txt_LastName.TabIndex = 2;
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
            this.txt_PhoneNumber.Location = new System.Drawing.Point(367, 39);
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
            this.txt_PhoneNumber.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(846, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "تاریخ تولد";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dp_Birthday
            // 
            this.dp_Birthday.Date = "1403/06/05";
            this.dp_Birthday.FocusColor = System.Drawing.Color.White;
            this.dp_Birthday.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Birthday.Location = new System.Drawing.Point(640, 51);
            this.dp_Birthday.Name = "dp_Birthday";
            this.dp_Birthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Birthday.Size = new System.Drawing.Size(200, 24);
            this.dp_Birthday.TabIndex = 4;
            this.dp_Birthday.Load += new System.EventHandler(this.dp_Birthday_Load);
            this.dp_Birthday.Click += new System.EventHandler(this.dp_Birthday_Click);
            this.dp_Birthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dp_Birthday_KeyDown);
            this.dp_Birthday.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.dp_Birthday_ChangeUICues);
            this.dp_Birthday.Validated += new System.EventHandler(this.dp_Birthday_Validated);
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
            this.cmb_Sex.Location = new System.Drawing.Point(926, 38);
            this.cmb_Sex.MaxDropDownItems = 4;
            this.cmb_Sex.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Sex.Name = "cmb_Sex";
            this.cmb_Sex.Size = new System.Drawing.Size(248, 49);
            this.cmb_Sex.StartIndex = 0;
            this.cmb_Sex.TabIndex = 3;
            this.cmb_Sex.SelectedIndexChanged += new System.EventHandler(this.cmb_Sex_SelectedIndexChanged);
            this.cmb_Sex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Sex_KeyDown);
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
            this.txt_Name.Location = new System.Drawing.Point(1301, 38);
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
            this.txt_Name.TabIndex = 1;
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
            this.txt_NationalCode.Hint = "کد ملی صاحب ماشین";
            this.txt_NationalCode.LeadingIcon = null;
            this.txt_NationalCode.Location = new System.Drawing.Point(1422, 38);
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
            this.txt_NationalCode.TabIndex = 0;
            this.txt_NationalCode.TabStop = false;
            this.txt_NationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NationalCode.TrailingIcon = null;
            this.txt_NationalCode.UseSystemPasswordChar = false;
            this.txt_NationalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NationalCode_KeyDown);
            // 
            // frm_CarSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 1100);
            this.Controls.Add(this.panel1);
            this.Name = "frm_CarSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_CarSearch_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Car)).EndInit();
            this.pnl_TXT.ResumeLayout(false);
            this.pnl_TXT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
        private System.Windows.Forms.Panel pnl_TXT;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Gmail;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Capacity;
        private System.Windows.Forms.Label label3;
        private PersianDate.DatePicker dp_CreateDate;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Number2;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Iran;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Number1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Character;
        private MaterialSkin.Controls.MaterialComboBox cmb_Type;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Model;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Brand;
        private MaterialSkin.Controls.MaterialTextBox2 txt_LastName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label1;
        private PersianDate.DatePicker dp_Birthday;
        private MaterialSkin.Controls.MaterialComboBox cmb_Sex;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Name;
        private MaterialSkin.Controls.MaterialTextBox2 txt_NationalCode;
        public System.Windows.Forms.DataGridView dgv_Car;
    }
}