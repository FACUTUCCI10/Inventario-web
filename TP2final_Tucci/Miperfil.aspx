<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Miperfil.aspx.cs" Inherits="TP2final_Tucci.Miperfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h3>Mi Perfil</h3>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <asp:Label ID="LblEmail" runat="server" Text="Email" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="Txtemail" runat="server" CssClass="form-control" ></asp:TextBox>
            </div>
             <div class="mb-3">
                <asp:Label ID="lblnombre" runat="server" Text="Nombre" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="Txtnombre" runat="server" cssclass="form-control"></asp:TextBox>
            </div>
             <div class="mb-3">
                <asp:Label ID="Lblapellido" runat="server" Text="Apellido" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="Txtapellido" runat="server"  CssClass="form-control"></asp:TextBox>
            </div>
             <%--<div class="mb-3">
                <asp:Label ID="LblfechaNacimiento" runat="server" Text="Fecha de nacimiento" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TxtfechaNacimiento" runat="server" CssClass="form-control"></asp:TextBox>
            </div>--%>
        </div>
        <div class="col-md-4">
            <div class="mb-3"> 
                <asp:Label ID="Lblimagen" runat="server" Text="imagen de perfíl" CssClass="form-label"></asp:Label>
                <input type="file" id="txtimagen" runat="server" class="form-control"/>
            </div>
            <asp:Image ID="imgNuevoPerfil"  runat="server" ImageUrl="https://www.google.com/url?sa=i&url=https%3A%2F%2Fagropro.ag%2Fplaceholder-22-png%2F&psig=AOvVaw1jbSLhOlfOMY32JMm8DGgn&ust=1701460690421000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCPja3pLB7IIDFQAAAAAdAAAAABAW" CssClass="img-fluid mb-3" />
        </div>
        <div class="row">
            <div class="col-md-4">
                <asp:Button ID="Btnguardar" runat="server" Text="guardar" OnClick="Btnguardar_Click" CssClass="btn btn-primary" />
                <a href="/">Regresar</a>
            </div>
    </div>
         </div>
</asp:Content>
