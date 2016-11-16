<%@ Page Title="" Language="C#" MasterPageFile="~/masters/bootstrapPlantilla.Master" AutoEventWireup="true" CodeBehind="rCitas.aspx.cs" Inherits="ProyectoWebFinal.registros.rCitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPHContenido" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPHForm" runat="server">

<div class="row">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        
    <div class="col-lg-5 col-md-5 col-sm-5 col-xs-12">
        <div class="form-group">
            <label for="TxBxBuscaPaciente">Buscar Paciente</label>
            <div class="input-group">      
                <asp:TextBox ID="TxBxBuscaPaciente" runat="server" CssClass="form-control" ToolTip="Buscar Paciente"></asp:TextBox>
              <span class="input-group-btn">
                <asp:Button ID="btnBuscarPaciente" runat="server" Text="Buscar Paciente" CssClass="btn btn-default" OnClick="btnBuscarPaciente_Click"  />
              </span>
            </div>
        </div>

        <div class="form-group">
            <%--<asp:Repeater ID="RepPacientes" runat="server">
                <HeaderTemplate>
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <th>Nombres</th> <th>Apellidos</th> <th>Cedula</th> <th>Telefono</th> <th>Primera Vez</th> <th>Asegurado</th>
                                </tr>
                            </thead>
                </HeaderTemplate>
                
                        <ItemTemplate>
                            <tr>
                                 <td><%# Eval("Nombres")%></td> <td><%# Eval("Apellidos")%></td> <td><%# Eval("Cedula")%></td> <td><%# Eval("Telefono")%></td> <td><%# Eval("EsNuevo")%></td> <td><%# Eval("EsASegurado")%></td>
                            </tr>                           
                        </ItemTemplate>

                <FooterTemplate>
                        </table>
                </FooterTemplate>
            </asp:Repeater>--%>
            <asp:GridView ID="GVPacientes" runat="server"></asp:GridView>


        </div>

    </div>

  <div class="col-lg-7 col-md-7 col-sm-7 col-xs-12">
    <div class="form-group">
        <asp:Label ID="LblPaciente" runat="server"></asp:Label>
    </div>

  <div class="form-group">
    <label for="TxBxDescripcion">Descripcion</label>
      <asp:TextBox ID="TxBxDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="6"></asp:TextBox>
  </div>

  <div class="form-group">
    <label for="TxBxFecha">Fecha</label>
      <asp:TextBox ID="TxBxFecha" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
  </div>
  
    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="BtnGuardar_Click" />

    </div>

    </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnBuscarPaciente" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPHPieDePagins" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPHScripts" runat="server">
</asp:Content>
