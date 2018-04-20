namespace Measurement_System
{
    partial class Choosing
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
            this.Back = new System.Windows.Forms.Button();
            this.Drop_Btn = new System.Windows.Forms.Button();
            this.kin_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(97, 194);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Drop_Btn
            // 
            this.Drop_Btn.Location = new System.Drawing.Point(159, 111);
            this.Drop_Btn.Name = "Drop_Btn";
            this.Drop_Btn.Size = new System.Drawing.Size(100, 23);
            this.Drop_Btn.TabIndex = 6;
            this.Drop_Btn.Text = "Drop down List";
            this.Drop_Btn.UseVisualStyleBackColor = true;
            this.Drop_Btn.Click += new System.EventHandler(this.Drop_Btn_Click);
            // 
            // kin_but
            // 
            this.kin_but.Location = new System.Drawing.Point(30, 111);
            this.kin_but.Name = "kin_but";
            this.kin_but.Size = new System.Drawing.Size(75, 23);
            this.kin_but.TabIndex = 5;
            this.kin_but.Text = "Kinect";
            this.kin_but.UseVisualStyleBackColor = true;
            this.kin_but.Click += new System.EventHandler(this.kin_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Taking body size by :";
            // 
            // Choosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Drop_Btn);
            this.Controls.Add(this.kin_but);
            this.Controls.Add(this.label1);
            this.Name = "Choosing";
            this.Text = "Choosing";
            this.Load += new System.EventHandler(this.Choosing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Drop_Btn;
        private System.Windows.Forms.Button kin_but;
        private System.Windows.Forms.Label label1;
    }
}