using System.Data;
 


class BusinessExtraditionTicket
{

	public int Insert(ExtraditionTicket  ObjExtraditionTicket) 
	{
		DataExtraditionTicket  objData = new DataExtraditionTicket();
		return  objData.DL_Insert_ExtraditionTicket(ObjExtraditionTicket.ID_FK_tbl_ChoiceTrip, ObjExtraditionTicket.ExtraditionTicketRefundAmount, ObjExtraditionTicket.ExtraditionTicketDateOfCancel );
	}

	public int Update(ExtraditionTicket  ObjExtraditionTicket) 
	{
		DataExtraditionTicket  objData = new DataExtraditionTicket();
		return  objData.DL_Update_ExtraditionTicket(ObjExtraditionTicket.ExtraditionTicketID, ObjExtraditionTicket.ID_FK_tbl_ChoiceTrip, ObjExtraditionTicket.ExtraditionTicketRefundAmount, ObjExtraditionTicket.ExtraditionTicketDateOfCancel );
	}

	public int Delete(ExtraditionTicket  ObjExtraditionTicket) 
	{
		DataExtraditionTicket  objData = new DataExtraditionTicket();
		return  objData.DL_Delete_ExtraditionTicket(ObjExtraditionTicket.ExtraditionTicketID);
	}

	public  DataTable GetList( ) 
	{
		DataExtraditionTicket  objData = new DataExtraditionTicket();
		return  objData.DL_GetList_ExtraditionTicket();
	}

	public  DataTable Search(ExtraditionTicket  ObjExtraditionTicket) 
	{
		DataExtraditionTicket  objData = new DataExtraditionTicket();
		return  objData.DL_Search_ExtraditionTicket(ObjExtraditionTicket.ExtraditionTicketID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataExtraditionTicket  objData = new DataExtraditionTicket();
		return  objData.DL_SearchByField_ExtraditionTicket(FieldName,value);
	}

}// End Class
