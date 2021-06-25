<%@ Page Title="RealRandomiser" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proekt_praktika_24._04._2021._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
  
    
    <div class="jumbotron MainDiv">
       <asp:Label style="font-size: 20px; color:black;" id="iterationsLabel" name="iterationsLabel" Text="Iterations" runat="server" /><br />
       <asp:TextBox style="  border-style: solid; border-color:black;" ID="textIterations" name="iterations" runat="server" /><br/><br/>
       <asp:Label style="font-size: 20px; color:black;" id="decimalsLabel" name="decimalsLabel" Text="Decimals" runat="server" /><br />
       <asp:TextBox style=" border-style: solid; border-color:black;" id="textDecimals" name="decimals" runat="server" /> <br /><br />
       <asp:Label style="font-size: 20px; color:black;" id="ErrorLabel" name="ErrorLabel"  runat="server" /><br />

        <asp:Button CssClass="btn btn-default btn-lg" style="background-color:#ff001e;color:white; "  ID="GenerateButton" Text="Generate Numbers" OnClick="GenerateButton_Click" runat="server" /> 
       

        <table class="random-table" >
            <asp:Repeater runat="server" ID="repeater">
                <HeaderTemplate>
                    <tr>
                        <td class="cell-number top" style="width:30%">Число</td>
                        <td class="cell-number top" style="width:30%">Повторения</td>
                        <td class="cell-number top" style="width:10%">Проценти</td>
                    </tr>

                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td class="cell-number"><%#Eval("Number")%></td>
                        <td class="cell-times"><%#Eval("Times")+(" times") %></td>
                        <td class="cell-percent"><%#Eval("Percent")+("%") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </table>
    </div>

   

</asp:Content>
