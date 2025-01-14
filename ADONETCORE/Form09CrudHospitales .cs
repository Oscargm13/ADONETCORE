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
    public partial class Form09CrudHospitales : Form
    {
        RepositoryHospital repo;
        public Form09CrudHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospital();
            LoadHospitales();
        }

        private async void LoadHospitales()
        {
            List<Hospital> hospital = await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (var hospi in hospital)
            {
                this.lstHospitales.Items.Add(hospi.IdHospital + " - " + hospi.Nombre + " - " + hospi.Localidad
                    + " - " + hospi.Telefono + " - " + hospi.NumCama);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtLocalidad.Text;
            string telefono = this.txtTelefono.Text;
            int numeroCamas = int.Parse(this.txtNumeroCamas.Text);
            await this.repo.InsertHospitalAsync(id, nombre, direccion, telefono, numeroCamas);
            LoadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteHospitalAsync(id);
            LoadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtLocalidad.Text;
            string telefono = this.txtTelefono.Text;
            int numeroCamas = int.Parse(this.txtNumeroCamas.Text);
            await this.repo.UpdateHospitalAsync(id, nombre, direccion, telefono, numeroCamas);
            LoadHospitales();
        }
    }
}
