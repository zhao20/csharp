<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchByZipAndCatagory.aspx.cs" Inherits="Phase5.SearchByZipAndCatagory" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <script type="text/javascript">
  

        function BackToMain() {

            window.location.href = 'Menu.aspx';
        }
</script>
</head>
<body>
    <form id="form1" runat="server">
   <center> <div>
           <asp:DropDownList ID="ddlZip" runat="server" DataSourceID="SqlDataSource1" 
                   DataTextField="Zip" DataValueField="Zip"> </asp:DropDownList>&nbsp;&nbsp; <asp:DropDownList ID="ddlCategory" runat="server" DataSourceID="SqlDataSource2" DataTextField="Classification_Code" DataValueField="Classification_Code"></asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSearchByZipAndCategory" runat="server" Text="Search" OnClick="btnSearchByZipAndCategory_Click" />&nbsp;&nbsp;&nbsp;&nbsp; 
       <input type="button" name="btnMainMenu" runat="server" value="Back MainMenu" onclick="BackToMain()" />    
                <asp:GridView ID="gvSearchByZip" runat="server"></asp:GridView>
                <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" 
                      SelectCommand="SELECT DISTINCT [Zip] FROM [LicenseDB]"></asp:SqlDataSource>
           <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT DISTINCT [Classification_Code] FROM [LicenseDB]"></asp:SqlDataSource>
    </div></center>
    </form>
</body>
</html>
