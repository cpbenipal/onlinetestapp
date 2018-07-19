<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EndTest.aspx.cs" Inherits="EndTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
<script language="JavaScript" src="Scripts/refresh.js" type="text/javascript"></script> 

    <style type="text/css">
        .style1
        {
            width: 944px;
        }
        .style2
        {
            width: 930px;
            height: 270px;
        }
        .style5
        {
        }
        .style6
        {
            font-size: x-large;
            font-family: "Times New Roman", Times, serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<body oncontextmenu="return false" onkeydown="return false" onkeypress="return false"/>
    <table class="style1">
        <tr>
            <td colspan="2">
                <img alt="" class="style2" src="Image/MainImage.jpg" /></td>
        </tr>
        <tr>
            <td class="style6" colspan="2" align="center" >
                Thanks For Your Presence! You Can Leave Now</td>
        </tr>
        <tr>
            <td class="style5" colspan="2"  align="center">
                <br />
                <br />
                <br />
                <asp:Button ID="btnendtest" runat="server" Text="Exit" 
                    onclick="btnendtest_Click" style="height: 26px" />
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>

