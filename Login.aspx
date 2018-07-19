<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">




  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


    <center> <h2> Student Login  </h2>

    <br />

         <table width="90%">
    <tr>
   <td>
    <img src="Image/login_image.jpg"
    </td>
    <td>
    
   
 




     <table>
      <tr>
           <%-- <td class="style3">
                
                Select Group
                
                </td>--%>
          <%--  <td>
               
                <asp:DropDownList ID="DDlGroup" runat="server" AutoPostBack="false" 
                    Width="126px" onselectedindexchanged="DDlGroup_SelectedIndexChanged">
                </asp:DropDownList>
               
            </td>--%>
        </tr>



        <tr>
            <td class="style3">
                User Name</td>
            <td>
                <asp:TextBox ID="Txtusername" runat="server" Width="150px" AutoComplete="Off"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                Password</td>
            <td>
                <asp:TextBox ID="Txtpassword" runat="server" TextMode="Password" AotuComplete="Off"  Width="150px">
                   </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                </td>
            <td align="left">
                <asp:Button ID="btnlogin" runat="server" Text="LogIn" 
                    onclick="btnlogin_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="lblmsg" runat="server" Text="" style="color: #FF0000"></asp:Label>
                <br />
                <br />
            </td>
        </tr>
    </table>


      </td>

    

    </tr>
    </table>


   
</center>

</asp:Content>

