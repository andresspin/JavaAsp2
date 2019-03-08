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
            InitializeComponent();
            this.tipoDominio=tipoDominio;
            this.IdDominio = IdDominio;
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
            if (String.IsNullOrEmpty(this.txtTipo.Text) || string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtValor.Text))
            {
                MessageBox.Show("Los campos con asterisco son obligatorios");

            }
            else {
                using (videotiendaEntities db = new videotiendaEntities())
                { oDominio = new dominios();
                    oDominio.tipo_dominio = this.txtTipo.Text;
                    oDominio.id_dominio = this.txtId.Text;
                    oDominio.vlr_dominio = this.txtValor.Text;
                    db.dominios.Add(oDominio);
                    db.SaveChanges();
                    this.Close();




                }
            }
        }
    }
}
