
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_Degree
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
            this.dgv_Degree = new System.Windows.Forms.DataGridView();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_Submit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Delete = new MaterialSkin.Controls.MaterialButton();
            this.btn_Edit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Insert = new MaterialSkin.Controls.MaterialButton();
            this.txt_Degree = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Degree)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(830, 39);
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
            this.pnl_Title.Location = new System.Drawing.Point(10, 51);
            this.pnl_Title.Size = new System.Drawing.Size(1132, 56);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Location = new System.Drawing.Point(1053, 11);
            this.lbl_Title.Size = new System.Drawing.Size(0, 21);
            this.lbl_Title.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 393);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Degree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 393);
            this.panel2.TabIndex = 2;
            // 
            // dgv_Degree
            // 
            this.dgv_Degree.AllowUserToAddRows = false;
            this.dgv_Degree.AllowUserToDeleteRows = false;
            this.dgv_Degree.AllowUserToResizeColumns = false;
            this.dgv_Degree.AllowUserToResizeRows = false;
            this.dgv_Degree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Degree.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Degree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Degree.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Degree.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Degree.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Degree.ColumnHeadersHeight = 29;
            this.dgv_Degree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Degree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCount});
            this.dgv_Degree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Degree.EnableHeadersVisualStyles = false;
            this.dgv_Degree.GridColor = System.Drawing.Color.White;
            this.dgv_Degree.Location = new System.Drawing.Point(0, 0);
            this.dgv_Degree.MultiSelect = false;
            this.dgv_Degree.Name = "dgv_Degree";
            this.dgv_Degree.ReadOnly = true;
            this.dgv_Degree.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Degree.RowHeadersVisible = false;
            this.dgv_Degree.RowHeadersWidth = 51;
            this.dgv_Degree.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Degree.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Degree.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Degree.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Degree.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgv_Degree.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgv_Degree.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Degree.RowTemplate.DividerHeight = 1;
            this.dgv_Degree.RowTemplate.Height = 35;
            this.dgv_Degree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Degree.Size = new System.Drawing.Size(486, 393);
            this.dgv_Degree.TabIndex = 0;
            this.dgv_Degree.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Degree_CellClick);
            this.dgv_Degree.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Degree_CellFormatting);
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
            this.panel3.Controls.Add(this.btn_Cancel);
            this.panel3.Controls.Add(this.btn_Submit);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Controls.Add(this.btn_Insert);
            this.panel3.Controls.Add(this.txt_Degree);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(486, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 393);
            this.panel3.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Cancel.Depth = 0;
            this.btn_Cancel.HighEmphasis = true;
            this.btn_Cancel.Icon = global::wfa_Terminal.Properties.Resources.cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(163, 303);
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
            this.btn_Submit.Location = new System.Drawing.Point(74, 303);
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
            this.btn_Delete.Location = new System.Drawing.Point(241, 231);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Delete.Size = new System.Drawing.Size(76, 36);
            this.btn_Delete.TabIndex = 3;
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
            this.btn_Edit.Location = new System.Drawing.Point(129, 231);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Edit.Size = new System.Drawing.Size(89, 36);
            this.btn_Edit.TabIndex = 2;
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
            this.btn_Insert.Location = new System.Drawing.Point(21, 231);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_Insert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Insert.Size = new System.Drawing.Size(86, 36);
            this.btn_Insert.TabIndex = 1;
            this.btn_Insert.Text = "افزودن";
            this.btn_Insert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Insert.UseAccentColor = true;
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // txt_Degree
            // 
            this.txt_Degree.AnimateReadOnly = false;
            this.txt_Degree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Degree.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Degree.Depth = 0;
            this.txt_Degree.Enabled = false;
            this.txt_Degree.ErrorMessage = "مدرک را وارد کنید";
            this.txt_Degree.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Degree.HideSelection = true;
            this.txt_Degree.Hint = "مدرک";
            this.txt_Degree.LeadingIcon = null;
            this.txt_Degree.Location = new System.Drawing.Point(56, 30);
            this.txt_Degree.MaxLength = 32767;
            this.txt_Degree.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Degree.Name = "txt_Degree";
            this.txt_Degree.PasswordChar = '\0';
            this.txt_Degree.PrefixSuffixText = null;
            this.txt_Degree.ReadOnly = false;
            this.txt_Degree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Degree.SelectedText = "";
            this.txt_Degree.SelectionLength = 0;
            this.txt_Degree.SelectionStart = 0;
            this.txt_Degree.ShortcutsEnabled = true;
            this.txt_Degree.ShowAssistiveText = true;
            this.txt_Degree.Size = new System.Drawing.Size(238, 64);
            this.txt_Degree.TabIndex = 0;
            this.txt_Degree.TabStop = false;
            this.txt_Degree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Degree.TrailingIcon = null;
            this.txt_Degree.UseSystemPasswordChar = false;
            this.txt_Degree.Click += new System.EventHandler(this.txt_Degree_Click);
            this.txt_Degree.Enter += new System.EventHandler(this.txt_Degree_Enter);
            this.txt_Degree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Degree_KeyDown);
            this.txt_Degree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Degree_KeyPress);
            // 
            // frm_Degree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 530);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Degree";
            this.Load += new System.EventHandler(this.frm_Degree2_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Degree)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_Degree;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Degree;
        private MaterialSkin.Controls.MaterialButton btn_Insert;
        private MaterialSkin.Controls.MaterialButton btn_Edit;
        private MaterialSkin.Controls.MaterialButton btn_Delete;
        private MaterialSkin.Controls.MaterialButton btn_Submit;
        private MaterialSkin.Controls.MaterialButton btn_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
    }
}