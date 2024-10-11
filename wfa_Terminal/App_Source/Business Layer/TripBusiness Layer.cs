using System.Data;
 


class BusinessTrip
{

	public int Insert(Trip  ObjTrip) 
	{
		DataTrip  objData = new DataTrip();
		return  objData.DL_Insert_Trip(ObjTrip.fi_ID_FK_tbl_Driver, ObjTrip.se_ID_FK_tbl_Driver, ObjTrip.Or_ID_FK_tbl_City, ObjTrip.De_ID_FK_tbl_City, ObjTrip.ID_FK_tbl_Car, ObjTrip.TripPrice, ObjTrip.TripCapacity, ObjTrip.TripDateOfMove, ObjTrip.TripDateOfArrive, ObjTrip.TripStatus, ObjTrip.TripDescription );
	}

	public int Update(Trip  ObjTrip) 
	{
		DataTrip  objData = new DataTrip();
		return  objData.DL_Update_Trip(ObjTrip.TripID, ObjTrip.fi_ID_FK_tbl_Driver, ObjTrip.se_ID_FK_tbl_Driver, ObjTrip.Or_ID_FK_tbl_City, ObjTrip.De_ID_FK_tbl_City, ObjTrip.ID_FK_tbl_Car, ObjTrip.TripPrice, ObjTrip.TripCapacity, ObjTrip.TripDateOfMove, ObjTrip.TripDateOfArrive, ObjTrip.TripStatus, ObjTrip.TripDescription );
	}

	public int Delete(Trip  ObjTrip) 
	{
		DataTrip  objData = new DataTrip();
		return  objData.DL_Delete_Trip(ObjTrip.TripID);
	}

	public  DataTable GetList( ) 
	{
		DataTrip  objData = new DataTrip();
		return  objData.DL_GetList_Trip();
	}

	public  DataTable Search(Trip  ObjTrip) 
	{
		DataTrip  objData = new DataTrip();
		return  objData.DL_Search_Trip(ObjTrip.TripID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataTrip  objData = new DataTrip();
		return  objData.DL_SearchByField_Trip(FieldName,value);
	}

}// End Class
