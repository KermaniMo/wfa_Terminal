using System.Data;


class BusinessManageDriver
{

	public int Insert(ManageDriver ObjManageDriver)
	{
		DataManageDriver objData = new DataManageDriver();
		return objData.DL_Insert_ManageDriver(ObjManageDriver.ID_FK_tbl_Driver, ObjManageDriver.ManageDriverStatus, ObjManageDriver.ManageDriverDateOfLeave, ObjManageDriver.ManageDriverDateOfBack, ObjManageDriver.ManageDriverDescription);
	}

	public int Update(ManageDriver ObjManageDriver)
	{
		DataManageDriver objData = new DataManageDriver();
		return objData.DL_Update_ManageDriver(ObjManageDriver.ManageDriverID, ObjManageDriver.ID_FK_tbl_Driver, ObjManageDriver.ManageDriverStatus, ObjManageDriver.ManageDriverDateOfLeave, ObjManageDriver.ManageDriverDateOfBack, ObjManageDriver.ManageDriverDescription);
	}

	public int Delete(ManageDriver ObjManageDriver)
	{
		DataManageDriver objData = new DataManageDriver();
		return objData.DL_Delete_ManageDriver(ObjManageDriver.ManageDriverID);
	}

	public DataTable GetList()
	{
		DataManageDriver objData = new DataManageDriver();
		return objData.DL_GetList_ManageDriver();
	}

	public DataTable Search(ManageDriver ObjManageDriver)
	{
		DataManageDriver objData = new DataManageDriver();
		return objData.DL_Search_ManageDriver(ObjManageDriver.ManageDriverID);
	}

	public DataTable SearchByField(string FieldName, string value)
	{
		DataManageDriver objData = new DataManageDriver();
		return objData.DL_SearchByField_ManageDriver(FieldName, value);
	}

}// End Class

