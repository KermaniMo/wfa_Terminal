using System.Data;
 


class BusinessPermission
{

	public int Insert(Permission  ObjPermission) 
	{
		DataPermission  objData = new DataPermission();
		return  objData.DL_Insert_Permission(ObjPermission.PermissionUserState, ObjPermission.AddPassenger, ObjPermission.EditPassenger, ObjPermission.RemovePassenger, ObjPermission.AddDriver, ObjPermission.EditDriver, ObjPermission.RemoveDriver, ObjPermission.AddTrip, ObjPermission.EditTrip, ObjPermission.RemoveTrip, ObjPermission.BookTicket, ObjPermission.ExtraditionTicket, ObjPermission.AddCar, ObjPermission.EditCar, ObjPermission.RemoveCar, ObjPermission.InputOutput, ObjPermission.ManageDriver );
	}

	public int Update(Permission  ObjPermission) 
	{
		DataPermission  objData = new DataPermission();
		return  objData.DL_Update_Permission(ObjPermission.PermissionID, ObjPermission.PermissionUserState, ObjPermission.AddPassenger, ObjPermission.EditPassenger, ObjPermission.RemovePassenger, ObjPermission.AddDriver, ObjPermission.EditDriver, ObjPermission.RemoveDriver, ObjPermission.AddTrip, ObjPermission.EditTrip, ObjPermission.RemoveTrip, ObjPermission.BookTicket, ObjPermission.ExtraditionTicket, ObjPermission.AddCar, ObjPermission.EditCar, ObjPermission.RemoveCar, ObjPermission.InputOutput, ObjPermission.ManageDriver );
	}

	public int Delete(Permission  ObjPermission) 
	{
		DataPermission  objData = new DataPermission();
		return  objData.DL_Delete_Permission(ObjPermission.PermissionID);
	}

	public  DataTable GetList( ) 
	{
		DataPermission  objData = new DataPermission();
		return  objData.DL_GetList_Permission();
	}

	public  DataTable Search(Permission  ObjPermission) 
	{
		DataPermission  objData = new DataPermission();
		return  objData.DL_Search_Permission(ObjPermission.PermissionID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataPermission  objData = new DataPermission();
		return  objData.DL_SearchByField_Permission(FieldName,value);
	}

}// End Class
