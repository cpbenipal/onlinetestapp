<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Instruction.aspx.cs" Inherits="Instruction" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
<%-- <script type = "text/javascript" >
     function disableBackButton() {
         window.history.forward();
     }
     setTimeout("disableBackButton()", 0);
</script>--%>
 
    <style type="text/css">
        .style2
        {
            width: 921px;
            height: 307px;
            margin-left: 0px;
        }
        p.MsoListParagraph
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:.5in;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
        .style3
        {
            width: 927px;
        }
        .style6
        {
            width: 462px;
        }
        .style7
        {
            width: 463px;
        }
    </style>

      

    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   <%-- <body onload="disableBackButton()">--%>
    <table style="font-size:12;" class="style3">
        <tr>
            <td colspan="2"><img class="style2" src="Image/online.png" /></td>
        </tr>
        <tr>
            <td class="style6">1. Do not Refresh and Reload page while answering. </td>
            <td class="style7"></td>
        </tr>
        <tr>
            <td class="style6">2. Save Each Question after anwer them.</td>
            <td class="style7">
                <asp:Button ID="btnstarttest" runat="server" Text="Start Test" 
                    onclick="btnstarttest_Click" />
            </td>
        </tr>
        <tr>
            <td class="style6">3. Your will be given 40 minute for 40 Question .</td>
            <td class="style7"></td>
        </tr>
    </table>
    
</asp:Content>
