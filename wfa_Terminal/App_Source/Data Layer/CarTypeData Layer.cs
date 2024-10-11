using System.Data; 
 using System.Data.SqlClient;
 using System; 

public class DataCarType
{

	 public int DL_Insert_CarType(string TypeName  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Insert_CarType";		
		Sqlcom.Parameters.AddWithValue("@TypeName",TypeName);
		
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

	 public int DL_Delete_CarType(int CarsTypeID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Delete_CarType";
		Sqlcom.Parameters.AddWithValue("@CarsTypeID",CarsTypeID);
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

	 public int DL_Update_CarType(int CarsTypeID, string TypeName  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Update_CarType";
		Sqlcom.Parameters.AddWithValue("@CarsTypeID",CarsTypeID);
Sqlcom.Parameters.AddWithValue("@TypeName",TypeName);

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

	 public DataTable DL_GetList_CarType()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_CarType",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_Search_CarType(int CarsTypeID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_CarType",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@CarsTypeID",CarsTypeID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_SearchByField_CarType(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_CarType",Scon.Open());
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
