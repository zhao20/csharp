<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="Phase5.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
</body>
</html>
<asp:gridview runat="server" AutoGenerateColumns="False" DataKeyNames="FID" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="Business_Name" HeaderText="Business_Name" SortExpression="Business_Name" />
        <asp:BoundField DataField="Street_Address" HeaderText="Street_Address" SortExpression="Street_Address" />
        <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
        <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
        <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
        <asp:BoundField DataField="Business_Phone_Number" HeaderText="Business_Phone_Number" SortExpression="Business_Phone_Number" />
        <asp:BoundField DataField="License_Status" HeaderText="License_Status" SortExpression="License_Status" />
        <asp:BoundField DataField="FID" HeaderText="FID" ReadOnly="True" SortExpression="FID" />
        <asp:BoundField DataField="Classification_Code" HeaderText="Classification_Code" SortExpression="Classification_Code" />
        <asp:BoundField DataField="Classification_Description" HeaderText="Classification_Description" SortExpression="Classification_Description" />
    </Columns>
    </asp:gridview>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT * FROM [LicenseDB] ORDER BY [FID]"></asp:SqlDataSource>
    <asp:EntityDataSource ID="EntityDataSource1" runat="server">
    </asp:EntityDataSource>
    </form>

