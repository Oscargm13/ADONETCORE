using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADONETCORE.Helpper;
using ADONETCORE.Models;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region PROCEDIMIENTOS ALMACENADOS
//CREATE PROCEDURE SP_EMPLEADOS_HOSPITAL
//    @idHospital NVARCHAR(50),
//    @suma INT OUTPUT,
//    @media INT OUTPUT,
//    @personas INT OUTPUT
//AS
//BEGIN
//    -- Listar todos los empleados del hospital
//    SELECT DOCTOR.APELLIDO AS NombreDoctor, DOCTOR.SALARIO AS SalarioDoctor
//    FROM DOCTOR
//    WHERE DOCTOR.HOSPITAL_COD = @idHospital

//    UNION ALL

//    SELECT PLANTILLA.APELLIDO AS NombrePlantilla, PLANTILLA.SALARIO AS SalarioPlantilla
//    FROM PLANTILLA
//    WHERE PLANTILLA.HOSPITAL_COD = @idHospital;

//--Calcular suma, media y número de empleados
//    SELECT 
//        @suma = SUM(SALARIO),
//    @media = AVG(SALARIO),
//    @personas = COUNT(*)
//    FROM (
//        SELECT SALARIO FROM DOCTOR WHERE HOSPITAL_COD = @idHospital
//        UNION ALL
//        SELECT SALARIO FROM PLANTILLA WHERE HOSPITAL_COD = @idHospital
//    ) AS Empleados;
//END
//GO
#endregion

namespace ADONETCORE.Repositorys
{

    internal class RepositoryPracticaEmpleadosHospitales
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryPracticaEmpleadosHospitales()
        {
            string connectionString = HelpperConfiguration.GetConnectionString();

            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Hospital>> LoadHospitales()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                
                Hospital hospital = new Hospital();
                hospital.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospital.Localidad = this.reader["DIRECCION"].ToString();
                hospital.Telefono = this.reader["TELEFONO"].ToString();
                hospital.NumCama = int.Parse(this.reader["NUM_CAMA"].ToString());
                hospitales.Add(hospital);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task<EmpleadosModelOut> GetEmpleadosHospitales(int idHospital)
        {
            this.com.Parameters.Clear();  // Limpiar parámetros previos
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_EMPLEADOS_HOSPITAL";

            this.com.Parameters.AddWithValue("@idHospital", idHospital);

            SqlParameter pamSuma = new SqlParameter("@suma", SqlDbType.Int) { Direction = ParameterDirection.Output };
            SqlParameter pamMedia = new SqlParameter("@media", SqlDbType.Int) { Direction = ParameterDirection.Output };
            SqlParameter pamPersonas = new SqlParameter("@personas", SqlDbType.Int) { Direction = ParameterDirection.Output };

            this.com.Parameters.Add(pamSuma);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamPersonas);

            await this.cn.OpenAsync();

            List<string> apellidos = new List<string>();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                // Usa la columna adecuada según el alias especificado en el procedimiento
                string nombre = this.reader["NombreDoctor"]?.ToString() ?? this.reader["NombrePlantilla"]?.ToString();
                if (!string.IsNullOrEmpty(nombre))
                {
                    apellidos.Add(nombre);
                }
            }
            await this.reader.CloseAsync();

            // Crear y devolver el modelo con los valores de salida
            EmpleadosModelOut empleados = new EmpleadosModelOut
            {
                Apellidos = apellidos,
                SumaSalarial = (int)pamSuma.Value,
                MediaSalarial = (int)pamMedia.Value,
                Personas = (int)pamPersonas.Value
            };

            await this.cn.CloseAsync();
            return empleados;
        }

    }
}
