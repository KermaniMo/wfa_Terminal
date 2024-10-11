using System.Data;
using System.Data.SqlClient;

public class DataDriver
{

	public int DL_Insert_Driver(string DriverNationalCode, string DriverPersonnelCode, string DriverLicenseNumber, string DriverName, string DriverLastName, string DriverMobileNumber, bool DriverSex, string DriverBirthday, string DriverEmail, string DriverDateEmploy, bool DriverMaritalStatuse, int ID_FK_tbl_Degree, byte DriverLicenseType, string DriverDateOfExpirationCertificate, string Address)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Insert_Driver";
			Sqlcom.Parameters.AddWithValue("@DriverNationalCode", DriverNationalCode);
			Sqlcom.Parameters.AddWithValue("@DriverPersonnelCode", DriverPersonnelCode);
			Sqlcom.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);
			Sqlcom.Parameters.AddWithValue("@DriverName", DriverName);
			Sqlcom.Parameters.AddWithValue("@DriverLastName", DriverLastName);
			Sqlcom.Parameters.AddWithValue("@DriverMobileNumber", DriverMobileNumber);
			Sqlcom.Parameters.AddWithValue("@DriverSex", DriverSex);
			Sqlcom.Parameters.AddWithValue("@DriverBirthday", DriverBirthday);
			Sqlcom.Parameters.AddWithValue("@DriverEmail", DriverEmail);
			Sqlcom.Parameters.AddWithValue("@DriverDateEmploy", DriverDateEmploy);
			Sqlcom.Parameters.AddWithValue("@DriverMaritalStatuse", DriverMaritalStatuse);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Degree", ID_FK_tbl_Degree);
			Sqlcom.Parameters.AddWithValue("@DriverLicenseType", DriverLicenseType);
			Sqlcom.Parameters.AddWithValue("@DriverDateOfExpirationCertificate", DriverDateOfExpirationCertificate);
			Sqlcom.Parameters.AddWithValue("@Address", Address);

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

	public int DL_Delete_Driver(int DriverID)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Delete_Driver";
			Sqlcom.Parameters.AddWithValue("@DriverID", DriverID);
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

	public int DL_Update_Driver(int DriverID, string DriverNationalCode, string DriverPersonnelCode, string DriverLicenseNumber, string DriverName, string DriverLastName, string DriverMobileNumber, bool DriverSex, string DriverBirthday, string DriverEmail, string DriverDateEmploy, bool DriverMaritalStatuse, int ID_FK_tbl_Degree, byte DriverLicenseType, string DriverDateOfExpirationCertificate, string Address)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Update_Driver";
			Sqlcom.Parameters.AddWithValue("@DriverID", DriverID);
			Sqlcom.Parameters.AddWithValue("@DriverNationalCode", DriverNationalCode);
			Sqlcom.Parameters.AddWithValue("@DriverPersonnelCode", DriverPersonnelCode);
			Sqlcom.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);
			Sqlcom.Parameters.AddWithValue("@DriverName", DriverName);
			Sqlcom.Parameters.AddWithValue("@DriverLastName", DriverLastName);
			Sqlcom.Parameters.AddWithValue("@DriverMobileNumber", DriverMobileNumber);
			Sqlcom.Parameters.AddWithValue("@DriverSex", DriverSex);
			Sqlcom.Parameters.AddWithValue("@DriverBirthday", DriverBirthday);
			Sqlcom.Parameters.AddWithValue("@DriverEmail", DriverEmail);
			Sqlcom.Parameters.AddWithValue("@DriverDateEmploy", DriverDateEmploy);
			Sqlcom.Parameters.AddWithValue("@DriverMaritalStatuse", DriverMaritalStatuse);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Degree", ID_FK_tbl_Degree);
			Sqlcom.Parameters.AddWithValue("@DriverLicenseType", DriverLicenseType);
			Sqlcom.Parameters.AddWithValue("@DriverDateOfExpirationCertificate", DriverDateOfExpirationCertificate);
			Sqlcom.Parameters.AddWithValue("@Address", Address);

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

	public DataTable DL_GetList_Driver()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_Driver", Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	public DataTable DL_Search_Driver(int DriverID)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_Driver", Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@DriverID", DriverID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	public DataTable DL_SearchByField_Driver(string FieldName, string value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_Driver", Scon.Open());
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

