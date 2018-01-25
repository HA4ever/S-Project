namespace WindowsFormsApp1
{
    partial class K
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
            this.pbstream = new System.Windows.Forms.PictureBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboStatus = new System.Windows.Forms.Label();
            this.lboConnectionID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbstream)).BeginInit();
            this.SuspendLayout();
            // 
            // pbstream
            // 
            this.pbstream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbstream.Location = new System.Drawing.Point(12, 79);
            this.pbstream.Name = "pbstream";
            this.pbstream.Size = new System.Drawing.Size(757, 261);
            this.pbstream.TabIndex = 0;
            this.pbstream.TabStop = false;
            // 
            // btnStream
            // 
            this.btnStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStream.Location = new System.Drawing.Point(623, 356);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(132, 30);
            this.btnStream.TabIndex = 1;
            this.btnStream.Text = "Stream";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection ID:";
            // 
            // lboStatus
            // 
            this.lboStatus.AutoSize = true;
            this.lboStatus.Location = new System.Drawing.Point(131, 8);
            this.lboStatus.Name = "lboStatus";
            this.lboStatus.Size = new System.Drawing.Size(11, 13);
            this.lboStatus.TabIndex = 4;
            this.lboStatus.Text = "-";
            // 
            // lboConnectionID
            // 
            this.lboConnectionID.AutoSize = true;
            this.lboConnectionID.Location = new System.Drawing.Point(129, 40);
            this.lboConnectionID.Name = "lboConnectionID";
            this.lboConnectionID.Size = new System.Drawing.Size(11, 13);
            this.lboConnectionID.TabIndex = 5;
            this.lboConnectionID.Text = "-";
            this.lboConnectionID.Click += new System.EventHandler(this.lboConnectionID_Click);
            // 
            // K
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 396);
            this.Controls.Add(this.lboConnectionID);
            this.Controls.Add(this.lboStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.pbstream);
            this.Name = "K";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pbstream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbstream;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lboStatus;
        private System.Windows.Forms.Label lboConnectionID;
    }
}

