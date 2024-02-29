<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="inventarioList.aspx.cs" Inherits="TP2final_Tucci.inventarioList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>Inventario</h1>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <asp:Label runat="server" Text="Filtrar" ></asp:Label>
                <asp:TextBox ID="txtFiltro" runat="server" AutoPostBack="true" OnTextChanged="Filtro_TextChanged" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
      <div class="col-6" style="display: flex; flex-direction: column; justify-content: flex-end;">
            <div class="mb-3">
                <asp:CheckBox Text="Filtro Avanzado" 
                    CssClass="" ID="chkAvanzado" runat="server" 
                    AutoPostBack="true"
                    OnCheckedChanged="chkAvanzado_CheckedChanged"/>
            </div>
        </div>

        <%if (chkAvanzado.Checked)
            { %>
        <div class="row">
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Campo" ID="lblCampo" runat="server" />
                    <asp:DropDownList runat="server" AutoPostBack="true" CssClass="form-control" id="ddlCampo" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged">
                        <asp:ListItem Text="Nombre" />
                        <asp:ListItem Text="Marca" />
                        <asp:ListItem Text="Categoria" />
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Criterio" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlCriterio" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
            <div class="col-3">
                <div class="mb-3">
                    <asp:Label Text="Filtro" runat="server" />
                    <asp:TextBox runat="server" ID="txtFiltroAvanzado" CssClass="form-control" />
                </div>
            </div>
            <div class="col-3">
                <div class="mb-3">
                   <%-- <asp:Label Text="Estado" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlEstado" CssClass="form-control">
                        <asp:ListItem Text="Todos" />
                        <asp:ListItem Text="Activo" />
                        <asp:ListItem Text="Inactivo" />
                    </asp:DropDownList>--%>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-3">
                <div class="mb-3">
                    <asp:Button Text="Buscar" runat="server" CssClass="btn btn-primary" id="btnBuscar" OnClick="btnBuscar_Click"/>
                </div>
            </div>
        </div>
        <%} %>
    

    <asp:GridView ID="DGVinventario" CssClass="table" runat="server" DataKeyNames="Id" AutoGenerateColumns="false"
        OnSelectedIndexChanged="DGVinventario_SelectedIndexChanged"
        OnSelectedIndexChanging="DGVinventario_SelectedIndexChanging"
        OnPageIndexChanging="DGVinventario_PageIndexChanging" AllowPaging="true" PageSize="5">
        <Columns>
            <asp:BoundField HeaderText="nombre" DataField="nombre" />
            <asp:BoundField HeaderText="categoria" DataField="categoria.descripcion" />
            <asp:BoundField HeaderText="marca" DataField="marca.descripcion" />
            <asp:BoundField HeaderText="precio" DataField="precio" />
            <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="✍️​" />
        </Columns>
    </asp:GridView>
    <a href="FormularioInventario.aspx" class="btn btn-primary">Agregar</a>
</asp:Content>
