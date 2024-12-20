using System.Data; 
 using System.Data.SqlClient;
 using System; 

public class DataExtraditionTicket
{

	 public int DL_Insert_ExtraditionTicket(int ID_FK_tbl_ChoiceTrip, decimal ExtraditionTicketRefundAmount, DateTime ExtraditionTicketDateOfCancel  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Insert_ExtraditionTicket";		
		Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_ChoiceTrip",ID_FK_tbl_ChoiceTrip);
Sqlcom.Parameters.AddWithValue("@ExtraditionTicketRefundAmount",ExtraditionTicketRefundAmount);
Sqlcom.Parameters.AddWithValue("@ExtraditionTicketDateOfCancel",ExtraditionTicketDateOfCancel);
		
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

	 public int DL_Delete_ExtraditionTicket(int ExtraditionTicketID )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Delete_ExtraditionTicket";
		Sqlcom.Parameters.AddWithValue("@ExtraditionTicketID",ExtraditionTicketID);
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

	 public int DL_Update_ExtraditionTicket(int ExtraditionTicketID, int ID_FK_tbl_ChoiceTrip, decimal ExtraditionTicketRefundAmount, DateTime ExtraditionTicketDateOfCancel  )
	{
		try{
		SqlCon Scon = new SqlCon();
		SqlCommand Sqlcom = new SqlCommand();
		Sqlcom.CommandType = CommandType.StoredProcedure;
		Sqlcom.CommandText ="sp_Update_ExtraditionTicket";
		Sqlcom.Parameters.AddWithValue("@ExtraditionTicketID",ExtraditionTicketID);
Sqlcom.Parameters.AddWithValue("@ID_FK_tbl_ChoiceTrip",ID_FK_tbl_ChoiceTrip);
Sqlcom.Parameters.AddWithValue("@ExtraditionTicketRefundAmount",ExtraditionTicketRefundAmount);
Sqlcom.Parameters.AddWithValue("@ExtraditionTicketDateOfCancel",ExtraditionTicketDateOfCancel);

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

	 public DataTable DL_GetList_ExtraditionTicket()
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_GetList_ExtraditionTicket",Scon.Open());
		DataTable DTable = new DataTable();
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_Search_ExtraditionTicket(int ExtraditionTicketID )
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_Search_ExtraditionTicket",Scon.Open());
		Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
		DataTable DTable = new DataTable();
		Sqlda.SelectCommand.Parameters.AddWithValue("@ExtraditionTicketID",ExtraditionTicketID);
		Sqlda.Fill(DTable);
		Scon.Close();
		return DTable; 
	}

	 public DataTable DL_SearchByField_ExtraditionTicket(string FieldName,string  value)
	{
		SqlCon Scon = new SqlCon();
		SqlDataAdapter Sqlda = new SqlDataAdapter("sp_SearchByField_ExtraditionTicket",Scon.Open());
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
