using System.Data;
using System.Data.SqlClient;
using System.Threading;

public class DataManageDriver
{

	public int DL_Insert_ManageDriver(int ID_FK_tbl_Driver, string ManageDriverStatus, string ManageDriverDateOfLeave, string ManageDriverDateOfBack, string ManageDriverDescription)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Insert_ManageDriver";
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Driver", ID_FK_tbl_Driver);
			Sqlcom.Parameters.AddWithValue("@ManageDriverStatus", ManageDriverStatus);
			Sqlcom.Parameters.AddWithValue("@ManageDriverDateOfLeave", ManageDriverDateOfLeave);
			Sqlcom.Parameters.AddWithValue("@ManageDriverDateOfBack", ManageDriverDateOfBack);
			Sqlcom.Parameters.AddWithValue("@ManageDriverDescription", ManageDriverDescription);

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

	public int DL_Delete_ManageDriver(int ManageDriverID)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Delete_ManageDriver";
			Sqlcom.Parameters.AddWithValue("@ManageDriverID", ManageDriverID);
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

	public int DL_Update_ManageDriver(int ManageDriverID, int ID_FK_tbl_Driver, string ManageDriverStatus, string ManageDriverDateOfLeave, string ManageDriverDateOfBack, string ManageDriverDescription)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Update_ManageDriver";
			Sqlcom.Parameters.AddWithValue("@ManageDriverID", ManageDriverID);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Driver", ID_FK_tbl_Driver);
			Sqlcom.Parameters.AddWithValue("@ManageDriverStatus", ManageDriverStatus);
			Sqlcom.Parameters.AddWithValue("@ManageDriverDateOfLeave", ManageDriverDateOfLeave);
			Sqlcom.Parameters.AddWithValue("@ManageDriverDateOfBack", ManageDriverDateOfBack);
			Sqlcom.Parameters.AddWithValue("@ManageDriverDescription", ManageDriverDescription);
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

	public DataTable DL_GetList_ManageDriver()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_ManageDriver", Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	public DataTable DL_Search_ManageDriver(int ManageDriverID)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_ManageDriver", Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ManageDriverID", ManageDriverID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	public DataTable DL_SearchByField_ManageDriver(string FieldName, string value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_ManageDriver", Scon.Open());
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

