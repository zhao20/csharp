<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Phase5.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        a:hover {
            font-size: 24px;
            background-color: yellow;
        }
    </style>
</head>
<body>
    <center><form id="form1" runat="server">
    <div>
    
    </div>

    <p><h1><strong>Welcome to License System</strong></h1></p>
        <br /><br /><br />
        
       <a href="LoadRemove.aspx"> Load or Remove Data</a>
        <br /><br />
       <a href="List.aspx"> Show entire List</a>
        <br /><br />
        <a href="adding.aspx">Add a License</a>
         <br /><br />
        <a href="Update.aspx">Update a License</a>
        <br /><br />
        <a href="Search.aspx">Search</a>
        <br /><br />
        <a href="Statistics.aspx">Statistics</a>
    </form>
        </center>
</body>
</html>

