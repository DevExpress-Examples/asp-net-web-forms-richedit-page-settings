using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         if (!IsPostBack)
            NewDocument();
    }

    private void NewDocument()
    {
        RichEditDocumentServer server = new RichEditDocumentServer();
        server.Document.Sections[0].Page.Landscape = false;
        server.Document.Unit = DevExpress.Office.DocumentUnit.Millimeter;
        server.Document.Sections[0].Margins.Left = 0.5f;
        server.Document.Sections[0].Margins.Right = 0.5f;
        server.Document.Sections[0].Margins.Top = 0.5f;
        server.Document.Sections[0].Margins.Bottom = 0.5f;

        server.Document.DefaultCharacterProperties.FontName = "Arial";
        server.Document.DefaultCharacterProperties.FontSize = 12f;
        server.Document.DefaultCharacterProperties.ForeColor = Color.Red;

        server.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.Custom;
        server.Document.Sections[0].Page.Width = 105f;
        server.Document.Sections[0].Page.Height = 297f;

        MemoryStream memoryStream = new MemoryStream();
        server.SaveDocument(memoryStream, DocumentFormat.Rtf);
        ASPxRichEdit1.Open("document" + Guid.NewGuid().ToString(), DocumentFormat.Rtf, () => { return memoryStream.ToArray(); });
    }
}