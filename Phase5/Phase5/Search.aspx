<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Phase5.Search" %>


<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function BackToMain() {

            window.location.href = 'Menu.aspx';
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="FID: "></asp:Label>
                        <asp:TextBox ID="txtFID" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Business Name: "></asp:Label><asp:TextBox ID="txtBusinessName" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Street Addres: "></asp:Label><asp:TextBox ID="txtAddress" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="City: "></asp:Label>
                        <asp:DropDownList ID="ddlCity" runat="server" DataSourceID="SqlDataSource2" DataTextField="City" DataValueField="City" AppendDataBoundItems="true">
                            <asp:ListItem Text="-Select-" Value="" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="States: "></asp:Label>
                        <asp:DropDownList ID="ddlStates" runat="server" DataSourceID="SqlDataSource3" DataTextField="State" AppendDataBoundItems="true" DataValueField="State">
                            <asp:ListItem Text="-Select-" Value="" />
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Zip: "></asp:Label>
                        <asp:DropDownList ID="ddlZip" runat="server" DataSourceID="SqlDataSource4" AppendDataBoundItems="true" DataTextField="Zip" DataValueField="Zip">
                            <asp:ListItem Text="-Select-" Value="" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Business Phone Number"></asp:Label>
                        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="License Status: "></asp:Label>
                        <asp:DropDownList ID="ddlStatus" runat="server" DataSourceID="EntityDataSource1" AppendDataBoundItems="true" DataTextField="License_Status" DataValueField="License_Status">
                            <asp:ListItem Text="-Select-" Value="" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Classfication Code: "></asp:Label>

                        <asp:TextBox ID="txtClassificationCode" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label10" runat="server" Text="Calssification Description"></asp:Label>
                        <asp:TextBox ID="txtClassficationDes" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>

            <br />

            <center><asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
             <input type="button" name="btnMainMenu" runat="server" value="Back MainMenu" onclick="BackToMain()" />
        </center>


        </div>

        <div>
            <asp:GridView ID="gvSearch" runat="server"></asp:GridView>

            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT DISTINCT [Zip] FROM [LicenseDB]"></asp:SqlDataSource>

            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=LicenseEntities" DefaultContainerName="LicenseEntities" EnableFlattening="False" EntitySetName="LicenseDBs" Select="DISTINCT it.[License_Status]">
            </asp:EntityDataSource>

        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT DISTINCT [City] FROM [LicenseDB]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT DISTINCT [Zip] FROM [LicenseDB]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:zhao20_1583911ConnectionString %>" SelectCommand="SELECT DISTINCT [State] FROM [LicenseDB]"></asp:SqlDataSource>
    </form>
</body>
</html>




