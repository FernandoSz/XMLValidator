using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFDI_Validator
{
    public partial class pnlReporte : Form
    {
        public pnlReporte()
        {
            InitializeComponent();
        }

        private void btnDescargas_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnDescargas_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dtimeFecha = DateTime.Today; //Obtiene la fecha actual.
                lblFecha.Text = dtimeFecha.ToString("dddd: dd / MMMM/ yyyy").ToString();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                pnlTipos.Visible = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDescargas_Click_1(object sender, EventArgs e)
        {
            pnlDescargas.Visible = true;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            pnlDescargas.Visible = false;

            pnlVisorReportes.Visible = true;
        }

        private void btnBuscarFolder_Click(object sender, EventArgs e)
        {
           searchFolder.ShowDialog();
        }

        private void btnEmitidas_Click(object sender, EventArgs e)
        {

            pnlVisorReportes.Visible = false;
            pnlDescargas.Visible = false;
            pnlnewdowload.Visible = true;
            lblTipoFactura.Text = "Facturas Emitidas:";
            txtEmisor.Text = "SAF2111945R1";
            lblReceptorReq.Visible = true;
            lblEmisorReq.Visible = false;
            pnlDescargas.Visible = false;


        }

        private void btnRemitidas_Click(object sender, EventArgs e)
        {
            pnlVisorReportes.Visible = false;
            pnlDescargas.Visible = false;
            pnlnewdowload.Visible = true;
            lblTipoFactura.Text = "Facturas Remitidas:";
            txtReceptor.Text = "SAF2111945R1";
            txtEmisor.Enabled = true;
            txtEmisor.Text = "";
            lblReceptorReq.Visible = false;
            lblEmisorReq.Visible = true;
            pnlDescargas.Visible = false;

        }
    }
}
