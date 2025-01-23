using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;


#region STORED PROCEDURES
//CREATE PROCEDURE SP_INSERT_DEPARTAMENTO
//  @DeptNo INT,
//  @DName NVARCHAR(50),
//  @Loc NVARCHAR(50)
//AS
//BEGIN
//  BEGIN TRY
//    -- Verificar si el departamento ya existe
//    IF EXISTS (SELECT 1 FROM DEPT WHERE DEPT_NO = @DeptNo)
//    BEGIN
//      RAISERROR('El departamento con el número %d ya existe.', 16, 1, @DeptNo)
//      RETURN
//    END
//    -- Insertar un nuevo departamento
//    INSERT INTO DEPT (DEPT_NO, DNOMBRE, LOC)
//    VALUES (@DeptNo, @DName, @Loc)
//    PRINT 'Departamento insertado exitosamente.'
//  END TRY
//  BEGIN CATCH
//    -- Manejo de errores
//    DECLARE @ErrorMessage NVARCHAR(4000),
//            @ErrorSeverity INT,
//            @ErrorState INT
//    SELECT @ErrorMessage = ERROR_MESSAGE(),
//           @ErrorSeverity = ERROR_SEVERITY(),
//           @ErrorState = ERROR_STATE()
//    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
//  END CATCH
//END
//GO
#endregion
namespace ADONETCORE
{
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            LoadDepartamentos();
        }

        public async void LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                string deptno = this.reader["DEPT_NO"].ToString();
                this.lstDepartamentos.Items.Add(nombre + " - " + deptno);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private void Cn_InfoMessage(object sender, EventArgs e)
        {
            //this.lblMensaje.Text = e.Message;
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            InsertDepartamentosAsync(id, nombre, localidad);
            LoadDepartamentos();
        }

        public async Task InsertDepartamentosAsync(int deptNo, string dName, string loc)
        {
            using (SqlCommand cmd = new SqlCommand("SP_INSERT_DEPARTAMENTO", this.cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptNo", deptNo);
                cmd.Parameters.AddWithValue("@DName", dName);
                cmd.Parameters.AddWithValue("@Loc", loc);

                await this.cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
                await this.cn.CloseAsync();
                await this.reader.CloseAsync();
            }
        }
    }
}
