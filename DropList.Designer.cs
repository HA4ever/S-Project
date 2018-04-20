namespace Measurement_System
{
    partial class DropList
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
            this.PBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBox = new System.Windows.Forms.ComboBox();
            this.Done = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PBox
            // 
            this.PBox.FormattingEnabled = true;
            this.PBox.Items.AddRange(new object[] {
            "Small",
            "Medium ",
            "Large ",
            "X-Large",
            "XX-LARGE",
            "XXX-LARGE"});
            this.PBox.Location = new System.Drawing.Point(90, 132);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(104, 21);
            this.PBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Pants Size :";
            // 
            // TBox
            // 
            this.TBox.FormattingEnabled = true;
            this.TBox.Items.AddRange(new object[] {
            "Small",
            "Medium ",
            "Large ",
            "X-Large",
            "XX-LARGE",
            "XXX-LARGE"});
            this.TBox.Location = new System.Drawing.Point(90, 69);
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(104, 21);
            this.TBox.TabIndex = 10;
            this.TBox.SelectedIndexChanged += new System.EventHandler(this.TBox_SelectedIndexChanged);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(42, 201);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 9;
            this.Done.Text = "DONE";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(168, 201);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select T-Shirt  Size :";
            // 
            // DropList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Name = "DropList";
            this.Text = "DropList";
            this.Load += new System.EventHandler(this.DropList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TBox;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}