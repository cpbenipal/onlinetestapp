<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" MaintainScrollPositionOnPostback="true" CodeFile="TakeTest.aspx.cs" Inherits="TakeTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">


<script language="JavaScript" src="Scripts/refresh.js" type="text/javascript"></script> 


 <script type="text/javascript">
        var mins
        var secs;
        var duration = "<%=gettestduration()%>";
        function cd() {
            mins = 1 * m(duration);
            secs = 0 + s(":01");
            redo();
        }
        function m(obj) {
            for (var i = 0; i < obj.length; i++) {
                if (obj.substring(i, i + 1) == ":")
                    break; 5
            }
            return (obj.substring(0, i));
        }

        function s(obj) {
            for (var i = 0; i < obj.length; i++) {
                if (obj.substring(i, i + 1) == ":")
                    break;
            }
            return (obj.substring(i + 1, obj.length));
        }

        function dis(mins, secs) {
            var disp;
            if (mins <= 9) {
                disp = " 0";
            } else {
                disp = " ";
            }
            disp += mins + ":";
            if (secs <= 9) {
                disp += "0" + secs;
            } else {
                disp += secs;
            }
            return (disp);
        }

        function redo() {
            secs--;
            if (secs == -1) {
                secs = 59;
                mins--;
            }
            document.getElementById("disp").value = dis(mins, secs);
            if ((mins == 0) && (secs == 0)) {
                window.alert("Time is up. Press OK to continue.");
              
                window.location = '<%= ResolveUrl("~/EndTest.aspx") %>';

            }
            else {
                document.getElementById("form1").value = setTimeout("redo()", 1000);
            }
            
        }

        function init() {
            cd();
        }
        window.onload = init;







//        function ValidateModuleList(source, args) {
//            var chkListModules = document.getElementById('<%= chkquestionoption.ClientID %>');
//            var chkListinputs = chkListModules.getElementsByTagName("input");
//            for (var i = 0; i < chkListinputs.length; i++) {
//                if (chkListinputs[i].checked) {
//                    args.IsValid = true;
//                    return;
//                }
//            }
//            args.IsValid = false;
//        }    
  </script>

  <%-- <script type = "text/javascript" >
       function disableBackButton() {
           window.history.forward();
       }
       setTimeout("disableBackButton()", 0);
</script>--%>
  


 <%-- <script language="JavaScript">

      var version = navigator.appVersion;

      function showKeyCode(e) {
          var keycode = (window.event) ? event.keyCode : e.keyCode;

          if ((version.indexOf('MSIE') != -1)) {
              if (keycode == 116) {
                  event.keyCode = 0;
                  event.returnValue = false;
                  return false;
              }
          }
          else {
              if (keycode == 116) {
                  return false;
              }
          }
      }

    </script>--%>   
  <style>  
      .txt 
      {  
        border:none;  
        font-family:verdana;  
        font-size:16pt;  
        font-weight:bold;  
        border-right-color:#FFFFFF  
        }  
        .style2
        {
            height: 1px;
            width: 101px;
        }
        .style3
        {
            height: 12px;
            width: 101px;
        }
      .style4
      {
          height: 31px;
      }
      .style6
      {
          height: 31px;
          width: 100px;
      }
      .style10
      {
          height: 11px;
          width: 100px;
      }
      .style11
      {
          height: 11px;
      }
      .style12
      {
          width: 100%;
      }
      .style13
      {
      }
      .style15
      {
          height: 1px;
          width: 129px;
      }
      .style16
      {
          height: 12px;
          width: 129px;
      }
      .style17
      {
          height: 1px;
          width: 100px;
      }
      .style18
      {
          height: 12px;
          width: 100px;
      }
      .style23
      {
          height: 1px;
          width: 78px;
      }
      .style24
      {
          height: 12px;
          width: 78px;
      }
      .style26
      {
          width: 100px;
          height: 288px;
      }
      .style27
      {
          height: 1px;
          width: 140px;
      }
      .style28
      {
          height: 12px;
          width: 162px;
      }
      .style29
      {
          height: 42px;
      }
      .style30
      {
          font-size: medium;
      }
      </style>    


   
 


    </asp:Content>
 
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<body oncontextmenu="return false" onkeydown="return false" onkeypress="return false"/>

<script language="JavaScript" type="text/javascript" >
    function OpenNewWP() {
        newWin = window.open('TakeTest.aspx', 'Test', 'toolbar=no,status=no,menubar=no,location=center,scrollbars=no,resizable=no,height=500,width=350',true);
        newWin.opener = top;
    }
</script> 


     <panel id="form1" name="cd">
<div> 
    <table class="style12">
    <tr>
            <td style="width: 100px">
                <asp:Image ID="Image1" runat="server" Height="225px" 
                    ImageUrl="~/Image/TakeTest.jpg" Width="915px" />
            </td>
        </tr>
        <tr>
            <td class="style13" align="right">
&nbsp; 
<asp:ScriptManager ID="ScriptManager2" runat="server">
    </asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
               
                    <ContentTemplate>
                        <asp:Label ID="lbltimr" runat="server" 
                            style="font-weight: 700; font-size: large" Text="Remaining Time"></asp:Label>
<input id = "disp"  type="text" value=""  name="disp" 
                    
                    
    style="border-style: none; border-color: inherit; border-width: medium; cursor:wait; width: 88px; font-weight: 700; font-size: large;" />
                    </ContentTemplate>
                </asp:UpdatePanel>
</td>
        </tr>
    </table>
&nbsp;<br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <Triggers>
     <asp:AsyncPostBackTrigger ControlID="btnnext" EventName="Click" />
   </Triggers>

        <ContentTemplate>
        

            <table>
            
                <tr>
                    <td class="style26">
                        <table ID="table" onclick="return TABLE1_onclick()" style="width: 931px">
                            <tr>
                                <td colspan="8" style="color: white; background-color: #3366ff" class="style29">
                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Test Name :" 
                                        Width="105px" style="font-size: large"></asp:Label>
                                    <asp:Label ID="lbltestname" runat="server" Font-Bold="True" Text="Test Name :" 
                                        Width="280px" style="font-size: large"></asp:Label>
                                    <asp:Label ID="lblTestName1" runat="server" Height="16px" 
                                        style="margin-right: 0px; margin-left: 63px;" Width="92px"></asp:Label>
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Question :" 
                                        style="font-size: medium"></asp:Label>
                                    <asp:Label ID="Question" runat="server" style="font-size: medium"></asp:Label>
                                    <span class="style30">Of</span>
                                    <asp:Label ID="lbltotalquestion" runat="server" style="font-size: medium"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style17">
                                    &nbsp;</td>
                                <td style="width: 100px; height: 1px;">
                                    <asp:Label ID="lblquestionid" runat="server" Text="Label" Visible="False"></asp:Label>
                                </td>
                                <td style="width: 100px; height: 1px;">
                                </td>
                                <td class="style23">
                                </td>
                                <td class="style27">
                                </td>
                                <td class="style15">
                                </td>
                                <td class="style2">
                                    <td style="width: 100px; height: 1px;">
                
           
  

       
           <%-- <div class="timerCss"> <asp:Label ID="lblTimerCount" runat="server" Height="5px" Width="232px"></asp:Label>&nbsp; </div>--%>
                                    </td>
                                </td>
                            </tr>
                            <tr>
                                <td class="style17">
                                    &nbsp;</td>
                                <td style="width: 100px; height: 1px;">
                                    &nbsp;</td>
                                <td style="width: 100px; height: 1px;">
                                    &nbsp;</td>
                                <td class="style23">
                                    &nbsp;</td>
                                <td class="style27">
                                    &nbsp;</td>
                                <td class="style15">
                                    &nbsp;</td>
                                <td class="style2">
                                    &nbsp;<td style="width: 100px; height: 1px;">
                                        &nbsp;</td>
                                </td>
                            </tr>
                            <tr>
                                <td class="style6">
                                    <asp:Label ID="Label5" runat="server" Height="60px"></asp:Label>
                                </td>
                                <td class="style4" colspan="7">
                                    &nbsp;<asp:Label ID="lblquestion" runat="server" Height="60px" Width="721px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style10">
                                    &nbsp;</td>
                                <td colspan="7" class="style11">
                                    <asp:RadioButtonList ID="rdoquestionoption" runat="server" Visible="False">
                                    </asp:RadioButtonList>
                                    <asp:CheckBoxList ID="chkquestionoption" runat="server" Visible="False">
                                    </asp:CheckBoxList>
                                    <asp:RequiredFieldValidator ID="rfvchooseans" runat="server" 
                                        ControlToValidate="rdoquestionoption" ErrorMessage="Choose Answer !!" 
                                        style="color: #FF0000" ValidationGroup="Ans"></asp:RequiredFieldValidator>
                                    <br />
                                    <asp:CustomValidator runat="server" ID="cvmodulelist"
                                     ClientValidationFunction="ValidateModuleList" ValidationGroup="a"
                                     ErrorMessage="Choose Answer !!" style="color: #FF0000" ></asp:CustomValidator>

                                    <br />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="style18">
                                    &nbsp;</td>
                                <td style="width: 100px; height: 12px;">
                                    &nbsp;</td>
                                <td style="width: 100px; height: 12px;">
                                </td>
                                <td class="style24">
                                </td>
                                <td class="style28">
                                    <asp:Button ID="btnskip" runat="server" OnClick="btnskip_Click" Text="Skip" />
                                    &nbsp;
                                    <asp:Button ID="btnnext" runat="server" OnClick="btnnext_Click" Text="Next" 
                                        ValidationGroup="Ans" Visible="False" />
                                    &nbsp;<asp:Button ID="btnnext1" runat="server" onclick="btnnext1_Click" 
                                        style="margin-left: 21px" Text="Next" ValidationGroup="a" Visible="False" />
                                </td>
                                <td class="style16">
                                    &nbsp;</td>
                                <td class="style3">
                                    &nbsp;</td>
                                <td style="width: 100px; height: 12px;">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
           
        </ContentTemplate>
      
    </asp:UpdatePanel>
    </div>
 </panel>
   
      <table>
        <tr>
            <td style="width: 100px">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
               
                </td>
        </tr>
    </table>


  
     </asp:Content>

