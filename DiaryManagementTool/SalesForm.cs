using DataAccessLayer;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;
using WIA;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;


namespace DiaryManagementTool
{
    public partial class SalesForm : Form
    {

        public SalesForm()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btnSubmit.BackColor = Color.Gray;
            ListScanners();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            PartyNameDdl.TextChanged += ValidateForm;
            InvoiceNumberTxtbox.TextChanged += ValidateForm;
            RemarkTxtbox.TextChanged += ValidateForm;
            AmountTxtbox.TextChanged += ValidateForm;

            SetInitialValues();
            InitializeDateTimePicker();
            InitializePartyNameComboBox();
            //InitializePdfViewer();
        }

        private void InitializePdfViewer()
        {
            ScannedPdfViewer = new PdfViewer();
            ScannedPdfViewer.Dock = DockStyle.Fill;
            this.Controls.Add(ScannedPdfViewer);
        }

        private void ListScanners()
        {
            // WIA Device Manager
            var deviceManager = new DeviceManager();
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Only consider scanner devices
                if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType)
                {
                    cmbScanners.Items.Add(new ScannerInfo
                    {
                        Name = deviceManager.DeviceInfos[i].Properties["Name"].get_Value().ToString(),
                        DeviceID = deviceManager.DeviceInfos[i].DeviceID
                    });
                }
            }

            if (cmbScanners.Items.Count > 0)
            {
                cmbScanners.SelectedIndex = 0;
            }
        }

        private void SetInitialValues()
        {
            DairyVocherTxtbox.Text = GetNextVoucherNumber().ToString();
            DairyDateTxtbox.Text = DateTime.Now.ToShortDateString();
            DairyTimeTxtbox.Text = DateTime.Now.ToShortTimeString();
        }

        private int GetNextVoucherNumber()
        {
            using (var context = new AppDbContext())
            {
                var lastVoucher = context.Sales.OrderByDescending(s => s.DairyVoucherNumber).FirstOrDefault();
                return lastVoucher != null ? lastVoucher.DairyVoucherNumber + 1 : 1;
            }
        }

        private void InitializePartyNameComboBox()
        {
            PartyNameDdl.DropDownStyle = ComboBoxStyle.DropDown;
            PartyNameDdl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PartyNameDdl.AutoCompleteSource = AutoCompleteSource.ListItems;

            LoadCustomerNames();
        }

        private void LoadCustomerNames()
        {
            using (var context = new AppDbContext())
            {
                var customers = context.Customers
                                       .Select(c => new { Id = c.CustomerId, Name = c.FullName })
                                       .ToList();

                var dataSource = new List<dynamic> { new { Id = 0, Name = string.Empty } };
                dataSource.AddRange(customers);

                PartyNameDdl.DataSource = dataSource;
                PartyNameDdl.DisplayMember = "Name";
                PartyNameDdl.ValueMember = "Id";

                PartyNameDdl.SelectedIndex = 0;
            }
        }

        private void InitializeDateTimePicker()
        {
            InvoiceDatePicker.Format = DateTimePickerFormat.Custom;
            InvoiceDatePicker.CustomFormat = "dd/MM/yyyy";
            InvoiceDatePicker.Value = DateTime.Now;
        }

        private void SaveSale(Sales sale)
        {
            using (var context = new AppDbContext())
            {
                context.Sales.Add(sale);
                context.SaveChanges();
            }
        }

        private void ValidateForm(object sender, EventArgs e)
        {
            bool isValid = !string.IsNullOrWhiteSpace(PartyNameDdl.Text) &&
                            !string.IsNullOrWhiteSpace(InvoiceNumberTxtbox.Text) &&
                            !string.IsNullOrWhiteSpace(AmountTxtbox.Text) &&
                            PartyNameDdl.SelectedIndex != 0;

            btnSubmit.Enabled = isValid;
            btnSubmit.BackColor = isValid ? Color.RoyalBlue : Color.Gray;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var sale = new Sales
            {
                DairyVoucherNumber = int.Parse(DairyVocherTxtbox.Text),
                DairyTime = TimeSpan.Parse(DairyTimeTxtbox.Text),
                DairyDate = DateTime.Parse(DairyDateTxtbox.Text),
                InvoiceDate = InvoiceDatePicker.Value,
                PartyName = PartyNameDdl.Text,
                CustomerId = (int)PartyNameDdl.SelectedValue,
                InvoiceNumber = InvoiceNumberTxtbox.Text,
                Remarks = RemarkTxtbox.Text,
                SalesType = "Sales",
                Amount = decimal.Parse(AmountTxtbox.Text)
            };

            SaveSale(sale);
            MessageBox.Show("Sale recorded successfully.");
            ClearForm();
            SetInitialValues();

        }

        private void ClearForm()
        {
            // Reset all textboxes
            InvoiceDatePicker.Text = string.Empty;
            PartyNameDdl.SelectedIndex = 0;
            InvoiceNumberTxtbox.Text = string.Empty;
            RemarkTxtbox.Text = string.Empty;
            AmountTxtbox.Text = string.Empty;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            var scannerInfo = (ScannerInfo)cmbScanners.SelectedItem;
            var savePath = "C:\\Sumit";

            var images = ScanDocuments(scannerInfo.DeviceID);
            if (images.Count > 0)
            {
                var pdfPath = Path.Combine(savePath, "ScannedDocument.pdf");
                SaveImagesToPdf(images, pdfPath);
                MessageBox.Show($"PDF saved at {pdfPath}");

                // Display the PDF
                DisplayPdf(pdfPath);
            }
            else
            {
                MessageBox.Show("No images scanned.");
            }
        }

        private void DisplayPdf(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("PDF file does not exist.");
                return;
            }

            try
            {
                var pdfDocument = PdfiumViewer.PdfDocument.Load(filePath);
                if (ScannedPdfViewer.Document != null)
                {
                    ScannedPdfViewer.Document.Dispose();
                }
                ScannedPdfViewer.Document = pdfDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load PDF: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private List<Image> ScanDocuments(string scannerId)
        {
            List<Image> scannedImages = new List<Image>();
            var deviceManager = new DeviceManager() as IDeviceManager; // Use the IDeviceManager interface

            Device scannerDevice = null;
            foreach (DeviceInfo info in deviceManager.DeviceInfos)
            {
                if (info.DeviceID == scannerId && info.Type == WiaDeviceType.ScannerDeviceType)
                {
                    scannerDevice = info.Connect();
                    break;
                }
            }

            if (scannerDevice != null)
            {
                SetScannerToADF(scannerDevice);

                int pageCounter = 1;

                while (true)
                {
                    try
                    {
                        ImageFile imageFile = (ImageFile)scannerDevice.Items[1].Transfer("{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}");
                        Image scannedImage = ConvertImageFileToImage(imageFile);
                        scannedImages.Add(scannedImage);
                        pageCounter++;
                        System.Threading.Thread.Sleep(5000);
                    }
                    catch (COMException ex)
                    {
                        Console.WriteLine("Caught COMException: " + ex.Message);
                        if (ex.ErrorCode == -2145325046)
                        {
                            Console.WriteLine("The document feeder is empty. No more pages to scan.");
                        }
                        else
                        {
                            Console.WriteLine("An unexpected scanner error occurred. Continuing with available images.");
                        }
                        break;
                    }
                }
            }

            return scannedImages;
        }

        private Image ConvertImageFileToImage(ImageFile imageFile)
        {
            byte[] imageBytes = (byte[])imageFile.FileData.get_BinaryData();
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void SetScannerToADF(Device scannerDevice)
        {
            const int WIA_DPS_DOCUMENT_HANDLING_SELECT = 3088;
            const int FEEDER = 1;

            foreach (Property prop in scannerDevice.Properties)
            {
                if (prop.PropertyID == WIA_DPS_DOCUMENT_HANDLING_SELECT)
                {
                    prop.set_Value(FEEDER);
                    break;
                }
            }
        }
        public void SaveImagesToPdf(List<System.Drawing.Image> images, string outputPath)
        {
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(images[0], null));
            iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(new PdfWriter(outputPath));
            Document doc = new Document(pdfDoc, new iText.Kernel.Geom.PageSize(image.GetImageWidth(), image.GetImageHeight()));

            for (int i = 0; i < images.Count; i++)
            {
                image = new iText.Layout.Element.Image(ImageDataFactory.Create(images[i], null));
                pdfDoc.AddNewPage(new iText.Kernel.Geom.PageSize(image.GetImageWidth(), image.GetImageHeight()));
                image.SetFixedPosition(i + 1, 0, 0);
                doc.Add(image);
            }

            doc.Close();
        }

        private void SalesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ScannedPdfViewer.Document != null)
            {
                ScannedPdfViewer.Document.Dispose();
            }
        }
    }
}
public class ScannerInfo
{
    public string Name { get; set; }
    public string DeviceID { get; set; }

    public override string ToString()
    {
        return Name;
    }
}
