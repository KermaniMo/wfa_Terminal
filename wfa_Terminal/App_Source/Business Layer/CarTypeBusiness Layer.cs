using System.Data;
 


class BusinessCarType
{

	public int Insert(CarType  ObjCarType) 
	{
		DataCarType  objData = new DataCarType();
		return  objData.DL_Insert_CarType(ObjCarType.TypeName );
	}

	public int Update(CarType  ObjCarType) 
	{
		DataCarType  objData = new DataCarType();
		return  objData.DL_Update_CarType(ObjCarType.CarsTypeID, ObjCarType.TypeName );
	}

	public int Delete(CarType  ObjCarType) 
	{
		DataCarType  objData = new DataCarType();
		return  objData.DL_Delete_CarType(ObjCarType.CarsTypeID);
	}

	public  DataTable GetList( ) 
	{
		DataCarType  objData = new DataCarType();
		return  objData.DL_GetList_CarType();
	}

	public  DataTable Search(CarType  ObjCarType) 
	{
		DataCarType  objData = new DataCarType();
		return  objData.DL_Search_CarType(ObjCarType.CarsTypeID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataCarType  objData = new DataCarType();
		return  objData.DL_SearchByField_CarType(FieldName,value);
	}

}// End Class
