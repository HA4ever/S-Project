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
            this.lboNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.pbstream.Size = new System.Drawing.Size(486, 359);
            this.pbstream.TabIndex = 0;
            this.pbstream.TabStop = false;
            this.pbstream.Click += new System.EventHandler(this.pbstream_Click);
            // 
            // btnStream
            // 
            this.btnStream.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStream.Location = new System.Drawing.Point(352, 454);
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
            // lboNumber
            // 
            this.lboNumber.AccessibleName = "NumberOFSk";
            this.lboNumber.AutoSize = true;
            this.lboNumber.Location = new System.Drawing.Point(130, 63);
            this.lboNumber.Name = "lboNumber";
            this.lboNumber.Size = new System.Drawing.Size(11, 13);
            this.lboNumber.TabIndex = 7;
            this.lboNumber.Text = "-";
            this.lboNumber.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleName = "Number";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "# of Pepole";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // K
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 494);
            this.Controls.Add(this.lboNumber);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label lboNumber;
        private System.Windows.Forms.Label label4;
    }
}

