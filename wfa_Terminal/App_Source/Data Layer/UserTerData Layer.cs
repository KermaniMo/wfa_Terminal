using System.Data; 
 using System.Data.SqlClient;
 using System; 

public class DataUserTer
{

	 public int DL_Insert_UserTer(string UserNamePersian, string UserLastNamePersian, string UserName, int ID_FK_tbl_Permission, int ID_FK_tbl_SecurityQuestion, string UserAnswer  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Insert_UserTer";		
		Sqlcom.Parameters.AddWithValue("@UserNamePersian",UserNamePersian);
Sqlcom.Parameters.AddWithValue("@UserLastNamePersian",UserLastNamePersian);
Sqlcom.Parameters.AddWithValue("@UserName",UserName);
Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Permission",ID_FK_tbl_Permission);
Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_SecurityQuestion",ID_FK_tbl_SecurityQuestion);
Sqlcom.Parameters.AddWithValue("@UserAnswer",UserAnswer);
		
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

	 public int DL_Delete_UserTer(int UserID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Delete_UserTer";
		Sqlcom.Parameters.AddWithValue("@UserID",UserID);
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

	 public int DL_Update_UserTer(int UserID, string UserNamePersian, string UserLastNamePersian, string UserName, int ID_FK_tbl_Permission, int ID_FK_tbl_SecurityQuestion, string UserAnswer  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Update_UserTer";
		Sqlcom.Parameters.AddWithValue("@UserID",UserID);
Sqlcom.Parameters.AddWithValue("@UserNamePersian",UserNamePersian);
Sqlcom.Parameters.AddWithValue("@UserLastNamePersian",UserLastNamePersian);
Sqlcom.Parameters.AddWithValue("@UserName",UserName);
Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Permission",ID_FK_tbl_Permission);
Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_SecurityQuestion",ID_FK_tbl_SecurityQuestion);
Sqlcom.Parameters.AddWithValue("@UserAnswer",UserAnswer);

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

	 public DataTable DL_GetList_UserTer()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_UserTer",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_Search_UserTer(int UserID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_UserTer",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@UserID",UserID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_SearchByField_UserTer(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_UserTer",Scon.Open());
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
