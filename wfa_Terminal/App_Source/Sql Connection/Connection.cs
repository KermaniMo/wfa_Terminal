
using System;
using System.Data;
using System.Data.SqlClient;

public class SqlCon
{

		private   String StrCon;
		private   SqlConnection Con;


	public SqlConnection Open()
	{
 
		StrCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Terminal.mdf;Integrated Security=True;Connect Timeout=30";
		Con = new SqlConnection(StrCon);
		Con.Open();
		return Con;
	}

	 public void Close()
	{

		  if (Con != null)
		{
			  if (Con.State == ConnectionState.Open)
			{
			    Con.Close();
			}
		}
	}
}
