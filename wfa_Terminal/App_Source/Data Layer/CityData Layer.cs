using System.Data; 
 using System.Data.SqlClient;
 using System; 

public class DataCity
{

	 public int DL_Insert_City(string CityName, int ID_FK_tbl_Province  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Insert_City";		
		Sqlcom.Parameters.AddWithValue("@CityName",CityName);
Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Province",ID_FK_tbl_Province);
		
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

	 public int DL_Delete_City(int CityID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Delete_City";
		Sqlcom.Parameters.AddWithValue("@CityID",CityID);
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

	 public int DL_Update_City(int CityID, string CityName, int ID_FK_tbl_Province  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Update_City";
		Sqlcom.Parameters.AddWithValue("@CityID",CityID);
Sqlcom.Parameters.AddWithValue("@CityName",CityName);
Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Province",ID_FK_tbl_Province);

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

	 public DataTable DL_GetList_City()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_City",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_Search_City(int CityID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_City",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@CityID",CityID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_SearchByField_City(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_City",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}
	//--------------------------------------
	public int DL_GroupInsert_City(DataTable dtable)
	{
		SqlCon scon = new SqlCon();
		SqlCommand sqlcmd = new SqlCommand();
		sqlcmd.CommandType = CommandType.StoredProcedure;
		sqlcmd.CommandText = "sp_GroupInsert_City";
		sqlcmd.Parameters.AddWithValue("@table", dtable);
		sqlcmd.Connection = scon.Open();
		int res = sqlcmd.ExecuteNonQuery();
		scon.Close();
		return res;



	}
}
//----------------------------------End
