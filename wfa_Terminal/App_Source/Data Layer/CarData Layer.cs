using System.Data;
using System.Data.SqlClient;
using System;

public class DataCar
{

    public int DL_Insert_Car(string OwnerNationalCode, string OwnerName, string OwnerLastName, string OwnerMobileNumber, bool OwnerSex, string OwnerBirthday, string OwnerEmail, DateTime CarRegister, string CarBrand, int ID_FK_tbl_CarType, string CarModel, string CarTag, string CarDateOfManufacture, short CarCapacity)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Insert_Car";
            Sqlcom.Parameters.AddWithValue("@OwnerNationalCode", OwnerNationalCode);
            Sqlcom.Parameters.AddWithValue("@OwnerName", OwnerName);
            Sqlcom.Parameters.AddWithValue("@OwnerLastName", OwnerLastName);
            Sqlcom.Parameters.AddWithValue("@OwnerMobileNumber", OwnerMobileNumber);
            Sqlcom.Parameters.AddWithValue("@OwnerSex", OwnerSex);
            Sqlcom.Parameters.AddWithValue("@OwnerBirthday", OwnerBirthday);
            Sqlcom.Parameters.AddWithValue("@OwnerEmail", OwnerEmail);
            Sqlcom.Parameters.AddWithValue("@CarRegister", CarRegister);
            Sqlcom.Parameters.AddWithValue("@CarBrand", CarBrand);
            Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_CarType", ID_FK_tbl_CarType);
            Sqlcom.Parameters.AddWithValue("@CarModel", CarModel);
            Sqlcom.Parameters.AddWithValue("@CarTag", CarTag);
            Sqlcom.Parameters.AddWithValue("@CarDateOfManufacture", CarDateOfManufacture);
            Sqlcom.Parameters.AddWithValue("@CarCapacity", CarCapacity);
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

    public int DL_Delete_Car(int CarID)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Delete_Car";
            Sqlcom.Parameters.AddWithValue("@CarID", CarID);
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

    public int DL_Update_Car(int CarID, string OwnerNationalCode, string OwnerName, string OwnerLastName, string OwnerMobileNumber, bool OwnerSex, string OwnerBirthday, string OwnerEmail, DateTime CarRegister, string CarBrand, int ID_FK_tbl_CarType, string CarModel, string CarTag, string CarDateOfManufacture, short CarCapacity)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Update_Car";
            Sqlcom.Parameters.AddWithValue("@CarID", CarID);
            Sqlcom.Parameters.AddWithValue("@OwnerNationalCode", OwnerNationalCode);
            Sqlcom.Parameters.AddWithValue("@OwnerName", OwnerName);
            Sqlcom.Parameters.AddWithValue("@OwnerLastName", OwnerLastName);
            Sqlcom.Parameters.AddWithValue("@OwnerMobileNumber", OwnerMobileNumber);
            Sqlcom.Parameters.AddWithValue("@OwnerSex", OwnerSex);
            Sqlcom.Parameters.AddWithValue("@OwnerBirthday", OwnerBirthday);
            Sqlcom.Parameters.AddWithValue("@OwnerEmail", OwnerEmail);
            Sqlcom.Parameters.AddWithValue("@CarRegister", CarRegister);
            Sqlcom.Parameters.AddWithValue("@CarBrand", CarBrand);
            Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_CarType", ID_FK_tbl_CarType);
            Sqlcom.Parameters.AddWithValue("@CarModel", CarModel);
            Sqlcom.Parameters.AddWithValue("@CarTag", CarTag);
            Sqlcom.Parameters.AddWithValue("@CarDateOfManufacture", CarDateOfManufacture);
            Sqlcom.Parameters.AddWithValue("@CarCapacity", CarCapacity);
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

    public DataTable DL_GetList_Car()
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_Car", Scon.Open());
        DataTable DTable = new DataTable();
        Sqlda.Fill(DTable);
        Scon.Close();
        return DTable;
    }

    public DataTable DL_Search_Car(int CarID)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_Car", Scon.Open());
        Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable DTable = new DataTable();
        Sqlda.SelectCommand.Parameters.AddWithValue("@CarID", CarID);
        Sqlda.Fill(DTable);
        Scon.Close();
        return DTable;
    }

    public DataTable DL_SearchByField_Car(string FieldName, string value)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_Car", Scon.Open());
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
