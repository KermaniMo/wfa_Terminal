using System.Data;
 


class BusinessUserTer
{

	public int Insert(UserTer  ObjUserTer) 
	{
		DataUserTer  objData = new DataUserTer();
		return  objData.DL_Insert_UserTer(ObjUserTer.UserNamePersian, ObjUserTer.UserLastNamePersian, ObjUserTer.UserName, ObjUserTer.ID_FK_tbl_Permission, ObjUserTer.ID_FK_tbl_SecurityQuestion, ObjUserTer.UserAnswer );
	}

	public int Update(UserTer  ObjUserTer) 
	{
		DataUserTer  objData = new DataUserTer();
		return  objData.DL_Update_UserTer(ObjUserTer.UserID, ObjUserTer.UserNamePersian, ObjUserTer.UserLastNamePersian, ObjUserTer.UserName, ObjUserTer.ID_FK_tbl_Permission, ObjUserTer.ID_FK_tbl_SecurityQuestion, ObjUserTer.UserAnswer );
	}

	public int Delete(UserTer  ObjUserTer) 
	{
		DataUserTer  objData = new DataUserTer();
		return  objData.DL_Delete_UserTer(ObjUserTer.UserID);
	}

	public  DataTable GetList( ) 
	{
		DataUserTer  objData = new DataUserTer();
		return  objData.DL_GetList_UserTer();
	}

	public  DataTable Search(UserTer  ObjUserTer) 
	{
		DataUserTer  objData = new DataUserTer();
		return  objData.DL_Search_UserTer(ObjUserTer.UserID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataUserTer  objData = new DataUserTer();
		return  objData.DL_SearchByField_UserTer(FieldName,value);
	}

}// End Class
