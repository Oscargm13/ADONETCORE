using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADONETCORE.Models;
using System.Data;

namespace ADONETCORE.Repositorys
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;

        }
        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficios = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficios;
        }
        public async Task<List<string>> GetEmpleadosOficioAsync(string oficio)
        {
            string sql = "select * from EMP where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
              await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }
        public async Task<int> UpdateSalarioEmpleadosOficio(string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO = SALARIO+@incremento " + " where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return afectados;
        }
        public async Task UpdateOficio(string oficio, string nuevoOficio)
        {
            string sql = "update EMP set OFICIO = @nuevooficio where OFICIO = @oficio";
            
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@nuevooficio", nuevoOficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
        public async Task<DatosEmpleadosOficios> DatosEmpleadosOficios(string oficio)
        {
            string sql = "select sum(SALARIO) as SUMASALARIAL "
+ ", avg(SALARIO) as MEDIASALARIAL"
+ ", max(SALARIO) as MAXIMOSALARIO"
+ " from EMP where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleadosOficios datos = new DatosEmpleadosOficios();
            await this.reader.ReadAsync();
            datos.sumSalario =
            int.Parse(this.reader["SUMASALARIAL"].ToString());
            datos.mediaSalarial =
            int.Parse(this.reader["MEDIASALARIAL"].ToString());
            datos.maximoSalarial =
            int.Parse(this.reader["MAXIMOSALARIO"].ToString());
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return datos;

        }
    }
 }
