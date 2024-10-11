using System.Data; 
 using System.Data.SqlClient;
 using System; 

public class DataPermission
{

	 public int DL_Insert_Permission(string PermissionUserState, bool AddPassenger, bool EditPassenger, bool RemovePassenger, bool AddDriver, bool EditDriver, bool RemoveDriver, bool AddTrip, bool EditTrip, bool RemoveTrip, bool BookTicket, bool ExtraditionTicket, bool AddCar, bool EditCar, bool RemoveCar, bool InputOutput, bool ManageDriver  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Insert_Permission";		
		Sqlcom.Parameters.AddWithValue("@PermissionUserState",PermissionUserState);
Sqlcom.Parameters.AddWithValue("@AddPassenger",AddPassenger);
Sqlcom.Parameters.AddWithValue("@EditPassenger",EditPassenger);
Sqlcom.Parameters.AddWithValue("@RemovePassenger",RemovePassenger);
Sqlcom.Parameters.AddWithValue("@AddDriver",AddDriver);
Sqlcom.Parameters.AddWithValue("@EditDriver",EditDriver);
Sqlcom.Parameters.AddWithValue("@RemoveDriver",RemoveDriver);
Sqlcom.Parameters.AddWithValue("@AddTrip",AddTrip);
Sqlcom.Parameters.AddWithValue("@EditTrip",EditTrip);
Sqlcom.Parameters.AddWithValue("@RemoveTrip",RemoveTrip);
Sqlcom.Parameters.AddWithValue("@BookTicket",BookTicket);
Sqlcom.Parameters.AddWithValue("@ExtraditionTicket",ExtraditionTicket);
Sqlcom.Parameters.AddWithValue("@AddCar",AddCar);
Sqlcom.Parameters.AddWithValue("@EditCar",EditCar);
Sqlcom.Parameters.AddWithValue("@RemoveCar",RemoveCar);
Sqlcom.Parameters.AddWithValue("@InputOutput",InputOutput);
Sqlcom.Parameters.AddWithValue("@ManageDriver",ManageDriver);
		
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

	 public int DL_Delete_Permission(int PermissionID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Delete_Permission";
		Sqlcom.Parameters.AddWithValue("@PermissionID",PermissionID);
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

	 public int DL_Update_Permission(int PermissionID, string PermissionUserState, bool AddPassenger, bool EditPassenger, bool RemovePassenger, bool AddDriver, bool EditDriver, bool RemoveDriver, bool AddTrip, bool EditTrip, bool RemoveTrip, bool BookTicket, bool ExtraditionTicket, bool AddCar, bool EditCar, bool RemoveCar, bool InputOutput, bool ManageDriver  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Update_Permission";
		Sqlcom.Parameters.AddWithValue("@PermissionID",PermissionID);
Sqlcom.Parameters.AddWithValue("@PermissionUserState",PermissionUserState);
Sqlcom.Parameters.AddWithValue("@AddPassenger",AddPassenger);
Sqlcom.Parameters.AddWithValue("@EditPassenger",EditPassenger);
Sqlcom.Parameters.AddWithValue("@RemovePassenger",RemovePassenger);
Sqlcom.Parameters.AddWithValue("@AddDriver",AddDriver);
Sqlcom.Parameters.AddWithValue("@EditDriver",EditDriver);
Sqlcom.Parameters.AddWithValue("@RemoveDriver",RemoveDriver);
Sqlcom.Parameters.AddWithValue("@AddTrip",AddTrip);
Sqlcom.Parameters.AddWithValue("@EditTrip",EditTrip);
Sqlcom.Parameters.AddWithValue("@RemoveTrip",RemoveTrip);
Sqlcom.Parameters.AddWithValue("@BookTicket",BookTicket);
Sqlcom.Parameters.AddWithValue("@ExtraditionTicket",ExtraditionTicket);
Sqlcom.Parameters.AddWithValue("@AddCar",AddCar);
Sqlcom.Parameters.AddWithValue("@EditCar",EditCar);
Sqlcom.Parameters.AddWithValue("@RemoveCar",RemoveCar);
Sqlcom.Parameters.AddWithValue("@InputOutput",InputOutput);
Sqlcom.Parameters.AddWithValue("@ManageDriver",ManageDriver);

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

	 public DataTable DL_GetList_Permission()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_Permission",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_Search_Permission(int PermissionID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_Permission",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@PermissionID",PermissionID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_SearchByField_Permission(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_Permission",Scon.Open());
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
