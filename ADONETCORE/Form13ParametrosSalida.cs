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

#region PROCEDIMIENTOS ALMACENADOS
//create procedure SP_EMPLEADOS_DEPT_OUOT
//(@nombre nvarchar(50), @suma int OUT, @media int OUT, @personas int OUT)
//as
//	declare @id int
//	select @id = DEPT_NO from DEPT
//	where DNOMBRE = @nombre
//	select * from EMP where DEPT_NO=@id
//	select @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO) from EMP
//	where DEPT_NO = @id
//go
#endregion

namespace ADONETCORE
{

    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametrosOut repo;
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosOut();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> lista = new List<string>();
            await this.repo.GetDepartamentos();
            this.cmbDepartamentos.Items.Clear();
            foreach (string nombre in lista)
            {
                this.cmbDepartamentos.Items.Add(nombre);
            }
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadosModelOut model = await this.repo.GetEmpleadosModelAsync(nombre);
            this.lstEmpleados.Items.Clear();
            foreach (string apellido in model.Apellidos)
            {
                this.lstEmpleados.Items.Add(apellido);
            }
            this.txtSumaSalarial.Text = model.SumaSalarial.ToString();
            this.txtMediaSalarial.Text = model.MediaSalarial.ToString();
            this.txtPersonas.Text = model.Personas.ToString();
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
