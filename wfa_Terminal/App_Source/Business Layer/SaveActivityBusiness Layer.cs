using System.Data;


class BusinessSaveActivity
{

	public int Insert(SaveActivity ObjSaveActivity)
	{
		DataSaveActivity objData = new DataSaveActivity();
		return objData.DL_Insert_SaveActivity(ObjSaveActivity.ID_FK_tbl_Driver, ObjSaveActivity.ID_FK_tbl_ManageDriver, ObjSaveActivity.SaveActivityStatus, ObjSaveActivity.SaveActivityDateOfLeave, ObjSaveActivity.SaveActivityDateOfBack, ObjSaveActivity.SaveActivityDescription);
	}

	public int Update(SaveActivity ObjSaveActivity)
	{
		DataSaveActivity objData = new DataSaveActivity();
		return objData.DL_Update_SaveActivity(ObjSaveActivity.SaveActivityID, ObjSaveActivity.ID_FK_tbl_Driver, ObjSaveActivity.ID_FK_tbl_ManageDriver, ObjSaveActivity.SaveActivityStatus, ObjSaveActivity.SaveActivityDateOfLeave, ObjSaveActivity.SaveActivityDateOfBack, ObjSaveActivity.SaveActivityDescription);
	}

	public int Delete(SaveActivity ObjSaveActivity)
	{
		DataSaveActivity objData = new DataSaveActivity();
		return objData.DL_Delete_SaveActivity(ObjSaveActivity.SaveActivityID);
	}

	public DataTable GetList()
	{
		DataSaveActivity objData = new DataSaveActivity();
		return objData.DL_GetList_SaveActivity();
	}

	public DataTable Search(SaveActivity ObjSaveActivity)
	{
		DataSaveActivity objData = new DataSaveActivity();
		return objData.DL_Search_SaveActivity(ObjSaveActivity.SaveActivityID);
	}

	public DataTable SearchByField(string FieldName, string value)
	{
		DataSaveActivity objData = new DataSaveActivity();
		return objData.DL_SearchByField_SaveActivity(FieldName, value);
	}

}// End Class

