using System.Data; 
 using System.Data.SqlClient;
 using System; 

public class DataDegree
{

	 public int DL_Insert_Degree(string DegreeTitle  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Insert_Degree";		
		Sqlcom.Parameters.AddWithValue("@DegreeTitle",DegreeTitle);
		
		Sqlcom.Connection = Scon.Open();
		int R=0;
		R = Sqlcom.ExecuteNonQuery();		  
		Scon.Close();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public int DL_Delete_Degree(int DegreeID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Delete_Degree";
		Sqlcom.Parameters.AddWithValue("@DegreeID",DegreeID);
		Sqlcom.Connection = Scon.Open();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.Close();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public int DL_Update_Degree(int DegreeID, string DegreeTitle  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Update_Degree";
		Sqlcom.Parameters.AddWithValue("@DegreeID",DegreeID);
Sqlcom.Parameters.AddWithValue("@DegreeTitle",DegreeTitle);

		Sqlcom.Connection = Scon.Open();
		int R=Sqlcom.ExecuteNonQuery();
		Scon.Close();
		return R;
		}
		catch
		{
		return 0;
		}
	}

	 public DataTable DL_GetList_Degree()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_Degree",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_Search_Degree(int DegreeID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_Degree",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@DegreeID",DegreeID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_SearchByField_Degree(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_Degree",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}
}
//----------------------------------End
