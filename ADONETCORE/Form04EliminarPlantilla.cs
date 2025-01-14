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
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            cargarPlantilla();
        }

        private void cargarPlantilla()
        {
            string sql = "select * from PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["HOSPITAL_COD"].ToString();
                this.lstPlantilla.Items.Add(apellido + " - " + funcion);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "delete from PLANTILLA where HOSPITAL_COD=" + this.txtPlantilla.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminadas = this.com.ExecuteNonQuery();
            this.cn.Close();
            MessageBox.Show("Plantillas eliminadas " + eliminadas);
            cargarPlantilla();
        }
    }
}
