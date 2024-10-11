using System.Data; 
 using System.Data.SqlClient;
 using System; 

public class DataProvince
{

	 public int DL_Insert_Province(string ProvinceName  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Insert_Province";		
		Sqlcom.Parameters.AddWithValue("@ProvinceName",ProvinceName);
		
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

	 public int DL_Delete_Province(int ProvinceID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Delete_Province";
		Sqlcom.Parameters.AddWithValue("@ProvinceID",ProvinceID);
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

	 public int DL_Update_Province(int ProvinceID, string ProvinceName  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Update_Province";
		Sqlcom.Parameters.AddWithValue("@ProvinceID",ProvinceID);
Sqlcom.Parameters.AddWithValue("@ProvinceName",ProvinceName);

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

	 public DataTable DL_GetList_Province()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_Province",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_Search_Province(int ProvinceID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_Province",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ProvinceID",ProvinceID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_SearchByField_Province(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_Province",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName );
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value );
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}
	//----------------------------------
	public int DL_GroupInsert_Province(DataTable dtable)
    {
		SqlCon scon = new SqlCon();
		SqlCommand sqlcmd = new SqlCommand();
		sqlcmd.CommandType = CommandType.StoredProcedure;
		sqlcmd.CommandText = "sp_GroupInsert_Provice";
		sqlcmd.Parameters.AddWithValue("@table",dtable);
		sqlcmd.Connection = scon.Open();
		int res = sqlcmd.ExecuteNonQuery();
		scon.Close();
		return res;



	}
}
//----------------------------------End
