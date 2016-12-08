<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Phase5.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Business Directory Search</title>
    
</head>

<body>
    <div>
        <h1>Business Directory Search</h1>
    </div>

    <form id="form1" runat="server">
    
    <div2></div2>

            <asp:TextBox ID="TextBox1" runat="server" >Business Name</asp:TextBox>

            <asp:TextBox ID="TextBox2" runat="server">Address</asp:TextBox>
        
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="City" DataValueField="City" >
                </asp:DropDownList> 
                
            

             <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="State" DataValueField="State" >
                </asp:DropDownList>                            
            
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click1" />
       
 
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT DISTINCT [City] FROM [LicenseDB]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT DISTINCT [State] FROM [LicenseDB]"></asp:SqlDataSource>
              
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         
        

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            
            
        </ContentTemplate>              
            </asp:UpdatePanel>
           
    </form>
</body>
</html>
