
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_TripSearch
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Trip = new System.Windows.Forms.DataGridView();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Control = new System.Windows.Forms.Panel();
            this.txt_Description = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cmb_Status = new MaterialSkin.Controls.MaterialComboBox();
            this.tp_Arrive = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dp_Arrive = new PersianDate.DatePicker();
            this.tp_Move = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dp_Move = new PersianDate.DatePicker();
            this.txt_Capacity = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Price = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Car = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmb_SecondCity = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_SecondProvince = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_FirstCity = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_FirstProvince = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_SecondDriver = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_FirstDriver = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trip)).BeginInit();
            this.pnl_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1708, 39);
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
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1708, 791);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Trip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1708, 460);
            this.panel2.TabIndex = 1;
            // 
            // dgv_Trip
            // 
            this.dgv_Trip.AllowUserToAddRows = false;
            this.dgv_Trip.AllowUserToDeleteRows = false;
            this.dgv_Trip.AllowUserToResizeColumns = false;
            this.dgv_Trip.AllowUserToResizeRows = false;
            this.dgv_Trip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Trip.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Trip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Trip.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Trip.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Trip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Trip.ColumnHeadersHeight = 29;
            this.dgv_Trip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Trip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCount});
            this.dgv_Trip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Trip.EnableHeadersVisualStyles = false;
            this.dgv_Trip.GridColor = System.Drawing.Color.White;
            this.dgv_Trip.Location = new System.Drawing.Point(0, 0);
            this.dgv_Trip.MultiSelect = false;
            this.dgv_Trip.Name = "dgv_Trip";
            this.dgv_Trip.ReadOnly = true;
            this.dgv_Trip.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Trip.RowHeadersVisible = false;
            this.dgv_Trip.RowHeadersWidth = 51;
            this.dgv_Trip.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Trip.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Trip.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Trip.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Trip.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgv_Trip.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_Trip.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Trip.RowTemplate.DividerHeight = 1;
            this.dgv_Trip.RowTemplate.Height = 35;
            this.dgv_Trip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Trip.Size = new System.Drawing.Size(1708, 460);
            this.dgv_Trip.TabIndex = 1;
            this.dgv_Trip.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Trip_CellDoubleClick);
            this.dgv_Trip.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Trip_CellFormatting);
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
            this.pnl_Control.Controls.Add(this.txt_Description);
            this.pnl_Control.Controls.Add(this.cmb_Status);
            this.pnl_Control.Controls.Add(this.tp_Arrive);
            this.pnl_Control.Controls.Add(this.label3);
            this.pnl_Control.Controls.Add(this.label4);
            this.pnl_Control.Controls.Add(this.dp_Arrive);
            this.pnl_Control.Controls.Add(this.tp_Move);
            this.pnl_Control.Controls.Add(this.label2);
            this.pnl_Control.Controls.Add(this.label1);
            this.pnl_Control.Controls.Add(this.dp_Move);
            this.pnl_Control.Controls.Add(this.txt_Capacity);
            this.pnl_Control.Controls.Add(this.txt_Price);
            this.pnl_Control.Controls.Add(this.txt_Car);
            this.pnl_Control.Controls.Add(this.cmb_SecondCity);
            this.pnl_Control.Controls.Add(this.cmb_SecondProvince);
            this.pnl_Control.Controls.Add(this.cmb_FirstCity);
            this.pnl_Control.Controls.Add(this.cmb_FirstProvince);
            this.pnl_Control.Controls.Add(this.txt_SecondDriver);
            this.pnl_Control.Controls.Add(this.txt_FirstDriver);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(1708, 331);
            this.pnl_Control.TabIndex = 0;
            // 
            // txt_Description
            // 
            this.txt_Description.AnimateReadOnly = false;
            this.txt_Description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Description.Depth = 0;
            this.txt_Description.HideSelection = true;
            this.txt_Description.Hint = "توضیحات";
            this.txt_Description.Location = new System.Drawing.Point(813, 175);
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
            this.txt_Description.Size = new System.Drawing.Size(248, 103);
            this.txt_Description.TabIndex = 43;
            this.txt_Description.TabStop = false;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Description.UseSystemPasswordChar = false;
            this.txt_Description.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Description_KeyDown);
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
            this.cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Hint = "وضعیت";
            this.cmb_Status.IntegralHeight = false;
            this.cmb_Status.ItemHeight = 43;
            this.cmb_Status.Location = new System.Drawing.Point(813, 104);
            this.cmb_Status.MaxDropDownItems = 4;
            this.cmb_Status.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(248, 49);
            this.cmb_Status.StartIndex = 0;
            this.cmb_Status.TabIndex = 42;
            this.cmb_Status.SelectedIndexChanged += new System.EventHandler(this.cmb_Status_SelectedIndexChanged);
            // 
            // tp_Arrive
            // 
            this.tp_Arrive.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tp_Arrive.Location = new System.Drawing.Point(153, 98);
            this.tp_Arrive.Name = "tp_Arrive";
            this.tp_Arrive.ShowUpDown = true;
            this.tp_Arrive.Size = new System.Drawing.Size(200, 26);
            this.tp_Arrive.TabIndex = 41;
            this.tp_Arrive.Value = new System.DateTime(2024, 8, 31, 18, 17, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(359, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "زمان رسیدن";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(639, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "تاریخ رسیدن";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dp_Arrive
            // 
            this.dp_Arrive.Date = "1403/06/17";
            this.dp_Arrive.FocusColor = System.Drawing.Color.White;
            this.dp_Arrive.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Arrive.Location = new System.Drawing.Point(450, 98);
            this.dp_Arrive.Name = "dp_Arrive";
            this.dp_Arrive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Arrive.Size = new System.Drawing.Size(183, 24);
            this.dp_Arrive.TabIndex = 38;
            // 
            // tp_Move
            // 
            this.tp_Move.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tp_Move.Location = new System.Drawing.Point(153, 44);
            this.tp_Move.Name = "tp_Move";
            this.tp_Move.ShowUpDown = true;
            this.tp_Move.Size = new System.Drawing.Size(200, 26);
            this.tp_Move.TabIndex = 37;
            this.tp_Move.Value = new System.DateTime(2024, 8, 31, 18, 17, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(359, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "زمان حرکت";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(639, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "تاریخ حرکت";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dp_Move
            // 
            this.dp_Move.Date = "1403/06/17";
            this.dp_Move.FocusColor = System.Drawing.Color.White;
            this.dp_Move.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Move.Location = new System.Drawing.Point(450, 44);
            this.dp_Move.Name = "dp_Move";
            this.dp_Move.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Move.Size = new System.Drawing.Size(183, 24);
            this.dp_Move.TabIndex = 34;
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.AnimateReadOnly = false;
            this.txt_Capacity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Capacity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Capacity.Depth = 0;
            this.txt_Capacity.ErrorMessage = "نامعتبر";
            this.txt_Capacity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Capacity.HideSelection = true;
            this.txt_Capacity.Hint = "ظرفیت";
            this.txt_Capacity.LeadingIcon = null;
            this.txt_Capacity.Location = new System.Drawing.Point(813, 34);
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
            this.txt_Capacity.TabIndex = 33;
            this.txt_Capacity.TabStop = false;
            this.txt_Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Capacity.TrailingIcon = null;
            this.txt_Capacity.UseSystemPasswordChar = false;
            this.txt_Capacity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Capacity_KeyDown);
            // 
            // txt_Price
            // 
            this.txt_Price.AnimateReadOnly = false;
            this.txt_Price.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Price.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Price.Depth = 0;
            this.txt_Price.ErrorMessage = "نامعتبر";
            this.txt_Price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.HideSelection = true;
            this.txt_Price.Hint = "قیمت";
            this.txt_Price.LeadingIcon = null;
            this.txt_Price.Location = new System.Drawing.Point(1121, 244);
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
            this.txt_Price.TabIndex = 32;
            this.txt_Price.TabStop = false;
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Price.TrailingIcon = null;
            this.txt_Price.UseSystemPasswordChar = false;
            this.txt_Price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Price_KeyDown);
            // 
            // txt_Car
            // 
            this.txt_Car.AnimateReadOnly = false;
            this.txt_Car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Car.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Car.Depth = 0;
            this.txt_Car.ErrorMessage = "نامعتبر";
            this.txt_Car.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Car.HideSelection = true;
            this.txt_Car.Hint = "ماشین";
            this.txt_Car.LeadingIcon = null;
            this.txt_Car.Location = new System.Drawing.Point(1433, 244);
            this.txt_Car.MaxLength = 32767;
            this.txt_Car.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Car.Name = "txt_Car";
            this.txt_Car.PasswordChar = '\0';
            this.txt_Car.PrefixSuffixText = null;
            this.txt_Car.ReadOnly = false;
            this.txt_Car.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Car.SelectedText = "";
            this.txt_Car.SelectionLength = 0;
            this.txt_Car.SelectionStart = 0;
            this.txt_Car.ShortcutsEnabled = true;
            this.txt_Car.ShowAssistiveText = true;
            this.txt_Car.Size = new System.Drawing.Size(248, 64);
            this.txt_Car.TabIndex = 31;
            this.txt_Car.TabStop = false;
            this.txt_Car.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Car.TrailingIcon = null;
            this.txt_Car.UseSystemPasswordChar = false;
            this.txt_Car.Click += new System.EventHandler(this.txt_Car_Click);
            this.txt_Car.Enter += new System.EventHandler(this.txt_Car_Enter);
            this.txt_Car.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FirstDriver_KeyPress);
            // 
            // cmb_SecondCity
            // 
            this.cmb_SecondCity.AutoResize = false;
            this.cmb_SecondCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_SecondCity.Depth = 0;
            this.cmb_SecondCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_SecondCity.DropDownHeight = 174;
            this.cmb_SecondCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SecondCity.DropDownWidth = 121;
            this.cmb_SecondCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_SecondCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_SecondCity.FormattingEnabled = true;
            this.cmb_SecondCity.Hint = "شهر مقصد";
            this.cmb_SecondCity.IntegralHeight = false;
            this.cmb_SecondCity.ItemHeight = 43;
            this.cmb_SecondCity.Location = new System.Drawing.Point(1121, 175);
            this.cmb_SecondCity.MaxDropDownItems = 4;
            this.cmb_SecondCity.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_SecondCity.Name = "cmb_SecondCity";
            this.cmb_SecondCity.Size = new System.Drawing.Size(248, 49);
            this.cmb_SecondCity.StartIndex = 0;
            this.cmb_SecondCity.TabIndex = 30;
            this.cmb_SecondCity.SelectedIndexChanged += new System.EventHandler(this.cmb_SecondCity_SelectedIndexChanged);
            // 
            // cmb_SecondProvince
            // 
            this.cmb_SecondProvince.AutoResize = false;
            this.cmb_SecondProvince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_SecondProvince.Depth = 0;
            this.cmb_SecondProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_SecondProvince.DropDownHeight = 174;
            this.cmb_SecondProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SecondProvince.DropDownWidth = 121;
            this.cmb_SecondProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_SecondProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_SecondProvince.FormattingEnabled = true;
            this.cmb_SecondProvince.Hint = "استان مقصد";
            this.cmb_SecondProvince.IntegralHeight = false;
            this.cmb_SecondProvince.ItemHeight = 43;
            this.cmb_SecondProvince.Location = new System.Drawing.Point(1121, 104);
            this.cmb_SecondProvince.MaxDropDownItems = 4;
            this.cmb_SecondProvince.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_SecondProvince.Name = "cmb_SecondProvince";
            this.cmb_SecondProvince.Size = new System.Drawing.Size(248, 49);
            this.cmb_SecondProvince.StartIndex = 0;
            this.cmb_SecondProvince.TabIndex = 29;
            this.cmb_SecondProvince.SelectedIndexChanged += new System.EventHandler(this.cmb_SecondProvince_SelectedIndexChanged);
            // 
            // cmb_FirstCity
            // 
            this.cmb_FirstCity.AutoResize = false;
            this.cmb_FirstCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_FirstCity.Depth = 0;
            this.cmb_FirstCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_FirstCity.DropDownHeight = 174;
            this.cmb_FirstCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FirstCity.DropDownWidth = 121;
            this.cmb_FirstCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_FirstCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_FirstCity.FormattingEnabled = true;
            this.cmb_FirstCity.Hint = "شهر مبدا";
            this.cmb_FirstCity.IntegralHeight = false;
            this.cmb_FirstCity.ItemHeight = 43;
            this.cmb_FirstCity.Location = new System.Drawing.Point(1433, 175);
            this.cmb_FirstCity.MaxDropDownItems = 4;
            this.cmb_FirstCity.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_FirstCity.Name = "cmb_FirstCity";
            this.cmb_FirstCity.Size = new System.Drawing.Size(248, 49);
            this.cmb_FirstCity.StartIndex = 0;
            this.cmb_FirstCity.TabIndex = 28;
            this.cmb_FirstCity.SelectedIndexChanged += new System.EventHandler(this.cmb_FirstCity_SelectedIndexChanged);
            // 
            // cmb_FirstProvince
            // 
            this.cmb_FirstProvince.AutoResize = false;
            this.cmb_FirstProvince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_FirstProvince.Depth = 0;
            this.cmb_FirstProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_FirstProvince.DropDownHeight = 174;
            this.cmb_FirstProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FirstProvince.DropDownWidth = 121;
            this.cmb_FirstProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_FirstProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_FirstProvince.FormattingEnabled = true;
            this.cmb_FirstProvince.Hint = "استان مبدا";
            this.cmb_FirstProvince.IntegralHeight = false;
            this.cmb_FirstProvince.ItemHeight = 43;
            this.cmb_FirstProvince.Location = new System.Drawing.Point(1433, 104);
            this.cmb_FirstProvince.MaxDropDownItems = 4;
            this.cmb_FirstProvince.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_FirstProvince.Name = "cmb_FirstProvince";
            this.cmb_FirstProvince.Size = new System.Drawing.Size(248, 49);
            this.cmb_FirstProvince.StartIndex = 0;
            this.cmb_FirstProvince.TabIndex = 27;
            this.cmb_FirstProvince.SelectedIndexChanged += new System.EventHandler(this.cmb_FirstProvince_SelectedIndexChanged);
            // 
            // txt_SecondDriver
            // 
            this.txt_SecondDriver.AnimateReadOnly = false;
            this.txt_SecondDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_SecondDriver.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_SecondDriver.Depth = 0;
            this.txt_SecondDriver.ErrorMessage = "نامعتبر";
            this.txt_SecondDriver.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SecondDriver.HideSelection = true;
            this.txt_SecondDriver.Hint = "راننده دوم";
            this.txt_SecondDriver.LeadingIcon = null;
            this.txt_SecondDriver.Location = new System.Drawing.Point(1121, 34);
            this.txt_SecondDriver.MaxLength = 32767;
            this.txt_SecondDriver.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_SecondDriver.Name = "txt_SecondDriver";
            this.txt_SecondDriver.PasswordChar = '\0';
            this.txt_SecondDriver.PrefixSuffixText = null;
            this.txt_SecondDriver.ReadOnly = false;
            this.txt_SecondDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SecondDriver.SelectedText = "";
            this.txt_SecondDriver.SelectionLength = 0;
            this.txt_SecondDriver.SelectionStart = 0;
            this.txt_SecondDriver.ShortcutsEnabled = true;
            this.txt_SecondDriver.ShowAssistiveText = true;
            this.txt_SecondDriver.Size = new System.Drawing.Size(248, 64);
            this.txt_SecondDriver.TabIndex = 12;
            this.txt_SecondDriver.TabStop = false;
            this.txt_SecondDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SecondDriver.TrailingIcon = null;
            this.txt_SecondDriver.UseSystemPasswordChar = false;
            this.txt_SecondDriver.Click += new System.EventHandler(this.txt_SecondDriver_Click);
            this.txt_SecondDriver.Enter += new System.EventHandler(this.txt_SecondDriver_Enter);
            this.txt_SecondDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FirstDriver_KeyPress);
            // 
            // txt_FirstDriver
            // 
            this.txt_FirstDriver.AnimateReadOnly = false;
            this.txt_FirstDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_FirstDriver.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_FirstDriver.Depth = 0;
            this.txt_FirstDriver.ErrorMessage = "نامعتبر";
            this.txt_FirstDriver.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstDriver.HideSelection = true;
            this.txt_FirstDriver.Hint = "راننده اول";
            this.txt_FirstDriver.LeadingIcon = null;
            this.txt_FirstDriver.Location = new System.Drawing.Point(1433, 34);
            this.txt_FirstDriver.MaxLength = 32767;
            this.txt_FirstDriver.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_FirstDriver.Name = "txt_FirstDriver";
            this.txt_FirstDriver.PasswordChar = '\0';
            this.txt_FirstDriver.PrefixSuffixText = null;
            this.txt_FirstDriver.ReadOnly = false;
            this.txt_FirstDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_FirstDriver.SelectedText = "";
            this.txt_FirstDriver.SelectionLength = 0;
            this.txt_FirstDriver.SelectionStart = 0;
            this.txt_FirstDriver.ShortcutsEnabled = true;
            this.txt_FirstDriver.ShowAssistiveText = true;
            this.txt_FirstDriver.Size = new System.Drawing.Size(248, 64);
            this.txt_FirstDriver.TabIndex = 11;
            this.txt_FirstDriver.TabStop = false;
            this.txt_FirstDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_FirstDriver.TrailingIcon = null;
            this.txt_FirstDriver.UseSystemPasswordChar = false;
            this.txt_FirstDriver.Click += new System.EventHandler(this.txt_FirstDriver_Click);
            this.txt_FirstDriver.Enter += new System.EventHandler(this.txt_FirstDriver_Enter);
            this.txt_FirstDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FirstDriver_KeyPress);
            // 
            // frm_TripSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 942);
            this.Controls.Add(this.panel1);
            this.Name = "frm_TripSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TripSearch_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trip)).EndInit();
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
        private System.Windows.Forms.Panel pnl_Control;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_Description;
        private MaterialSkin.Controls.MaterialComboBox cmb_Status;
        private System.Windows.Forms.DateTimePicker tp_Arrive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private PersianDate.DatePicker dp_Arrive;
        private System.Windows.Forms.DateTimePicker tp_Move;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PersianDate.DatePicker dp_Move;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Capacity;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Price;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Car;
        private MaterialSkin.Controls.MaterialComboBox cmb_SecondCity;
        private MaterialSkin.Controls.MaterialComboBox cmb_SecondProvince;
        private MaterialSkin.Controls.MaterialComboBox cmb_FirstCity;
        private MaterialSkin.Controls.MaterialComboBox cmb_FirstProvince;
        private MaterialSkin.Controls.MaterialTextBox2 txt_SecondDriver;
        private MaterialSkin.Controls.MaterialTextBox2 txt_FirstDriver;
        public System.Windows.Forms.DataGridView dgv_Trip;
    }
}