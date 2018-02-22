namespace Measurement_System
{
    partial class AdminMain
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
            this.EXIT = new System.Windows.Forms.Button();
            this.Manage_Employee = new System.Windows.Forms.Button();
            this.Prouduce_Size_Report = new System.Windows.Forms.Button();
            this.Manage_Order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(400, 260);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(121, 36);
            this.EXIT.TabIndex = 0;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Manage_Employee
            // 
            this.Manage_Employee.Location = new System.Drawing.Point(13, 32);
            this.Manage_Employee.Name = "Manage_Employee";
            this.Manage_Employee.Size = new System.Drawing.Size(236, 45);
            this.Manage_Employee.TabIndex = 1;
            this.Manage_Employee.Text = "Manage Employee";
            this.Manage_Employee.UseVisualStyleBackColor = true;
            this.Manage_Employee.Click += new System.EventHandler(this.Manage_Employee_Click);
            // 
            // Prouduce_Size_Report
            // 
            this.Prouduce_Size_Report.Location = new System.Drawing.Point(14, 98);
            this.Prouduce_Size_Report.Name = "Prouduce_Size_Report";
            this.Prouduce_Size_Report.Size = new System.Drawing.Size(234, 48);
            this.Prouduce_Size_Report.TabIndex = 2;
            this.Prouduce_Size_Report.Text = "Prouduce Size Report";
            this.Prouduce_Size_Report.UseVisualStyleBackColor = true;
            this.Prouduce_Size_Report.Click += new System.EventHandler(this.Prouduce_Size_Report_Click);
            // 
            // Manage_Order
            // 
            this.Manage_Order.Location = new System.Drawing.Point(16, 167);
            this.Manage_Order.Name = "Manage_Order";
            this.Manage_Order.Size = new System.Drawing.Size(231, 49);
            this.Manage_Order.TabIndex = 3;
            this.Manage_Order.Text = "Manage Order";
            this.Manage_Order.UseVisualStyleBackColor = true;
            this.Manage_Order.Click += new System.EventHandler(this.Manage_Order_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 308);
            this.Controls.Add(this.Manage_Order);
            this.Controls.Add(this.Prouduce_Size_Report);
            this.Controls.Add(this.Manage_Employee);
            this.Controls.Add(this.EXIT);
            this.Name = "AdminMain";
            this.Text = "MASUREMENT SYSTEM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button Manage_Employee;
        private System.Windows.Forms.Button Prouduce_Size_Report;
        private System.Windows.Forms.Button Manage_Order;
    }
}