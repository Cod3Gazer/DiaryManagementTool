namespace DiaryManagementTool
{
    partial class CustomerForm
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
            this.ScreenPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.AddCustomerForm = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.FormTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FollowUpByTxtbox = new System.Windows.Forms.TextBox();
            this.CreditDaysTxtbox = new System.Windows.Forms.TextBox();
            this.AddressTxtbox = new System.Windows.Forms.TextBox();
            this.AlterPhnNoTxtbox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTxtbox = new System.Windows.Forms.TextBox();
            this.PrintNameTxtBox = new System.Windows.Forms.TextBox();
            this.AliasTxtbox = new System.Windows.Forms.TextBox();
            this.FollowUpByLbl = new System.Windows.Forms.Label();
            this.CreditDaysLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.AlterPhoneNoLbl = new System.Windows.Forms.Label();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.LedgerTypeLbl = new System.Windows.Forms.Label();
            this.PrintNameLbl = new System.Windows.Forms.Label();
            this.AliasLbl = new System.Windows.Forms.Label();
            this.NameTxtbox = new System.Windows.Forms.TextBox();
            this.DairyVocherLbl = new System.Windows.Forms.Label();
            this.LedgerTypeListBox = new System.Windows.Forms.ListBox();
            this.ScreenPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.AddCustomerForm.SuspendLayout();
            this.FormTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.ColumnCount = 1;
            this.ScreenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScreenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ScreenPanel.Controls.Add(this.MainPanel, 0, 0);
            this.ScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.RowCount = 1;
            this.ScreenPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScreenPanel.Size = new System.Drawing.Size(1077, 617);
            this.ScreenPanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.MainPanel.Controls.Add(this.AddCustomerForm, 0, 1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 2;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.462822F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.53718F));
            this.MainPanel.Size = new System.Drawing.Size(1077, 617);
            this.MainPanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.HeaderPanel.Controls.Add(this.HeaderLbl);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1077, 33);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.ForeColor = System.Drawing.Color.White;
            this.HeaderLbl.Location = new System.Drawing.Point(370, 1);
            this.HeaderLbl.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(255, 32);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "ADD CUSTOMER";
            // 
            // AddCustomerForm
            // 
            this.AddCustomerForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerForm.BackColor = System.Drawing.Color.White;
            this.AddCustomerForm.Controls.Add(this.btnClearAll);
            this.AddCustomerForm.Controls.Add(this.btnSubmit);
            this.AddCustomerForm.Controls.Add(this.FormTableLayout);
            this.AddCustomerForm.Location = new System.Drawing.Point(0, 33);
            this.AddCustomerForm.Margin = new System.Windows.Forms.Padding(0);
            this.AddCustomerForm.Name = "AddCustomerForm";
            this.AddCustomerForm.Size = new System.Drawing.Size(1077, 578);
            this.AddCustomerForm.TabIndex = 1;
            this.AddCustomerForm.TabStop = false;
            this.AddCustomerForm.Text = "Add Customer";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearAll.BackColor = System.Drawing.Color.White;
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnClearAll.Location = new System.Drawing.Point(207, 512);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(300, 34);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(541, 512);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(300, 34);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormTableLayout
            // 
            this.FormTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormTableLayout.ColumnCount = 2;
            this.FormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.81073F));
            this.FormTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.18927F));
            this.FormTableLayout.Controls.Add(this.FollowUpByTxtbox, 1, 8);
            this.FormTableLayout.Controls.Add(this.CreditDaysTxtbox, 1, 7);
            this.FormTableLayout.Controls.Add(this.AddressTxtbox, 1, 6);
            this.FormTableLayout.Controls.Add(this.AlterPhnNoTxtbox, 1, 5);
            this.FormTableLayout.Controls.Add(this.PhoneNumberTxtbox, 1, 4);
            this.FormTableLayout.Controls.Add(this.PrintNameTxtBox, 1, 2);
            this.FormTableLayout.Controls.Add(this.AliasTxtbox, 1, 1);
            this.FormTableLayout.Controls.Add(this.FollowUpByLbl, 0, 8);
            this.FormTableLayout.Controls.Add(this.CreditDaysLbl, 0, 7);
            this.FormTableLayout.Controls.Add(this.AddressLbl, 0, 6);
            this.FormTableLayout.Controls.Add(this.AlterPhoneNoLbl, 0, 5);
            this.FormTableLayout.Controls.Add(this.PhoneNumberLbl, 0, 4);
            this.FormTableLayout.Controls.Add(this.LedgerTypeLbl, 0, 3);
            this.FormTableLayout.Controls.Add(this.PrintNameLbl, 0, 2);
            this.FormTableLayout.Controls.Add(this.AliasLbl, 0, 1);
            this.FormTableLayout.Controls.Add(this.NameTxtbox, 1, 0);
            this.FormTableLayout.Controls.Add(this.DairyVocherLbl, 0, 0);
            this.FormTableLayout.Controls.Add(this.LedgerTypeListBox, 1, 3);
            this.FormTableLayout.Location = new System.Drawing.Point(145, 37);
            this.FormTableLayout.Name = "FormTableLayout";
            this.FormTableLayout.RowCount = 9;
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.FormTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.FormTableLayout.Size = new System.Drawing.Size(759, 442);
            this.FormTableLayout.TabIndex = 0;
            // 
            // FollowUpByTxtbox
            // 
            this.FollowUpByTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FollowUpByTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowUpByTxtbox.Location = new System.Drawing.Point(229, 406);
            this.FollowUpByTxtbox.Name = "FollowUpByTxtbox";
            this.FollowUpByTxtbox.Size = new System.Drawing.Size(527, 26);
            this.FollowUpByTxtbox.TabIndex = 28;
            // 
            // CreditDaysTxtbox
            // 
            this.CreditDaysTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditDaysTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditDaysTxtbox.Location = new System.Drawing.Point(229, 360);
            this.CreditDaysTxtbox.Name = "CreditDaysTxtbox";
            this.CreditDaysTxtbox.Size = new System.Drawing.Size(527, 26);
            this.CreditDaysTxtbox.TabIndex = 27;
            // 
            // AddressTxtbox
            // 
            this.AddressTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxtbox.Location = new System.Drawing.Point(229, 281);
            this.AddressTxtbox.Multiline = true;
            this.AddressTxtbox.Name = "AddressTxtbox";
            this.AddressTxtbox.Size = new System.Drawing.Size(527, 58);
            this.AddressTxtbox.TabIndex = 26;
            // 
            // AlterPhnNoTxtbox
            // 
            this.AlterPhnNoTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AlterPhnNoTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterPhnNoTxtbox.Location = new System.Drawing.Point(229, 234);
            this.AlterPhnNoTxtbox.Name = "AlterPhnNoTxtbox";
            this.AlterPhnNoTxtbox.Size = new System.Drawing.Size(527, 26);
            this.AlterPhnNoTxtbox.TabIndex = 25;
            // 
            // PhoneNumberTxtbox
            // 
            this.PhoneNumberTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTxtbox.Location = new System.Drawing.Point(229, 189);
            this.PhoneNumberTxtbox.Name = "PhoneNumberTxtbox";
            this.PhoneNumberTxtbox.Size = new System.Drawing.Size(527, 26);
            this.PhoneNumberTxtbox.TabIndex = 24;
            // 
            // PrintNameTxtBox
            // 
            this.PrintNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintNameTxtBox.Location = new System.Drawing.Point(229, 99);
            this.PrintNameTxtBox.Name = "PrintNameTxtBox";
            this.PrintNameTxtBox.Size = new System.Drawing.Size(527, 26);
            this.PrintNameTxtBox.TabIndex = 22;
            // 
            // AliasTxtbox
            // 
            this.AliasTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AliasTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliasTxtbox.Location = new System.Drawing.Point(229, 54);
            this.AliasTxtbox.Name = "AliasTxtbox";
            this.AliasTxtbox.Size = new System.Drawing.Size(527, 26);
            this.AliasTxtbox.TabIndex = 21;
            // 
            // FollowUpByLbl
            // 
            this.FollowUpByLbl.AutoSize = true;
            this.FollowUpByLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FollowUpByLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FollowUpByLbl.Location = new System.Drawing.Point(3, 396);
            this.FollowUpByLbl.Name = "FollowUpByLbl";
            this.FollowUpByLbl.Size = new System.Drawing.Size(220, 46);
            this.FollowUpByLbl.TabIndex = 20;
            this.FollowUpByLbl.Text = "Follow Up By";
            this.FollowUpByLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreditDaysLbl
            // 
            this.CreditDaysLbl.AutoSize = true;
            this.CreditDaysLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreditDaysLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditDaysLbl.Location = new System.Drawing.Point(3, 351);
            this.CreditDaysLbl.Name = "CreditDaysLbl";
            this.CreditDaysLbl.Size = new System.Drawing.Size(220, 45);
            this.CreditDaysLbl.TabIndex = 19;
            this.CreditDaysLbl.Text = "Credit Days";
            this.CreditDaysLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.Location = new System.Drawing.Point(3, 270);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(220, 81);
            this.AddressLbl.TabIndex = 18;
            this.AddressLbl.Text = "Address";
            this.AddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlterPhoneNoLbl
            // 
            this.AlterPhoneNoLbl.AutoSize = true;
            this.AlterPhoneNoLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlterPhoneNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlterPhoneNoLbl.Location = new System.Drawing.Point(3, 225);
            this.AlterPhoneNoLbl.Name = "AlterPhoneNoLbl";
            this.AlterPhoneNoLbl.Size = new System.Drawing.Size(220, 45);
            this.AlterPhoneNoLbl.TabIndex = 17;
            this.AlterPhoneNoLbl.Text = "Alternative Phone Number";
            this.AlterPhoneNoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.AutoSize = true;
            this.PhoneNumberLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLbl.Location = new System.Drawing.Point(3, 180);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(220, 45);
            this.PhoneNumberLbl.TabIndex = 16;
            this.PhoneNumberLbl.Text = "Phone Number";
            this.PhoneNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LedgerTypeLbl
            // 
            this.LedgerTypeLbl.AutoSize = true;
            this.LedgerTypeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedgerTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedgerTypeLbl.Location = new System.Drawing.Point(3, 135);
            this.LedgerTypeLbl.Name = "LedgerTypeLbl";
            this.LedgerTypeLbl.Size = new System.Drawing.Size(220, 45);
            this.LedgerTypeLbl.TabIndex = 15;
            this.LedgerTypeLbl.Text = "Ledger Type";
            this.LedgerTypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrintNameLbl
            // 
            this.PrintNameLbl.AutoSize = true;
            this.PrintNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintNameLbl.Location = new System.Drawing.Point(3, 90);
            this.PrintNameLbl.Name = "PrintNameLbl";
            this.PrintNameLbl.Size = new System.Drawing.Size(220, 45);
            this.PrintNameLbl.TabIndex = 14;
            this.PrintNameLbl.Text = "Print Name";
            this.PrintNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AliasLbl
            // 
            this.AliasLbl.AutoSize = true;
            this.AliasLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AliasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliasLbl.Location = new System.Drawing.Point(3, 45);
            this.AliasLbl.Name = "AliasLbl";
            this.AliasLbl.Size = new System.Drawing.Size(220, 45);
            this.AliasLbl.TabIndex = 13;
            this.AliasLbl.Text = "Alias";
            this.AliasLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTxtbox
            // 
            this.NameTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtbox.Location = new System.Drawing.Point(229, 9);
            this.NameTxtbox.Name = "NameTxtbox";
            this.NameTxtbox.Size = new System.Drawing.Size(527, 26);
            this.NameTxtbox.TabIndex = 12;
            // 
            // DairyVocherLbl
            // 
            this.DairyVocherLbl.AutoSize = true;
            this.DairyVocherLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DairyVocherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DairyVocherLbl.Location = new System.Drawing.Point(3, 0);
            this.DairyVocherLbl.Name = "DairyVocherLbl";
            this.DairyVocherLbl.Size = new System.Drawing.Size(220, 45);
            this.DairyVocherLbl.TabIndex = 1;
            this.DairyVocherLbl.Text = "Name";
            this.DairyVocherLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LedgerTypeListBox
            // 
            this.LedgerTypeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedgerTypeListBox.FormattingEnabled = true;
            this.LedgerTypeListBox.Location = new System.Drawing.Point(229, 138);
            this.LedgerTypeListBox.Name = "LedgerTypeListBox";
            this.LedgerTypeListBox.Size = new System.Drawing.Size(527, 39);
            this.LedgerTypeListBox.TabIndex = 29;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 617);
            this.Controls.Add(this.ScreenPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ScreenPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.AddCustomerForm.ResumeLayout(false);
            this.FormTableLayout.ResumeLayout(false);
            this.FormTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ScreenPanel;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.GroupBox AddCustomerForm;
        private System.Windows.Forms.TableLayoutPanel FormTableLayout;
        private System.Windows.Forms.Label DairyVocherLbl;
        private System.Windows.Forms.Label AliasLbl;
        private System.Windows.Forms.Label LedgerTypeLbl;
        private System.Windows.Forms.Label PrintNameLbl;
        private System.Windows.Forms.Label AlterPhoneNoLbl;
        private System.Windows.Forms.Label PhoneNumberLbl;
        private System.Windows.Forms.Label CreditDaysLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox PrintNameTxtBox;
        private System.Windows.Forms.TextBox AliasTxtbox;
        private System.Windows.Forms.Label FollowUpByLbl;
        private System.Windows.Forms.TextBox NameTxtbox;
        private System.Windows.Forms.TextBox PhoneNumberTxtbox;
        private System.Windows.Forms.TextBox AddressTxtbox;
        private System.Windows.Forms.TextBox AlterPhnNoTxtbox;
        private System.Windows.Forms.TextBox FollowUpByTxtbox;
        private System.Windows.Forms.TextBox CreditDaysTxtbox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ListBox LedgerTypeListBox;
    }
}