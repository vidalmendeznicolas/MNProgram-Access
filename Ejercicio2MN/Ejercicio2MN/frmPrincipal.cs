using Ejercicio.Modelo.Entidades;
using Ejercicio.Modelo.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio
{
    public partial class frmPrincipal : Form
    {
        public const string litEntLibro = "LIBROS";
        public const string litEntPelicula = "PELICULAS";
        public const string litEntRevista = "REVISTAS";

        ApiCliente Apicliente = new ApiCliente();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(700, 430);
            MaximumSize = new Size(700, 430);
            Size = new Size(700, 430);
            Location = Point.Empty;
            Text = "MNProgram Nicolás Vidal Méndez";
            btnBaja.Enabled = false;
            ComboBox.Items.Add(litEntLibro);
            ComboBox.Items.Add(litEntPelicula);
            ComboBox.Items.Add(litEntRevista);
            ComboBox.SelectedIndex = 0;
        }

        private async void filtro_TextChanged(object sender, EventArgs e)
        {
            if (ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una entidad para filtrar", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            switch (ComboBox.SelectedItem.ToString())
            {
                case litEntLibro:
                    if (filtro.Text == "")
                        dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntLibro);
                    else
                        dgvEntidad.DataSource = await Apicliente.GetListaFiltradaAsync(litEntLibro, filtro.Text);
                    break;
                case litEntPelicula:
                    if (filtro.Text == "")
                        dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntPelicula);
                    else
                        dgvEntidad.DataSource = await Apicliente.GetListaFiltradaAsync(litEntPelicula,filtro.Text);
                    break;
                case litEntRevista:
                    if (filtro.Text == "")
                        dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntRevista);
                    else
                        dgvEntidad.DataSource = await Apicliente.GetListaFiltradaAsync(litEntRevista, filtro.Text);
                    break;
            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ComboBox.SelectedItem.ToString())
            {
                case litEntLibro:
                    dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntLibro);
                    break;
                case litEntPelicula:
                    dgvEntidad.DataSource =  await Apicliente.GetListaAsync(litEntPelicula);
                    break;
                case litEntRevista:
                    dgvEntidad.DataSource =  await Apicliente.GetListaAsync(litEntRevista);
                    break;
            }
        }

        private async void btnAlta_Click(object sender, EventArgs e)
        {
            if(ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una entidad para dar la ALTA","WARNING",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            switch(ComboBox.SelectedItem.ToString())
            {
                case litEntLibro:
                    await Apicliente.GetAddListaAsync(litEntLibro);       
                    dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntLibro);
                    break;
                case litEntPelicula:
                    await Apicliente.GetAddListaAsync(litEntPelicula);
                    dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntPelicula);
                    break;
                case litEntRevista:
                    await Apicliente.GetAddListaAsync(litEntRevista);
                    dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntRevista);
                    break;
            }
        }

        private async void btnBaja_Click(object sender, EventArgs e)
        {
            if (ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una entidad para dar la BAJA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(dgvEntidad.SelectedCells.Count == 0)
            {
                MessageBox.Show("Tabla vacía, no se puede la BAJA", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow filaSelccionada = dgvEntidad.Rows[dgvEntidad.SelectedCells[0].RowIndex];
            int id = Convert.ToInt32(filaSelccionada.Cells["id"].Value);

            switch (ComboBox.SelectedItem.ToString())
            {
                case litEntLibro:
                    await Apicliente.GetBajaListaAsync(litEntLibro, id);
                    dgvEntidad.DataSource = null;
                    dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntLibro);
                    break;
                case litEntPelicula:
                    await Apicliente.GetBajaListaAsync(litEntPelicula, id);
                    dgvEntidad.DataSource = null;
                    dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntPelicula);
                    break;
                case litEntRevista:
                    await Apicliente.GetBajaListaAsync(litEntRevista, id);
                    dgvEntidad.DataSource = null;
                    dgvEntidad.DataSource = await Apicliente.GetListaAsync(litEntRevista);
                    break;
            }
        }       

        private async void btnInforme_Click(object sender, EventArgs e)
        {
            MessageBox.Show(await Apicliente.GetInformeAsync(), "Informe",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvEntidad.Rows.Count > 0)
                btnBaja.Enabled = true;
            else
                btnBaja.Enabled = false;
        }
    }
}
