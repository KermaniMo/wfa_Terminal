using System.Data;
using System.Data.SqlClient;
using System;

public class DataPassenger
{

    public int DL_Insert_Passenger(string PassengerNationalCode, string PassengerName, string PassengerLastName, string PassengerMobileNumber, bool PassengerSex, string PassengerBirthday, string PassengerEmail, string PassengerRegister)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Insert_Passenger";
            Sqlcom.Parameters.AddWithValue("@PassengerNationalCode", PassengerNationalCode);
            Sqlcom.Parameters.AddWithValue("@PassengerName", PassengerName);
            Sqlcom.Parameters.AddWithValue("@PassengerLastName", PassengerLastName);
            Sqlcom.Parameters.AddWithValue("@PassengerMobileNumber", PassengerMobileNumber);
            Sqlcom.Parameters.AddWithValue("@PassengerSex", PassengerSex);
            Sqlcom.Parameters.AddWithValue("@PassengerBirthday", PassengerBirthday);
            Sqlcom.Parameters.AddWithValue("@PassengerEmail", PassengerEmail);
            Sqlcom.Parameters.AddWithValue("@PassengerRegister", PassengerRegister);

            Sqlcom.Connection = Scon.Open();
            int R = 0;
            R = Sqlcom.ExecuteNonQuery();
            Scon.Close();
            return R;
        }
        catch
        {
            return 0;
        }
    }

    public int DL_Delete_Passenger(int PassengerID)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Delete_Passenger";
            Sqlcom.Parameters.AddWithValue("@PassengerID", PassengerID);
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

    public int DL_Update_Passenger(int PassengerID, string PassengerNationalCode, string PassengerName, string PassengerLastName, string PassengerMobileNumber, bool PassengerSex, string PassengerBirthday, string PassengerEmail, string PassengerRegister)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Update_Passenger";
            Sqlcom.Parameters.AddWithValue("@PassengerID", PassengerID);
            Sqlcom.Parameters.AddWithValue("@PassengerNationalCode", PassengerNationalCode);
            Sqlcom.Parameters.AddWithValue("@PassengerName", PassengerName);
            Sqlcom.Parameters.AddWithValue("@PassengerLastName", PassengerLastName);
            Sqlcom.Parameters.AddWithValue("@PassengerMobileNumber", PassengerMobileNumber);
            Sqlcom.Parameters.AddWithValue("@PassengerSex", PassengerSex);
            Sqlcom.Parameters.AddWithValue("@PassengerBirthday", PassengerBirthday);
            Sqlcom.Parameters.AddWithValue("@PassengerEmail", PassengerEmail);
            Sqlcom.Parameters.AddWithValue("@PassengerRegister", PassengerRegister);

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

    public DataTable DL_GetList_Passenger()
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_Passenger", Scon.Open());
        DataTable DTable = new DataTable();
        Sqlda.Fill(DTable);
        Scon.Close();
        return DTable;
    }

    public DataTable DL_Search_Passenger(int PassengerID)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_Passenger", Scon.Open());
        Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable DTable = new DataTable();
        Sqlda.SelectCommand.Parameters.AddWithValue("@PassengerID", PassengerID);
        Sqlda.Fill(DTable);
        Scon.Close();
        return DTable;
    }

    public DataTable DL_SearchByField_Passenger(string FieldName, string value)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_Passenger", Scon.Open());
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
