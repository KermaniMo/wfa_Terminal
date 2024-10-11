
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_ManageTicket
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
            this.dgv_ManageTicket = new System.Windows.Forms.DataGridView();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Control = new System.Windows.Forms.Panel();
            this.btn_Extradition = new MaterialSkin.Controls.MaterialButton();
            this.pic_SearchArrive = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dp_Arrive = new PersianDate.DatePicker();
            this.pic_SearchMove = new System.Windows.Forms.PictureBox();
            this.pic_SearchCity2 = new System.Windows.Forms.PictureBox();
            this.pic_SearchCity1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dp_Move = new PersianDate.DatePicker();
            this.txt_City2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_City1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.lbl_NameLastName = new System.Windows.Forms.Label();
            this.lbl_NationalCode = new System.Windows.Forms.Label();
            this.lbl_InsertPassenger = new System.Windows.Forms.Label();
            this.txt_TicketCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageTicket)).BeginInit();
            this.pnl_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchArrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchCity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchCity1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1353, 39);
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
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 681);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_ManageTicket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 477);
            this.panel2.TabIndex = 1;
            // 
            // dgv_ManageTicket
            // 
            this.dgv_ManageTicket.AllowUserToAddRows = false;
            this.dgv_ManageTicket.AllowUserToDeleteRows = false;
            this.dgv_ManageTicket.AllowUserToResizeColumns = false;
            this.dgv_ManageTicket.AllowUserToResizeRows = false;
            this.dgv_ManageTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ManageTicket.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ManageTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ManageTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_ManageTicket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ManageTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ManageTicket.ColumnHeadersHeight = 29;
            this.dgv_ManageTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ManageTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCount});
            this.dgv_ManageTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ManageTicket.EnableHeadersVisualStyles = false;
            this.dgv_ManageTicket.GridColor = System.Drawing.Color.White;
            this.dgv_ManageTicket.Location = new System.Drawing.Point(0, 0);
            this.dgv_ManageTicket.MultiSelect = false;
            this.dgv_ManageTicket.Name = "dgv_ManageTicket";
            this.dgv_ManageTicket.ReadOnly = true;
            this.dgv_ManageTicket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ManageTicket.RowHeadersVisible = false;
            this.dgv_ManageTicket.RowHeadersWidth = 51;
            this.dgv_ManageTicket.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ManageTicket.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_ManageTicket.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_ManageTicket.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ManageTicket.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgv_ManageTicket.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_ManageTicket.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_ManageTicket.RowTemplate.DividerHeight = 1;
            this.dgv_ManageTicket.RowTemplate.Height = 35;
            this.dgv_ManageTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ManageTicket.Size = new System.Drawing.Size(1353, 477);
            this.dgv_ManageTicket.TabIndex = 1;
            this.dgv_ManageTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ManageTicket_CellClick);
            this.dgv_ManageTicket.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ManageTicket_CellFormatting);
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
            this.pnl_Control.Controls.Add(this.btn_Extradition);
            this.pnl_Control.Controls.Add(this.pic_SearchArrive);
            this.pnl_Control.Controls.Add(this.label1);
            this.pnl_Control.Controls.Add(this.dp_Arrive);
            this.pnl_Control.Controls.Add(this.pic_SearchMove);
            this.pnl_Control.Controls.Add(this.pic_SearchCity2);
            this.pnl_Control.Controls.Add(this.pic_SearchCity1);
            this.pnl_Control.Controls.Add(this.label3);
            this.pnl_Control.Controls.Add(this.dp_Move);
            this.pnl_Control.Controls.Add(this.txt_City2);
            this.pnl_Control.Controls.Add(this.txt_City1);
            this.pnl_Control.Controls.Add(this.lbl_NameLastName);
            this.pnl_Control.Controls.Add(this.lbl_NationalCode);
            this.pnl_Control.Controls.Add(this.lbl_InsertPassenger);
            this.pnl_Control.Controls.Add(this.txt_TicketCode);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(1353, 204);
            this.pnl_Control.TabIndex = 0;
            // 
            // btn_Extradition
            // 
            this.btn_Extradition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Extradition.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Extradition.Depth = 0;
            this.btn_Extradition.Enabled = false;
            this.btn_Extradition.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Extradition.HighEmphasis = true;
            this.btn_Extradition.Icon = global::wfa_Terminal.Properties.Resources.file;
            this.btn_Extradition.Location = new System.Drawing.Point(29, 138);
            this.btn_Extradition.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Extradition.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Extradition.Name = "btn_Extradition";
            this.btn_Extradition.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Extradition.Size = new System.Drawing.Size(113, 36);
            this.btn_Extradition.TabIndex = 132;
            this.btn_Extradition.Text = "برگشت زدن";
            this.btn_Extradition.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Extradition.UseAccentColor = true;
            this.btn_Extradition.UseVisualStyleBackColor = true;
            this.btn_Extradition.Click += new System.EventHandler(this.btn_Extradition_Click);
            // 
            // pic_SearchArrive
            // 
            this.pic_SearchArrive.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchArrive.Location = new System.Drawing.Point(628, 121);
            this.pic_SearchArrive.Name = "pic_SearchArrive";
            this.pic_SearchArrive.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchArrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchArrive.TabIndex = 131;
            this.pic_SearchArrive.TabStop = false;
            this.pic_SearchArrive.Click += new System.EventHandler(this.pic_SearchArrive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(894, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 130;
            this.label1.Text = "تاریخ رسیدن";
            // 
            // dp_Arrive
            // 
            this.dp_Arrive.Date = "1403/06/18";
            this.dp_Arrive.FocusColor = System.Drawing.Color.White;
            this.dp_Arrive.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Arrive.Location = new System.Drawing.Point(688, 138);
            this.dp_Arrive.Name = "dp_Arrive";
            this.dp_Arrive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Arrive.Size = new System.Drawing.Size(200, 24);
            this.dp_Arrive.TabIndex = 129;
            // 
            // pic_SearchMove
            // 
            this.pic_SearchMove.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchMove.Location = new System.Drawing.Point(989, 121);
            this.pic_SearchMove.Name = "pic_SearchMove";
            this.pic_SearchMove.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchMove.TabIndex = 128;
            this.pic_SearchMove.TabStop = false;
            this.pic_SearchMove.Click += new System.EventHandler(this.pic_SearchMove_Click);
            // 
            // pic_SearchCity2
            // 
            this.pic_SearchCity2.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchCity2.Location = new System.Drawing.Point(29, 35);
            this.pic_SearchCity2.Name = "pic_SearchCity2";
            this.pic_SearchCity2.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchCity2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchCity2.TabIndex = 127;
            this.pic_SearchCity2.TabStop = false;
            this.pic_SearchCity2.Click += new System.EventHandler(this.pic_SearchCity2_Click);
            // 
            // pic_SearchCity1
            // 
            this.pic_SearchCity1.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchCity1.Location = new System.Drawing.Point(345, 35);
            this.pic_SearchCity1.Name = "pic_SearchCity1";
            this.pic_SearchCity1.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchCity1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchCity1.TabIndex = 126;
            this.pic_SearchCity1.TabStop = false;
            this.pic_SearchCity1.Click += new System.EventHandler(this.pic_SearchCity1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1255, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 125;
            this.label3.Text = "تاریخ حرکت";
            // 
            // dp_Move
            // 
            this.dp_Move.Date = "1403/06/18";
            this.dp_Move.FocusColor = System.Drawing.Color.White;
            this.dp_Move.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Move.Location = new System.Drawing.Point(1049, 138);
            this.dp_Move.Name = "dp_Move";
            this.dp_Move.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Move.Size = new System.Drawing.Size(200, 24);
            this.dp_Move.TabIndex = 124;
            // 
            // txt_City2
            // 
            this.txt_City2.AnimateReadOnly = false;
            this.txt_City2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_City2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_City2.Depth = 0;
            this.txt_City2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_City2.HideSelection = true;
            this.txt_City2.Hint = "شهر مقصد";
            this.txt_City2.LeadingIcon = null;
            this.txt_City2.Location = new System.Drawing.Point(89, 37);
            this.txt_City2.MaxLength = 32767;
            this.txt_City2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_City2.Name = "txt_City2";
            this.txt_City2.PasswordChar = '\0';
            this.txt_City2.PrefixSuffixText = null;
            this.txt_City2.ReadOnly = false;
            this.txt_City2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_City2.SelectedText = "";
            this.txt_City2.SelectionLength = 0;
            this.txt_City2.SelectionStart = 0;
            this.txt_City2.ShortcutsEnabled = true;
            this.txt_City2.Size = new System.Drawing.Size(250, 48);
            this.txt_City2.TabIndex = 123;
            this.txt_City2.TabStop = false;
            this.txt_City2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_City2.TrailingIcon = null;
            this.txt_City2.UseSystemPasswordChar = false;
            this.txt_City2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_City2_KeyDown);
            // 
            // txt_City1
            // 
            this.txt_City1.AnimateReadOnly = false;
            this.txt_City1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_City1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_City1.Depth = 0;
            this.txt_City1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_City1.HideSelection = true;
            this.txt_City1.Hint = "شهر مبدا";
            this.txt_City1.LeadingIcon = null;
            this.txt_City1.Location = new System.Drawing.Point(405, 37);
            this.txt_City1.MaxLength = 32767;
            this.txt_City1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_City1.Name = "txt_City1";
            this.txt_City1.PasswordChar = '\0';
            this.txt_City1.PrefixSuffixText = null;
            this.txt_City1.ReadOnly = false;
            this.txt_City1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_City1.SelectedText = "";
            this.txt_City1.SelectionLength = 0;
            this.txt_City1.SelectionStart = 0;
            this.txt_City1.ShortcutsEnabled = true;
            this.txt_City1.Size = new System.Drawing.Size(250, 48);
            this.txt_City1.TabIndex = 122;
            this.txt_City1.TabStop = false;
            this.txt_City1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_City1.TrailingIcon = null;
            this.txt_City1.UseSystemPasswordChar = false;
            this.txt_City1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_City1_KeyDown);
            // 
            // lbl_NameLastName
            // 
            this.lbl_NameLastName.AutoSize = true;
            this.lbl_NameLastName.Location = new System.Drawing.Point(740, 53);
            this.lbl_NameLastName.Name = "lbl_NameLastName";
            this.lbl_NameLastName.Size = new System.Drawing.Size(0, 18);
            this.lbl_NameLastName.TabIndex = 121;
            // 
            // lbl_NationalCode
            // 
            this.lbl_NationalCode.AutoSize = true;
            this.lbl_NationalCode.Location = new System.Drawing.Point(866, 53);
            this.lbl_NationalCode.Name = "lbl_NationalCode";
            this.lbl_NationalCode.Size = new System.Drawing.Size(0, 18);
            this.lbl_NationalCode.TabIndex = 120;
            // 
            // lbl_InsertPassenger
            // 
            this.lbl_InsertPassenger.AutoSize = true;
            this.lbl_InsertPassenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_InsertPassenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lbl_InsertPassenger.Location = new System.Drawing.Point(997, 53);
            this.lbl_InsertPassenger.Name = "lbl_InsertPassenger";
            this.lbl_InsertPassenger.Size = new System.Drawing.Size(48, 18);
            this.lbl_InsertPassenger.TabIndex = 119;
            this.lbl_InsertPassenger.Text = "مسافر";
            this.lbl_InsertPassenger.Click += new System.EventHandler(this.lbl_InsertPassenger_Click);
            // 
            // txt_TicketCode
            // 
            this.txt_TicketCode.AnimateReadOnly = false;
            this.txt_TicketCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_TicketCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_TicketCode.Depth = 0;
            this.txt_TicketCode.ErrorMessage = "نامعتبر";
            this.txt_TicketCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TicketCode.HideSelection = true;
            this.txt_TicketCode.Hint = "کد رهگیری";
            this.txt_TicketCode.LeadingIcon = null;
            this.txt_TicketCode.Location = new System.Drawing.Point(1082, 37);
            this.txt_TicketCode.MaxLength = 10;
            this.txt_TicketCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_TicketCode.Name = "txt_TicketCode";
            this.txt_TicketCode.PasswordChar = '\0';
            this.txt_TicketCode.PrefixSuffixText = null;
            this.txt_TicketCode.ReadOnly = false;
            this.txt_TicketCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_TicketCode.SelectedText = "";
            this.txt_TicketCode.SelectionLength = 0;
            this.txt_TicketCode.SelectionStart = 0;
            this.txt_TicketCode.ShortcutsEnabled = true;
            this.txt_TicketCode.ShowAssistiveText = true;
            this.txt_TicketCode.Size = new System.Drawing.Size(248, 64);
            this.txt_TicketCode.TabIndex = 11;
            this.txt_TicketCode.TabStop = false;
            this.txt_TicketCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_TicketCode.TrailingIcon = null;
            this.txt_TicketCode.UseSystemPasswordChar = false;
            this.txt_TicketCode.TextChanged += new System.EventHandler(this.txt_TicketCode_TextChanged);
            // 
            // frm_ManageTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 904);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ManageTicket";
            this.Load += new System.EventHandler(this.frm_ManageTicket_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageTicket)).EndInit();
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchArrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchCity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchCity1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgv_ManageTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
        private System.Windows.Forms.Panel pnl_Control;
        private MaterialSkin.Controls.MaterialTextBox2 txt_TicketCode;
        private System.Windows.Forms.Label lbl_NameLastName;
        private System.Windows.Forms.Label lbl_NationalCode;
        private System.Windows.Forms.Label lbl_InsertPassenger;
        private System.Windows.Forms.PictureBox pic_SearchMove;
        private System.Windows.Forms.PictureBox pic_SearchCity2;
        private System.Windows.Forms.PictureBox pic_SearchCity1;
        private System.Windows.Forms.Label label3;
        private PersianDate.DatePicker dp_Move;
        private MaterialSkin.Controls.MaterialTextBox2 txt_City2;
        private MaterialSkin.Controls.MaterialTextBox2 txt_City1;
        private System.Windows.Forms.PictureBox pic_SearchArrive;
        private System.Windows.Forms.Label label1;
        private PersianDate.DatePicker dp_Arrive;
        private MaterialSkin.Controls.MaterialButton btn_Extradition;
    }
}