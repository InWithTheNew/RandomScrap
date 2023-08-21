using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Linq;
namespace RandomGarbLuke
{
	public class SqlObject
	{
		SqlConnection _sqlConnectionObject = new();

		public SqlObject(string ConnectionString)
		{

			_sqlConnectionObject = new SqlConnection(ConnectionString);

        }

		public System.Data.DataTable GetResults()
		{

            _sqlConnectionObject.Open();

            var results =  _sqlConnectionObject.GetSchema();

			_sqlConnectionObject.Close();

			return results;
		}

		public void AddResults(string FirstName, string LastName, int Height, string Table)
		{

            _sqlConnectionObject.Open();
            try
			{
				string SqlCommand = String.Format(@"INSERT INTO {3} (FirstName,LastName,Height) VALUES('{0}','{1}',{2})", FirstName, LastName, Height, Table);

				SqlCommand cmd = new SqlCommand(SqlCommand, _sqlConnectionObject);

				cmd.ExecuteNonQuery();

				Console.WriteLine(String.Format("{0},{1},{2} Inserted into table {3}!", FirstName, LastName, Height, Table));

            }
			catch(SqlException e)
			{
				Console.WriteLine(e);
			}
			_sqlConnectionObject.Close();
        }

	}
}

