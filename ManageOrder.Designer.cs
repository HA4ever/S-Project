namespace Measurement_System
{
    partial class ManageOrder
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
            this.BACK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewOrdersBut = new System.Windows.Forms.Button();
            this.ChangeStateBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(356, 313);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(82, 30);
            this.BACK.TabIndex = 0;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // ViewOrdersBut
            // 
            this.ViewOrdersBut.Location = new System.Drawing.Point(249, 258);
            this.ViewOrdersBut.Name = "ViewOrdersBut";
            this.ViewOrdersBut.Size = new System.Drawing.Size(84, 36);
            this.ViewOrdersBut.TabIndex = 4;
            this.ViewOrdersBut.Text = "View Orders";
            this.ViewOrdersBut.UseVisualStyleBackColor = true;
            this.ViewOrdersBut.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChangeStateBut
            // 
            this.ChangeStateBut.Location = new System.Drawing.Point(339, 258);
            this.ChangeStateBut.Name = "ChangeStateBut";
            this.ChangeStateBut.Size = new System.Drawing.Size(85, 36);
            this.ChangeStateBut.TabIndex = 3;
            this.ChangeStateBut.Text = "Change State";
            this.ChangeStateBut.UseVisualStyleBackColor = true;
            this.ChangeStateBut.Click += new System.EventHandler(this.ChangeStateBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "W = WAITING  ,  A = ACCEPT  , R = REJECT ,  D = DELEVERD";
            // 
            // ManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewOrdersBut);
            this.Controls.Add(this.ChangeStateBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BACK);
            this.Name = "ManageOrder";
            this.Text = "ManageOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewOrdersBut;
        private System.Windows.Forms.Button ChangeStateBut;
        private System.Windows.Forms.Label label1;
    }
}