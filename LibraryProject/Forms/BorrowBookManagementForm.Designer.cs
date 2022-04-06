
namespace LibraryProject
{
    partial class BorrowBookManagementForm
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
            this.menuButton = new System.Windows.Forms.Button();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.booksTable = new System.Windows.Forms.DataGridView();
            this.dateTimePickerBorrowBookFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBorrowBookTo = new System.Windows.Forms.DateTimePicker();
            this.searchMemberButton = new System.Windows.Forms.Button();
            this.searchMemberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.searchBookTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borrowsTable = new System.Windows.Forms.DataGridView();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.borrowBookButton = new System.Windows.Forms.Button();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.calculatePenaltyButton = new System.Windows.Forms.Button();
            this.penaltyTextBox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(1301, 849);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(170, 70);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.Menu_Click);
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToAddRows = false;
            this.usersTable.AllowUserToDeleteRows = false;
            this.usersTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pesel,
            this.id_position,
            this.first_name,
            this.last_name});
            this.usersTable.Location = new System.Drawing.Point(13, 12);
            this.usersTable.MultiSelect = false;
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersWidth = 51;
            this.usersTable.RowTemplate.Height = 24;
            this.usersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersTable.Size = new System.Drawing.Size(606, 247);
            this.usersTable.TabIndex = 3;
            this.usersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectMember);
            // 
            // booksTable
            // 
            this.booksTable.AllowUserToAddRows = false;
            this.booksTable.AllowUserToDeleteRows = false;
            this.booksTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.booksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.title,
            this.Author,
            this.publisher,
            this.section,
            this.quantity,
            this.quantity_available});
            this.booksTable.Location = new System.Drawing.Point(871, 12);
            this.booksTable.MultiSelect = false;
            this.booksTable.Name = "booksTable";
            this.booksTable.ReadOnly = true;
            this.booksTable.RowHeadersWidth = 51;
            this.booksTable.RowTemplate.Height = 24;
            this.booksTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksTable.Size = new System.Drawing.Size(600, 247);
            this.booksTable.TabIndex = 19;
            this.booksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectBook);
            // 
            // dateTimePickerBorrowBookFrom
            // 
            this.dateTimePickerBorrowBookFrom.Location = new System.Drawing.Point(1127, 539);
            this.dateTimePickerBorrowBookFrom.Name = "dateTimePickerBorrowBookFrom";
            this.dateTimePickerBorrowBookFrom.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerBorrowBookFrom.TabIndex = 20;
            // 
            // dateTimePickerBorrowBookTo
            // 
            this.dateTimePickerBorrowBookTo.Location = new System.Drawing.Point(1127, 578);
            this.dateTimePickerBorrowBookTo.Name = "dateTimePickerBorrowBookTo";
            this.dateTimePickerBorrowBookTo.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerBorrowBookTo.TabIndex = 21;
            // 
            // searchMemberButton
            // 
            this.searchMemberButton.Location = new System.Drawing.Point(217, 273);
            this.searchMemberButton.Name = "searchMemberButton";
            this.searchMemberButton.Size = new System.Drawing.Size(170, 70);
            this.searchMemberButton.TabIndex = 24;
            this.searchMemberButton.Text = "Wyszukaj osobę";
            this.searchMemberButton.UseVisualStyleBackColor = true;
            this.searchMemberButton.Click += new System.EventHandler(this.searchMemberButton_Click);
            // 
            // searchMemberTextBox
            // 
            this.searchMemberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchMemberTextBox.Location = new System.Drawing.Point(13, 292);
            this.searchMemberTextBox.Name = "searchMemberTextBox";
            this.searchMemberTextBox.Size = new System.Drawing.Size(165, 26);
            this.searchMemberTextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(35, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Wyszukiwanie:";
            // 
            // searchBookButton
            // 
            this.searchBookButton.Location = new System.Drawing.Point(1075, 273);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(170, 70);
            this.searchBookButton.TabIndex = 35;
            this.searchBookButton.Text = "Wyszukaj książkę";
            this.searchBookButton.UseVisualStyleBackColor = true;
            this.searchBookButton.Click += new System.EventHandler(this.searchBookButton_Click);
            // 
            // searchBookTextBox
            // 
            this.searchBookTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBookTextBox.Location = new System.Drawing.Point(871, 292);
            this.searchBookTextBox.Name = "searchBookTextBox";
            this.searchBookTextBox.Size = new System.Drawing.Size(165, 26);
            this.searchBookTextBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(893, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Wyszukiwanie:";
            // 
            // borrowsTable
            // 
            this.borrowsTable.AllowUserToAddRows = false;
            this.borrowsTable.AllowUserToDeleteRows = false;
            this.borrowsTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.borrowsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_member,
            this.id_book,
            this.position_member,
            this.first_name_member,
            this.last_name_member,
            this.title_book,
            this.author_book,
            this.borrow_date,
            this.return_date});
            this.borrowsTable.Location = new System.Drawing.Point(13, 539);
            this.borrowsTable.MultiSelect = false;
            this.borrowsTable.Name = "borrowsTable";
            this.borrowsTable.ReadOnly = true;
            this.borrowsTable.RowHeadersWidth = 51;
            this.borrowsTable.RowTemplate.Height = 24;
            this.borrowsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowsTable.Size = new System.Drawing.Size(904, 380);
            this.borrowsTable.TabIndex = 36;
            this.borrowsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectBooksBorrows);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameTextBox.Location = new System.Drawing.Point(149, 478);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 26);
            this.lastNameTextBox.TabIndex = 43;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameTextBox.Location = new System.Drawing.Point(149, 440);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(165, 26);
            this.firstNameTextBox.TabIndex = 42;
            // 
            // peselTextBox
            // 
            this.peselTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peselTextBox.Location = new System.Drawing.Point(149, 370);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.ReadOnly = true;
            this.peselTextBox.Size = new System.Drawing.Size(165, 26);
            this.peselTextBox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(35, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Pozycja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(35, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "PESEL";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorTextBox.Location = new System.Drawing.Point(1007, 406);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.ReadOnly = true;
            this.authorTextBox.Size = new System.Drawing.Size(165, 26);
            this.authorTextBox.TabIndex = 52;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sectionTextBox.Location = new System.Drawing.Point(1007, 481);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.ReadOnly = true;
            this.sectionTextBox.Size = new System.Drawing.Size(165, 26);
            this.sectionTextBox.TabIndex = 51;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.publisherTextBox.Location = new System.Drawing.Point(1007, 443);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.ReadOnly = true;
            this.publisherTextBox.Size = new System.Drawing.Size(165, 26);
            this.publisherTextBox.TabIndex = 50;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTextBox.Location = new System.Drawing.Point(1007, 370);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(165, 26);
            this.titleTextBox.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(893, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Sekcja";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(893, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Wydawca";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(893, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Autor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(893, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Tytuł";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.positionTextBox.Location = new System.Drawing.Point(149, 406);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(165, 26);
            this.positionTextBox.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(967, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Data wypożyzcenia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(967, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Data zwrotu";
            // 
            // borrowBookButton
            // 
            this.borrowBookButton.Location = new System.Drawing.Point(971, 623);
            this.borrowBookButton.Name = "borrowBookButton";
            this.borrowBookButton.Size = new System.Drawing.Size(170, 70);
            this.borrowBookButton.TabIndex = 56;
            this.borrowBookButton.Text = "Wypożycz książkę";
            this.borrowBookButton.UseVisualStyleBackColor = true;
            this.borrowBookButton.Click += new System.EventHandler(this.borrowBookButton_Click);
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(971, 720);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(170, 70);
            this.returnBookButton.TabIndex = 57;
            this.returnBookButton.Text = "Zwróć książkę";
            this.returnBookButton.UseVisualStyleBackColor = true;
            // 
            // calculatePenaltyButton
            // 
            this.calculatePenaltyButton.Location = new System.Drawing.Point(971, 817);
            this.calculatePenaltyButton.Name = "calculatePenaltyButton";
            this.calculatePenaltyButton.Size = new System.Drawing.Size(170, 70);
            this.calculatePenaltyButton.TabIndex = 58;
            this.calculatePenaltyButton.Text = "Oblicz karę za oddanie książki po terminie";
            this.calculatePenaltyButton.UseVisualStyleBackColor = true;
            // 
            // penaltyTextBox
            // 
            this.penaltyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.penaltyTextBox.Location = new System.Drawing.Point(971, 893);
            this.penaltyTextBox.Name = "penaltyTextBox";
            this.penaltyTextBox.ReadOnly = true;
            this.penaltyTextBox.Size = new System.Drawing.Size(170, 26);
            this.penaltyTextBox.TabIndex = 59;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // pesel
            // 
            this.pesel.HeaderText = "Pesel";
            this.pesel.MinimumWidth = 6;
            this.pesel.Name = "pesel";
            this.pesel.ReadOnly = true;
            this.pesel.Width = 125;
            // 
            // id_position
            // 
            this.id_position.HeaderText = "Pozycja";
            this.id_position.MinimumWidth = 6;
            this.id_position.Name = "id_position";
            this.id_position.ReadOnly = true;
            this.id_position.Width = 125;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "Imię";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 125;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Nazwisko";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
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
            // id_member
            // 
            this.id_member.HeaderText = "Id os.";
            this.id_member.MinimumWidth = 6;
            this.id_member.Name = "id_member";
            this.id_member.ReadOnly = true;
            this.id_member.Width = 70;
            // 
            // id_book
            // 
            this.id_book.HeaderText = "Id ks.";
            this.id_book.MinimumWidth = 6;
            this.id_book.Name = "id_book";
            this.id_book.ReadOnly = true;
            this.id_book.Width = 70;
            // 
            // position_member
            // 
            this.position_member.HeaderText = "Pozycja";
            this.position_member.MinimumWidth = 6;
            this.position_member.Name = "position_member";
            this.position_member.ReadOnly = true;
            // 
            // first_name_member
            // 
            this.first_name_member.HeaderText = "Imię";
            this.first_name_member.MinimumWidth = 6;
            this.first_name_member.Name = "first_name_member";
            this.first_name_member.ReadOnly = true;
            // 
            // last_name_member
            // 
            this.last_name_member.HeaderText = "Nazwisko";
            this.last_name_member.MinimumWidth = 6;
            this.last_name_member.Name = "last_name_member";
            this.last_name_member.ReadOnly = true;
            // 
            // title_book
            // 
            this.title_book.HeaderText = "Tytuł";
            this.title_book.MinimumWidth = 6;
            this.title_book.Name = "title_book";
            this.title_book.ReadOnly = true;
            // 
            // author_book
            // 
            this.author_book.HeaderText = "Autor";
            this.author_book.MinimumWidth = 6;
            this.author_book.Name = "author_book";
            this.author_book.ReadOnly = true;
            // 
            // borrow_date
            // 
            this.borrow_date.HeaderText = "Data wypożyczenia";
            this.borrow_date.MinimumWidth = 6;
            this.borrow_date.Name = "borrow_date";
            this.borrow_date.ReadOnly = true;
            this.borrow_date.Width = 160;
            // 
            // return_date
            // 
            this.return_date.HeaderText = "Data zwrotu";
            this.return_date.MinimumWidth = 6;
            this.return_date.Name = "return_date";
            this.return_date.ReadOnly = true;
            this.return_date.Width = 160;
            // 
            // BorrowBookManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 928);
            this.Controls.Add(this.penaltyTextBox);
            this.Controls.Add(this.calculatePenaltyButton);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.borrowBookButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.borrowsTable);
            this.Controls.Add(this.searchBookButton);
            this.Controls.Add(this.searchBookTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchMemberButton);
            this.Controls.Add(this.searchMemberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerBorrowBookTo);
            this.Controls.Add(this.dateTimePickerBorrowBookFrom);
            this.Controls.Add(this.booksTable);
            this.Controls.Add(this.usersTable);
            this.Controls.Add(this.menuButton);
            this.Name = "BorrowBookManagementForm";
            this.Text = "Biblioteka - wypożycz / oddaj książkę";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BorrowBookManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.BorrowBookManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.DataGridView booksTable;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowBookFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowBookTo;
        private System.Windows.Forms.Button searchMemberButton;
        private System.Windows.Forms.TextBox searchMemberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.TextBox searchBookTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView borrowsTable;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button borrowBookButton;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.Button calculatePenaltyButton;
        private System.Windows.Forms.TextBox penaltyTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn position_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_member;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
    }
}