namespace Measurement_System
{
    partial class ManageEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmp));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label userTypeLabel;
            this.BACK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userTableBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.userTableBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox1 = new System.Windows.Forms.TextBox();
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.userTypeTextBox1 = new System.Windows.Forms.TextBox();
            this.userTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDBDataSet1 = new Measurement_System.UserDBDataSet();
            this.userTableTableAdapter1 = new Measurement_System.UserDBDataSetTableAdapters.UserTableTableAdapter();
            this.tableAdapterManager1 = new Measurement_System.UserDBDataSetTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            userTypeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource1BindingNavigator)).BeginInit();
            this.userTableBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(366, 278);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(85, 34);
            this.BACK.TabIndex = 0;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(iDLabel);
            this.panel1.Controls.Add(this.iDTextBox1);
            this.panel1.Controls.Add(usernameLabel);
            this.panel1.Controls.Add(this.usernameTextBox1);
            this.panel1.Controls.Add(passwordLabel);
            this.panel1.Controls.Add(this.passwordTextBox1);
            this.panel1.Controls.Add(userTypeLabel);
            this.panel1.Controls.Add(this.userTypeTextBox1);
            this.panel1.Location = new System.Drawing.Point(15, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 244);
            this.panel1.TabIndex = 1;
            // 
            // userTableBindingSource1BindingNavigator
            // 
            this.userTableBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.userTableBindingSource1BindingNavigator.BindingSource = this.userTableBindingSource1;
            this.userTableBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.userTableBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.userTableBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.userTableBindingSource1BindingNavigatorSaveItem});
            this.userTableBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userTableBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.userTableBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.userTableBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.userTableBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.userTableBindingSource1BindingNavigator.Name = "userTableBindingSource1BindingNavigator";
            this.userTableBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.userTableBindingSource1BindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.userTableBindingSource1BindingNavigator.TabIndex = 2;
            this.userTableBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // userTableBindingSource1BindingNavigatorSaveItem
            // 
            this.userTableBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userTableBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userTableBindingSource1BindingNavigatorSaveItem.Image")));
            this.userTableBindingSource1BindingNavigatorSaveItem.Name = "userTableBindingSource1BindingNavigatorSaveItem";
            this.userTableBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userTableBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.userTableBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.userTableBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(28, 53);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(22, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox1
            // 
            this.iDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource1, "ID", true));
            this.iDTextBox1.Location = new System.Drawing.Point(94, 50);
            this.iDTextBox1.Name = "iDTextBox1";
            this.iDTextBox1.Size = new System.Drawing.Size(133, 20);
            this.iDTextBox1.TabIndex = 3;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(28, 79);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "username:";
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource1, "username", true));
            this.usernameTextBox1.Location = new System.Drawing.Point(94, 76);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(133, 20);
            this.usernameTextBox1.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(28, 105);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(57, 13);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource1, "Password", true));
            this.passwordTextBox1.Location = new System.Drawing.Point(94, 102);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(133, 20);
            this.passwordTextBox1.TabIndex = 7;
            // 
            // userTypeLabel
            // 
            userTypeLabel.AutoSize = true;
            userTypeLabel.Location = new System.Drawing.Point(28, 131);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new System.Drawing.Size(60, 13);
            userTypeLabel.TabIndex = 8;
            userTypeLabel.Text = "User Type:";
            // 
            // userTypeTextBox1
            // 
            this.userTypeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource1, "UserType", true));
            this.userTypeTextBox1.Location = new System.Drawing.Point(94, 128);
            this.userTypeTextBox1.Name = "userTypeTextBox1";
            this.userTypeTextBox1.Size = new System.Drawing.Size(133, 20);
            this.userTypeTextBox1.TabIndex = 9;
            // 
            // userTableBindingSource1
            // 
            this.userTableBindingSource1.DataMember = "UserTable";
            this.userTableBindingSource1.DataSource = this.userDBDataSet1;
            // 
            // userDBDataSet1
            // 
            this.userDBDataSet1.DataSetName = "UserDBDataSet";
            this.userDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableTableAdapter1
            // 
            this.userTableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Measurement_System.UserDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserTableTableAdapter = this.userTableTableAdapter1;
            // 
            // ManageEmp
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 315);
            this.Controls.Add(this.userTableBindingSource1BindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BACK);
            this.Name = "ManageEmp";
            this.Text = "MASUREMENT SYSTEM";
            this.Load += new System.EventHandler(this.ManageEmp_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource1BindingNavigator)).EndInit();
            this.userTableBindingSource1BindingNavigator.ResumeLayout(false);
            this.userTableBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private UserDBDataSet userDBDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private UserDBDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private UserDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton userTableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator userTableBindingNavigator;
        private System.Windows.Forms.TextBox userTypeTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Panel panel1;
        private UserDBDataSet userDBDataSet1;
        private System.Windows.Forms.BindingSource userTableBindingSource1;
        private UserDBDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter1;
        private UserDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator userTableBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton userTableBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox1;
        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.TextBox userTypeTextBox1;
    }
}