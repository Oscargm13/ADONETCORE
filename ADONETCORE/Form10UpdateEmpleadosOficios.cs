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
    public partial class Form10UpdateEmpleadosOficios : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }

        private async void LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string ofi in oficios)
            {
                this.lstOficios.Items.Add(ofi);
            }
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                this.LoadEmpleados(oficio);
            }
        }

        private async void LoadEmpleados(string oficio)
        {
            List<string> empleados = await this.repo.GetEmpleadosOficioAsync(oficio);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in empleados)
            {
                this.lstEmpleados.Items.Add(ape);
            }
        }

        private async void btnIncrementarSalarios_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int modificados = await this.repo.UpdateSalarioEmpleadosOficio(oficio, incremento);
            DatosEmpleadosOficios datos = await this.repo.DatosEmpleadosOficios(oficio);
            this.lblSumaSalarial.Text = "Suma " + datos.sumSalario;
            this.lblMediaSalarial.Text = "Media " + datos.mediaSalarial;
            this.lblMaximoSalarial.Text = "Maximo " + datos.maximoSalarial;
            MessageBox.Show("Salarios modificados " + modificados);
            
        }

        private async void btnOficio_Click(object sender, EventArgs e)
        {
            string oficioNuevo = this.txtOficio.Text;
            string oficio = this.lstOficios.SelectedItem.ToString();
            await this.repo.UpdateOficio(oficio, oficioNuevo);
            MessageBox.Show(" modificados: ");
        }

        private async void datosEmpleados()
        {
            string oficio = this.lstOficios.SelectedItem.ToString();
            await this.repo.DatosEmpleadosOficios(oficio);

        }
    }
}
