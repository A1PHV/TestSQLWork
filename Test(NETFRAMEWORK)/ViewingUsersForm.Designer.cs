
namespace Test_NETFRAMEWORK_
{
    partial class ViewingUsersForm
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
            this.viewUsersDesk = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.viewUsersInfoDesk = new System.Windows.Forms.DataGridView();
            this.statisticButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersDesk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersInfoDesk)).BeginInit();
            this.SuspendLayout();
            // 
            // viewUsersDesk
            // 
            this.viewUsersDesk.AllowUserToAddRows = false;
            this.viewUsersDesk.AllowUserToDeleteRows = false;
            this.viewUsersDesk.AllowUserToResizeColumns = false;
            this.viewUsersDesk.AllowUserToResizeRows = false;
            this.viewUsersDesk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewUsersDesk.Location = new System.Drawing.Point(0, -1);
            this.viewUsersDesk.MultiSelect = false;
            this.viewUsersDesk.Name = "viewUsersDesk";
            this.viewUsersDesk.ReadOnly = true;
            this.viewUsersDesk.RowHeadersWidth = 51;
            this.viewUsersDesk.RowTemplate.Height = 24;
            this.viewUsersDesk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewUsersDesk.Size = new System.Drawing.Size(798, 193);
            this.viewUsersDesk.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 394);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 44);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(354, 394);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(109, 44);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(679, 394);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 44);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // viewUsersInfoDesk
            // 
            this.viewUsersInfoDesk.AllowUserToAddRows = false;
            this.viewUsersInfoDesk.AllowUserToDeleteRows = false;
            this.viewUsersInfoDesk.AllowUserToResizeColumns = false;
            this.viewUsersInfoDesk.AllowUserToResizeRows = false;
            this.viewUsersInfoDesk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewUsersInfoDesk.Location = new System.Drawing.Point(0, 198);
            this.viewUsersInfoDesk.MultiSelect = false;
            this.viewUsersInfoDesk.Name = "viewUsersInfoDesk";
            this.viewUsersInfoDesk.ReadOnly = true;
            this.viewUsersInfoDesk.RowHeadersWidth = 51;
            this.viewUsersInfoDesk.RowTemplate.Height = 24;
            this.viewUsersInfoDesk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewUsersInfoDesk.Size = new System.Drawing.Size(798, 190);
            this.viewUsersInfoDesk.TabIndex = 4;
            // 
            // statisticButton
            // 
            this.statisticButton.Location = new System.Drawing.Point(313, 469);
            this.statisticButton.Name = "statisticButton";
            this.statisticButton.Size = new System.Drawing.Size(194, 42);
            this.statisticButton.TabIndex = 5;
            this.statisticButton.Text = "Statistic";
            this.statisticButton.UseVisualStyleBackColor = true;
            this.statisticButton.Click += new System.EventHandler(this.statisticButton_Click);
            // 
            // ViewingUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.statisticButton);
            this.Controls.Add(this.viewUsersInfoDesk);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.viewUsersDesk);
            this.Name = "ViewingUsersForm";
            this.Text = "ViewingUsers";
            this.Load += new System.EventHandler(this.ViewingUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersDesk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersInfoDesk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewUsersDesk;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView viewUsersInfoDesk;
        private System.Windows.Forms.Button statisticButton;
    }
}