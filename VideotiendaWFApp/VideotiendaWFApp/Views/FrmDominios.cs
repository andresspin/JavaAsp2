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
        private dominios getSelectedItem()
        {
            // Inicializar el objeto para almacenar dominio seleccionado en la tabla
            dominios d = new dominios();
            try
            {
                //obtener los valores de la llave primaria del dominio seleccionado en la tabla
                    d.tipo_dominio = grDatos.Rows[grDatos.CurrentRow.Index].Cells[0].Value.ToString();
                d.id_dominio = grDatos.Rows[grDatos.CurrentRow.Index].Cells[1].Value.ToString();
                //retornar objeto con datos del dominio seleccionado de la tabla
                return d;


            }
            catch
            { return null; }
            
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
            refrescarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Obtener el dominio que se selecciono en la tabla para editar
            dominios d = getSelectedItem();
            // en el if se ve si hubo seleccion 
            if (d != null)
            {
                //Inicializar formulñario de edicion de dominios
                Views.FrmGestionarDominios frmGestionarDominios = new Views.FrmGestionarDominios(d.tipo_dominio,d.id_dominio);
                //abrir pantalla de edicion de dominios
                frmGestionarDominios.ShowDialog();
                refrescarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el dominio que se va a eliminar

            dominios d = getSelectedItem();
            // se valida si hubo seleccion
            if (d != null)
            {
                // Aqui se pedira confirmacion al eliminar un registro
                if (MessageBox.Show("Esta seguro que desea eliminar este registro?",
                    "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {

                    // establecer conexion a la bd con entity framwork
                    using (videotiendaEntities db = new videotiendaEntities())
                    {
                        // buscar el dominio en la bd
                        dominios dEliminar = db.dominios.Find(d.tipo_dominio, d.id_dominio);
                        // Eliminar el dominio de la tabla
                        db.dominios.Remove(dEliminar);
                        //confirmar cambios en la bd
                        db.SaveChanges();

                    }
                    //Actualizar la bd
                    this.refrescarTabla();
                }
            }


        }
    }
}





