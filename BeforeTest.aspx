<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BeforeTest.aspx.cs" Inherits="BeforeTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
  <%-- <script type = "text/javascript" >
       function disableBackButton() {
           window.history.forward();
       }
       setTimeout("disableBackButton()", 0);
</script>--%>

<%--<script type="text/javascript">
    function noBack() {
        window.history.forward()
    }
    noBack();
    window.onload = noBack;
    window.onpageshow = function (evt) { if (evt.persisted) noBack() }
    window.onunload = function () { void (0) }
    </script>--%>
 
 <script language="javascript" type="text/javascript">

     noBack2();

     function noBack2() { window.history.forward(); }
     window.onload = noBack2;
     window.onpageshow = function (evt) { if (evt.persisted) noBack2(); }
     window.onunload = function () { void (0); }

</script>

   
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-family: "Times New Roman", Times, serif;
        }
        .style3
        {
            font-size: x-large;
        }
        .style4
        {
            color: #FF9933;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
   <%--<body onload="disableBackButton()">--%>
 <body><table class="style1">
        <tr>
            <td>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" align="center" class="style2">
                <span class="style3"><span class="style4">Do You Really Want To Start The Test?</span><br />
                <br />
                <br />
                <br />
                </span>
                <asp:Button ID="btnyes" runat="server" Text="Yes" onclick="btnyes_Click" />
&nbsp;&nbsp;
                <asp:Button ID="btnno" runat="server" Text="No" onclick="btnno_Click" 
                    Width="37px" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

