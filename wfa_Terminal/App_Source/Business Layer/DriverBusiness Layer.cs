using System.Data;


class BusinessDriver
{

	public int Insert(Driver ObjDriver)
	{
		DataDriver objData = new DataDriver();
		return objData.DL_Insert_Driver(ObjDriver.DriverNationalCode, ObjDriver.DriverPersonnelCode, ObjDriver.DriverLicenseNumber, ObjDriver.DriverName, ObjDriver.DriverLastName, ObjDriver.DriverMobileNumber, ObjDriver.DriverSex, ObjDriver.DriverBirthday, ObjDriver.DriverEmail, ObjDriver.DriverDateEmploy, ObjDriver.DriverMaritalStatuse, ObjDriver.ID_FK_tbl_Degree, ObjDriver.DriverLicenseType, ObjDriver.DriverDateOfExpirationCertificate, ObjDriver.Address);
	}

	public int Update(Driver ObjDriver)
	{
		DataDriver objData = new DataDriver();
		return objData.DL_Update_Driver(ObjDriver.DriverID, ObjDriver.DriverNationalCode, ObjDriver.DriverPersonnelCode, ObjDriver.DriverLicenseNumber, ObjDriver.DriverName, ObjDriver.DriverLastName, ObjDriver.DriverMobileNumber, ObjDriver.DriverSex, ObjDriver.DriverBirthday, ObjDriver.DriverEmail, ObjDriver.DriverDateEmploy, ObjDriver.DriverMaritalStatuse, ObjDriver.ID_FK_tbl_Degree, ObjDriver.DriverLicenseType, ObjDriver.DriverDateOfExpirationCertificate, ObjDriver.Address);
	}

	public int Delete(Driver ObjDriver)
	{
		DataDriver objData = new DataDriver();
		return objData.DL_Delete_Driver(ObjDriver.DriverID);
	}

	public DataTable GetList()
	{
		DataDriver objData = new DataDriver();
		return objData.DL_GetList_Driver();
	}

	public DataTable Search(Driver ObjDriver)
	{
		DataDriver objData = new DataDriver();
		return objData.DL_Search_Driver(ObjDriver.DriverID);
	}

	public DataTable SearchByField(string FieldName, string value)
	{
		DataDriver objData = new DataDriver();
		return objData.DL_SearchByField_Driver(FieldName, value);
	}

}// End Class

