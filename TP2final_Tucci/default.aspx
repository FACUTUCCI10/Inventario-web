<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TP2final_Tucci._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>hola!</h1>
    <p>llegaste al Gestor web</p>

    <div class="row row-cols-1 row-cols-md-3 g-4">
   <%--     <%
            foreach(dom.Articulo articulos in listaArticulos)
            {

         %>       
            
  <div class="col">
    <div class="card">
      <img src="<%: articulos.imagenUrl %>" class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title"><%:articulos.nombre %></h5>
        <p class="card-text"><%:articulos.descripcion %></p>
      </div>
    </div>
  </div>

 <% } %>--%>


 <asp:Repeater runat="server" ID="repRepetidor" >
      <ItemTemplate>
     <div class="col">
                <div class="card">
                    <img src="<%#Eval("ImagenUrl") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                        <p class="card-text"><%#Eval("Descripcion") %></p>
                        <a href="FormularioInventario.aspx?id=<%#Eval("Id") %>">Ver Detalle</a>
                       
                    </div>
                </div>
            </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>
</asp:Content>

