<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="loginUser.aspx.cs" Inherits="TP2final_Tucci.loginUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col-4">
            <h2>Crea tu perfil</h2>
            <div class="mb-3">
                <label class="form-label">Email</label>
                <asp:TextBox ID="TxtEmail" CssClass="form-control" runat="server" ></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Password</label>
                <asp:TextBox ID="TxtPassword" CssClass="form-control" runat="server" TextMode="Password" ></asp:TextBox>
            </div>
            <asp:Button ID="BtnRegistrarse" cssclass=" btn btn-primary" runat="server" OnClick="BtnRegistrarse_Click" Text="Registrarse" />
            <a href="/">cancelar</a>
        
        </div>
    </div>
</asp:Content>
