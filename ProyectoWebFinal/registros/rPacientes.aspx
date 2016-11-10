<%@ Page Title="" Language="C#" MasterPageFile="~/masters/bootstrapPlantilla.Master" AutoEventWireup="true" CodeBehind="rPacientes.aspx.cs" Inherits="ProyectoWebFinal.registros.rPacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPHContenido" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPHForm" runat="server">
  
  <div class="row">  
  <div class="col-lg-6">
    <div class="input-group">      
        <asp:TextBox ID="TxBxBuscar" runat="server" CssClass="form-control" ToolTip="Buscar Paciente"></asp:TextBox>
      <span class="input-group-btn">
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar Paciente" CssClass="btn btn-default" OnClick="btnBuscar_Click" />
      </span>
    </div><!-- /input-group -->
  </div><!-- /.col-lg-6 -->
</div><!-- /.row -->

    <br />

   <div class="form-group">
    <label for="TxBxNombres">Nombres</label>
      <asp:TextBox ID="TxBxNombres" runat="server" CssClass="form-control"></asp:TextBox>
  </div>

    <div class="form-group">
    <label for="TxBxApellidos">Apellidos</label>
      <asp:TextBox ID="TxBxApellidos" runat="server" CssClass="form-control"></asp:TextBox>
  </div>

    <div class="form-group">
    <label for="TxBxCedula">Cedula</label>
      <asp:TextBox ID="TxBxCedula" runat="server" CssClass="form-control"></asp:TextBox>
  </div>

    <div class="form-group">
    <label for="TxBxTelefono">Telefono</label>
      <asp:TextBox ID="TxBxTelefono" runat="server" CssClass="form-control"></asp:TextBox>
  </div>
    
    <div class="checkbox">
      <label>
        <asp:CheckBox ID="ChkBxEsAsegurado" runat="server"></asp:CheckBox>
        Esta Asegurado
      </label>
    </div>

    <div class="checkbox">
      <label>
        <asp:CheckBox ID="ChkBxEsNuevo" runat="server"></asp:CheckBox>
        Es Nuevo
      </label>
    </div>
            
    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success btn-block" OnClick="BtnGuardar_Click"  />

    <asp:UpdatePanel ID="UpdPaciente" runat="server">
        <ContentTemplate>
            <asp:Repeater ID="repetPacientes" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th>Paciente</th><th>Cedula</th><th>Telefono</th><th>Asegurado</th><th>Nueva Cita</th><th>Opciones</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <td colspan="6">
                                    10
                                </td>
                            </tr>
                        </tfoot>
                        <tbody>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Nombres")%>&nbsp;<%# Eval("Apellidos")%></td><td><%# Eval("Cedula")%></td><td><%# Eval("Telefono")%></td><td><%# Eval("EsASegurado")%></td><td><%# Eval("EsNuevo")%></td><td>Opciones</td>
                    </tr>
                </ItemTemplate>

                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </ContentTemplate>
    
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="BtnGuardar" EventName="Click" />
        </Triggers>
    
      </asp:UpdatePanel>


    

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPHPieDePagins" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPHScripts" runat="server">
</asp:Content>
