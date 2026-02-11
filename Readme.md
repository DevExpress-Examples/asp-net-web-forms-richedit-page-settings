<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545359/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T520406)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# ASPxRichEdit - How to define default page settings such as margins, paper kind, etc.

This example demonstrates how to set a document page's landscape, paper kind, margins, and font properties.

## Implementation Details

The non-visual [RichEditDocumentServer](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditDocumentServer) component allows you to adjust document settings. Create a new document and adjust its page by using the corresponding API.

```csharp
private void NewDocument() {
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
```

## Files to Review

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))

## Documentation

* [Document Interface](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document)
* [DefaultCharacterProperties](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.DefaultCharacterProperties)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-richedit-page-settings&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-richedit-page-settings&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
