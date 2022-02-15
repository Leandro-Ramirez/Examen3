#region Usos
using Forms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Forms
{
    public partial class FrmPersonas : Form
    {
        #region Variables Globales
        List<Ingeniero> listaPersona = new List<Ingeniero>();
        Ingeniero ingeniero;
        #endregion

        #region Inicializar Componente frmPersona
        public FrmPersonas()
        {
            InitializeComponent();
            listaPersona = new List<Ingeniero>();
        }
        #endregion

        #region Boton Registrar Click
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }
        #endregion

        #region Boton Mostrar Click
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MostrarPersona();
        }
        #endregion

        #region Boton Salir Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quieres Salir del Formulario?", "Persona",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
        #endregion

        #region Metodo de Guardado
        public void GuardarPersona()
        {
            ingeniero = new Ingeniero(txtNombre.Text, cmbSexo.Text, int.Parse(txtEdad.Text),
                txtCarnet.Text, cmbNivel.Text, cmbUniversidad.Text,
                cmbCarrera.Text, cmbMaterias.Text, int.Parse(txtNotas.Text),
                txtProyecto.Text, int.Parse(txtHoraT.Text), int.Parse(txtHoraC.Text));
        }
        #endregion

        #region Metodo Mostrar Persona
        public void MostrarPersona()
        {
            listaPersona.Add(ingeniero);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = listaPersona;
        }
        #endregion

        #region Seleccion de Tipo
        //public void Identificar()
        //{
        //    string Tipo;
        //    Tipo = cmbTipo.Text;

        //    
        //}
        #endregion

        #region Carga del formulario Persona
        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            if (cmbCarrera.Text == "IngenieriaComputacion")
            {

            }
           
            if (cmbCarrera.Text == "IngenieriaElectrica")
            {

            }
            if (cmbCarrera.Text == "IngenieriaIndustrial")
            {

            }
            if (cmbCarrera.Text == "IngenieriaMecanica")
            {

            }
            if (cmbCarrera.Text == "IngenieriaQuimica")
            {

            }
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Persona":
                    {
                        lblNombre.Visible = true;
                        lblSexo.Visible = true;
                        lblEdad.Visible = true;
                        txtNombre.Visible = true;
                        cmbSexo.Visible = true;
                        txtEdad.Visible = true;

                        lblCarnet.Visible = false;
                        lblNivel.Visible = false;
                        txtCarnet.Visible = false;
                        cmbNivel.Visible = false;

                        lblUniversidad.Visible = false;
                        lblCarrera.Visible = false;
                        lblMaterias.Visible = false;
                        lblNotas.Visible = false;
                        cmbUniversidad.Visible = false;
                        cmbCarrera.Visible = false;
                        cmbMaterias.Visible = false;
                        txtNotas.Visible = false;

                        lblProyecto.Visible = false;
                        lblHorasT.Visible = false;
                        lblHorasC.Visible = false;
                        txtProyecto.Visible = false;
                        txtHoraT.Visible = false;
                        txtHoraC.Visible = false;
                    }
                    break;

                case "Estudiante":
                    {
                        lblNombre.Visible = true;
                        lblSexo.Visible = true;
                        lblEdad.Visible = true;
                        txtNombre.Visible = true;
                        cmbSexo.Visible = true;
                        txtEdad.Visible = true;

                        lblCarnet.Visible = true;
                        lblNivel.Visible = true;
                        txtCarnet.Visible = true;
                        cmbNivel.Visible = true;

                        lblUniversidad.Visible = false;
                        lblCarrera.Visible = false;
                        lblMaterias.Visible = false;
                        lblNotas.Visible = false;
                        cmbUniversidad.Visible = false;
                        cmbCarrera.Visible = false;
                        cmbMaterias.Visible = false;
                        txtNotas.Visible = false;

                        lblProyecto.Visible = false;
                        lblHorasT.Visible = false;
                        lblHorasC.Visible = false;
                        txtProyecto.Visible = false;
                        txtHoraT.Visible = false;
                        txtHoraC.Visible = false;
                    }
                    break;
                case "Universitario":
                    {
                        lblNombre.Visible = true;
                        lblSexo.Visible = true;
                        lblEdad.Visible = true;
                        txtNombre.Visible = true;
                        cmbSexo.Visible = true;
                        txtEdad.Visible = true;

                        lblCarnet.Visible = true;
                        lblNivel.Visible = true;
                        txtCarnet.Visible = true;
                        cmbNivel.Visible = true;

                        lblUniversidad.Visible = true;
                        lblCarrera.Visible = true;
                        lblMaterias.Visible = true;
                        lblNotas.Visible = true;
                        cmbUniversidad.Visible = true;
                        cmbCarrera.Visible = true;
                        cmbMaterias.Visible = true;
                        txtNotas.Visible = true;

                        lblProyecto.Visible = false;
                        lblHorasT.Visible = false;
                        lblHorasC.Visible = false;
                        txtProyecto.Visible = false;
                        txtHoraT.Visible = false;
                        txtHoraC.Visible = false;
                    }
                    break;
                case "Ingeniero":
                    {
                        lblNombre.Visible = true;
                        lblSexo.Visible = true;
                        lblEdad.Visible = true;
                        txtNombre.Visible = true;
                        cmbSexo.Visible = true;
                        txtEdad.Visible = true;

                        lblCarnet.Visible = true;
                        lblNivel.Visible = true;
                        txtCarnet.Visible = true;
                        cmbNivel.Visible = true;

                        lblUniversidad.Visible = true;
                        lblCarrera.Visible = true;
                        lblMaterias.Visible = true;
                        lblNotas.Visible = true;
                        cmbUniversidad.Visible = true;
                        cmbCarrera.Visible = true;
                        cmbMaterias.Visible = true;
                        txtNotas.Visible = true;

                        lblProyecto.Visible = true;
                        lblHorasT.Visible = true;
                        lblHorasC.Visible = true;
                        txtProyecto.Visible = true;
                        txtHoraT.Visible = true;
                        txtHoraC.Visible = true;
                    }
                    break;
            }
        }
            #endregion
            //var Promedio = from Estudiante in Estudiantes
            //where Estudiante.Nota
        }
}