using System.Data;
 


class BusinessCar
{

	public int Insert(Car  ObjCar) 
	{
		DataCar  objData = new DataCar();
		return  objData.DL_Insert_Car(ObjCar.OwnerNationalCode, ObjCar.OwnerName, ObjCar.OwnerLastName, ObjCar.OwnerMobileNumber, ObjCar.OwnerSex, ObjCar.OwnerBirthday, ObjCar.OwnerEmail, ObjCar.CarRegister, ObjCar.CarBrand, ObjCar.ID_FK_tbl_CarType, ObjCar.CarModel, ObjCar.CarTag, ObjCar.CarDateOfManufacture, ObjCar.CarCapacity );
	}

	public int Update(Car  ObjCar) 
	{
		DataCar  objData = new DataCar();
		return  objData.DL_Update_Car(ObjCar.CarID, ObjCar.OwnerNationalCode, ObjCar.OwnerName, ObjCar.OwnerLastName, ObjCar.OwnerMobileNumber, ObjCar.OwnerSex, ObjCar.OwnerBirthday, ObjCar.OwnerEmail, ObjCar.CarRegister, ObjCar.CarBrand, ObjCar.ID_FK_tbl_CarType, ObjCar.CarModel, ObjCar.CarTag, ObjCar.CarDateOfManufacture, ObjCar.CarCapacity );
	}

	public int Delete(Car  ObjCar) 
	{
		DataCar  objData = new DataCar();
		return  objData.DL_Delete_Car(ObjCar.CarID);
	}

	public  DataTable GetList( ) 
	{
		DataCar  objData = new DataCar();
		return  objData.DL_GetList_Car();
	}

	public  DataTable Search(Car  ObjCar) 
	{
		DataCar  objData = new DataCar();
		return  objData.DL_Search_Car(ObjCar.CarID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataCar  objData = new DataCar();
		return  objData.DL_SearchByField_Car(FieldName,value);
	}

}// End Class
