using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace ProyectoWebFinal.registros
{
    public partial class rPacientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsCallback)
            {
                

            }
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            Personas pers = new Personas();
            pers.Nombres = TxBxNombres.Text;
            pers.Apellidos = TxBxApellidos.Text;
            pers.Cedula = TxBxCedula.Text;
            pers.Telefono = TxBxTelefono.Text;

            if (pers.Insertar()) {               
                Pacientes pac = new Pacientes();
                pac.PersonaId = pers.Id;
                pac.EsAsegurado = Convert.ToBoolean(ChkBxEsAsegurado.Text);
                pac.EsNuevo = true;
                pac.Insertar();
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Pacientes pac = new Pacientes();
            DataTable dt = pac.ListadoBusqueda(TxBxBuscar.Text);

            if (dt.Rows.Count > 0)
            {
                TxBxNombres.Text = dt.Rows[0]["Nombres"].ToString();
                TxBxApellidos.Text = dt.Rows[0]["Apellidos"].ToString();
                TxBxCedula.Text = dt.Rows[0]["Cedula"].ToString();
                TxBxTelefono.Text = dt.Rows[0]["Telefono"].ToString();
                ChkBxEsAsegurado.Text = dt.Rows[0]["EsASegurado"].ToString();
                ChkBxEsNuevo.Text = dt.Rows[0]["EsNuevo"].ToString();
            }
        }
    }
}