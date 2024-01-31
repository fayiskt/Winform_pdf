using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsPdfCreation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdf1();
        }
        private void pdf1()
        {
            String savePathReport;
            DateTime datetimenow;

            //start
            //Path for initial directory in dialog box
            savePathReport = Convert.ToString("D:\\Work\\Work\\January 2022\\05-01-2022\\test");
            datetimenow = DateTime.Now;

            SaveFileDialog file_data = new SaveFileDialog();
            file_data.InitialDirectory = savePathReport;
            file_data.Filter = "PDF files (*.pdf)|*.pdf";
            file_data.FileName = "itext_file555";
            file_data.ShowDialog();
            FileStream fs = new FileStream(file_data.FileName, FileMode.Create, FileAccess.Write, FileShare.None);

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //content
            //document.Add(new Paragraph("New Document!"));

            PdfPTable new_table = new PdfPTable(2);
            new_table.WidthPercentage = 50;
            new_table.SetTotalWidth(new float[] { 20, 30});
            ////////////////////////////////
            PdfPCell cell = new PdfPCell();
            cell = new PdfPCell(new Phrase("Name"));
            cell.PaddingRight = 6;
            cell.PaddingBottom = 2;
            new_table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Age"));
            cell.PaddingRight = 6;
            cell.PaddingBottom = 2;
            new_table.AddCell(cell);

            cell = new PdfPCell(new Phrase("A"));
            cell.PaddingRight = 6;
            cell.PaddingBottom = 2;
            new_table.AddCell(cell);

            cell = new PdfPCell(new Phrase("10"));
            cell.PaddingRight = 6;
            cell.PaddingBottom = 2;
            new_table.AddCell(cell);

            cell = new PdfPCell(new Phrase("B"));
            cell.PaddingRight = 6;
            cell.PaddingBottom = 2;
            cell.Rowspan = 2;
            new_table.AddCell(cell);

            cell = new PdfPCell(new Phrase("15"));
            cell.PaddingRight = 6;
            cell.PaddingBottom = 2;
            new_table.AddCell(cell);

            cell = new PdfPCell(new Phrase("20"));
            cell.PaddingRight = 6;
            cell.PaddingBottom = 2;
            new_table.AddCell(cell);


            document.Add(new_table);
            //end
            document.Close();
            writer.Close();
            fs.Close();

            MessageBox.Show("Completed");

        }
        private void pdf2()
        {
        }
    }
}
