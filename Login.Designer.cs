namespace Measurement_System
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.EXIT = new System.Windows.Forms.Button();
            this.LG_BUT = new System.Windows.Forms.Button();
           
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
        
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(138, 105);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(221, 20);
            this.UserBox.TabIndex = 2;
            this.UserBox.Text = "USERNAME";
            this.UserBox.TextChanged += new System.EventHandler(this.UserBox_TextChanged);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(138, 157);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(221, 20);
            this.PassBox.TabIndex = 3;
            this.PassBox.Text = "PASSWORD";
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(138, 193);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(96, 27);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // LG_BUT
            // 
            this.LG_BUT.Location = new System.Drawing.Point(263, 193);
            this.LG_BUT.Name = "LG_BUT";
            this.LG_BUT.Size = new System.Drawing.Size(96, 27);
            this.LG_BUT.TabIndex = 6;
            this.LG_BUT.Text = "LOGIN";
            this.LG_BUT.UseVisualStyleBackColor = true;
            this.LG_BUT.Click += new System.EventHandler(this.LG_BUT_Click);
            // 
            // userDBDataSet
            // 
          
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Measurement_System.Properties.Resources.security_banner;
            this.ClientSize = new System.Drawing.Size(519, 328);
            this.Controls.Add(this.LG_BUT);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label2);
            this.Name = "Login";
            this.Text = "MASUREMENT SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
           
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button LG_BUT;
     
        private System.Windows.Forms.BindingSource userTableBindingSource;
    
    }
}

