<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadRemove.aspx.cs" Inherits="Phase5.LoadRemove" %>

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
        <table border ="0" style="width:60%">
            <thead>
                <tr> 
                    <td>
                        <center><div>
    
                                Select Your CSV File:<asp:FileUpload ID="fuCSV" runat="server" accept=".csv"/>
    
                    </div>
                        <br />
                        <br />
                        <div>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                            </div>
                     </center> 
                    </td>
                    <td>
                       <center><asp:Button ID="btnRemove" runat="server" Text="Remove All Data" OnClick="btnRemove_Click" />
                          
                        </center> 
                    </td>
                    <td>
                        <input type="button" name="btnMainMenu" runat="server" value="Back MainMenu" onclick="BackToMain()" />
                    </td>

                </tr>
            </thead>
                    
    

        </table>

        &nbsp;&nbsp
       <center><asp:Label ID="lblMessage" runat="server" Text="Label" ForeColor="Red"></asp:Label>
           </center> 
       <center><asp:Button ID="btnList" runat="server" Text="Show List" Visible="False"/></center> 

    </form>
</body>
</html>
