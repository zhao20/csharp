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
<asp:gridview runat="server" AllowCustomPaging="True" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="FID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
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
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:gridview>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT * FROM [LicenseDB] ORDER BY [FID]"></asp:SqlDataSource>
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=LicenseEntities" DefaultContainerName="LicenseEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="LicenseDBs" EntityTypeFilter="LicenseDB">
    </asp:EntityDataSource>
    <p>
        &nbsp;</p>
    </form>

