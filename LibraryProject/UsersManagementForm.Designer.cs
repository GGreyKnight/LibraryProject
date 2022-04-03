
namespace LibraryProject
{
    partial class UsersManagementForm
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
            this.UsersManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersManagement
            // 
            this.UsersManagement.Location = new System.Drawing.Point(553, 337);
            this.UsersManagement.Name = "UsersManagement";
            this.UsersManagement.Size = new System.Drawing.Size(235, 101);
            this.UsersManagement.TabIndex = 1;
            this.UsersManagement.Text = "Menu";
            this.UsersManagement.UseVisualStyleBackColor = true;
            this.UsersManagement.Click += new System.EventHandler(this.Menu_Click);
            // 
            // UsersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsersManagement);
            this.Name = "UsersManagementForm";
            this.Text = "Biblioteka - zarządzanie czytelnikami";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersManagementForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersManagement;
    }
}