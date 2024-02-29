<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TP2final_Tucci.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1></h1>
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email:</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtpassword" class="form-label">Contraseña: </label>
                <asp:TextBox runat="server" placeholder="*****" ID="txtpassword" CssClass="form-control" textmode="password" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Ingresar" ID="btnIngresar" CssClass="btn btn-primary" OnClick="btnIngresar_Click" runat="server" />
                <a href="inventarioList.aspx">Cancelar</a>
            </div>
</asp:Content>
