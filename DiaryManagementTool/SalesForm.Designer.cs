namespace DiaryManagementTool
{
    partial class SalesForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ScreenPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.SaleForm = new System.Windows.Forms.GroupBox();
            this.cmbScanners = new System.Windows.Forms.ComboBox();
            this.SalesFormUpperPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DairyTimeTxtbox = new System.Windows.Forms.TextBox();
            this.DairyTimeLbl = new System.Windows.Forms.Label();
            this.DairyDateTxtbox = new System.Windows.Forms.TextBox();
            this.DairyDateLbl = new System.Windows.Forms.Label();
            this.DairyVocherLbl = new System.Windows.Forms.Label();
            this.DairyVocherTxtbox = new System.Windows.Forms.TextBox();
            this.Scan = new System.Windows.Forms.Button();
            this.SalesFormLowerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InvoiceNumberTxtbox = new System.Windows.Forms.TextBox();
            this.RemarkTxtbox = new System.Windows.Forms.TextBox();
            this.AmountTxtbox = new System.Windows.Forms.TextBox();
            this.InvoiceDateLbl = new System.Windows.Forms.Label();
            this.InvoiceNumberLbl = new System.Windows.Forms.Label();
            this.PartyNameLbl = new System.Windows.Forms.Label();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.RemarkLbl = new System.Windows.Forms.Label();
            this.InvoiceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PartyNameDdl = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.ScannedPdfViewer = new PdfiumViewer.PdfViewer();
            this.ScreenPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SaleForm.SuspendLayout();
            this.SalesFormUpperPanel.SuspendLayout();
            this.SalesFormLowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "SALES";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.ColumnCount = 1;
            this.ScreenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScreenPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ScreenPanel.Controls.Add(this.MainPanel, 0, 0);
            this.ScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.ScreenPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.RowCount = 1;
            this.ScreenPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScreenPanel.Size = new System.Drawing.Size(1319, 954);
            this.ScreenPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.MainPanel.Controls.Add(this.SaleForm, 0, 1);
            this.MainPanel.Controls.Add(this.ScannedPdfViewer, 0, 2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 3;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.44025F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.84277F));
            this.MainPanel.Size = new System.Drawing.Size(1319, 954);
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
            this.HeaderPanel.Size = new System.Drawing.Size(1319, 45);
            this.HeaderPanel.TabIndex = 0;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.ForeColor = System.Drawing.Color.White;
            this.HeaderLbl.Location = new System.Drawing.Point(600, 5);
            this.HeaderLbl.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(108, 32);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "SALES";
            // 
            // SaleForm
            // 
            this.SaleForm.Controls.Add(this.cmbScanners);
            this.SaleForm.Controls.Add(this.SalesFormUpperPanel);
            this.SaleForm.Controls.Add(this.Scan);
            this.SaleForm.Controls.Add(this.SalesFormLowerPanel);
            this.SaleForm.Controls.Add(this.btnSubmit);
            this.SaleForm.Controls.Add(this.btnClearAll);
            this.SaleForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaleForm.Location = new System.Drawing.Point(3, 48);
            this.SaleForm.Name = "SaleForm";
            this.SaleForm.Size = new System.Drawing.Size(1313, 188);
            this.SaleForm.TabIndex = 1;
            this.SaleForm.TabStop = false;
            this.SaleForm.Text = "Sales Form";
            // 
            // cmbScanners
            // 
            this.cmbScanners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbScanners.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbScanners.FormattingEnabled = true;
            this.cmbScanners.Location = new System.Drawing.Point(3, 149);
            this.cmbScanners.Name = "cmbScanners";
            this.cmbScanners.Size = new System.Drawing.Size(524, 33);
            this.cmbScanners.TabIndex = 13;
            // 
            // SalesFormUpperPanel
            // 
            this.SalesFormUpperPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SalesFormUpperPanel.ColumnCount = 6;
            this.SalesFormUpperPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.SalesFormUpperPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.SalesFormUpperPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.SalesFormUpperPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.SalesFormUpperPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.SalesFormUpperPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.SalesFormUpperPanel.Controls.Add(this.DairyTimeTxtbox, 5, 0);
            this.SalesFormUpperPanel.Controls.Add(this.DairyTimeLbl, 4, 0);
            this.SalesFormUpperPanel.Controls.Add(this.DairyDateTxtbox, 3, 0);
            this.SalesFormUpperPanel.Controls.Add(this.DairyDateLbl, 2, 0);
            this.SalesFormUpperPanel.Controls.Add(this.DairyVocherLbl, 0, 0);
            this.SalesFormUpperPanel.Controls.Add(this.DairyVocherTxtbox, 1, 0);
            this.SalesFormUpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesFormUpperPanel.Location = new System.Drawing.Point(3, 23);
            this.SalesFormUpperPanel.Name = "SalesFormUpperPanel";
            this.SalesFormUpperPanel.RowCount = 1;
            this.SalesFormUpperPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SalesFormUpperPanel.Size = new System.Drawing.Size(1307, 35);
            this.SalesFormUpperPanel.TabIndex = 2;
            // 
            // DairyTimeTxtbox
            // 
            this.DairyTimeTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DairyTimeTxtbox.Enabled = false;
            this.DairyTimeTxtbox.Location = new System.Drawing.Point(1089, 4);
            this.DairyTimeTxtbox.Name = "DairyTimeTxtbox";
            this.DairyTimeTxtbox.Size = new System.Drawing.Size(214, 27);
            this.DairyTimeTxtbox.TabIndex = 5;
            // 
            // DairyTimeLbl
            // 
            this.DairyTimeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DairyTimeLbl.AutoSize = true;
            this.DairyTimeLbl.Location = new System.Drawing.Point(925, 8);
            this.DairyTimeLbl.Name = "DairyTimeLbl";
            this.DairyTimeLbl.Size = new System.Drawing.Size(103, 18);
            this.DairyTimeLbl.TabIndex = 4;
            this.DairyTimeLbl.Text = "Dairy Time:";
            this.DairyTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DairyDateTxtbox
            // 
            this.DairyDateTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DairyDateTxtbox.Enabled = false;
            this.DairyDateTxtbox.Location = new System.Drawing.Point(655, 4);
            this.DairyDateTxtbox.Name = "DairyDateTxtbox";
            this.DairyDateTxtbox.Size = new System.Drawing.Size(210, 27);
            this.DairyDateTxtbox.TabIndex = 3;
            // 
            // DairyDateLbl
            // 
            this.DairyDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DairyDateLbl.AutoSize = true;
            this.DairyDateLbl.Location = new System.Drawing.Point(492, 8);
            this.DairyDateLbl.Name = "DairyDateLbl";
            this.DairyDateLbl.Size = new System.Drawing.Size(102, 18);
            this.DairyDateLbl.TabIndex = 2;
            this.DairyDateLbl.Text = "Dairy Date:";
            this.DairyDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DairyVocherLbl
            // 
            this.DairyVocherLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DairyVocherLbl.AutoSize = true;
            this.DairyVocherLbl.Location = new System.Drawing.Point(11, 8);
            this.DairyVocherLbl.Name = "DairyVocherLbl";
            this.DairyVocherLbl.Size = new System.Drawing.Size(196, 18);
            this.DairyVocherLbl.TabIndex = 0;
            this.DairyVocherLbl.Text = "Dairy Voucher Number:";
            this.DairyVocherLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DairyVocherTxtbox
            // 
            this.DairyVocherTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DairyVocherTxtbox.Enabled = false;
            this.DairyVocherTxtbox.Location = new System.Drawing.Point(221, 4);
            this.DairyVocherTxtbox.Name = "DairyVocherTxtbox";
            this.DairyVocherTxtbox.Size = new System.Drawing.Size(210, 27);
            this.DairyVocherTxtbox.TabIndex = 1;
            // 
            // Scan
            // 
            this.Scan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Scan.BackColor = System.Drawing.Color.RoyalBlue;
            this.Scan.FlatAppearance.BorderSize = 0;
            this.Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.ForeColor = System.Drawing.Color.White;
            this.Scan.Location = new System.Drawing.Point(533, 147);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(194, 34);
            this.Scan.TabIndex = 12;
            this.Scan.Text = "SCAN";
            this.Scan.UseVisualStyleBackColor = false;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // SalesFormLowerPanel
            // 
            this.SalesFormLowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesFormLowerPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SalesFormLowerPanel.ColumnCount = 5;
            this.SalesFormLowerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SalesFormLowerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SalesFormLowerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SalesFormLowerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SalesFormLowerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SalesFormLowerPanel.Controls.Add(this.InvoiceNumberTxtbox, 1, 1);
            this.SalesFormLowerPanel.Controls.Add(this.RemarkTxtbox, 4, 1);
            this.SalesFormLowerPanel.Controls.Add(this.AmountTxtbox, 3, 1);
            this.SalesFormLowerPanel.Controls.Add(this.InvoiceDateLbl, 0, 0);
            this.SalesFormLowerPanel.Controls.Add(this.InvoiceNumberLbl, 1, 0);
            this.SalesFormLowerPanel.Controls.Add(this.PartyNameLbl, 2, 0);
            this.SalesFormLowerPanel.Controls.Add(this.AmountLbl, 3, 0);
            this.SalesFormLowerPanel.Controls.Add(this.RemarkLbl, 4, 0);
            this.SalesFormLowerPanel.Controls.Add(this.InvoiceDatePicker, 0, 1);
            this.SalesFormLowerPanel.Controls.Add(this.PartyNameDdl, 2, 1);
            this.SalesFormLowerPanel.Location = new System.Drawing.Point(3, 64);
            this.SalesFormLowerPanel.Name = "SalesFormLowerPanel";
            this.SalesFormLowerPanel.RowCount = 2;
            this.SalesFormLowerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SalesFormLowerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SalesFormLowerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SalesFormLowerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SalesFormLowerPanel.Size = new System.Drawing.Size(1307, 78);
            this.SalesFormLowerPanel.TabIndex = 1;
            // 
            // InvoiceNumberTxtbox
            // 
            this.InvoiceNumberTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceNumberTxtbox.Location = new System.Drawing.Point(265, 42);
            this.InvoiceNumberTxtbox.Name = "InvoiceNumberTxtbox";
            this.InvoiceNumberTxtbox.Size = new System.Drawing.Size(254, 27);
            this.InvoiceNumberTxtbox.TabIndex = 9;
            // 
            // RemarkTxtbox
            // 
            this.RemarkTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemarkTxtbox.Location = new System.Drawing.Point(1048, 42);
            this.RemarkTxtbox.Name = "RemarkTxtbox";
            this.RemarkTxtbox.Size = new System.Drawing.Size(255, 27);
            this.RemarkTxtbox.TabIndex = 8;
            // 
            // AmountTxtbox
            // 
            this.AmountTxtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmountTxtbox.Location = new System.Drawing.Point(787, 42);
            this.AmountTxtbox.Name = "AmountTxtbox";
            this.AmountTxtbox.Size = new System.Drawing.Size(254, 27);
            this.AmountTxtbox.TabIndex = 7;
            // 
            // InvoiceDateLbl
            // 
            this.InvoiceDateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvoiceDateLbl.AutoSize = true;
            this.InvoiceDateLbl.Location = new System.Drawing.Point(75, 10);
            this.InvoiceDateLbl.Name = "InvoiceDateLbl";
            this.InvoiceDateLbl.Size = new System.Drawing.Size(112, 18);
            this.InvoiceDateLbl.TabIndex = 1;
            this.InvoiceDateLbl.Text = "Invoice Date";
            this.InvoiceDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceNumberLbl
            // 
            this.InvoiceNumberLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvoiceNumberLbl.AutoSize = true;
            this.InvoiceNumberLbl.Location = new System.Drawing.Point(324, 10);
            this.InvoiceNumberLbl.Name = "InvoiceNumberLbl";
            this.InvoiceNumberLbl.Size = new System.Drawing.Size(136, 18);
            this.InvoiceNumberLbl.TabIndex = 4;
            this.InvoiceNumberLbl.Text = "Invoice Number";
            this.InvoiceNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PartyNameLbl
            // 
            this.PartyNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PartyNameLbl.AutoSize = true;
            this.PartyNameLbl.Location = new System.Drawing.Point(601, 10);
            this.PartyNameLbl.Name = "PartyNameLbl";
            this.PartyNameLbl.Size = new System.Drawing.Size(103, 18);
            this.PartyNameLbl.TabIndex = 3;
            this.PartyNameLbl.Text = "Party Name";
            this.PartyNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AmountLbl
            // 
            this.AmountLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(878, 10);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(71, 18);
            this.AmountLbl.TabIndex = 6;
            this.AmountLbl.Text = "Amount";
            this.AmountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RemarkLbl
            // 
            this.RemarkLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemarkLbl.AutoSize = true;
            this.RemarkLbl.Location = new System.Drawing.Point(1106, 10);
            this.RemarkLbl.Name = "RemarkLbl";
            this.RemarkLbl.Size = new System.Drawing.Size(138, 18);
            this.RemarkLbl.TabIndex = 5;
            this.RemarkLbl.Text = "Remark (If Any)";
            this.RemarkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceDatePicker
            // 
            this.InvoiceDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvoiceDatePicker.Location = new System.Drawing.Point(4, 42);
            this.InvoiceDatePicker.Name = "InvoiceDatePicker";
            this.InvoiceDatePicker.Size = new System.Drawing.Size(254, 27);
            this.InvoiceDatePicker.TabIndex = 11;
            // 
            // PartyNameDdl
            // 
            this.PartyNameDdl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartyNameDdl.FormattingEnabled = true;
            this.PartyNameDdl.Location = new System.Drawing.Point(526, 42);
            this.PartyNameDdl.Name = "PartyNameDdl";
            this.PartyNameDdl.Size = new System.Drawing.Size(254, 26);
            this.PartyNameDdl.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1116, 148);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 34);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.BackColor = System.Drawing.Color.White;
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnClearAll.Location = new System.Drawing.Point(923, 148);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(187, 34);
            this.btnClearAll.TabIndex = 12;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // ScannedPdfViewer
            // 
            this.ScannedPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScannedPdfViewer.Location = new System.Drawing.Point(8, 245);
            this.ScannedPdfViewer.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ScannedPdfViewer.Name = "ScannedPdfViewer";
            this.ScannedPdfViewer.Size = new System.Drawing.Size(1303, 703);
            this.ScannedPdfViewer.TabIndex = 2;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 954);
            this.Controls.Add(this.ScreenPanel);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.ScreenPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.SaleForm.ResumeLayout(false);
            this.SalesFormUpperPanel.ResumeLayout(false);
            this.SalesFormUpperPanel.PerformLayout();
            this.SalesFormLowerPanel.ResumeLayout(false);
            this.SalesFormLowerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel ScreenPanel;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.GroupBox SaleForm;
        private System.Windows.Forms.TableLayoutPanel SalesFormLowerPanel;
        private System.Windows.Forms.TableLayoutPanel SalesFormUpperPanel;
        private System.Windows.Forms.TextBox DairyVocherTxtbox;
        private System.Windows.Forms.TextBox DairyTimeTxtbox;
        private System.Windows.Forms.Label DairyTimeLbl;
        private System.Windows.Forms.TextBox DairyDateTxtbox;
        private System.Windows.Forms.Label DairyDateLbl;
        private System.Windows.Forms.Label DairyVocherLbl;
        private System.Windows.Forms.TextBox InvoiceNumberTxtbox;
        private System.Windows.Forms.TextBox RemarkTxtbox;
        private System.Windows.Forms.TextBox AmountTxtbox;
        private System.Windows.Forms.Label InvoiceDateLbl;
        private System.Windows.Forms.Label InvoiceNumberLbl;
        private System.Windows.Forms.Label PartyNameLbl;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Label RemarkLbl;
        private System.Windows.Forms.DateTimePicker InvoiceDatePicker;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox PartyNameDdl;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.ComboBox cmbScanners;
        private PdfiumViewer.PdfViewer ScannedPdfViewer;
    }
}