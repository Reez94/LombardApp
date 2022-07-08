
namespace LombardApp
{
    partial class frmAdminPanel
    {
        /// Required designer variable.

        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.

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
            this.btnChangeItem = new System.Windows.Forms.Button();
            this.BtnAddClient = new System.Windows.Forms.Button();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.FirstName = new System.Windows.Forms.ColumnHeader();
            this.LastName = new System.Windows.Forms.ColumnHeader();
            this.Pesel = new System.Windows.Forms.ColumnHeader();
            this.TelNumber = new System.Windows.Forms.ColumnHeader();
            this.Address = new System.Windows.Forms.ColumnHeader();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.IdItem = new System.Windows.Forms.ColumnHeader();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.ClientId = new System.Windows.Forms.ColumnHeader();
            this.DatePledge = new System.Windows.Forms.ColumnHeader();
            this.EndDatePledge = new System.Windows.Forms.ColumnHeader();
            this.labelClients = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearClients = new System.Windows.Forms.Button();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.labelDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnImportClients = new System.Windows.Forms.Button();
            this.btnImportItems = new System.Windows.Forms.Button();
            this.btnExportClients = new System.Windows.Forms.Button();
            this.btnExportItems = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeItem
            // 
            this.btnChangeItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChangeItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeItem.FlatAppearance.BorderSize = 0;
            this.btnChangeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeItem.Location = new System.Drawing.Point(844, 364);
            this.btnChangeItem.Name = "btnChangeItem";
            this.btnChangeItem.Size = new System.Drawing.Size(70, 30);
            this.btnChangeItem.TabIndex = 0;
            this.btnChangeItem.Text = "Zmień";
            this.btnChangeItem.UseVisualStyleBackColor = false;
            this.btnChangeItem.Click += new System.EventHandler(this.btnChangeItem_Click);
            // 
            // BtnAddClient
            // 
            this.BtnAddClient.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddClient.FlatAppearance.BorderSize = 0;
            this.BtnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddClient.Location = new System.Drawing.Point(458, 364);
            this.BtnAddClient.Name = "BtnAddClient";
            this.BtnAddClient.Size = new System.Drawing.Size(70, 30);
            this.BtnAddClient.TabIndex = 1;
            this.BtnAddClient.Text = "Dodaj";
            this.BtnAddClient.UseVisualStyleBackColor = false;
            this.BtnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // listViewClients
            // 
            this.listViewClients.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Pesel,
            this.TelNumber,
            this.Address});
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(12, 74);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(440, 471);
            this.listViewClients.TabIndex = 2;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.SelectedIndexChanged += new System.EventHandler(this.listViewClients_SelectedIndexChanged);
            this.listViewClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewClients_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 30;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Imię";
            // 
            // LastName
            // 
            this.LastName.Text = "Nazwisko";
            this.LastName.Width = 70;
            // 
            // Pesel
            // 
            this.Pesel.Text = "PESEL";
            this.Pesel.Width = 80;
            // 
            // TelNumber
            // 
            this.TelNumber.Text = "Nr telefonu";
            this.TelNumber.Width = 80;
            // 
            // Address
            // 
            this.Address.Text = "Adres zamieszkania";
            this.Address.Width = 120;
            // 
            // listViewItems
            // 
            this.listViewItems.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdItem,
            this.ItemName,
            this.Price,
            this.ClientId,
            this.DatePledge,
            this.EndDatePledge});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(929, 74);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(423, 471);
            this.listViewItems.TabIndex = 3;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            this.listViewItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewItems_MouseDoubleClick);
            // 
            // IdItem
            // 
            this.IdItem.Text = "Id";
            this.IdItem.Width = 30;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Nazwa";
            this.ItemName.Width = 90;
            // 
            // Price
            // 
            this.Price.Text = "Cena";
            // 
            // ClientId
            // 
            this.ClientId.Text = "Id klienta";
            // 
            // DatePledge
            // 
            this.DatePledge.Text = "Data zastawu";
            this.DatePledge.Width = 85;
            // 
            // EndDatePledge
            // 
            this.EndDatePledge.Text = "Wygaśnięcie zastawu";
            this.EndDatePledge.Width = 98;
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.BackColor = System.Drawing.Color.Transparent;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClients.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelClients.Location = new System.Drawing.Point(12, 9);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(128, 42);
            this.labelClients.TabIndex = 4;
            this.labelClients.Text = "Klienci";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.BackColor = System.Drawing.Color.Transparent;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelItems.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelItems.Location = new System.Drawing.Point(1210, 9);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(142, 42);
            this.labelItems.TabIndex = 5;
            this.labelItems.Text = "Rzeczy";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(613, 364);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(70, 30);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Zmień";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.Location = new System.Drawing.Point(689, 364);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(70, 30);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "Dodaj";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(458, 101);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(225, 17);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(458, 289);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(225, 47);
            this.txtAddress.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTel.Location = new System.Drawing.Point(458, 242);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(225, 17);
            this.txtTel.TabIndex = 10;
            // 
            // txtPesel
            // 
            this.txtPesel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPesel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesel.Location = new System.Drawing.Point(458, 195);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(225, 17);
            this.txtPesel.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(458, 148);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 17);
            this.txtLastName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(458, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(458, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(458, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "PESEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(458, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Numer telefonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(458, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adres zamieszkania";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemName.Location = new System.Drawing.Point(698, 101);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(225, 17);
            this.txtItemName.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(698, 195);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(225, 17);
            this.txtPrice.TabIndex = 20;
            // 
            // txtIdClient
            // 
            this.txtIdClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdClient.Location = new System.Drawing.Point(698, 242);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(225, 17);
            this.txtIdClient.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(698, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nazwa przedmiotu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(698, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cena";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(698, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Id klienta";
            // 
            // btnClearClients
            // 
            this.btnClearClients.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClearClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearClients.FlatAppearance.BorderSize = 0;
            this.btnClearClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearClients.Location = new System.Drawing.Point(534, 364);
            this.btnClearClients.Name = "btnClearClients";
            this.btnClearClients.Size = new System.Drawing.Size(73, 30);
            this.btnClearClients.TabIndex = 24;
            this.btnClearClients.Text = "Wyczyść";
            this.btnClearClients.UseVisualStyleBackColor = false;
            this.btnClearClients.Click += new System.EventHandler(this.btnClearClients_Click);
            // 
            // btnClearItems
            // 
            this.btnClearItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClearItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearItems.FlatAppearance.BorderSize = 0;
            this.btnClearItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearItems.Location = new System.Drawing.Point(765, 364);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(73, 30);
            this.btnClearItems.TabIndex = 25;
            this.btnClearItems.Text = "Wyczyść";
            this.btnClearItems.UseVisualStyleBackColor = false;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.BackColor = System.Drawing.Color.Transparent;
            this.labelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDays.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelDays.Location = new System.Drawing.Point(698, 121);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(99, 24);
            this.labelDays.TabIndex = 22;
            this.labelDays.Text = "Na ile dni?";
            // 
            // txtDays
            // 
            this.txtDays.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDays.Location = new System.Drawing.Point(698, 148);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(225, 17);
            this.txtDays.TabIndex = 19;
            // 
            // btnImportClients
            // 
            this.btnImportClients.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImportClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImportClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportClients.FlatAppearance.BorderSize = 0;
            this.btnImportClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportClients.Location = new System.Drawing.Point(146, 26);
            this.btnImportClients.Name = "btnImportClients";
            this.btnImportClients.Size = new System.Drawing.Size(135, 25);
            this.btnImportClients.TabIndex = 29;
            this.btnImportClients.Text = "Importuj klientów";
            this.btnImportClients.UseVisualStyleBackColor = false;
            this.btnImportClients.Click += new System.EventHandler(this.btnImportClients_Click);
            // 
            // btnImportItems
            // 
            this.btnImportItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImportItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImportItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportItems.FlatAppearance.BorderSize = 0;
            this.btnImportItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportItems.Location = new System.Drawing.Point(928, 2);
            this.btnImportItems.Name = "btnImportItems";
            this.btnImportItems.Size = new System.Drawing.Size(135, 56);
            this.btnImportItems.TabIndex = 30;
            this.btnImportItems.Text = "Importuj przedmioty";
            this.btnImportItems.UseVisualStyleBackColor = false;
            this.btnImportItems.Click += new System.EventHandler(this.btnImportItems_Click);
            // 
            // btnExportClients
            // 
            this.btnExportClients.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExportClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportClients.FlatAppearance.BorderSize = 0;
            this.btnExportClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportClients.Location = new System.Drawing.Point(287, 1);
            this.btnExportClients.Name = "btnExportClients";
            this.btnExportClients.Size = new System.Drawing.Size(135, 50);
            this.btnExportClients.TabIndex = 31;
            this.btnExportClients.Text = "Eksportuj klientów";
            this.btnExportClients.UseVisualStyleBackColor = false;
            this.btnExportClients.Click += new System.EventHandler(this.btnExportClients_Click);
            // 
            // btnExportItems
            // 
            this.btnExportItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExportItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportItems.FlatAppearance.BorderSize = 0;
            this.btnExportItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportItems.Location = new System.Drawing.Point(1069, 12);
            this.btnExportItems.Name = "btnExportItems";
            this.btnExportItems.Size = new System.Drawing.Size(135, 46);
            this.btnExportItems.TabIndex = 32;
            this.btnExportItems.Text = "Eksportuj przedmioty";
            this.btnExportItems.UseVisualStyleBackColor = false;
            this.btnExportItems.Click += new System.EventHandler(this.btnExportItems_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveClient.FlatAppearance.BorderSize = 0;
            this.btnRemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveClient.Location = new System.Drawing.Point(197, 551);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(73, 30);
            this.btnRemoveClient.TabIndex = 33;
            this.btnRemoveClient.Text = "Usuń";
            this.btnRemoveClient.UseVisualStyleBackColor = false;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.Location = new System.Drawing.Point(1120, 551);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(73, 30);
            this.btnRemoveItem.TabIndex = 34;
            this.btnRemoveItem.Text = "Usuń";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1364, 596);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.btnExportItems);
            this.Controls.Add(this.btnExportClients);
            this.Controls.Add(this.btnImportItems);
            this.Controls.Add(this.btnImportClients);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.btnClearItems);
            this.Controls.Add(this.btnClearClients);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.listViewClients);
            this.Controls.Add(this.BtnAddClient);
            this.Controls.Add(this.btnChangeItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Administracyjny Lombardu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeItem;
        private System.Windows.Forms.Button BtnAddClient;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Pesel;
        private System.Windows.Forms.ColumnHeader TelNumber;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader IdItem;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader ClientId;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearClients;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.ColumnHeader DatePledge;
        private System.Windows.Forms.ColumnHeader EndDatePledge;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnImportClients;
        private System.Windows.Forms.Button btnImportItems;
        private System.Windows.Forms.Button btnExportClients;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExportItems;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}