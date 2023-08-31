
namespace Test_NETFRAMEWORK_
{
    partial class AddingUsersForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.roleBox = new System.Windows.Forms.ListBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(260, 12);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(255, 22);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.Text = "Username";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(260, 89);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(255, 22);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "Password";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(260, 417);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(255, 32);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.ItemHeight = 16;
            this.roleBox.Location = new System.Drawing.Point(260, 372);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(255, 20);
            this.roleBox.TabIndex = 3;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(260, 158);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(255, 22);
            this.lastnameBox.TabIndex = 4;
            this.lastnameBox.Text = "Lastname";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(260, 235);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(255, 22);
            this.firstnameBox.TabIndex = 5;
            this.firstnameBox.Text = "Firstname";
            // 
            // patronymicBox
            // 
            this.patronymicBox.Location = new System.Drawing.Point(260, 303);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(255, 22);
            this.patronymicBox.TabIndex = 6;
            this.patronymicBox.Text = "Patronymic";
            // 
            // AddingUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patronymicBox);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "AddingUsers";
            this.Text = "AddingUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox roleBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox patronymicBox;
    }
}