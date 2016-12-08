<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="Phase5.Statistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Statistic Page</title>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
      $(function () {
          $("#tabs").tabs({
              panelTemplate: "<iframe style='width:100%'></iframe>",
              idPrefix: "ui-tabs-",
              select: function (event, ui) {
                  if (!$("#ui-tabs-" + ui.index).prop("src")) {
                      $("#ui-tabs-" + ui.index).attr("src", $.data(ui.tab, 'load.tabs'));
                  }
              }
          });
      });


  </script>
</head>
<body>
 <form id ="form1" runat="server">

     <div id="tabs">
    <ul style="padding: 0; margin: 0;">
        <li class="context-tab"><a id="recent-tab" href="#ui-tabs-0">First Three</a></li>
        <li class="context-tab"><a id="popular-tab" href="SearchByZip.aspx">Search By Zip</a></li>
        <li class="context-tab"><a id="random-tab" href="SearchByZipAndCatagory.aspx">Search By Zip And Category</a></li>
       
    </ul>

    <div id="ui-tabs-0"> 
       <p> <asp:DropDownList ID="ddlCity" runat="server" DataSourceID="EntityDataSource1" DataTextField="City" DataValueField="City">
        </asp:DropDownList>&nbsp; &nbsp;&nbsp;&nbsp;<right> <asp:Button ID="btnTopThree" runat="server" Text="Search" OnClick="btnTopThree_Click" /></right>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=LicenseEntities" 
            DefaultContainerName="LicenseEntities" EnableFlattening="False" EntitySetName="LicenseDBs" Select="DISTINCT it.[City]" OrderBy="it.[City]"   >
        </asp:EntityDataSource>
      </p>
       <asp:GridView ID="GridView1" runat="server">
       </asp:GridView>

    </div>

</div>
<div id="tabs">



  <div id="ui-tabs-0">
     
    

      </div>
  <div id="tabs-2">



                

  </div>
  <div id="tabs-3">
     
       </div>
      <div id="tabs-4">
    
            </div>
      <div id="tabs-5">

      </div>

</div>    
     <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
 </form>
</body>


</html>
