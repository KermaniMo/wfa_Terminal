
namespace wfa_Terminal.Forms.Grand_Forms
{
    partial class frm_Trip
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
            this.btn_Bank = new System.Windows.Forms.Button();
            this.btn_PayType = new System.Windows.Forms.Button();
            this.btn_Passenger = new System.Windows.Forms.Button();
            this.btn_MakeTicket = new System.Windows.Forms.Button();
            this.btn_TicketBook = new System.Windows.Forms.Button();
            this.btn_TicketManage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Exit
            // 
            this.pic_Exit.Location = new System.Drawing.Point(975, 1);
            this.pic_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // pic_Min
            // 
            this.pic_Min.Location = new System.Drawing.Point(934, 1);
            this.pic_Min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(1942, 35);
            // 
            // btn_Bank
            // 
            this.btn_Bank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_Bank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bank.Image = global::wfa_Terminal.Properties.Resources.bank;
            this.btn_Bank.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Bank.Location = new System.Drawing.Point(1226, 61);
            this.btn_Bank.Name = "btn_Bank";
            this.btn_Bank.Size = new System.Drawing.Size(190, 81);
            this.btn_Bank.TabIndex = 8;
            this.btn_Bank.Text = "بانک ";
            this.btn_Bank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bank.UseVisualStyleBackColor = true;
            this.btn_Bank.Click += new System.EventHandler(this.btn_Bank_Click);
            // 
            // btn_PayType
            // 
            this.btn_PayType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_PayType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_PayType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PayType.Image = global::wfa_Terminal.Properties.Resources.coin1;
            this.btn_PayType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PayType.Location = new System.Drawing.Point(1437, 61);
            this.btn_PayType.Name = "btn_PayType";
            this.btn_PayType.Size = new System.Drawing.Size(190, 81);
            this.btn_PayType.TabIndex = 9;
            this.btn_PayType.Text = "روش پرداخت";
            this.btn_PayType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PayType.UseVisualStyleBackColor = true;
            this.btn_PayType.Click += new System.EventHandler(this.btn_PayType_Click);
            // 
            // btn_Passenger
            // 
            this.btn_Passenger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_Passenger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Passenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Passenger.Image = global::wfa_Terminal.Properties.Resources.traveler1;
            this.btn_Passenger.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Passenger.Location = new System.Drawing.Point(1226, 166);
            this.btn_Passenger.Name = "btn_Passenger";
            this.btn_Passenger.Size = new System.Drawing.Size(190, 81);
            this.btn_Passenger.TabIndex = 10;
            this.btn_Passenger.Text = "مسافر";
            this.btn_Passenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Passenger.UseVisualStyleBackColor = true;
            this.btn_Passenger.Click += new System.EventHandler(this.btn_Passenger_Click);
            // 
            // btn_MakeTicket
            // 
            this.btn_MakeTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_MakeTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_MakeTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MakeTicket.Image = global::wfa_Terminal.Properties.Resources.journey2;
            this.btn_MakeTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MakeTicket.Location = new System.Drawing.Point(1437, 166);
            this.btn_MakeTicket.Name = "btn_MakeTicket";
            this.btn_MakeTicket.Size = new System.Drawing.Size(190, 81);
            this.btn_MakeTicket.TabIndex = 11;
            this.btn_MakeTicket.Text = "ساخت بلیط";
            this.btn_MakeTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MakeTicket.UseVisualStyleBackColor = true;
            this.btn_MakeTicket.Click += new System.EventHandler(this.btn_MakeTicket_Click);
            // 
            // btn_TicketBook
            // 
            this.btn_TicketBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_TicketBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_TicketBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TicketBook.Image = global::wfa_Terminal.Properties.Resources.tickets;
            this.btn_TicketBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TicketBook.Location = new System.Drawing.Point(1226, 270);
            this.btn_TicketBook.Name = "btn_TicketBook";
            this.btn_TicketBook.Size = new System.Drawing.Size(190, 81);
            this.btn_TicketBook.TabIndex = 12;
            this.btn_TicketBook.Text = "رزرو بلیط";
            this.btn_TicketBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TicketBook.UseVisualStyleBackColor = true;
            this.btn_TicketBook.Click += new System.EventHandler(this.btn_TicketBook_Click);
            // 
            // btn_TicketManage
            // 
            this.btn_TicketManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_TicketManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_TicketManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TicketManage.Image = global::wfa_Terminal.Properties.Resources.ticket;
            this.btn_TicketManage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TicketManage.Location = new System.Drawing.Point(1437, 270);
            this.btn_TicketManage.Name = "btn_TicketManage";
            this.btn_TicketManage.Size = new System.Drawing.Size(190, 81);
            this.btn_TicketManage.TabIndex = 13;
            this.btn_TicketManage.Text = "مدیریت بلیط";
            this.btn_TicketManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TicketManage.UseVisualStyleBackColor = true;
            this.btn_TicketManage.Click += new System.EventHandler(this.btn_TicketManage_Click);
            // 
            // frm_Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.btn_TicketManage);
            this.Controls.Add(this.btn_TicketBook);
            this.Controls.Add(this.btn_MakeTicket);
            this.Controls.Add(this.btn_Passenger);
            this.Controls.Add(this.btn_PayType);
            this.Controls.Add(this.btn_Bank);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Trip";
            this.Load += new System.EventHandler(this.frm_Trip_Load);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.btn_Bank, 0);
            this.Controls.SetChildIndex(this.btn_PayType, 0);
            this.Controls.SetChildIndex(this.btn_Passenger, 0);
            this.Controls.SetChildIndex(this.btn_MakeTicket, 0);
            this.Controls.SetChildIndex(this.btn_TicketBook, 0);
            this.Controls.SetChildIndex(this.btn_TicketManage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bank;
        private System.Windows.Forms.Button btn_PayType;
        private System.Windows.Forms.Button btn_Passenger;
        private System.Windows.Forms.Button btn_MakeTicket;
        private System.Windows.Forms.Button btn_TicketBook;
        private System.Windows.Forms.Button btn_TicketManage;
    }
}