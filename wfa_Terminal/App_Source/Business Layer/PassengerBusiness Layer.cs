using System.Data;
 


class BusinessPassenger
{

	public int Insert(Passenger  ObjPassenger) 
	{
		DataPassenger  objData = new DataPassenger();
		return  objData.DL_Insert_Passenger(ObjPassenger.PassengerNationalCode, ObjPassenger.PassengerName, ObjPassenger.PassengerLastName, ObjPassenger.PassengerMobileNumber, ObjPassenger.PassengerSex, ObjPassenger.PassengerBirthday, ObjPassenger.PassengerEmail, ObjPassenger.PassengerRegister );
	}

	public int Update(Passenger  ObjPassenger) 
	{
		DataPassenger  objData = new DataPassenger();
		return  objData.DL_Update_Passenger(ObjPassenger.PassengerID, ObjPassenger.PassengerNationalCode, ObjPassenger.PassengerName, ObjPassenger.PassengerLastName, ObjPassenger.PassengerMobileNumber, ObjPassenger.PassengerSex, ObjPassenger.PassengerBirthday, ObjPassenger.PassengerEmail, ObjPassenger.PassengerRegister );
	}

	public int Delete(Passenger  ObjPassenger) 
	{
		DataPassenger  objData = new DataPassenger();
		return  objData.DL_Delete_Passenger(ObjPassenger.PassengerID);
	}

	public  DataTable GetList( ) 
	{
		DataPassenger  objData = new DataPassenger();
		return  objData.DL_GetList_Passenger();
	}

	public  DataTable Search(Passenger  ObjPassenger) 
	{
		DataPassenger  objData = new DataPassenger();
		return  objData.DL_Search_Passenger(ObjPassenger.PassengerID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataPassenger  objData = new DataPassenger();
		return  objData.DL_SearchByField_Passenger(FieldName,value);
	}

}// End Class
