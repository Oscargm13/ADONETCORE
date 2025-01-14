using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ADONETCORE
{
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form05UpdateSalas()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            cargarSalas();
        }

        private async void cargarSalas()
        {
            string sql = "select * from SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();    
            this.lstSalas.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                string funcion = this.reader["HOSPITAL_COD"].ToString();
                this.lstSalas.Items.Add(nombre + " - " + funcion);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int seleccionado = this.lstSalas.SelectedIndex;
            if (seleccionado == -1)
            {
                MessageBox.Show("Por favor, selecciona una sala para modificar.");
                return;
            }
            string salaSeleccionada = this.lstSalas.SelectedItem.ToString();
            string nombreSalaActual = salaSeleccionada.Split('-')[0].Trim();
            string nuevoNombre = this.txtPlantilla.Text;
            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Por favor, ingresa un nuevo nombre para la sala.");
                return;
            }
            string sql = "UPDATE SALA SET NOMBRE = @NuevoNombre WHERE NOMBRE = @NombreActual";

       
                this.com.Connection = this.cn;
                this.com.CommandType = CommandType.Text;
                this.com.CommandText = sql;
                this.com.Parameters.Clear();
                this.com.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                this.com.Parameters.AddWithValue("@NombreActual", nombreSalaActual);

                await this.cn.OpenAsync();
                int filasAfectadas = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            cargarSalas();
        }

    }
}
