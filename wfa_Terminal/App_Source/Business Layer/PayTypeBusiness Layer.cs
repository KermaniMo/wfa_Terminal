using System.Data;
 


class BusinessPayType
{

	public int Insert(PayType  ObjPayType) 
	{
		DataPayType  objData = new DataPayType();
		return  objData.DL_Insert_PayType(ObjPayType.PayTypeTitle );
	}

	public int Update(PayType  ObjPayType) 
	{
		DataPayType  objData = new DataPayType();
		return  objData.DL_Update_PayType(ObjPayType.PayTypeID, ObjPayType.PayTypeTitle );
	}

	public int Delete(PayType  ObjPayType) 
	{
		DataPayType  objData = new DataPayType();
		return  objData.DL_Delete_PayType(ObjPayType.PayTypeID);
	}

	public  DataTable GetList( ) 
	{
		DataPayType  objData = new DataPayType();
		return  objData.DL_GetList_PayType();
	}

	public  DataTable Search(PayType  ObjPayType) 
	{
		DataPayType  objData = new DataPayType();
		return  objData.DL_Search_PayType(ObjPayType.PayTypeID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataPayType  objData = new DataPayType();
		return  objData.DL_SearchByField_PayType(FieldName,value);
	}

}// End Class
