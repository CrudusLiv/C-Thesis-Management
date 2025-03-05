namespace DIP101_Assignment
{
    partial class ReturnThesis
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.returnDateInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThesisName = new System.Windows.Forms.Label();
            this.btnThesisReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstThesisBorrowedList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thesisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFine = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.returnDateInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblThesisName);
            this.groupBox2.Controls.Add(this.btnThesisReturn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(324, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 249);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details of Student";
            // 
            // returnDateInput
            // 
            this.returnDateInput.Location = new System.Drawing.Point(158, 52);
            this.returnDateInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnDateInput.Name = "returnDateInput";
            this.returnDateInput.Size = new System.Drawing.Size(196, 35);
            this.returnDateInput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.returnDateInput, "Return Thesis Date");
            this.returnDateInput.TextChanged += new System.EventHandler(this.returnDateInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Return Date:";
            // 
            // lblThesisName
            // 
            this.lblThesisName.BackColor = System.Drawing.SystemColors.Control;
            this.lblThesisName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThesisName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThesisName.Location = new System.Drawing.Point(158, 97);
            this.lblThesisName.Name = "lblThesisName";
            this.lblThesisName.Size = new System.Drawing.Size(198, 42);
            this.lblThesisName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lblThesisName, "Thesis Name");
            // 
            // btnThesisReturn
            // 
            this.btnThesisReturn.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThesisReturn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThesisReturn.Location = new System.Drawing.Point(128, 169);
            this.btnThesisReturn.Name = "btnThesisReturn";
            this.btnThesisReturn.Size = new System.Drawing.Size(126, 46);
            this.btnThesisReturn.TabIndex = 3;
            this.btnThesisReturn.Text = "&Return";
            this.toolTip1.SetToolTip(this.btnThesisReturn, "Return Thesis");
            this.btnThesisReturn.UseVisualStyleBackColor = false;
            this.btnThesisReturn.Click += new System.EventHandler(this.btnThesisReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Thesis Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thesis Borrowed List";
            // 
            // lstThesisBorrowedList
            // 
            this.lstThesisBorrowedList.FormattingEnabled = true;
            this.lstThesisBorrowedList.ItemHeight = 20;
            this.lstThesisBorrowedList.Location = new System.Drawing.Point(34, 98);
            this.lstThesisBorrowedList.Name = "lstThesisBorrowedList";
            this.lstThesisBorrowedList.Size = new System.Drawing.Size(256, 584);
            this.lstThesisBorrowedList.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lstThesisBorrowedList, "List of borrowed thesis");
            this.lstThesisBorrowedList.SelectedIndexChanged += new System.EventHandler(this.lstThesisBorrowedList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.borrowReturnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.thesisToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // thesisToolStripMenuItem
            // 
            this.thesisToolStripMenuItem.Name = "thesisToolStripMenuItem";
            this.thesisToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.thesisToolStripMenuItem.Text = "Thesis";
            this.thesisToolStripMenuItem.Click += new System.EventHandler(this.thesisToolStripMenuItem_Click);
            // 
            // borrowReturnToolStripMenuItem
            // 
            this.borrowReturnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.borrowReturnToolStripMenuItem.Name = "borrowReturnToolStripMenuItem";
            this.borrowReturnToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.borrowReturnToolStripMenuItem.Text = "Borrow / Return";
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.borrowToolStripMenuItem.Text = "Borrow";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // lblFine
            // 
            this.lblFine.BackColor = System.Drawing.SystemColors.Control;
            this.lblFine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFine.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(47, 33);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(218, 38);
            this.lblFine.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lblFine, "Overdue fines");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblFine);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(350, 445);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(356, 138);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overdue Fine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "(Only appicable for students who has overdued) ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(685, 637);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 45);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ReturnThesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIP101_Assignment.Properties.Resources._return;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 702);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lstThesisBorrowedList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ReturnThesis";
            this.Text = "Return Thesis";
            this.Load += new System.EventHandler(this.ReturnThesis_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThesisReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstThesisBorrowedList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thesisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox returnDateInput;
        private System.Windows.Forms.Label lblThesisName;
        private System.Windows.Forms.Button btnExit;
    }
}