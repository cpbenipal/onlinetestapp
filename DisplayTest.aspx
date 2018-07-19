<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DisplayTest.aspx.cs" Inherits="DisplayTest" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

   

    <style type="text/css">
        .style1
        {
            width: 944px;
        }
        .style3
        {
            width: 471px;
        }
        .style4
        {
            width: 83px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<center> <h2> SELECT Test </h2></center>

    <table class="style1">
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr align="center">
            <td colspan="2">
                   <asp:GridView ID="grddisplaytest" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" DataKeyNames="TESTID" ForeColor="#333333" GridLines="None" onrowcancelingedit="grddisplaytest_RowCancelingEdit" 
                    onrowdeleting="grddisplaytest_RowDeleting" 
                    onrowediting="grddisplaytest_RowEditing" 
                    onrowupdating="grddisplaytest_RowUpdating">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField HeaderText="S No">
                        <ItemTemplate>
                     <%#Container.DataItemIndex+1 %>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Test Name">
                            <ItemTemplate>
                                <asp:Label ID="lbltestname" runat="server" Text='<%# Eval("PURPOSEOFTEST") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txttestname" runat="server" 
                                    Text='<%# Eval("PURPOSEOFTEST") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Select Test">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnbedit" runat="server" CommandName="cancel">Select Test</asp:LinkButton>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:LinkButton ID="lnbupdate" runat="server" CommandName="update">Update</asp:LinkButton>
                                <asp:LinkButton ID="lnbcancel" runat="server" CommandName="cancel">Cancel</asp:LinkButton>
                            </EditItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" 
                        HorizontalAlign="Left" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                </td>
        </tr>
    </table>


    <br />
    

</asp:Content>

