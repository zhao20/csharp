<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadRemove.aspx.cs" Inherits="Phase5.LoadRemove" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <center><div>
    
        Select Your CSV File:<asp:FileUpload ID="fuCSV" runat="server" />
    
    </div>
        <br />
        <br />
        <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
      </center> 
         <asp:GridView ID="gvList" runat="server"></asp:GridView>
    </form>
</body>
</html>
