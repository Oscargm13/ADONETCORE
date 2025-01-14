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
    public partial class Form01PrimerAdo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;
        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion esta pasando de "
                + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            this.lblMensaje.BackColor = Color.LightGreen;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.Red;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            string sql = "select * from EMP";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.reader = this.com.ExecuteReader();

            for (int i = 0; i < this.reader.FieldCount; i++)
            { 
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTipoDato.Items.Add(tipoDato);
            }

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            this.reader.Close();
        }
    }
}
