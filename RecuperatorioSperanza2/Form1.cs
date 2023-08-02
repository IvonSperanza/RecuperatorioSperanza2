using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperatorioSperanza2
{
    public partial class Form1 : Form
    {
        RepositorioSala repositoriosala;
        RepositorioEntradas repositorioentradas;
        RepositorioPeliculas repositorioPeliculas;



        public Form1()
        {
            InitializeComponent();
            repositorioentradas = new RepositorioEntradas();
            repositorioPeliculas = new RepositorioPeliculas();
            repositoriosala = new RepositorioSala();

            ActualizarListaEntradasVendidas();
        }
        private void CargarDatosIniciales()
        {

            dgvSalasYAsistentes.ColumnCount = 3;
            dgvSalasYAsistentes.Columns[0].Name = "Sala";
            dgvSalasYAsistentes.Columns[1].Name = "Tipo Sala";
            dgvSalasYAsistentes.Columns[2].Name = "Asistentes";


            dgvPeliculas.ColumnCount = 2;
            dgvPeliculas.Columns[0].Name = "Película";
            dgvPeliculas.Columns[1].Name = "Tipo Sala";

            dgvEntradas.ColumnCount = 4;
            dgvEntradas.Columns[0].Name = "Película";
            dgvEntradas.Columns[1].Name = "Tipo Sala";
            dgvEntradas.Columns[2].Name = "Precio";
            dgvEntradas.Columns[3].Name = "Es Jubilado";


        }
        private void ActualizarListaEntradasVendidas()
        {
            dgvEntradas.Rows.Clear();

            var entradas = repositorioentradas.ObtenerTodasLasEntradasVendidas();

            foreach (var entrada in entradas)
            {
                decimal precioEntrada = entrada.CalcularPrecioEntrada();
                dgvEntradas.Rows.Add(entrada.Pelicula.Nombre, entrada.TipoSala, precioEntrada, entrada.EsJubilado ? "Sí" : "No");
            }
            decimal totalRecaudado = repositorioentradas.CalcularRecaudadoTotal();
            dgvEntradas.Rows.Add("", "", "", "Total recaudado:", totalRecaudado);
        }
        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            string nombrePelicula = lstPeliculas.Text;
            TipoSala tipoSala = (TipoSala)cmbTipoSala.SelectedIndex;

            Pelicula pelicula = new Pelicula(nombrePelicula, tipoSala);
            repositorioPeliculas.AgregarPelicula(pelicula);

            ActualizarListaPeliculas();
            ConfigurarColumnasPeliculas();
        }
        private void ActualizarListaSalas()
        {
            lstPeliculas.Items.Clear();
            var salas = repositoriosala.ObtenerTodasLasSalas();
            foreach (var sala in salas)
            {
                lstPeliculas.Items.Add(sala.Nombre);
            }
        }
        private void ActualizarRecaudacion()
        {
            dgvEntradas.DataSource = null; 
            dgvEntradas.Rows.Clear();

            var entradas = repositorioentradas.ObtenerTodasLasEntradasVendidas();

            decimal totalRecaudado = 0;

            foreach (var entrada in entradas)
            {
                decimal precioEntrada = entrada.CalcularPrecioEntrada();
                dgvEntradas.Rows.Add(entrada.Pelicula.Nombre, entrada.TipoSala, precioEntrada, entrada.EsJubilado ? "Sí" : "No");
                totalRecaudado += precioEntrada;
            }

            
            dgvEntradas.Rows.Add("", "", "", "Total recaudado:", totalRecaudado);
        }

        private void ActualizarListaPeliculas()
        {
            lstPeliculas.Items.Clear();
            var peliculas = repositorioPeliculas.ObtenerTodasLasPeliculas();
            foreach (var pelicula in peliculas)
            {
                lstPeliculas.Items.Add(pelicula.Nombre);
            }
        }
        private void ActualizarListaEntradas()
        {
            dgvEntradas.DataSource = repositorioentradas.ObtenerTodasLasEntradasVendidas();
        }
        private void ActualizarCantidadJubilados()
        {
            int cantidadJubilados = repositorioentradas.ContarAsistentesJubilados();
            txtAsistentesJubilados.Text = $"Asistentes jubilados: {cantidadJubilados}";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombrePelicula_TextChanged(object sender, EventArgs e)
        {

        }
        private void ConfigurarColumnasSalas()
        {
            dgvSalasYAsistentes.AutoGenerateColumns = false;
            dgvSalasYAsistentes.Columns.Clear();

            dgvSalasYAsistentes.Columns.Add("Nombre", "Nombre Sala");
            dgvSalasYAsistentes.Columns.Add("CapacidadMaxima", "Capacidad Máxima");

            dgvSalasYAsistentes.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvSalasYAsistentes.Columns["CapacidadMaxima"].DataPropertyName = "CapacidadMaxima";

            dgvSalasYAsistentes.Columns["Nombre"].Width = 150;
            dgvSalasYAsistentes.Columns["CapacidadMaxima"].Width = 120;
        }

        private void ConfigurarColumnasPeliculas()
        {
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.Columns.Clear();

            dgvPeliculas.Columns.Add("Nombre", "Nombre Película");
            dgvPeliculas.Columns.Add("TipoSala", "Tipo Sala");

            dgvPeliculas.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvPeliculas.Columns["TipoSala"].DataPropertyName = "TipoSala";

            dgvPeliculas.Columns["Nombre"].Width = 150;
            dgvPeliculas.Columns["TipoSala"].Width = 100;
        }
        private void ConfigurarColumnasEntradas()
        {
            dgvEntradas.AutoGenerateColumns = false;
            dgvEntradas.Columns.Clear();

            dgvEntradas.Columns.Add("Pelicula", "Película");
            dgvEntradas.Columns.Add("TipoSala", "Tipo Sala");
            dgvEntradas.Columns.Add("Precio", "Precio");
            dgvEntradas.Columns.Add("EsJubilado", "Es Jubilado");

            dgvEntradas.Columns["Pelicula"].DataPropertyName = "Pelicula.Nombre";
            dgvEntradas.Columns["TipoSala"].DataPropertyName = "TipoSala";
            dgvEntradas.Columns["Precio"].DataPropertyName = "Precio";
            dgvEntradas.Columns["EsJubilado"].DataPropertyName = "EsJubilado";

            dgvEntradas.Columns["Pelicula"].Width = 150;
            dgvEntradas.Columns["TipoSala"].Width = 100;
            dgvEntradas.Columns["Precio"].Width = 80;
            dgvEntradas.Columns["EsJubilado"].Width = 80;

           
            dgvEntradas.Columns.Add("TotalRecaudado", "Total Recaudado");
        }

        private void btnAgregarSala_Click(object sender, EventArgs e)
        {
            string nombreSala = txtNombreSala.Text;
            int capacidadMaxima = 5;

            Sala sala = new Sala(nombreSala, capacidadMaxima);
            repositoriosala.AgregarSala(sala);

            ActualizarListaSalas();
            ConfigurarColumnasSalas();
        }

        private void txtNombreSala_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVenderEntrada_Click(object sender, EventArgs e)
        {
            string nombrePelicula = lstPeliculas.SelectedItem?.ToString();
            TipoSala tipoSala = (TipoSala)cmbTipoSalaEntrada.SelectedIndex;
            bool esJubilado = chkEsJubilado.Checked;

            if (nombrePelicula == null)
            {
                MessageBox.Show("Seleccione una película antes de vender la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pelicula peliculaSeleccionada = repositorioPeliculas.ObtenerTodasLasPeliculas()
                .Find(p => p.Nombre == nombrePelicula);

            Entrada entrada = new Entrada(peliculaSeleccionada, tipoSala, esJubilado);
            repositorioentradas.VenderEntrada(entrada);

            ActualizarListaEntradasVendidas();
            ActualizarRecaudacion();
            ActualizarCantidadJubilados();
        }

        private void chkEsJubilado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
