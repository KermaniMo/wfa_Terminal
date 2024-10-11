using System.Data;
 


class BusinessChoiceTrip
{

	public int Insert(ChoiceTrip ObjChoiceTrip)
	{
		DataChoiceTrip objData = new DataChoiceTrip();
		return objData.DL_Insert_ChoiceTrip(ObjChoiceTrip.ChoiceTripTicketCode, ObjChoiceTrip.ID_FK_tbl_Passenger, ObjChoiceTrip.ID_FK_tbl_Trip, ObjChoiceTrip.ID_FK_tbl_Bank, ObjChoiceTrip.ID_FK_tbl_PayType, ObjChoiceTrip.ChoiceTripSeatNumber, ObjChoiceTrip.ChoiceTripPrice, ObjChoiceTrip.ChoiceTripDateOfBook, ObjChoiceTrip.ChoiceTripTicketState);
	}

	public int Update(ChoiceTrip ObjChoiceTrip)
	{
		DataChoiceTrip objData = new DataChoiceTrip();
		return objData.DL_Update_ChoiceTrip(ObjChoiceTrip.ChoiceTripID, ObjChoiceTrip.ChoiceTripTicketCode, ObjChoiceTrip.ID_FK_tbl_Passenger, ObjChoiceTrip.ID_FK_tbl_Trip, ObjChoiceTrip.ID_FK_tbl_Bank, ObjChoiceTrip.ID_FK_tbl_PayType, ObjChoiceTrip.ChoiceTripSeatNumber, ObjChoiceTrip.ChoiceTripPrice, ObjChoiceTrip.ChoiceTripDateOfBook, ObjChoiceTrip.ChoiceTripTicketState);
	}

	public int Delete(ChoiceTrip ObjChoiceTrip)
	{
		DataChoiceTrip objData = new DataChoiceTrip();
		return objData.DL_Delete_ChoiceTrip(ObjChoiceTrip.ChoiceTripID);
	}

	public DataTable GetList()
	{
		DataChoiceTrip objData = new DataChoiceTrip();
		return objData.DL_GetList_ChoiceTrip();
	}

	public DataTable Search(ChoiceTrip ObjChoiceTrip)
	{
		DataChoiceTrip objData = new DataChoiceTrip();
		return objData.DL_Search_ChoiceTrip(ObjChoiceTrip.ChoiceTripID);
	}

	public DataTable SearchByField(string FieldName, string value)
	{
		DataChoiceTrip objData = new DataChoiceTrip();
		return objData.DL_SearchByField_ChoiceTrip(FieldName, value);
	}
	//-----------------------------------
	public int FreeNumber(int ID_FK_Trip, int SeatNumber, ref DataTable dtable_Test)
    {
		DataChoiceTrip obj_DataChoiceTrip = new DataChoiceTrip();
		return obj_DataChoiceTrip.DL_FreeNumber_ChoiceTrip(ID_FK_Trip,SeatNumber,ref dtable_Test);

	}
	//-----------------------------------
	public int CheckTicketCode(string code)
    {
		DataChoiceTrip obj_DataChoiceTrip = new DataChoiceTrip();
		return obj_DataChoiceTrip.DL_CheckTicketCode_ChoiceTrip(code);

	}

}// End Class
