using System.Data;
using System.Data.SqlClient;
using System;

public class DataTrip
{

    public int DL_Insert_Trip(int fi_ID_FK_tbl_Driver, int se_ID_FK_tbl_Driver, int Or_ID_FK_tbl_City, int De_ID_FK_tbl_City, int ID_FK_tbl_Car, decimal TripPrice, short TripCapacity, string TripDateOfMove, string TripDateOfArrive, bool TripStatus, string TripDescription)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Insert_Trip";
            Sqlcom.Parameters.AddWithValue("@fi_ID_FK_tbl_Driver", fi_ID_FK_tbl_Driver);
            Sqlcom.Parameters.AddWithValue("@se_ID_FK_tbl_Driver", se_ID_FK_tbl_Driver);
            Sqlcom.Parameters.AddWithValue("@Or_ID_FK_tbl_City", Or_ID_FK_tbl_City);
            Sqlcom.Parameters.AddWithValue("@De_ID_FK_tbl_City", De_ID_FK_tbl_City);
            Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Car", ID_FK_tbl_Car);
            Sqlcom.Parameters.AddWithValue("@TripPrice", TripPrice);
            Sqlcom.Parameters.AddWithValue("@TripCapacity", TripCapacity);
            Sqlcom.Parameters.AddWithValue("@TripDateOfMove", TripDateOfMove);
            Sqlcom.Parameters.AddWithValue("@TripDateOfArrive", TripDateOfArrive);
            Sqlcom.Parameters.AddWithValue("@TripStatus", TripStatus);
            Sqlcom.Parameters.AddWithValue("@TripDescription", TripDescription);

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

    public int DL_Delete_Trip(int TripID)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Delete_Trip";
            Sqlcom.Parameters.AddWithValue("@TripID", TripID);
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

    public int DL_Update_Trip(int TripID, int fi_ID_FK_tbl_Driver, int se_ID_FK_tbl_Driver, int Or_ID_FK_tbl_City, int De_ID_FK_tbl_City, int ID_FK_tbl_Car, decimal TripPrice, short TripCapacity, string TripDateOfMove, string TripDateOfArrive, bool TripStatus, string TripDescription)
    {
        try
        {
            SqlCon Scon = new SqlCon();
            SqlCommand Sqlcom = new SqlCommand();
            Sqlcom.CommandType = CommandType.StoredProcedure;
            Sqlcom.CommandText = "sp_Update_Trip";
            Sqlcom.Parameters.AddWithValue("@TripID", TripID);
            Sqlcom.Parameters.AddWithValue("@fi_ID_FK_tbl_Driver", fi_ID_FK_tbl_Driver);
            Sqlcom.Parameters.AddWithValue("@se_ID_FK_tbl_Driver", se_ID_FK_tbl_Driver);
            Sqlcom.Parameters.AddWithValue("@Or_ID_FK_tbl_City", Or_ID_FK_tbl_City);
            Sqlcom.Parameters.AddWithValue("@De_ID_FK_tbl_City", De_ID_FK_tbl_City);
            Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Car", ID_FK_tbl_Car);
            Sqlcom.Parameters.AddWithValue("@TripPrice", TripPrice);
            Sqlcom.Parameters.AddWithValue("@TripCapacity", TripCapacity);
            Sqlcom.Parameters.AddWithValue("@TripDateOfMove", TripDateOfMove);
            Sqlcom.Parameters.AddWithValue("@TripDateOfArrive", TripDateOfArrive);
            Sqlcom.Parameters.AddWithValue("@TripStatus", TripStatus);
            Sqlcom.Parameters.AddWithValue("@TripDescription", TripDescription);

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

    public DataTable DL_GetList_Trip()
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_Trip", Scon.Open());
        DataTable DTable = new DataTable();
        Sqlda.Fill(DTable);
        Scon.Close();
        return DTable;
    }

    public DataTable DL_Search_Trip(int TripID)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_Trip", Scon.Open());
        Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable DTable = new DataTable();
        Sqlda.SelectCommand.Parameters.AddWithValue("@TripID", TripID);
        Sqlda.Fill(DTable);
        Scon.Close();
        return DTable;
    }

    public DataTable DL_SearchByField_Trip(string FieldName, string value)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_Trip", Scon.Open());
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
