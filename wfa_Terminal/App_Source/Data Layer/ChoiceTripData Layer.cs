using System.Data;
using System.Data.SqlClient;
using System;

public class DataChoiceTrip
{

	public int DL_Insert_ChoiceTrip(string ChoiceTripTicketCode, int ID_FK_tbl_Passenger, int ID_FK_tbl_Trip, int ID_FK_tbl_Bank, int ID_FK_tbl_PayType, short ChoiceTripSeatNumber, decimal ChoiceTripPrice, string ChoiceTripDateOfBook, bool ChoiceTripTicketState)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Insert_ChoiceTrip";
			Sqlcom.Parameters.AddWithValue("@ChoiceTripTicketCode", ChoiceTripTicketCode);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Passenger", ID_FK_tbl_Passenger);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Trip", ID_FK_tbl_Trip);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Bank", ID_FK_tbl_Bank);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_PayType", ID_FK_tbl_PayType);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripSeatNumber", ChoiceTripSeatNumber);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripPrice", ChoiceTripPrice);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripDateOfBook", ChoiceTripDateOfBook);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripTicketState", ChoiceTripTicketState);

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

	public int DL_Delete_ChoiceTrip(int ChoiceTripID)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Delete_ChoiceTrip";
			Sqlcom.Parameters.AddWithValue("@ChoiceTripID", ChoiceTripID);
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

	public int DL_Update_ChoiceTrip(int ChoiceTripID, string ChoiceTripTicketCode, int ID_FK_tbl_Passenger, int ID_FK_tbl_Trip, int ID_FK_tbl_Bank, int ID_FK_tbl_PayType, short ChoiceTripSeatNumber, decimal ChoiceTripPrice, string ChoiceTripDateOfBook, bool ChoiceTripTicketState)
	{
		try
		{
			SqlCon Scon = new SqlCon();
			SqlCommand Sqlcom = new SqlCommand();
			Sqlcom.CommandType = CommandType.StoredProcedure;
			Sqlcom.CommandText = "sp_Update_ChoiceTrip";
			Sqlcom.Parameters.AddWithValue("@ChoiceTripID", ChoiceTripID);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripTicketCode", ChoiceTripTicketCode);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Passenger", ID_FK_tbl_Passenger);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Trip", ID_FK_tbl_Trip);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_Bank", ID_FK_tbl_Bank);
			Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_PayType", ID_FK_tbl_PayType);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripSeatNumber", ChoiceTripSeatNumber);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripPrice", ChoiceTripPrice);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripDateOfBook", ChoiceTripDateOfBook);
			Sqlcom.Parameters.AddWithValue("@ChoiceTripTicketState", ChoiceTripTicketState);

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

	public DataTable DL_GetList_ChoiceTrip()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_ChoiceTrip", Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	public DataTable DL_Search_ChoiceTrip(int ChoiceTripID)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_ChoiceTrip", Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ChoiceTripID", ChoiceTripID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	public DataTable DL_SearchByField_ChoiceTrip(string FieldName, string value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_ChoiceTrip", Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName);
		Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value);
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable;
	}

	//-----------------------------------------------------
	public int DL_FreeNumber_ChoiceTrip(int ID_FK_Trip, int SeatNumber ,ref DataTable dtable_Test)
    {
        SqlCon Scon = new SqlCon();
        SqlDataAdapter Sqlda = new SqlDataAdapter("sp_FreeSeatNumber_ChoiceTrip", Scon.Open());
        Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        Sqlda.SelectCommand.Parameters.AddWithValue("@ID_FK_Trip", ID_FK_Trip);
        Sqlda.SelectCommand.Parameters.AddWithValue("@SeatNumber", SeatNumber);
        Sqlda.SelectCommand.Parameters.Add("@R",SqlDbType.Int).Direction=ParameterDirection.ReturnValue;
        Sqlda.SelectCommand.ExecuteNonQuery();
        int R =int.Parse(Sqlda.SelectCommand.Parameters["@R"].Value.ToString());
        Sqlda.Fill(dtable_Test);
        Scon.Close();
        return R;
    }
    //----------------------------
    public int DL_CheckTicketCode_ChoiceTrip(string code)
    {
        SqlCon Scon = new SqlCon();
        SqlCommand Sqlcom = new SqlCommand();
        Sqlcom.CommandType = CommandType.StoredProcedure;
        Sqlcom.CommandText = "sp_CheckTicketCode_ChoiceTrip";
        Sqlcom.Parameters.AddWithValue("@Code", code);
        Sqlcom.Parameters.Add("@R", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
        Sqlcom.Connection = Scon.Open();
         Sqlcom.ExecuteNonQuery();
		int R =int.Parse(Sqlcom.Parameters["@R"].Value.ToString());
		Scon.Close();
        return R;
    }

}
//----------------------------------End
