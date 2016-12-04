<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adding.aspx.cs" Inherits="Phase5.WebForm1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!--include jQuery -->  
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"  
type="text/javascript">


</script>   
<!--include jQuery Validation Plugin-->  
<script src="http://ajax.aspnetcdn.com/ajax/jquery.validate/1.12.0/jquery.validate.min.js"  
type="text/javascript"></script> 
<head runat="server">
    <title></title>
    <style>
        p.altertive { 
            background: lightblue;
        }

    </style>
</head>
    <script type="text/javascript">
        function funcSubmit()
     {
        
        $('#<%=btnADD.ClientID%>').click();
            lblSuccess.Text = "";
        }

        function funcClean()
        {
            var elements = document.getElementsByTagName("input");
            for (var ii = 0; ii < elements.length; ii++) {
                if (elements[ii].type == "text") {
                    elements[ii].value = "";
                }
            }
            Page_ClientValidate('');
            lblSuccess.Text = "";
        }
    </script>

    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#btnADD").click(function () {
                lblSuccess.Text = "";
                Page_ClientValidate('');

            });
        });
                </script>

<body>
   <center> <form id="form1" runat="server" >
       <asp:Label ID="lblSuccess" runat="server" Text="" ForeColor ="Red"></asp:Label>
        <table border ="1" cellpadding="10" cellspacing ="0" >

            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="FID :"></asp:Label>
                </td>
                <td>
                  <left>  <asp:TextBox ID="txtFID" runat="server" MaxLength="10" Width ="100" ></asp:TextBox></left>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please Input 0-9 Numbers Only" ForeColor="Red" ControlToValidate="txtFID"
                        ValidationExpression="^[0-9]*$" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="FID is required" ForeColor ="Red" ControlToValidate ="txtFID"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Business Name :"></asp:Label>
                </td>
                <td>
                     <left><asp:TextBox ID="txtBusiness_Name" runat="server" MaxLength="100" Width="500"></asp:TextBox></left>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Business Name is required" ForeColor ="Red" ControlToValidate ="txtBusiness_Name"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr class ="altertive">
            <td><asp:Label ID="Label13" runat="server" Text="Street Address :"></asp:Label></td>
            <td>  <left><asp:TextBox ID="txtStreet_Address" runat="server" MaxLength="100" Width="500"></asp:TextBox></left>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Street Address is required" ForeColor ="Red" ControlToValidate ="txtStreet_Address"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td><asp:Label ID="Label14" runat="server" Text="City :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtCity" runat="server" MaxLength="10" Width="100"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="City is required" ForeColor ="Red" ControlToValidate ="txtCity"></asp:RequiredFieldValidator>
              </td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label15" runat="server" Text="State :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtState" runat="server" MaxLength="10" Width="100"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="State is required" ForeColor ="Red" ControlToValidate ="txtState"></asp:RequiredFieldValidator>
              </td>
        </tr>
          <tr>
            <td><asp:Label ID="Label16" runat="server" Text="Zip :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtZip" runat="server" MaxLength="10" Width ="100"></asp:TextBox></left>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please Input Proper ZipCode" ForeColor="Red" ControlToValidate="txtZip"
                        ValidationExpression="^([0-9]{5})([\-]{1}[0-9]{4})?$" Display="Dynamic"></asp:RegularExpressionValidator>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Zip is required" ForeColor ="Red" ControlToValidate ="txtZip"></asp:RequiredFieldValidator>
              </td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label17" runat="server" Text="Business Phone Number :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtBusiness_Phone_Number" runat="server" MaxLength="15" Width="150"></asp:TextBox></left>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please Input a Proper Phone Number" ForeColor="Red" ControlToValidate="txtBusiness_Phone_Number"
                        ValidationExpression="^\(?[\d]{3}\)?[\s-]?[\d]{3}[\s-]?[\d]{4}$" Display="Dynamic"></asp:RegularExpressionValidator>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="FID is required" ForeColor ="Red" ControlToValidate ="txtBusiness_Phone_Number"></asp:RequiredFieldValidator>
              </td>
        </tr>
          <tr>
            <td><asp:Label ID="Label18" runat="server" Text="License Status :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtLicense_Status" runat="server" MaxLength="10" Width="100"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Business Phone Number is required" ForeColor ="Red" ControlToValidate ="txtLicense_Status"></asp:RequiredFieldValidator>
              </td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label19" runat="server" Text="Classfication Code :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtClassficationCode" runat="server" MaxLength="10" Width="100"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Classfication Code is required" ForeColor ="Red" ControlToValidate ="txtClassficationCode"></asp:RequiredFieldValidator>
              </td>
        </tr>
          <tr>
            <td><asp:Label ID="Label20" runat="server" Text="Classification Description :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtClassficationDes" runat="server" MaxLength="100" Width="500"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Classification Description is required" ForeColor ="Red" ControlToValidate ="txtClassficationDes"></asp:RequiredFieldValidator>
              </td>
        </tr>

        </table>
           <p>
        <asp:Button ID="btnBack" runat="server" Text="Main Menu" Width="126px" OnClick="btnBack_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
               <button id="btnSubmit" onclick="funcSubmit()">Submit</button> 
        <asp:Button ID="btnADD" runat="server" Text="Submit" Width="126px" OnClick="btnADD_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
               
               <button id="btnClean" onclick="funcClean()">Reset</button>
     
         </p>
    </form>
       </center>

</body>
</html>
