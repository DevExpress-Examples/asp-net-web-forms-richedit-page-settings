<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v16.1, Version=16.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	 <dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" >
	  <Settings>
	   <Behavior CreateNew="Hidden" Save="Hidden" Open="Hidden" SaveAs="Hidden" />
	  </Settings>
	 </dx:ASPxRichEdit>
	</form>
</body>
</html>