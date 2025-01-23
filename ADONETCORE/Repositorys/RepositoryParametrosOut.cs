using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADONETCORE.Models;
using Microsoft.Data.SqlClient;

namespace ADONETCORE.Repositorys
{
    public class RepositoryParametrosOut
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        public RepositoryParametrosOut()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public async Task<List<string>> GetDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }
        public async Task<EmpleadosModelOut> GetEmpleadosModelAsync(string nombre)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUOT";
            //PARA LOS PARAMETROS DE ENTRADA PODEMOS UTILIZAR
            //AddWithValue SIN PROBLEMAS
            //PARA LOS PARAMETROS DE ENTRADA ES IMPRESCINDIBLE
            //UTILIZAR OBJETOS Parameter
            this.com.Parameters.AddWithValue("@nombre", nombre);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            //INDICAMOS LA DIRECCION DEL PARAMETRO
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            EmpleadosModelOut model = new EmpleadosModelOut();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                apellidos.Add(apellido);
            }
            await this.reader.CloseAsync();
            //DIBUJAMOS LOS PARAMETROS
            model.Apellidos = apellidos;
            model.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            model.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            model.Personas = int.Parse(pamPersonas.Value.ToString());

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return model;
        }
    }
   
    
}
