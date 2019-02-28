<%@ Page Title="Prepared Statement" Language="C#" MasterPageFile="./Home.master" AutoEventWireup="true" CodeFile="Prepared.aspx.cs" Inherits="SQLDemo.Prepared" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<br />
<br />
<h2>Prepared Statement</h2>
<br />
<div>
    <div class="form-group">
        <asp:Label runat="server" AssociatedControlID="NameField" CssClass="col-md-2 control-label">User Name:</asp:Label>
        <asp:TextBox runat="server" ID="NameField" CssClass="form-control" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="NameField"
            CssClass="text-danger" ErrorMessage="Field is required." />
        <br/>
        <div class="col-md-offset-2">
            <asp:Button runat="server" OnClick="Submit" Text="Submit" CssClass="btn btn-default" />
        </div>
    </div>
    <br />
    <br />
    <asp:GridView ID="Results" runat="server"></asp:GridView>
    <br />
    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorText" />
        </p>
    </asp:PlaceHolder>
</div>

<br />
<br />

</asp:Content>
