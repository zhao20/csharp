<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Phase5.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css">
<script src="http://code.jquery.com/jquery-1.9.1.js"></script>
<script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <!--include jQuery Validation Plugin-->  
<script src="http://ajax.aspnetcdn.com/ajax/jquery.validate/1.12.0/jquery.validate.min.js"  
type="text/javascript"></script> 
<script language="javascript" type="text/javascript">
    $(function () {
        $('#<%=txtFID.ClientID%>').autocomplete({
    source: function (request, response) {
        $.ajax({
            url: "Update.aspx/GetFID",
            data: "{ 'pre':'" + request.term + "'}",
            dataType: "json",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                response($.map(data.d, function (item) {
                    return { value: item }
                }))
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(textStatus);
            }
        });
    }
});
    });

    
        function BackToMain() {

            window.location.href = 'MainMenu.aspx';
        }

        //function funcClean()
        //{
        //    var elements = document.getElementsByTagName("input");
        //    for (var ii = 0; ii < elements.length; ii++) {
        //        if (elements[ii].type == "text") {
        //            elements[ii].value = "";
        //        }
        //    }
        //    document.forms[0].reset();

        //    for (i = 0; i < Page_Validators.length; i++) {
        //        Page_Validators[i].style.visibility = 'hidden';
        //    }

  

        //  //  lblMessage.Text = "";
        //}
    </script>

    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#btnADD").click(function () {
                lblMessage.Text = "";
                Page_ClientValidate('');

            });
        });
</script>

  
    <style>
        p.altertive { 
            background: lightblue;
        }

    </style>
</head>
<body>
    <center>
    <form id="form1" runat="server">

        <table>
    <tr>
        <td>FID : </td>
        <td>
            <div class="ui-widget" style="text-align:left">
                
                    <asp:TextBox ID="txtFID" runat="server" Width="350px" CssClass="textboxAuto"  Font-Size="12px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;<asp:Button ID="btnModify" runat="server" Text="Modify" OnClick="btnModify_Click" />
            </div>
        </td>
    </tr>        
</table>
   &nbsp;&nbsp;
        <Table border ="1" cellpadding="10" cellspacing ="0" >

            
            <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="Business Name :"></asp:Label>
                </td>
                <td>
                     <left><asp:TextBox ID="txtBusiness_Name" runat="server" MaxLength="100" Width="500"></asp:TextBox></left>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Business Name is required" ForeColor ="Red" 
                        ControlToValidate ="txtBusiness_Name" Display="Dynamic" ValidationGroup="First"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr class ="altertive">
            <td><asp:Label ID="Label13" runat="server" Text="Street Address :"></asp:Label></td>
            <td>  <left><asp:TextBox ID="txtStreet_Address" runat="server" MaxLength="100" Width="500"></asp:TextBox></left>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Street Address is required" ForeColor ="Red" 
                    ControlToValidate ="txtStreet_Address" Display="Dynamic" ValidationGroup="First"></asp:RequiredFieldValidator>
            </td>
        </tr>
          <tr>
            <td><asp:Label ID="Label14" runat="server" Text="City :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtCity" runat="server" MaxLength="10" Width="100"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="City is required" ForeColor ="Red" 
                      ControlToValidate ="txtCity" Display="Dynamic" ValidationGroup="First"></asp:RequiredFieldValidator>
              </td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label15" runat="server" Text="State :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtState" runat="server" MaxLength="10" Width="100"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="State is required" ForeColor ="Red" 
                      ControlToValidate ="txtState" Display="Dynamic" ValidationGroup="First"></asp:RequiredFieldValidator>
              </td>
        </tr>
          <tr>
            <td><asp:Label ID="Label16" runat="server" Text="Zip :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtZip" runat="server" MaxLength="10" Width ="100"></asp:TextBox></left>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please Input Proper ZipCode" ForeColor="Red" ControlToValidate="txtZip"
                        ValidationExpression="^([0-9]{5})([\-]{1}[0-9]{4})?$" Display="Dynamic" ValidationGroup="First"></asp:RegularExpressionValidator>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Zip is required" ForeColor ="Red" 
                      ControlToValidate ="txtZip" Display="Dynamic" ValidationGroup="First"></asp:RequiredFieldValidator>
              </td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label17" runat="server" Text="Business Phone Number :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtBusiness_Phone_Number" runat="server" MaxLength="15" Width="150"></asp:TextBox></left>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please Input a Proper Phone Number" ForeColor="Red" 
                      ControlToValidate="txtBusiness_Phone_Number" ValidationGroup="First" ValidationExpression="^\(?[\d]{3}\)?[\s-]?[\d]{3}[\s-]?[\d]{4}$" Display="Dynamic"></asp:RegularExpressionValidator>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Business phone number is required" ForeColor ="Red" 
                      ControlToValidate ="txtBusiness_Phone_Number" ValidationGroup="First" Display="Dynamic"></asp:RequiredFieldValidator>
              </td>
        </tr>
          <tr>
            <td><asp:Label ID="Label18" runat="server" Text="License Status :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtLicense_Status" runat="server" MaxLength="10" Width="100"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Business Phone Number is required" ForeColor ="Red" 
                      ControlToValidate ="txtLicense_Status" Display="Dynamic" ValidationGroup="First"></asp:RequiredFieldValidator>
              </td>
        </tr>
           <tr class ="altertive">
            <td><asp:Label ID="Label19" runat="server" Text="Classfication Code :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtClassficationCode" runat="server" MaxLength="10" Width="100"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Classfication Code is required" ForeColor ="Red"
                       ControlToValidate ="txtClassficationCode" Display="Dynamic" ValidationGroup="First"></asp:RequiredFieldValidator>
              </td>
        </tr>
          <tr>
            <td><asp:Label ID="Label20" runat="server" Text="Classification Description :"></asp:Label></td>
              <td><left><asp:TextBox ID="txtClassficationDes" runat="server" MaxLength="100" Width="500"></asp:TextBox></left>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Classification Description is required" ForeColor ="Red" 
                      ControlToValidate ="txtClassficationDes" Display="Dynamic" ValidationGroup="First"></asp:RequiredFieldValidator>
              </td>
        </tr>

        </Table>

         <p>
              <input type="button" name="btnMainMenu" runat="server" value="Back MainMenu" onclick="BackToMain()" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="126px" OnClick="btnSubmit_Click"  validationGroup="First"/>&nbsp;&nbsp;&nbsp;&nbsp;
               
              
             </p>
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
    </form>

         </center>
</body>
</html>
