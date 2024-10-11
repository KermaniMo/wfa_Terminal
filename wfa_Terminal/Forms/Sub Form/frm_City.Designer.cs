
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_City
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_City = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Province = new System.Windows.Forms.DataGridView();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Switch_City = new MaterialSkin.Controls.MaterialSwitch();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.btn_Edit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Insert = new MaterialSkin.Controls.MaterialButton();
            this.txt_City = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Province = new MaterialSkin.Controls.MaterialTextBox2();
            this.RowCountCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Delete = new MaterialSkin.Controls.MaterialButton();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_City)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Province)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1240, 39);
            // 
            // pic_Min
            // 
            this.pic_Min.Location = new System.Drawing.Point(1082, 1);
            // 
            // pic_Exit
            // 
            this.pic_Exit.Location = new System.Drawing.Point(1119, 1);
            // 
            // pnl_Title
            // 
            this.pnl_Title.Location = new System.Drawing.Point(10, 55);
            this.pnl_Title.Size = new System.Drawing.Size(1134, 56);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(1055, 55);
            this.lbl_Title.Size = new System.Drawing.Size(0, 21);
            this.lbl_Title.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 394);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgv_City);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(688, 201);
            this.panel5.TabIndex = 4;
            // 
            // dgv_City
            // 
            this.dgv_City.AllowUserToAddRows = false;
            this.dgv_City.AllowUserToDeleteRows = false;
            this.dgv_City.AllowUserToResizeColumns = false;
            this.dgv_City.AllowUserToResizeRows = false;
            this.dgv_City.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_City.BackgroundColor = System.Drawing.Color.White;
            this.dgv_City.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_City.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_City.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_City.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_City.ColumnHeadersHeight = 29;
            this.dgv_City.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_City.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCountCity});
            this.dgv_City.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_City.EnableHeadersVisualStyles = false;
            this.dgv_City.GridColor = System.Drawing.Color.White;
            this.dgv_City.Location = new System.Drawing.Point(0, 0);
            this.dgv_City.MultiSelect = false;
            this.dgv_City.Name = "dgv_City";
            this.dgv_City.ReadOnly = true;
            this.dgv_City.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_City.RowHeadersVisible = false;
            this.dgv_City.RowHeadersWidth = 51;
            this.dgv_City.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_City.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_City.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_City.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_City.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgv_City.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_City.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_City.RowTemplate.DividerHeight = 1;
            this.dgv_City.RowTemplate.Height = 35;
            this.dgv_City.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_City.Size = new System.Drawing.Size(688, 201);
            this.dgv_City.TabIndex = 1;
            this.dgv_City.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_City_CellClick);
            this.dgv_City.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_City_CellFormatting);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(688, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Province);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 183);
            this.panel2.TabIndex = 2;
            // 
            // dgv_Province
            // 
            this.dgv_Province.AllowUserToAddRows = false;
            this.dgv_Province.AllowUserToDeleteRows = false;
            this.dgv_Province.AllowUserToResizeColumns = false;
            this.dgv_Province.AllowUserToResizeRows = false;
            this.dgv_Province.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Province.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Province.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Province.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Province.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Province.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Province.ColumnHeadersHeight = 29;
            this.dgv_Province.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Province.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCount});
            this.dgv_Province.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Province.EnableHeadersVisualStyles = false;
            this.dgv_Province.GridColor = System.Drawing.Color.White;
            this.dgv_Province.Location = new System.Drawing.Point(0, 0);
            this.dgv_Province.MultiSelect = false;
            this.dgv_Province.Name = "dgv_Province";
            this.dgv_Province.ReadOnly = true;
            this.dgv_Province.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Province.RowHeadersVisible = false;
            this.dgv_Province.RowHeadersWidth = 51;
            this.dgv_Province.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Province.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Province.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Province.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Province.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgv_Province.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_Province.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Province.RowTemplate.DividerHeight = 1;
            this.dgv_Province.RowTemplate.Height = 35;
            this.dgv_Province.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Province.Size = new System.Drawing.Size(688, 183);
            this.dgv_Province.TabIndex = 0;
            this.dgv_Province.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Province_CellClick);
            this.dgv_Province.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Province_CellFormatting);
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
            this.panel3.Controls.Add(this.Switch_City);
            this.panel3.Controls.Add(this.btn_Save);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Controls.Add(this.btn_Insert);
            this.panel3.Controls.Add(this.txt_City);
            this.panel3.Controls.Add(this.txt_Province);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(688, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 394);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Switch_City
            // 
            this.Switch_City.AutoSize = true;
            this.Switch_City.Depth = 0;
            this.Switch_City.Enabled = false;
            this.Switch_City.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch_City.Location = new System.Drawing.Point(14, 94);
            this.Switch_City.Margin = new System.Windows.Forms.Padding(0);
            this.Switch_City.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Switch_City.MouseState = MaterialSkin.MouseState.HOVER;
            this.Switch_City.Name = "Switch_City";
            this.Switch_City.Ripple = true;
            this.Switch_City.Size = new System.Drawing.Size(106, 37);
            this.Switch_City.TabIndex = 12;
            this.Switch_City.Text = "افزودن شهر";
            this.Switch_City.UseCompatibleTextRendering = true;
            this.Switch_City.UseVisualStyleBackColor = true;
            this.Switch_City.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Save.Depth = 0;
            this.btn_Save.HighEmphasis = true;
            this.btn_Save.Icon = global::wfa_Terminal.Properties.Resources.diskette__1_;
            this.btn_Save.Location = new System.Drawing.Point(443, 343);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Save.Size = new System.Drawing.Size(80, 36);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "ذخیره";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = false;
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Edit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Edit.Depth = 0;
            this.btn_Edit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.HighEmphasis = true;
            this.btn_Edit.Icon = global::wfa_Terminal.Properties.Resources.edit_button;
            this.btn_Edit.Location = new System.Drawing.Point(236, 237);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Edit.Size = new System.Drawing.Size(89, 36);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "ویرایش";
            this.btn_Edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Edit.UseAccentColor = true;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Insert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Insert.Depth = 0;
            this.btn_Insert.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.HighEmphasis = true;
            this.btn_Insert.Icon = global::wfa_Terminal.Properties.Resources.row;
            this.btn_Insert.Location = new System.Drawing.Point(128, 237);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Insert.Size = new System.Drawing.Size(86, 36);
            this.btn_Insert.TabIndex = 7;
            this.btn_Insert.Text = "افزودن";
            this.btn_Insert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Insert.UseAccentColor = true;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // txt_City
            // 
            this.txt_City.AnimateReadOnly = false;
            this.txt_City.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_City.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_City.Depth = 0;
            this.txt_City.ErrorMessage = "شهر را وارد کنید";
            this.txt_City.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_City.HideSelection = true;
            this.txt_City.Hint = "شهر";
            this.txt_City.LeadingIcon = null;
            this.txt_City.Location = new System.Drawing.Point(162, 134);
            this.txt_City.MaxLength = 32767;
            this.txt_City.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_City.Name = "txt_City";
            this.txt_City.PasswordChar = '\0';
            this.txt_City.PrefixSuffixText = null;
            this.txt_City.ReadOnly = false;
            this.txt_City.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_City.SelectedText = "";
            this.txt_City.SelectionLength = 0;
            this.txt_City.SelectionStart = 0;
            this.txt_City.ShortcutsEnabled = true;
            this.txt_City.ShowAssistiveText = true;
            this.txt_City.Size = new System.Drawing.Size(238, 64);
            this.txt_City.TabIndex = 6;
            this.txt_City.TabStop = false;
            this.txt_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_City.TrailingIcon = null;
            this.txt_City.UseSystemPasswordChar = false;
            this.txt_City.Visible = false;
            this.txt_City.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_City_KeyDown);
            // 
            // txt_Province
            // 
            this.txt_Province.AnimateReadOnly = false;
            this.txt_Province.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Province.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Province.Depth = 0;
            this.txt_Province.ErrorMessage = "استان را وارد کنید";
            this.txt_Province.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Province.HideSelection = true;
            this.txt_Province.Hint = "استان";
            this.txt_Province.LeadingIcon = null;
            this.txt_Province.Location = new System.Drawing.Point(162, 43);
            this.txt_Province.MaxLength = 32767;
            this.txt_Province.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Province.Name = "txt_Province";
            this.txt_Province.PasswordChar = '\0';
            this.txt_Province.PrefixSuffixText = null;
            this.txt_Province.ReadOnly = false;
            this.txt_Province.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Province.SelectedText = "";
            this.txt_Province.SelectionLength = 0;
            this.txt_Province.SelectionStart = 0;
            this.txt_Province.ShortcutsEnabled = true;
            this.txt_Province.ShowAssistiveText = true;
            this.txt_Province.Size = new System.Drawing.Size(238, 64);
            this.txt_Province.TabIndex = 0;
            this.txt_Province.TabStop = false;
            this.txt_Province.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Province.TrailingIcon = null;
            this.txt_Province.UseSystemPasswordChar = false;
            this.txt_Province.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Province_KeyDown);
            this.txt_Province.TextChanged += new System.EventHandler(this.txt_Province_TextChanged);
            // 
            // RowCountCity
            // 
            this.RowCountCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RowCountCity.FillWeight = 20F;
            this.RowCountCity.HeaderText = "ردیف";
            this.RowCountCity.MinimumWidth = 6;
            this.RowCountCity.Name = "RowCountCity";
            this.RowCountCity.ReadOnly = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Delete.Depth = 0;
            this.btn_Delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.HighEmphasis = true;
            this.btn_Delete.Icon = global::wfa_Terminal.Properties.Resources.folder__1_;
            this.btn_Delete.Location = new System.Drawing.Point(348, 237);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Delete.Size = new System.Drawing.Size(76, 36);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Delete.UseAccentColor = true;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 548);
            this.Controls.Add(this.panel1);
            this.Name = "frm_City";
            this.Load += new System.EventHandler(this.frm_City_Load);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_City)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Province)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_City;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Province;
        private MaterialSkin.Controls.MaterialTextBox2 txt_City;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private MaterialSkin.Controls.MaterialButton btn_Edit;
        private MaterialSkin.Controls.MaterialButton btn_Insert;
        private MaterialSkin.Controls.MaterialSwitch Switch_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCountCity;
        private MaterialSkin.Controls.MaterialButton btn_Delete;
    }
}