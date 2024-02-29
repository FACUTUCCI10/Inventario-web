<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="loginAdmin.aspx.cs" Inherits="TP2final_Tucci.loginAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>login para admin</h1>
    <p>tenes perfil de admin,de lo contrario no podrías estar aca</p>
    <div class="mb-3">
        <asp:Button Text="Regresar" ID="btnRegresarAdmin" CssClass="btn btn-primary" OnClick="btnRegresarAdmin_Click" runat="server" />

    </div>
</asp:Content>
