<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adding.aspx.cs" Inherits="Phase5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        p.altertive { 
            background: lightblue;
        }

    </style>
</head>


<body>
   <center> <form id="form1" runat="server" >
        <table border ="1" cellpadding="10" cellspacing ="0" >

            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="FID :"></asp:Label>
                </td>
                <td>
                  <left>  <asp:TextBox ID="txtFID" runat="server" MaxLength="10" Width ="100" ></asp:TextBox></left>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Business Name :"></asp:Label>
                </td>
                <td>
                     <left><asp:TextBox ID="txtBusiness_Name" runat="server" MaxLength="100" Width="500"></asp:TextBox></left>
                </td>
            </tr>
             <tr class ="altertive">
            <td><asp:Label ID="Label13" runat="server" Text="Street Address :"></asp:Label></td>
            <td>  <left><asp:TextBox ID="txtStreet_Address" runat="server" MaxLength="100" Width="500"></asp:TextBox></left></td>
        </tr>
          <tr>
            <td><asp:Label ID="Label14" runat="server" Text="City :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtCity" runat="server" MaxLength="10" Width="100"></asp:TextBox></left></td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label15" runat="server" Text="State :"></asp:Label></td>
              <td><left><asp:TextBox ID="TxtState" runat="server" MaxLength="10" Width="100"></asp:TextBox></left></td>
        </tr>
          <tr>
            <td><asp:Label ID="Label16" runat="server" Text="Zip :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtZip" runat="server" MaxLength="10" Width ="100"></asp:TextBox></left></td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label17" runat="server" Text="Business Phone Number :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtBusiness_Phone_Number" runat="server" MaxLength="15" Width="150"></asp:TextBox></left></td>
        </tr>
          <tr>
            <td><asp:Label ID="Label18" runat="server" Text="License Status :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtLicense_Status" runat="server" MaxLength="10" Width="100"></asp:TextBox></left></td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label19" runat="server" Text="Classfication Code :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtClassficationCode" runat="server" MaxLength="10" Width="100"></asp:TextBox></left></td>
        </tr>
          <tr>
            <td><asp:Label ID="Label20" runat="server" Text="Classification Description :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtClassficationDes" runat="server" MaxLength="100" Width="500"></asp:TextBox></left></td>
        </tr>

        </table>
           <p>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:Button ID="btnBack" runat="server" Text="Main Menu" Width="126px" OnClick="btnBack_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="126px" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="Reset" Width="126px" />
         </p>
    </form>
       </center>

</body>
</html>
