using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;


namespace DBConnect
{
    class DocumentPrinter
    {
        private Font printFont = new Font("Consolas", 12.0f);
        private Font printFontBold = new Font("Consolas", 16.0f, FontStyle.Bold);

        private PrintDocument document;
        private int pageNumber = 1;
        private string bodyText;
        private string title;

        public DocumentPrinter(string bodyText, string title)
        {
            this.bodyText = bodyText;
            this.title = title;

            document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        public void Print()
        {
            document.Print();
        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            string headerText = GetHeaderText(this.pageNumber);

            ////////////////////////////////////////////////////////////
            /// H e a d e r
            ////////////////////////////////////////////////////////////

            // Draw the header text within the bounds of the page, using bold font
            e.Graphics.DrawString(headerText, this.printFontBold, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            // Measure header text to work out position of body text
            SizeF size = e.Graphics.MeasureString(headerText,
                                                  printFontBold,
                                                  e.MarginBounds.Size,
                                                  StringFormat.GenericTypographic,
                                                  out charactersOnPage,
                                                  out linesPerPage);

            // Calculate the bounds of a rectangle that describes the region of the 
            // page that remains available for printing
            int bodyTextY = e.MarginBounds.Y + (int)(size.Height + 40);
            int bodyTextHeight = e.MarginBounds.Height - (int)(size.Height + 40);

            Rectangle bodyTextBounds = new Rectangle(e.MarginBounds.X, bodyTextY, e.MarginBounds.Width, bodyTextHeight);

            ////////////////////////////////////////////////////////////
            /// B o d y
            ////////////////////////////////////////////////////////////

            // Draw the body text within the bounds of the page
            e.Graphics.DrawString(this.bodyText, this.printFont, Brushes.Black, bodyTextBounds, StringFormat.GenericTypographic);

            // Sets the value of charactersOnPage to the number of characters
            // of the text that will fit within the bounds of one page. 
            e.Graphics.MeasureString(this.bodyText,
                                     printFontBold,
                                     bodyTextBounds.Size,
                                     StringFormat.GenericTypographic,
                                     out charactersOnPage,
                                     out linesPerPage);

            // Remove the portion of the string that has been printed.
            this.bodyText = this.bodyText.Substring(charactersOnPage);

            ////////////////////////////////////////////////////////////
            /// N e x t   P a g e
            ////////////////////////////////////////////////////////////

            // Check to see if more pages are to be printed.
            if (this.bodyText.Length > 0)
            {
                this.pageNumber++;
                e.HasMorePages = true;
            }
            else
            {
                this.pageNumber = 1;
                e.HasMorePages = false;
            }
        }

        private string GetHeaderText(int page)
        {
            string header = $"              {this.title}                 Page {page:d}\n";
            DateTime now = DateTime.Now;
            header += $"Date: {now.Day:d2}/{now.Month:d2}/{now.Year:d4}".PadLeft(30);

            // Date: {now.Day:d2}/{now.Month:d2}/{now.Year:d4}
            // Date: 29/04/2021

            return header;
        }
    }
}