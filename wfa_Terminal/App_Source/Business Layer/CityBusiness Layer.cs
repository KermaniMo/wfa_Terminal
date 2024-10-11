using System.Data;
 


class BusinessCity
{

	public int Insert(City  ObjCity) 
	{
		DataCity  objData = new DataCity();
		return  objData.DL_Insert_City(ObjCity.CityName, ObjCity.ID_FK_tbl_Province );
	}

	public int Update(City  ObjCity) 
	{
		DataCity  objData = new DataCity();
		return  objData.DL_Update_City(ObjCity.CityID, ObjCity.CityName, ObjCity.ID_FK_tbl_Province );
	}

	public int Delete(City  ObjCity) 
	{
		DataCity  objData = new DataCity();
		return  objData.DL_Delete_City(ObjCity.CityID);
	}

	public  DataTable GetList( ) 
	{
		DataCity  objData = new DataCity();
		return  objData.DL_GetList_City();
	}

	public  DataTable Search(City  ObjCity) 
	{
		DataCity  objData = new DataCity();
		return  objData.DL_Search_City(ObjCity.CityID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataCity  objData = new DataCity();
		return  objData.DL_SearchByField_City(FieldName,value);
	}
	//-------------------------------------
	public int GroupInsert(DataTable dtable)
	{
		DataCity obj_DataCity = new DataCity();
		return obj_DataCity.DL_GroupInsert_City(dtable);
	}


}// End Class
