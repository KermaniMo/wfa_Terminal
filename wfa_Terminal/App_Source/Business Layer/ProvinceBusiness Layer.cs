using System.Data;
 


class BusinessProvince
{

	public int Insert(Province  ObjProvince) 
	{
		DataProvince  objData = new DataProvince();
		return  objData.DL_Insert_Province(ObjProvince.ProvinceName );
	}

	public int Update(Province  ObjProvince) 
	{
		DataProvince  objData = new DataProvince();
		return  objData.DL_Update_Province(ObjProvince.ProvinceID, ObjProvince.ProvinceName );
	}

	public int Delete(Province  ObjProvince) 
	{
		DataProvince  objData = new DataProvince();
		return  objData.DL_Delete_Province(ObjProvince.ProvinceID);
	}

	public  DataTable GetList( ) 
	{
		DataProvince  objData = new DataProvince();
		return  objData.DL_GetList_Province();
	}

	public  DataTable Search(Province  ObjProvince) 
	{
		DataProvince  objData = new DataProvince();
		return  objData.DL_Search_Province(ObjProvince.ProvinceID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataProvince  objData = new DataProvince();
		return  objData.DL_SearchByField_Province(FieldName,value);
	}
	//-----------------------------------
	public int GroupInsert(DataTable dtable)
    {
		DataProvince obj_DataProvince = new DataProvince();
		return obj_DataProvince.DL_GroupInsert_Province(dtable);
	}


}// End Class
