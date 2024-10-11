
namespace wfa_Terminal.Forms.Sub_Form
{
    partial class frm_BookTicket
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
            this.txt_City1 = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_City2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.dp_Move = new PersianDate.DatePicker();
            this.pic_SearchCity1 = new System.Windows.Forms.PictureBox();
            this.pic_SearchCity2 = new System.Windows.Forms.PictureBox();
            this.pic_SearchMove = new System.Windows.Forms.PictureBox();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchCity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchCity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchMove)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1327, 39);
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
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 350);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_City1
            // 
            this.txt_City1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_City1.AnimateReadOnly = false;
            this.txt_City1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_City1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_City1.Depth = 0;
            this.txt_City1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_City1.HideSelection = true;
            this.txt_City1.Hint = "شهر مبدا";
            this.txt_City1.LeadingIcon = null;
            this.txt_City1.Location = new System.Drawing.Point(747, 135);
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
            this.txt_City1.TabIndex = 6;
            this.txt_City1.TabStop = false;
            this.txt_City1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_City1.TrailingIcon = null;
            this.txt_City1.UseSystemPasswordChar = false;
            this.txt_City1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_City1_KeyDown);
            // 
            // txt_City2
            // 
            this.txt_City2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_City2.AnimateReadOnly = false;
            this.txt_City2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_City2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_City2.Depth = 0;
            this.txt_City2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_City2.HideSelection = true;
            this.txt_City2.Hint = "شهر مقصد";
            this.txt_City2.LeadingIcon = null;
            this.txt_City2.Location = new System.Drawing.Point(431, 135);
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
            this.txt_City2.TabIndex = 7;
            this.txt_City2.TabStop = false;
            this.txt_City2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_City2.TrailingIcon = null;
            this.txt_City2.UseSystemPasswordChar = false;
            this.txt_City2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_City2_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(287, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 95;
            this.label3.Text = "تاریخ حرکت";
            // 
            // dp_Move
            // 
            this.dp_Move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dp_Move.Date = "1403/06/17";
            this.dp_Move.FocusColor = System.Drawing.Color.White;
            this.dp_Move.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dp_Move.Location = new System.Drawing.Point(81, 150);
            this.dp_Move.Name = "dp_Move";
            this.dp_Move.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dp_Move.Size = new System.Drawing.Size(200, 24);
            this.dp_Move.TabIndex = 94;
            this.dp_Move.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dp_Move_KeyDown);
            // 
            // pic_SearchCity1
            // 
            this.pic_SearchCity1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_SearchCity1.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchCity1.Location = new System.Drawing.Point(687, 133);
            this.pic_SearchCity1.Name = "pic_SearchCity1";
            this.pic_SearchCity1.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchCity1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchCity1.TabIndex = 96;
            this.pic_SearchCity1.TabStop = false;
            this.pic_SearchCity1.Click += new System.EventHandler(this.pic_SearchNationalCode_Click);
            // 
            // pic_SearchCity2
            // 
            this.pic_SearchCity2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_SearchCity2.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchCity2.Location = new System.Drawing.Point(371, 133);
            this.pic_SearchCity2.Name = "pic_SearchCity2";
            this.pic_SearchCity2.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchCity2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchCity2.TabIndex = 97;
            this.pic_SearchCity2.TabStop = false;
            this.pic_SearchCity2.Click += new System.EventHandler(this.pic_City2_Click);
            // 
            // pic_SearchMove
            // 
            this.pic_SearchMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_SearchMove.Image = global::wfa_Terminal.Properties.Resources.search;
            this.pic_SearchMove.Location = new System.Drawing.Point(21, 133);
            this.pic_SearchMove.Name = "pic_SearchMove";
            this.pic_SearchMove.Size = new System.Drawing.Size(54, 53);
            this.pic_SearchMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SearchMove.TabIndex = 98;
            this.pic_SearchMove.TabStop = false;
            this.pic_SearchMove.Click += new System.EventHandler(this.pic_Move_Click);
            // 
            // frm_BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 565);
            this.Controls.Add(this.pic_SearchMove);
            this.Controls.Add(this.pic_SearchCity2);
            this.Controls.Add(this.pic_SearchCity1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dp_Move);
            this.Controls.Add(this.txt_City2);
            this.Controls.Add(this.txt_City1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_BookTicket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BookTicket_Load);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Title, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txt_City1, 0);
            this.Controls.SetChildIndex(this.txt_City2, 0);
            this.Controls.SetChildIndex(this.dp_Move, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pic_SearchCity1, 0);
            this.Controls.SetChildIndex(this.pic_SearchCity2, 0);
            this.Controls.SetChildIndex(this.pic_SearchMove, 0);
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchCity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchCity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SearchMove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_City1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_City2;
        private System.Windows.Forms.Label label3;
        private PersianDate.DatePicker dp_Move;
        private System.Windows.Forms.PictureBox pic_SearchCity1;
        private System.Windows.Forms.PictureBox pic_SearchCity2;
        private System.Windows.Forms.PictureBox pic_SearchMove;
    }
}