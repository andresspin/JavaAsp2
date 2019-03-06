using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideotiendaWFApp.Models;

namespace VideotiendaWFApp.Views
{
    public partial class FrmDominios : Form
    {
        public FrmDominios()
        {
            InitializeComponent();
        }

        private void FrmDominios_Load(object sender, EventArgs e)
        {
            refrescarTabla();
        }

#region Helper

        public void refrescarTabla()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var lstDominios = from d in db.dominios
                                  select d;
                grDatos.DataSource = lstDominios.ToList();

            }
        }
#endregion

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                //consultar todos los dominios
                var lstDominios = from d in db.dominios select d;
                // Aplicar filtros ingresados por el usuario en el campo Tipo
                if (!String.IsNullOrEmpty(txtTipo.Text))
                {
                    lstDominios = lstDominios.Where(d => d.tipo_dominio.Contains(this.txtTipo.Text));


                }

                // despues de evaluar Tipo se evaluara el campo ID
                if (!String.IsNullOrEmpty(txtId.Text))
                {
                    lstDominios = lstDominios.Where(d => d.id_dominio.Contains(this.txtId.Text));


                }

                // despues se evaluara el campo valor

                if (!String.IsNullOrEmpty(txtValor.Text))
                {
                    lstDominios = lstDominios.Where(d => d.vlr_dominio.Contains(this.txtValor.Text));


                }

                grDatos.DataSource = lstDominios.ToList();


            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtTipo.Text = " ";
            this.txtId.Text = " ";
            this.txtValor.Text = " ";
            refrescarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Views.FrmGestionarDominios frmGestionarDominios = new Views.FrmGestionarDominios(null, null);
            frmGestionarDominios.ShowDialog();
        }
    }
}
