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
    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamentos repo;
        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<Departamento> departamento = await this.repo.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (var department in departamento)
            {
                this.lstDepartamentos.Items.Add(department.IdDepartamento + " - " + department.Nombre + " - " + department.Localidad);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.InsertDepartamentosAsync(id, nombre, localidad);
            this.LoadDepartamentos();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.repo.UpdateDepartamentosAsync(id, nombre, localidad);
            this.LoadDepartamentos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteDepartamentoAsync(id);
            this.LoadDepartamentos();
        }
    }
}
