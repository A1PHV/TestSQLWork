
namespace Test_NETFRAMEWORK_
{
    partial class EditingUsersForm
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.roleBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.firtstnameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(245, 12);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(267, 22);
            this.usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(245, 84);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(267, 22);
            this.passwordBox.TabIndex = 1;
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.ItemHeight = 16;
            this.roleBox.Location = new System.Drawing.Point(245, 370);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(267, 20);
            this.roleBox.TabIndex = 2;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(301, 405);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(155, 42);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(245, 161);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(267, 22);
            this.lastnameBox.TabIndex = 4;
            // 
            // patronymicBox
            // 
            this.patronymicBox.Location = new System.Drawing.Point(245, 305);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(267, 22);
            this.patronymicBox.TabIndex = 5;
            // 
            // firtstnameBox
            // 
            this.firtstnameBox.Location = new System.Drawing.Point(245, 234);
            this.firtstnameBox.Name = "firtstnameBox";
            this.firtstnameBox.Size = new System.Drawing.Size(267, 22);
            this.firtstnameBox.TabIndex = 6;
            // 
            // EditingUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firtstnameBox);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "EditingUsers";
            this.Text = "EditingUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.ListBox roleBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.TextBox firtstnameBox;
    }
}