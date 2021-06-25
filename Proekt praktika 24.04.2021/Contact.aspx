<%@ Page Title="BooleanRandomiser" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Proekt_praktika_24._04._2021.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron MainDiv">
      <asp:Label style="font-size: 20px; color:black;" id="iterationsLabel" name="iterationsLabel" Text="Iterations" runat="server" /><br />
       <asp:TextBox style="  margin-top:10px; border-style: solid; border-color:black;" id="textIterations" name="iterations" runat="server" /><br/><br/>

        <div style="font-size:20px; margin-bottom:20px;"><%= result %></div>
    <asp:Button BorderStyle="None" CssClass="btn btn-default btn-lg" style="background-color: #ff001e; color:white; " ID="GenerateButton" Text="Generate Results" OnClick="GenerateButton_Click" runat="server" />
        
        </div>
</asp:Content>
