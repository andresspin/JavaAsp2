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
    public partial class FrmGestionarDominios : Form
    {
        dominios oDominio = null;
        private String tipoDominio;
        private String IdDominio;

        // constructor
        public FrmGestionarDominios(String tipoDominio, String IdDominio)
        {
            //dibuja el formulario
            InitializeComponent();
            //Recibir los datos de la PK(si son nulos estamos insertando, si hay datos estamos editando
            this.tipoDominio=tipoDominio;
            this.IdDominio = IdDominio;
            

            //si hay datos (edicion) llamamos el metodo cargar datos()
            if(! string .IsNullOrEmpty(this.IdDominio)
                && ! string.IsNullOrEmpty(this.tipoDominio))
            {
                // Si es modo edicion, bloqueamos los TextBox de la llave primaria
                cargarDatos();
                this.txtTipo.ReadOnly = true;
                this.txtId.ReadOnly = true;
            }
            else
            {
                this.txtTipo.ReadOnly = false;
                this.txtId.ReadOnly = false;


            }
        }

        private void cargarDatos()

        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                oDominio = db.dominios.Find(tipoDominio,IdDominio);
                txtTipo.Text = oDominio.tipo_dominio;
                txtId.Text = oDominio.id_dominio;
                txtValor.Text = oDominio.vlr_dominio;



            }



        }

        private void FrmGestionarDominios_Load(object sender, EventArgs e)
        {
            // haremos qu el cursor se ubique en el primer text bx
            this.txtTipo.Select();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos solicitados sean diligenciados
            if (String.IsNullOrEmpty(this.txtTipo.Text) || string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtValor.Text))
            {
                MessageBox.Show("Los campos con asterisco son obligatorios");

            }
            else {
                // el using establece la conexion con la BD a traves de Entity Framwork
                using (videotiendaEntities db = new videotiendaEntities())
                {
                    // si estamos en modo insercion, inicializamos el objeto oDominio
                    if(this.tipoDominio == null && this.IdDominio == null)
                        oDominio = new dominios();
                
              
                    oDominio.tipo_dominio = this.txtTipo.Text;
                    oDominio.id_dominio = this.txtId.Text;
                    oDominio.vlr_dominio = this.txtValor.Text;
                    // en modo insercion, adicionamos un nuevo registro
                    if (this.tipoDominio == null && this.IdDominio == null)
                        db.dominios.Add(oDominio);
                    else
                        // en modo edicion, cambiamos el estado del objeto a modificar
                        db.Entry(oDominio).State = System.Data.Entity.EntityState.Modified;
                    // confirmar cambios en la BD
                    
                    db.SaveChanges();
                    //cerrar el formulario
                    this.Close();




                }
            }
        }
    }
}
