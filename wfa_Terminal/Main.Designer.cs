
namespace wfa_Terminal
{
    partial class frm_Main
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
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.btn_Permisan = new System.Windows.Forms.Button();
            this.btn_Trip = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.pnl_Active = new System.Windows.Forms.Panel();
            this.pnl_Sensor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.pnl_Draw.SuspendLayout();
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Exit
            // 
            this.pic_Exit.Location = new System.Drawing.Point(867, 1);
            // 
            // pic_Min
            // 
            this.pic_Min.Location = new System.Drawing.Point(830, 1);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Size = new System.Drawing.Size(999, 35);
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnl_Draw.Controls.Add(this.btn_Permisan);
            this.pnl_Draw.Controls.Add(this.btn_Trip);
            this.pnl_Draw.Controls.Add(this.btn_Dashboard);
            this.pnl_Draw.Location = new System.Drawing.Point(788, 0);
            this.pnl_Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(190, 563);
            this.pnl_Draw.TabIndex = 1;
            this.pnl_Draw.Visible = false;
            this.pnl_Draw.MouseLeave += new System.EventHandler(this.pnl_Draw_MouseLeave);
            this.pnl_Draw.MouseHover += new System.EventHandler(this.pnl_Draw_MouseHover);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            // 
            // btn_Permisan
            // 
            this.btn_Permisan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Permisan.FlatAppearance.BorderSize = 0;
            this.btn_Permisan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btn_Permisan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Permisan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Permisan.Image = global::wfa_Terminal.Properties.Resources.crime_investigation1;
            this.btn_Permisan.Location = new System.Drawing.Point(0, 138);
            this.btn_Permisan.Name = "btn_Permisan";
            this.btn_Permisan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Permisan.Size = new System.Drawing.Size(190, 69);
            this.btn_Permisan.TabIndex = 2;
            this.btn_Permisan.TabStop = false;
            this.btn_Permisan.Text = "دسترسی";
            this.btn_Permisan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Permisan.UseVisualStyleBackColor = true;
            this.btn_Permisan.Visible = false;
            this.btn_Permisan.Click += new System.EventHandler(this.btn_Permisan_Click);
            // 
            // btn_Trip
            // 
            this.btn_Trip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Trip.FlatAppearance.BorderSize = 0;
            this.btn_Trip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btn_Trip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Trip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Trip.Image = global::wfa_Terminal.Properties.Resources.travel_bag1;
            this.btn_Trip.Location = new System.Drawing.Point(0, 69);
            this.btn_Trip.Name = "btn_Trip";
            this.btn_Trip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Trip.Size = new System.Drawing.Size(190, 69);
            this.btn_Trip.TabIndex = 1;
            this.btn_Trip.TabStop = false;
            this.btn_Trip.Text = "سفر";
            this.btn_Trip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Trip.UseVisualStyleBackColor = true;
            this.btn_Trip.Click += new System.EventHandler(this.btn_Trip_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btn_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Image = global::wfa_Terminal.Properties.Resources.dashboard4;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Dashboard.Size = new System.Drawing.Size(190, 69);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.TabStop = false;
            this.btn_Dashboard.Text = "داشبورد";
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_Form.Controls.Add(this.pnl_Active);
            this.pnl_Form.Controls.Add(this.pnl_Draw);
            this.pnl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Form.Location = new System.Drawing.Point(10, 35);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(979, 563);
            this.pnl_Form.TabIndex = 2;
            this.pnl_Form.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Form_Paint);
            this.pnl_Form.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Form_MouseMove);
            // 
            // pnl_Active
            // 
            this.pnl_Active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pnl_Active.Location = new System.Drawing.Point(809, 7);
            this.pnl_Active.Name = "pnl_Active";
            this.pnl_Active.Size = new System.Drawing.Size(5, 50);
            this.pnl_Active.TabIndex = 2;
            // 
            // pnl_Sensor
            // 
            this.pnl_Sensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnl_Sensor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Sensor.Location = new System.Drawing.Point(989, 35);
            this.pnl_Sensor.Name = "pnl_Sensor";
            this.pnl_Sensor.Size = new System.Drawing.Size(10, 573);
            this.pnl_Sensor.TabIndex = 3;
            this.pnl_Sensor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_sensor_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 10);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 563);
            this.panel2.TabIndex = 5;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(999, 608);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Sensor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Main_MouseMove);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Sensor, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pnl_Form, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Draw.ResumeLayout(false);
            this.pnl_Form.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Permisan;
        private System.Windows.Forms.Button btn_Trip;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Panel pnl_Sensor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnl_Active;
    }
}

