
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
            this.menuButton = new System.Windows.Forms.Button();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.updateMemberButton = new System.Windows.Forms.Button();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(800, 571);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(170, 70);
            this.menuButton.TabIndex = 1;
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
            this.last_name,
            this.created_at,
            this.updated_at});
            this.usersTable.Location = new System.Drawing.Point(12, 12);
            this.usersTable.MultiSelect = false;
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersWidth = 51;
            this.usersTable.RowTemplate.Height = 24;
            this.usersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersTable.Size = new System.Drawing.Size(958, 365);
            this.usersTable.TabIndex = 2;
            this.usersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectMember);
            this.usersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTable_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // pesel
            // 
            this.pesel.HeaderText = "Pesel";
            this.pesel.MinimumWidth = 6;
            this.pesel.Name = "pesel";
            this.pesel.Width = 125;
            // 
            // id_position
            // 
            this.id_position.HeaderText = "Pozycja";
            this.id_position.MinimumWidth = 6;
            this.id_position.Name = "id_position";
            this.id_position.Width = 125;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "Imię";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.Width = 125;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Nazwisko";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.Width = 125;
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Utworzono";
            this.created_at.MinimumWidth = 6;
            this.created_at.Name = "created_at";
            this.created_at.Width = 150;
            // 
            // updated_at
            // 
            this.updated_at.HeaderText = "Zaktualizowano";
            this.updated_at.MinimumWidth = 6;
            this.updated_at.Name = "updated_at";
            this.updated_at.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PESEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pozycja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwisko";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peselTextBox.Location = new System.Drawing.Point(126, 397);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(165, 26);
            this.peselTextBox.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameTextBox.Location = new System.Drawing.Point(126, 473);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(165, 26);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameTextBox.Location = new System.Drawing.Point(126, 511);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 26);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // positionComboBox
            // 
            this.positionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Student",
            "Wykładowca",
            "Pracownik"});
            this.positionComboBox.Location = new System.Drawing.Point(126, 436);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(165, 28);
            this.positionComboBox.TabIndex = 11;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(342, 397);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(170, 70);
            this.addMemberButton.TabIndex = 12;
            this.addMemberButton.Text = "Dodaj osobę do bazy";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // updateMemberButton
            // 
            this.updateMemberButton.Location = new System.Drawing.Point(342, 484);
            this.updateMemberButton.Name = "updateMemberButton";
            this.updateMemberButton.Size = new System.Drawing.Size(170, 70);
            this.updateMemberButton.TabIndex = 13;
            this.updateMemberButton.Text = "Uaktualnij dane wybranej osoby";
            this.updateMemberButton.UseVisualStyleBackColor = true;
            this.updateMemberButton.Click += new System.EventHandler(this.updateMemberButton_Click);
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Location = new System.Drawing.Point(342, 571);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(170, 70);
            this.deleteMemberButton.TabIndex = 14;
            this.deleteMemberButton.Text = "Usuń osobę z bazy";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            this.deleteMemberButton.Click += new System.EventHandler(this.deleteMemberButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(800, 397);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(170, 70);
            this.searchButton.TabIndex = 17;
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
            this.searchBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(618, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Wyszukiwanie:";
            // 
            // UsersManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.updateMemberButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersTable);
            this.Controls.Add(this.menuButton);
            this.Name = "UsersManagementForm";
            this.Text = "Biblioteka - zarządzanie czytelnikami";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.UsersManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.Button updateMemberButton;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label5;
    }
}