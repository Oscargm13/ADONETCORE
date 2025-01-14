using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ADONETCORE.Repositorys
{
    
    internal class RepositoryDepartamentosEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SELECT DISTINCT DEPT_NO FROM DEPARTAMENTOS";
            List<string> departamentos = new List<string>();

            await using (SqlConnection connection = new SqlConnection(this.cn.ConnectionString))
            {
                await using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        string nombre = reader["DEPT_NO"].ToString();
                        departamentos.Add(nombre);
                    }
                    await reader.CloseAsync();
                }
            }

            return departamentos;
        }

        public async Task<List<string>> GetEmpleadosAsync(string departamento)
        {
            string sql = "SELECT DISTINCT APELLIDO FROM EMP where DEPT_NO = " + departamento;
            List<string> empleados = new List<string>();
            
            await using (SqlConnection connection = new SqlConnection(this.cn.ConnectionString))
            {
                await using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                    {
                        string apellido = reader["APELLIDO"].ToString();
                        empleados.Add(apellido);
                    }
                    await reader.CloseAsync();
                }
            }

            return empleados;
        }

        public async Task DeleteEmpleadoAsync(string nombreEmpleado)
        {
            string sql = "DELETE FROM EMP WHERE APELLIDO = @empleado";

            await using (SqlConnection connection = new SqlConnection(this.cn.ConnectionString))
            {
                await using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@empleado", nombreEmpleado);
                    command.CommandType = System.Data.CommandType.Text;

                    await connection.OpenAsync();
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    await connection.CloseAsync();

                }
            }
        }

    }
}
