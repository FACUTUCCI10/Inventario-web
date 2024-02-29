<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="menuLogin.aspx.cs" Inherits="TP2final_Tucci.menuLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>Te logueaste correctamente</h1>
    <div class="mb-3">
        <asp:Button Text="Pagina 1" ID="btnpage1" CssClass="btn btn-primary" OnClick="btnpage1_Click" runat="server" />

    </div>
    <div>
         <div class="mb-3">
             <% if (Session["usuario"]!=null &&((dom.usuario)Session["usuario"]).tipoUsuario== dom.TipoUsuario.ADMIN) {  %>
            
             <asp:Button Text="Pagina 2" ID="btnpage2" CssClass="btn btn-primary" OnClick="btnpage2_Click" runat="server" />
            <p>Tenes que ser admin.</p>

             <% } %>
    </div>
    </div>
   
</asp:Content>
