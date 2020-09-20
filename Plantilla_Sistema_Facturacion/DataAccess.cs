using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Plantilla_Sistema_Facturacion
{
	public class DataAccess
	{

		SqlConnection connection;
		SqlDataReader dataReader;
		SqlDataAdapter dataAdapter;
		DataTable dataTable;
		DataSet dataSet;
		SqlCommand cmd;

		public string ValidarUsuario(string userName, string password)
		{
			string empleado = "";
			try
			{
				string query = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s join TBLEMPLEADO e on s.IdEmpleado = e.IdEmpleado where StrUsuario = '{userName}' and StrClave = '{password}' ";
				OpenConnection();
				cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = query;
				cmd.CommandType = CommandType.Text;
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
				CloseConnection();
				return empleado;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public DataTable LoadTable(String table, string condition)
		{
			String query;
			try
			{
				OpenConnection();
				query = "select * from " + table + " " + condition;
				dataAdapter = new SqlDataAdapter(query, connection);
				dataSet = new DataSet();
				dataAdapter.Fill(dataSet, table);
				dataTable = dataSet.Tables[table];
				CloseConnection();
				return dataTable;
			}
			catch (Exception e)
			{
				MessageBox.Show("Error al cargar los datos: " + e.ToString());
				return null;
			}
		}

		public string RunCommand(string command)
		{
			string response = "Los datos se actualizaron correctamente";
			try
			{
				int rt;
				OpenConnection();
				cmd = new SqlCommand(command, connection);
				rt = cmd.ExecuteNonQuery();
				CloseConnection();
				if (rt <= 0)
				{
					response = "Los datos no fueron actualizados";
				}
			}
			catch (Exception ex)
			{
				response = "falló inserción: " + ex;
			}
			return response;
		}

		public DataTable GetDataForQuery(string query)
		{
			try
			{
				OpenConnection();
				dataAdapter = new SqlDataAdapter(query, connection);
				dataTable = new DataTable();
				dataAdapter.Fill(dataTable);
				CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Falló operación: " + ex);
				return null;
			}
			return dataTable;
		}

		private void OpenConnection()
		{
			try
			{
				connection = new SqlConnection(@"Data Source=MAURICIOVALENCI\MSSQLSERVER1;Initial Catalog =“DBFACTURAS”; Integrated Security = True");
				connection.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("falló conexión " + ex);
			}
		}
		private void CloseConnection()
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
	}
}
