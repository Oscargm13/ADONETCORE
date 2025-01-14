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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string salario = this.txtSalario.Text;
            string sql = "select * from EMP where salario >= " + salario;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string ape = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(ape + " - " + sal);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnBuscarOficio_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            string sql = "select * from EMP where OFICIO = '" + oficio + "'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string ape = this.reader["APELLIDO"].ToString();
                string sal = this.reader["OFICIO"].ToString();
                this.lstEmpleados.Items.Add(ape + " - " + sal);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
