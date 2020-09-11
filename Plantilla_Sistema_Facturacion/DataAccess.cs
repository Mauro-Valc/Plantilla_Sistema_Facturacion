using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Plantilla_Sistema_Facturacion
{

	public class DataAccess
	{
		
		SqlConnetion connection;
		SqlDataReader dataReader;
		SqlDataAdapter dataAdapter;
		DataTable dataTable;
		DataSet dataSet;

		public void OpenConnection()
		{
			try
			{
				connection = new SqlConnection("Data Source=MSSQLSERVER1;InitialCatalog =[DBFACTURAS]; Integrated Security = True");
				connection.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("falló conexión " + ex);
			}
		}
		public void CloseConnection()
		{
			try
			{
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("falló cerrar conexión " + ex);
			}
		}
		public string ValidarUsuario(string userName, string password)
		{
			string empleado = "";
			try
			{
				strign query = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s join TBLEMPLEADO e on s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}' ";
				OpenConnection();
				cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = query;
				cmd.CommandType = CommandType.text;
				cmd.CommandTimeout = 10;
				dataReader = cmd.ExecuteReader();
				while (dataReader.Read())
				{
					empleado = Convert.ToString(dataReader.GetValue(0));

				}
                if (dataReader != null)
                {
					dataReader.Close();
				}
				return empleado;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
