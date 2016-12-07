<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Phase5.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
    </div>
        
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <ContentTemplate>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click1" />
       
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
      
            
        
        
         
        
         <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="" ContextTypeName="Phase5.Search" TableName="ModelState">
        </asp:LinqDataSource>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
           
        
               
    </form>
</body>
</html>
