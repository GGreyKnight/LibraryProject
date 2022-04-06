
namespace LibraryProject
{
    partial class BooksManagementForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booksTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuButton = new System.Windows.Forms.Button();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(800, 397);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(170, 70);
            this.searchButton.TabIndex = 32;
            this.searchButton.Text = "Wyszukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBox.Location = new System.Drawing.Point(596, 416);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(165, 26);
            this.searchBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(618, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Wyszukiwanie:";
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(342, 486);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(170, 70);
            this.deleteBookButton.TabIndex = 29;
            this.deleteBookButton.Text = "Usuń książkę z bazy";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // updateBookButton
            // 
            this.updateBookButton.Location = new System.Drawing.Point(342, 571);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(170, 70);
            this.updateBookButton.TabIndex = 28;
            this.updateBookButton.Text = "Uaktualnij dane pozycji o podanym Id";
            this.updateBookButton.UseVisualStyleBackColor = true;
            this.updateBookButton.Click += new System.EventHandler(this.updateBookButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(342, 397);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(170, 70);
            this.addBookButton.TabIndex = 27;
            this.addBookButton.Text = "Dodaj książkę do bazy";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sectionTextBox.Location = new System.Drawing.Point(126, 508);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(165, 26);
            this.sectionTextBox.TabIndex = 25;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.publisherTextBox.Location = new System.Drawing.Point(126, 470);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(165, 26);
            this.publisherTextBox.TabIndex = 24;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTextBox.Location = new System.Drawing.Point(126, 397);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(165, 26);
            this.titleTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sekcja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Wydawca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tytuł";
            // 
            // booksTable
            // 
            this.booksTable.AllowUserToAddRows = false;
            this.booksTable.AllowUserToDeleteRows = false;
            this.booksTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.booksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.Author,
            this.publisher,
            this.section,
            this.quantity,
            this.quantity_available,
            this.created_at,
            this.updated_at});
            this.booksTable.Location = new System.Drawing.Point(12, 12);
            this.booksTable.MultiSelect = false;
            this.booksTable.Name = "booksTable";
            this.booksTable.ReadOnly = true;
            this.booksTable.RowHeadersWidth = 51;
            this.booksTable.RowTemplate.Height = 24;
            this.booksTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksTable.Size = new System.Drawing.Size(958, 365);
            this.booksTable.TabIndex = 18;
            this.booksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectBook);
            this.booksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksTable_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // title
            // 
            this.title.HeaderText = "Tytuł";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Autor";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 125;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Wydawca";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Width = 125;
            // 
            // section
            // 
            this.section.HeaderText = "Sekcja";
            this.section.MinimumWidth = 6;
            this.section.Name = "section";
            this.section.ReadOnly = true;
            this.section.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Ilość";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // quantity_available
            // 
            this.quantity_available.HeaderText = "Dostępna ilość";
            this.quantity_available.MinimumWidth = 6;
            this.quantity_available.Name = "quantity_available";
            this.quantity_available.ReadOnly = true;
            this.quantity_available.Width = 130;
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Utworzono";
            this.created_at.MinimumWidth = 6;
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Width = 150;
            // 
            // updated_at
            // 
            this.updated_at.HeaderText = "Zaktualizowano";
            this.updated_at.MinimumWidth = 6;
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            this.updated_at.Width = 150;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(800, 571);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(170, 70);
            this.menuButton.TabIndex = 33;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.Menu_Click);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorTextBox.Location = new System.Drawing.Point(126, 433);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(165, 26);
            this.authorTextBox.TabIndex = 34;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quantityTextBox.Location = new System.Drawing.Point(126, 545);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(165, 26);
            this.quantityTextBox.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ilość";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.Location = new System.Drawing.Point(126, 592);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(165, 26);
            this.idTextBox.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Id";
            // 
            // BooksManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.updateBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksTable);
            this.Name = "BooksManagementForm";
            this.Text = "Biblioteka - zarządzanie księgozbiorem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BooksManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.BooksManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button updateBookButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView booksTable;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label7;
    }
}