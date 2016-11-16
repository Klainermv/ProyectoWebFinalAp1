using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ProyectoWebFinal.registros
{
    public partial class rCitas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Citas cita = new Citas();
            cita.Descripcion = TxBxDescripcion.Text;
            cita.Fecha = Convert.ToDateTime(TxBxFecha.Text);

            if (cita.Insertar()) {
                limpiaCampos();
            }
        }

        private void limpiaCampos() {
            TxBxDescripcion.Text = string.Empty;
            TxBxFecha.Text = string.Empty;
        }

        protected void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            GVPacientes.DataSource = paciente.ListadoBusqueda(TxBxBuscaPaciente.Text);
            GVPacientes.DataBind();
        }
    }
}