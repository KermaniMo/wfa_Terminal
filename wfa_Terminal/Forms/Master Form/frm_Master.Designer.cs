﻿
namespace wfa_Terminal.Forms.Master_Form
{
    partial class frm_Master
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pic_Min = new System.Windows.Forms.PictureBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnl_Top.Controls.Add(this.pic_Min);
            this.pnl_Top.Controls.Add(this.pic_Exit);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(900, 35);
            this.pnl_Top.TabIndex = 0;
            // 
            // pic_Min
            // 
            this.pic_Min.Image = global::wfa_Terminal.Properties.Resources.minus;
            this.pic_Min.Location = new System.Drawing.Point(436, 1);
            this.pic_Min.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Min.Name = "pic_Min";
            this.pic_Min.Size = new System.Drawing.Size(30, 32);
            this.pic_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Min.TabIndex = 2;
            this.pic_Min.TabStop = false;
            this.pic_Min.Click += new System.EventHandler(this.pic_Min_Click);
            // 
            // pic_Exit
            // 
            this.pic_Exit.Image = global::wfa_Terminal.Properties.Resources.reject;
            this.pic_Exit.Location = new System.Drawing.Point(858, 4);
            this.pic_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(30, 32);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Exit.TabIndex = 1;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.pic_Exit_Click);
            // 
            // frm_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Master";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Master_Load);
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.PictureBox pic_Exit;
        protected System.Windows.Forms.PictureBox pic_Min;
        protected System.Windows.Forms.Panel pnl_Top;
    }
}