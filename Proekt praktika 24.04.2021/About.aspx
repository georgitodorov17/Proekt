<%@ Page Title="WholeRandomiser" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Proekt_praktika_24._04._2021.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="jumbotron MainDiv" >
       <asp:Label style="font-size: 20px; color:black;" id="iterationsLabel" name="iterationsLabel" Text="Iterations" runat="server" /><br />
       <asp:TextBox  style=" border-style: solid; border-color:black;" id="textIterations" name="iterations" runat="server" /><br/><br/>
       <asp:Label style="font-size: 20px; color:black;" id="MinLable" name="decimalsLabel" Text="Minimal Value" runat="server" /><br />
       <asp:TextBox style=" border-style: solid; border-color:black;" id="Min" name="decimals" runat="server" /> <br /><br />
       <asp:Label style="font-size: 20px; color:black;" id="MaxLable" name="decimalsLabel" Text="Maximum Value" runat="server" /><br />
       <asp:TextBox style="border-color:black;  margin-top:10px;  border-style: solid;" id="Max" name="decimals" runat="server" /> <br /><br />
        <div><%= result %></div>
       <asp:Button BorderStyle="None" CssClass="btn btn-default btn-lg" style="background-color: #ff001e; color:white; " ID="GenerateButton" Text="Generate Numbers" OnClick="GenerateButton_Click" runat="server" />
    </div>
</asp:Content>
