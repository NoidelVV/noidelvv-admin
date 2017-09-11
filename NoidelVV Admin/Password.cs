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
    public partial class Password : Form
    {
        string year, text, title;
        public Password()
        {
            InitializeComponent();
        }

        private void generatePswBt_Click(object sender, EventArgs e)
        {
            title = titleTB.Text; year = yearMTB.Text; text = textTB.Text;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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
            bool pageBreak = false;
            foreach (var worksheet in Workbook.Worksheets(fileTB.Text))
                foreach (var row in worksheet.Rows)
                {
                    string name = row.Cells[1].Text;
                    string surname = row.Cells[0].Text;
                    string cl = row.Cells[4].Text;
                    string username = row.Cells[2].Text;
                    string password = row.Cells[3].Text;

                    Microsoft.Office.Interop.Word.Paragraph oPara1;
                    oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = name + " " + surname + " " + cl + " - A.S. " + year;
                    oPara1.Range.Font.Bold = 1;
                    oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    oPara1.Range.InsertParagraphAfter();

                    string text2 = text.Replace("%name%", row.Cells[1].Text).Replace("%surname%", row.Cells[0].Text).Replace("%class%", row.Cells[4].Text).Replace("%username%", row.Cells[2].Text).Replace("%password%", row.Cells[3].Text);
                    Microsoft.Office.Interop.Word.Paragraph oPara2;
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Font.Bold = 0;
                    oPara2.Range.Text = text2 + (pageBreak?"":"\n\r\n\r");
                    oPara2.Format.SpaceAfter = 11;    //24 pt spacing after paragraph.
                    oPara2.Range.InsertParagraphAfter();
                    if (pageBreak)
                    {
                        pageBreak = false;
                        oDoc.Words.Last.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak);
                    }
                    else
                    {
                        pageBreak = true;
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fld = new OpenFileDialog();
            fld.Filter = "File Excel (*.xlsx)|*.xlsx";
            fld.ShowDialog();
            fileTB.Text = fld.FileName;
        }

        private void fileTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
