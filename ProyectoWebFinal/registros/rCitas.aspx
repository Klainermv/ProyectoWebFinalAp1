<%@ Page Title="" Language="C#" MasterPageFile="~/masters/bootstrapPlantilla.Master" AutoEventWireup="true" CodeBehind="rCitas.aspx.cs" Inherits="ProyectoWebFinal.registros.rCitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPHContenido" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPHForm" runat="server">

  <div class="form-group">
    <label for="TxBxDescripcion">Descripcion</label>
      <asp:TextBox ID="TxBxDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="6"></asp:TextBox>
  </div>

  <div class="form-group">
    <label for="TxBxFecha">Fecha</label>
      <asp:TextBox ID="TxBxFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
  </div>
  
    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="BtnGuardar_Click" />

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPHPieDePagins" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPHScripts" runat="server">
</asp:Content>
