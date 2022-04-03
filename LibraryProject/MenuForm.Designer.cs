
namespace LibraryProject
{
    partial class MenuForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersManagement = new System.Windows.Forms.Button();
            this.BooksManagement = new System.Windows.Forms.Button();
            this.BorrowBookManagement = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Library = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsersManagement
            // 
            this.UsersManagement.Location = new System.Drawing.Point(139, 158);
            this.UsersManagement.Name = "UsersManagement";
            this.UsersManagement.Size = new System.Drawing.Size(235, 101);
            this.UsersManagement.TabIndex = 0;
            this.UsersManagement.Text = "Zarządzanie czytelnikami";
            this.UsersManagement.UseVisualStyleBackColor = true;
            this.UsersManagement.Click += new System.EventHandler(this.button_UserManagement_Click);
            // 
            // BooksManagement
            // 
            this.BooksManagement.Location = new System.Drawing.Point(424, 158);
            this.BooksManagement.Name = "BooksManagement";
            this.BooksManagement.Size = new System.Drawing.Size(235, 101);
            this.BooksManagement.TabIndex = 1;
            this.BooksManagement.Text = "Zarządzanie księgozbiorem";
            this.BooksManagement.UseVisualStyleBackColor = true;
            this.BooksManagement.Click += new System.EventHandler(this.BooksManagement_Click);
            // 
            // BorrowBookManagement
            // 
            this.BorrowBookManagement.Location = new System.Drawing.Point(139, 297);
            this.BorrowBookManagement.Name = "BorrowBookManagement";
            this.BorrowBookManagement.Size = new System.Drawing.Size(235, 101);
            this.BorrowBookManagement.TabIndex = 2;
            this.BorrowBookManagement.Text = "Wypożycz / oddaj książkę";
            this.BorrowBookManagement.UseVisualStyleBackColor = true;
            this.BorrowBookManagement.Click += new System.EventHandler(this.BorrowBookManagement_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(424, 297);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(235, 101);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Wyjście";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Library
            // 
            this.Library.AutoSize = true;
            this.Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Library.Location = new System.Drawing.Point(239, 55);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(321, 76);
            this.Library.TabIndex = 4;
            this.Library.Text = "Biblioteka";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Library);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.BorrowBookManagement);
            this.Controls.Add(this.BooksManagement);
            this.Controls.Add(this.UsersManagement);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UsersManagement;
        private System.Windows.Forms.Button BooksManagement;
        private System.Windows.Forms.Button BorrowBookManagement;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label Library;
    }
}

