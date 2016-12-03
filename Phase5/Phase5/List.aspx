<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Phase5.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="FID" DataSourceID="EntityDataSource1" InsertItemPosition="LastItem">
            <AlternatingItemTemplate>
                <tr style="background-color: #FFFFFF;color: #284775;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="Business_NameLabel" runat="server" Text='<%# Eval("Business_Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Street_AddressLabel" runat="server" Text='<%# Eval("Street_Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ZipLabel" runat="server" Text='<%# Eval("Zip") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Business_Phone_NumberLabel" runat="server" Text='<%# Eval("Business_Phone_Number") %>' />
                    </td>
                    <td>
                        <asp:Label ID="License_StatusLabel" runat="server" Text='<%# Eval("License_Status") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FIDLabel" runat="server" Text='<%# Eval("FID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Classification_CodeLabel" runat="server" Text='<%# Eval("Classification_Code") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Classification_DescriptionLabel" runat="server" Text='<%# Eval("Classification_Description") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color: #999999;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="Business_NameTextBox" runat="server" Text='<%# Bind("Business_Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Street_AddressTextBox" runat="server" Text='<%# Bind("Street_Address") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="StateTextBox" runat="server" Text='<%# Bind("State") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ZipTextBox" runat="server" Text='<%# Bind("Zip") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Business_Phone_NumberTextBox" runat="server" Text='<%# Bind("Business_Phone_Number") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="License_StatusTextBox" runat="server" Text='<%# Bind("License_Status") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FIDLabel1" runat="server" Text='<%# Eval("FID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Classification_CodeTextBox" runat="server" Text='<%# Bind("Classification_Code") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Classification_DescriptionTextBox" runat="server" Text='<%# Bind("Classification_Description") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="Business_NameTextBox" runat="server" Text='<%# Bind("Business_Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Street_AddressTextBox" runat="server" Text='<%# Bind("Street_Address") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="StateTextBox" runat="server" Text='<%# Bind("State") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ZipTextBox" runat="server" Text='<%# Bind("Zip") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Business_Phone_NumberTextBox" runat="server" Text='<%# Bind("Business_Phone_Number") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="License_StatusTextBox" runat="server" Text='<%# Bind("License_Status") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="FIDTextBox" runat="server" Text='<%# Bind("FID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Classification_CodeTextBox" runat="server" Text='<%# Bind("Classification_Code") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="Classification_DescriptionTextBox" runat="server" Text='<%# Bind("Classification_Description") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #E0FFFF;color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="Business_NameLabel" runat="server" Text='<%# Eval("Business_Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Street_AddressLabel" runat="server" Text='<%# Eval("Street_Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ZipLabel" runat="server" Text='<%# Eval("Zip") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Business_Phone_NumberLabel" runat="server" Text='<%# Eval("Business_Phone_Number") %>' />
                    </td>
                    <td>
                        <asp:Label ID="License_StatusLabel" runat="server" Text='<%# Eval("License_Status") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FIDLabel" runat="server" Text='<%# Eval("FID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Classification_CodeLabel" runat="server" Text='<%# Eval("Classification_Code") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Classification_DescriptionLabel" runat="server" Text='<%# Eval("Classification_Description") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                    <th runat="server"></th>
                                    <th runat="server">Business_Name</th>
                                    <th runat="server">Street_Address</th>
                                    <th runat="server">City</th>
                                    <th runat="server">State</th>
                                    <th runat="server">Zip</th>
                                    <th runat="server">Business_Phone_Number</th>
                                    <th runat="server">License_Status</th>
                                    <th runat="server">FID</th>
                                    <th runat="server">Classification_Code</th>
                                    <th runat="server">Classification_Description</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF"></td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="Business_NameLabel" runat="server" Text='<%# Eval("Business_Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Street_AddressLabel" runat="server" Text='<%# Eval("Street_Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ZipLabel" runat="server" Text='<%# Eval("Zip") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Business_Phone_NumberLabel" runat="server" Text='<%# Eval("Business_Phone_Number") %>' />
                    </td>
                    <td>
                        <asp:Label ID="License_StatusLabel" runat="server" Text='<%# Eval("License_Status") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FIDLabel" runat="server" Text='<%# Eval("FID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Classification_CodeLabel" runat="server" Text='<%# Eval("Classification_Code") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Classification_DescriptionLabel" runat="server" Text='<%# Eval("Classification_Description") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="">
        </asp:LinqDataSource>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=LicenseEntities" DefaultContainerName="LicenseEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="LicenseDBs">
        </asp:EntityDataSource>
        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="50">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" />
            </Fields>
        </asp:DataPager>
    </form>
</body>
</html>
