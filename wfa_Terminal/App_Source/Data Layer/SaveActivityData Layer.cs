using System.Data;
using System.Data.SqlClient;

public class DataSaveActivity
{

	public int DL_Insert_SaveActivity(int ID_FK_tbl_Driver, int ID_FK_tbl_ManageDriver, string SaveActivityStatus, string SaveActivityDateOfLeave, string SaveActivityDateOfBack, string SaveActivityDescription)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Insert_SaveActivity";
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Driver", ID_FK_tbl_Driver);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_ManageDriver", ID_FK_tbl_ManageDriver);
			Sqlcom.Parameters.AddWithValue("@SaveActivityStatus", SaveActivityStatus);
			Sqlcom.Parameters.AddWithValue("@SaveActivityDateOfLeave", SaveActivityDateOfLeave);
			Sqlcom.Parameters.AddWithValue("@SaveActivityDateOfBack", SaveActivityDateOfBack);
			Sqlcom.Parameters.AddWithValue("@SaveActivityDescription", SaveActivityDescription);

			Sqlcom.Parameters.Add("@R", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
			Sqlcom.Connection = Scon.Open();
			int R = 0;
			Sqlcom.ExecuteNonQuery();
			R = int.Parse(Sqlcom.Parameters["@R"].Value.ToString());
			Scon.Close();
			return R;
		}
		catch
		{
			return 0;
		}
	}

	public int DL_Delete_SaveActivity(int SaveActivityID)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Delete_SaveActivity";
			Sqlcom.Parameters.AddWithValue("@SaveActivityID", SaveActivityID);
			Sqlcom.Connection = Scon.Open();
			int R = Sqlcom.ExecuteNonQuery();
			Scon.Close();
			return R;
		}
		catch
		{
			return 0;
		}
	}

	public int DL_Update_SaveActivity(int SaveActivityID, int ID_FK_tbl_Driver, int ID_FK_tbl_ManageDriver, string SaveActivityStatus, string SaveActivityDateOfLeave, string SaveActivityDateOfBack, string SaveActivityDescription)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Update_SaveActivity";
			Sqlcom.Parameters.AddWithValue("@SaveActivityID", SaveActivityID);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Driver", ID_FK_tbl_Driver);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_ManageDriver", ID_FK_tbl_ManageDriver);
			Sqlcom.Parameters.AddWithValue("@SaveActivityStatus", SaveActivityStatus);
			Sqlcom.Parameters.AddWithValue("@SaveActivityDateOfLeave", SaveActivityDateOfLeave);
			Sqlcom.Parameters.AddWithValue("@SaveActivityDateOfBack", SaveActivityDateOfBack);
			Sqlcom.Parameters.AddWithValue("@SaveActivityDescription", SaveActivityDescription);

			Sqlcom.Parameters.Add("@R", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
			Sqlcom.Connection = Scon.Open();
			Sqlcom.ExecuteNonQuery();
			int R = int.Parse(Sqlcom.Parameters["@R"].Value.ToString());
			Scon.Close();
			return R;
		}
		catch
		{
			return 0;
		}
	}

	public DataTable DL_GetList_SaveActivity()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_SaveActivity", Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	public DataTable DL_Search_SaveActivity(int SaveActivityID)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_SaveActivity", Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@SaveActivityID", SaveActivityID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	public DataTable DL_SearchByField_SaveActivity(string FieldName, string value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_SaveActivity", Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName);
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value);
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}
}
//----------------------------------End

