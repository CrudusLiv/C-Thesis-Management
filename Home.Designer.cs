namespace DIP101_Assignment
{
    partial class Home
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
            this.btnRegStudent = new System.Windows.Forms.Button();
            this.btnRegThesis = new System.Windows.Forms.Button();
            this.btnReturnThesis = new System.Windows.Forms.Button();
            this.btnBorrowThesis = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnRegStudent
            // 
            this.btnRegStudent.BackgroundImage = global::DIP101_Assignment.Properties.Resources.student;
            this.btnRegStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegStudent.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegStudent.Location = new System.Drawing.Point(80, 40);
            this.btnRegStudent.Name = "btnRegStudent";
            this.btnRegStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRegStudent.Size = new System.Drawing.Size(190, 162);
            this.btnRegStudent.TabIndex = 0;
            this.btnRegStudent.Text = "Register &Student";
            this.btnRegStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnRegStudent, "Press this button to register a student");
            this.btnRegStudent.UseVisualStyleBackColor = true;
            this.btnRegStudent.Click += new System.EventHandler(this.btnRegStudent_Click);
            // 
            // btnRegThesis
            // 
            this.btnRegThesis.BackgroundImage = global::DIP101_Assignment.Properties.Resources.thesis;
            this.btnRegThesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegThesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegThesis.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegThesis.Location = new System.Drawing.Point(80, 223);
            this.btnRegThesis.Name = "btnRegThesis";
            this.btnRegThesis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRegThesis.Size = new System.Drawing.Size(190, 160);
            this.btnRegThesis.TabIndex = 1;
            this.btnRegThesis.Text = "Register &Thesis";
            this.btnRegThesis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnRegThesis, "Press this button to register a thesis");
            this.btnRegThesis.UseVisualStyleBackColor = true;
            this.btnRegThesis.Click += new System.EventHandler(this.btnRegThesis_Click);
            // 
            // btnReturnThesis
            // 
            this.btnReturnThesis.BackgroundImage = global::DIP101_Assignment.Properties.Resources._return;
            this.btnReturnThesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnThesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnThesis.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnThesis.Location = new System.Drawing.Point(338, 223);
            this.btnReturnThesis.Name = "btnReturnThesis";
            this.btnReturnThesis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReturnThesis.Size = new System.Drawing.Size(190, 160);
            this.btnReturnThesis.TabIndex = 3;
            this.btnReturnThesis.Text = "&Return Thesis";
            this.btnReturnThesis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnReturnThesis, "Press this button to return a thesis");
            this.btnReturnThesis.UseVisualStyleBackColor = true;
            this.btnReturnThesis.Click += new System.EventHandler(this.btnReturnThesis_Click);
            // 
            // btnBorrowThesis
            // 
            this.btnBorrowThesis.BackgroundImage = global::DIP101_Assignment.Properties.Resources.borrow;
            this.btnBorrowThesis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrowThesis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowThesis.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowThesis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrowThesis.Location = new System.Drawing.Point(338, 42);
            this.btnBorrowThesis.Name = "btnBorrowThesis";
            this.btnBorrowThesis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBorrowThesis.Size = new System.Drawing.Size(190, 160);
            this.btnBorrowThesis.TabIndex = 2;
            this.btnBorrowThesis.Text = "&Borrow Thesis";
            this.btnBorrowThesis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnBorrowThesis, "Press this button to borrow a thesis");
            this.btnBorrowThesis.UseVisualStyleBackColor = true;
            this.btnBorrowThesis.Click += new System.EventHandler(this.btnBorrowThesis_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(489, 389);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(148, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "&Logout";
            this.toolTip1.SetToolTip(this.btnLogout, "Logout");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(654, 449);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRegStudent);
            this.Controls.Add(this.btnReturnThesis);
            this.Controls.Add(this.btnBorrowThesis);
            this.Controls.Add(this.btnRegThesis);
            this.Name = "Home";
            this.Text = "Home";
            this.toolTip1.SetToolTip(this, "Home Page");
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegStudent;
        private System.Windows.Forms.Button btnRegThesis;
        private System.Windows.Forms.Button btnReturnThesis;
        private System.Windows.Forms.Button btnBorrowThesis;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

