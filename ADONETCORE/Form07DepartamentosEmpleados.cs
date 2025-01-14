using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADONETCORE.Repositorys;

namespace ADONETCORE
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.loadDepartamentos();
        }

        private async void loadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            foreach (string nombre in departamentos)
            {
                this.lstDepartamentos.Items.Add(nombre);
            }
        }

        private async void loadEmpleados()
        {
            string departamento = this.lstDepartamentos.SelectedItem.ToString();
            this.lstEmpleados.Items.Clear();
            List<string> empleados = await this.repo.GetEmpleadosAsync(departamento);
            foreach (string nombre in empleados)
            {
                this.lstEmpleados.Items.Add(nombre);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string empleado = this.lstEmpleados.SelectedItem.ToString();
            this.repo.DeleteEmpleadoAsync(empleado);
            this.loadEmpleados();
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadEmpleados();
        }
    }
}
