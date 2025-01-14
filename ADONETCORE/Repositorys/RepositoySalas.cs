using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ADONETCORE.Repositorys
{
    public class RepositoySalas
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoySalas()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetNombresSalaAsync()
        {
            string sql = "select distinct NOMBRE from SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            //NESITAMOS CREAR EL OBJETO
            List<string> salas = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                salas.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return salas;
        }

        public async Task UpdateNombreSalaAsync
            (string oldName, string newName)
        {
            string sql = "update SALA set NOMBRE = @nuevonombre " + " where NOMBRE = @antiguonombre";
            SqlParameter pamNewName = new SqlParameter("@nuevonombre", newName);
            this.com.Parameters.Add(pamNewName);
            SqlParameter pamOldName = new SqlParameter("@antiguonombre", oldName);
            this.com.Parameters.Add(pamOldName);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
