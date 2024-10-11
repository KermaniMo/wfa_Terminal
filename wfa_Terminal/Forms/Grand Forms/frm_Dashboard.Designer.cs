
namespace wfa_Terminal.Forms.Grand_Forms
{
    partial class frm_Dashboard
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
            this.btn_Car = new System.Windows.Forms.Button();
            this.btn_Driver = new System.Windows.Forms.Button();
            this.btn_City = new System.Windows.Forms.Button();
            this.btn_Degree = new System.Windows.Forms.Button();
            this.btn_DriverManagment = new System.Windows.Forms.Button();
            this.btn_InputOutput = new System.Windows.Forms.Button();
            this.btn_CarType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            this.pnl_Top.SuspendLayout();
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
            this.pnl_Top.Size = new System.Drawing.Size(1942, 35);
            // 
            // btn_Car
            // 
            this.btn_Car.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_Car.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Car.Image = global::wfa_Terminal.Properties.Resources.bus_school3;
            this.btn_Car.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Car.Location = new System.Drawing.Point(1115, 42);
            this.btn_Car.Name = "btn_Car";
            this.btn_Car.Size = new System.Drawing.Size(190, 81);
            this.btn_Car.TabIndex = 1;
            this.btn_Car.Text = "ماشین";
            this.btn_Car.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Car.UseVisualStyleBackColor = true;
            this.btn_Car.Click += new System.EventHandler(this.btn_Car_Click_1);
            // 
            // btn_Driver
            // 
            this.btn_Driver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_Driver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Driver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Driver.Image = global::wfa_Terminal.Properties.Resources.driver;
            this.btn_Driver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Driver.Location = new System.Drawing.Point(1312, 42);
            this.btn_Driver.Name = "btn_Driver";
            this.btn_Driver.Size = new System.Drawing.Size(190, 81);
            this.btn_Driver.TabIndex = 2;
            this.btn_Driver.Text = "ثبت راننده";
            this.btn_Driver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Driver.UseVisualStyleBackColor = true;
            this.btn_Driver.Click += new System.EventHandler(this.btn_Driver_Click);
            // 
            // btn_City
            // 
            this.btn_City.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_City.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_City.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_City.Image = global::wfa_Terminal.Properties.Resources.location;
            this.btn_City.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_City.Location = new System.Drawing.Point(1312, 129);
            this.btn_City.Name = "btn_City";
            this.btn_City.Size = new System.Drawing.Size(190, 81);
            this.btn_City.TabIndex = 3;
            this.btn_City.Text = "شهر و استان";
            this.btn_City.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_City.UseVisualStyleBackColor = true;
            this.btn_City.Click += new System.EventHandler(this.btn_City_Click);
            // 
            // btn_Degree
            // 
            this.btn_Degree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_Degree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_Degree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Degree.Image = global::wfa_Terminal.Properties.Resources.diploma;
            this.btn_Degree.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Degree.Location = new System.Drawing.Point(1116, 129);
            this.btn_Degree.Name = "btn_Degree";
            this.btn_Degree.Size = new System.Drawing.Size(190, 81);
            this.btn_Degree.TabIndex = 4;
            this.btn_Degree.Text = "ثبت مدرک";
            this.btn_Degree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Degree.UseVisualStyleBackColor = true;
            this.btn_Degree.Click += new System.EventHandler(this.btn_Degree_Click);
            // 
            // btn_DriverManagment
            // 
            this.btn_DriverManagment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_DriverManagment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_DriverManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DriverManagment.Image = global::wfa_Terminal.Properties.Resources.management;
            this.btn_DriverManagment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DriverManagment.Location = new System.Drawing.Point(1116, 216);
            this.btn_DriverManagment.Name = "btn_DriverManagment";
            this.btn_DriverManagment.Size = new System.Drawing.Size(190, 81);
            this.btn_DriverManagment.TabIndex = 5;
            this.btn_DriverManagment.Text = "مدیریت راننده";
            this.btn_DriverManagment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DriverManagment.UseVisualStyleBackColor = true;
            this.btn_DriverManagment.Click += new System.EventHandler(this.btn_DriverManagment_Click);
            // 
            // btn_InputOutput
            // 
            this.btn_InputOutput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_InputOutput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_InputOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InputOutput.Image = global::wfa_Terminal.Properties.Resources.notebook;
            this.btn_InputOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_InputOutput.Location = new System.Drawing.Point(1312, 216);
            this.btn_InputOutput.Name = "btn_InputOutput";
            this.btn_InputOutput.Size = new System.Drawing.Size(190, 81);
            this.btn_InputOutput.TabIndex = 6;
            this.btn_InputOutput.Text = "ورودی خروجی";
            this.btn_InputOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InputOutput.UseVisualStyleBackColor = true;
            this.btn_InputOutput.Click += new System.EventHandler(this.btn_InputOutput_Click);
            // 
            // btn_CarType
            // 
            this.btn_CarType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_CarType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_CarType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CarType.Image = global::wfa_Terminal.Properties.Resources.vehicles1;
            this.btn_CarType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CarType.Location = new System.Drawing.Point(920, 129);
            this.btn_CarType.Name = "btn_CarType";
            this.btn_CarType.Size = new System.Drawing.Size(190, 81);
            this.btn_CarType.TabIndex = 7;
            this.btn_CarType.Text = "نوع ماشین";
            this.btn_CarType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CarType.UseVisualStyleBackColor = true;
            this.btn_CarType.Click += new System.EventHandler(this.btn_CarType_Click);
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.btn_CarType);
            this.Controls.Add(this.btn_InputOutput);
            this.Controls.Add(this.btn_DriverManagment);
            this.Controls.Add(this.btn_Degree);
            this.Controls.Add(this.btn_City);
            this.Controls.Add(this.btn_Driver);
            this.Controls.Add(this.btn_Car);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Dashboard_MouseMove);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.btn_Car, 0);
            this.Controls.SetChildIndex(this.btn_Driver, 0);
            this.Controls.SetChildIndex(this.btn_City, 0);
            this.Controls.SetChildIndex(this.btn_Degree, 0);
            this.Controls.SetChildIndex(this.btn_DriverManagment, 0);
            this.Controls.SetChildIndex(this.btn_InputOutput, 0);
            this.Controls.SetChildIndex(this.btn_CarType, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Car;
        private System.Windows.Forms.Button btn_Driver;
        private System.Windows.Forms.Button btn_City;
        private System.Windows.Forms.Button btn_Degree;
        private System.Windows.Forms.Button btn_DriverManagment;
        private System.Windows.Forms.Button btn_InputOutput;
        private System.Windows.Forms.Button btn_CarType;
    }
}