Imports Microsoft.VisualBasic
Imports DevExpress.XtraRichEdit
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		 If (Not IsPostBack) Then
			NewDocument()
		 End If
	End Sub

	Private Sub NewDocument()
		Dim server As New RichEditDocumentServer()
		server.Document.Sections(0).Page.Landscape = False
		server.Document.Unit = DevExpress.Office.DocumentUnit.Millimeter
		server.Document.Sections(0).Margins.Left = 0.5f
		server.Document.Sections(0).Margins.Right = 0.5f
		server.Document.Sections(0).Margins.Top = 0.5f
		server.Document.Sections(0).Margins.Bottom = 0.5f

		server.Document.DefaultCharacterProperties.FontName = "Arial"
		server.Document.DefaultCharacterProperties.FontSize = 12f
		server.Document.DefaultCharacterProperties.ForeColor = Color.Red

		server.Document.Sections(0).Page.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
		server.Document.Sections(0).Page.Width = 105f
		server.Document.Sections(0).Page.Height = 297f

		Dim memoryStream As New MemoryStream()
		server.SaveDocument(memoryStream, DocumentFormat.Rtf)
		ASPxRichEdit1.Open("document" & Guid.NewGuid().ToString(), DocumentFormat.Rtf, Function() memoryStream.ToArray())
	End Sub
End Class
