using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel;

namespace NoidelVV_Admin
{
    public partial class GenCrediti : Form
    {
        public GenCrediti()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatePswBt_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Microsoft.Office.Interop.Word._Application oWord;
            Microsoft.Office.Interop.Word._Document oDoc;
            oWord = new Microsoft.Office.Interop.Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);
            foreach (var worksheet in Workbook.Worksheets(fileTB.Text))
                foreach (var row in worksheet.Rows)
                {
                    string activity = row.Cells[0].Text;
                    string name = row.Cells[1].Text;
                    string classe = row.Cells[2].Text;
                    string done = row.Cells[3].Text;
                    string time = row.Cells[4].Text;

                    Microsoft.Office.Interop.Word.Paragraph oPara8;
                    oPara8 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara8.Range.InlineShapes.AddPicture(Application.StartupPath + @"\logo_circolari.png");
                    oPara8.Range.InsertParagraphAfter();

                    //Microsoft.Office.Interop.Word.Paragraph oPara1;
                    //oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    //oPara1.Range.Text = activity;
                    //oPara1.Range.Font.Bold = 1;
                    //oPara1.Range.Font.Size = 24;
                    //oPara1.Range.Font.Name = "Verdana";
                    //oPara1.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    //oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    //oPara1.Range.InsertParagraphAfter();

                    Microsoft.Office.Interop.Word.Paragraph oPara2;
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Text = "Si attesta che lo studente";
                    oPara2.Range.Font.Size = 9;
                    oPara2.Range.Font.Bold = 0;
                    oPara2.Range.Font.Name = "Verdana";
                    oPara2.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara2.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    oPara2.Range.InsertParagraphAfter();

                    Microsoft.Office.Interop.Word.Paragraph oPara3;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara3.Range.Text = name;
                    oPara3.Range.Font.Bold = 1;
                    oPara3.Range.Font.Size = 18;
                    oPara3.Range.Font.Name = "Verdana";
                    oPara3.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara3.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    oPara3.Range.InsertParagraphAfter();

                    Microsoft.Office.Interop.Word.Paragraph oPara4;
                    oPara4 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara4.Range.Text = "classe "+classe+", ha partecipato all'organizzazione dell'attività";
                    oPara4.Range.Font.Size = 9;
                    oPara4.Range.Font.Bold = 0;
                    oPara4.Range.Font.Name = "Verdana";
                    oPara4.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara4.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    oPara4.Range.InsertParagraphAfter();

                    Microsoft.Office.Interop.Word.Paragraph oPara6;
                    oPara6 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara6.Range.Text = activity;
                    oPara6.Range.Font.Bold = 0;
                    oPara6.Range.Font.Size = 16;
                    oPara6.Range.Font.Name = "Verdana";
                    oPara6.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara6.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    oPara6.Range.InsertParagraphAfter();

                    Microsoft.Office.Interop.Word.Paragraph assets = oDoc.Content.Paragraphs.Add();
                    assets.Format.SpaceAfter = 1; 
                    assets.Range.Font.Size = 9;
                    assets.Range.Text = "";
                    assets.Range.Font.Name = "Verdana";
                    assets.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    assets.Format.SpaceAfter = 1; 
                    string[] bulletItems = done.Split(',');
                    foreach (string dn in bulletItems)
                    {
                        assets.Range.Font.Size = 11;
                        assets.Range.Text += dn + "\n";
                    }
                    assets.Format.SpaceAfter = 24;
                    assets.Range.InsertParagraphAfter();

                    Microsoft.Office.Interop.Word.Paragraph oPara5;
                    oPara5 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara5.Range.Text = "per " + time;
                    oPara5.Range.Font.Size = 9;
                    oPara5.Range.Font.Name = "Verdana";
                    oPara5.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara5.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    oPara5.Range.InsertParagraphAfter();

                    Microsoft.Office.Interop.Word.Paragraph oPara7;
                    oPara7 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara7.Range.Text = "La Vicepreside";
                    oPara7.Range.Font.Size = 9;
                    oPara7.Range.Font.Name = "Verdana";
                    oPara7.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight;
                    oPara7.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    oPara7.Range.InsertParagraphAfter();

                    oDoc.Words.Last.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fld = new OpenFileDialog();
            fld.Filter = "File Excel (*.xlsx)|*.xlsx";
            fld.ShowDialog();
            fileTB.Text = fld.FileName;
        }
    }
}
