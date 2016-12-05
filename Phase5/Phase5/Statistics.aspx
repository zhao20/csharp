<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="Phase5.Statistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="EntityDataSource1" DataTextField="City" DataValueField="City">
        </asp:DropDownList>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=LicenseEntities" DefaultContainerName="LicenseEntities" EnableFlattening="False" EntitySetName="LicenseDBs" Select="it.[City]">
        </asp:EntityDataSource>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
