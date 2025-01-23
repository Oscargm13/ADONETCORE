using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADONETCORE.Models;
using ADONETCORE.Repositorys;



namespace ADONETCORE
{
    public partial class Form15AdoNetCorePractica : Form
    {
        RepositoryPracticaEmpleadosHospitales repo;
        public Form15AdoNetCorePractica()
        {
            InitializeComponent();
            repo = new RepositoryPracticaEmpleadosHospitales();
            this.LoadHospitales();
        }

        public async Task LoadHospitales()
        {
            List<Hospital> hospitales = new List<Hospital>();
            hospitales = await repo.LoadHospitales();
            this.cmbHospital.Items.Clear();
            foreach (Hospital hospital in hospitales)
            {
                this.cmbHospital.Items.Add(hospital.Nombre + " - " + hospital.IdHospital);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void Form15AdoNetCorePractica_Load(object sender, EventArgs e)
        {

        }

        private async void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbHospital.SelectedItem == null) return;

            // Trocear la cadena para obtener solo el ID del hospital
            string hospital = this.cmbHospital.SelectedItem.ToString();
            string[] parts = hospital.Split(" - ");
            if (parts.Length < 2) return;

            int idHospital;
            if (int.TryParse(parts[1], out idHospital))
            {
                EmpleadosModelOut model = await repo.GetEmpleadosHospitales(idHospital);
                this.lstEmpleados.Items.Clear();
                foreach (string apellido in model.Apellidos)
                {
                    this.lstEmpleados.Items.Add(apellido);
                }
                this.txtSumaSalarial.Text = model.SumaSalarial.ToString();
                this.txtMediaSalarial.Text = model.MediaSalarial.ToString();
                this.txtPersonas.Text = model.Personas.ToString();
            }
            else
            {
                MessageBox.Show("Error al obtener el ID del hospital.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
