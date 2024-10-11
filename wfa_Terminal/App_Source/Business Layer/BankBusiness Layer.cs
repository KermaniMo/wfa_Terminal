using System.Data;
 


class BusinessBank
{

	public int Insert(Bank  ObjBank) 
	{
		DataBank  objData = new DataBank();
		return  objData.DL_Insert_Bank(ObjBank.BankTitle );
	}

	public int Update(Bank  ObjBank) 
	{
		DataBank  objData = new DataBank();
		return  objData.DL_Update_Bank(ObjBank.BankID, ObjBank.BankTitle );
	}

	public int Delete(Bank  ObjBank) 
	{
		DataBank  objData = new DataBank();
		return  objData.DL_Delete_Bank(ObjBank.BankID);
	}

	public  DataTable GetList( ) 
	{
		DataBank  objData = new DataBank();
		return  objData.DL_GetList_Bank();
	}

	public  DataTable Search(Bank  ObjBank) 
	{
		DataBank  objData = new DataBank();
		return  objData.DL_Search_Bank(ObjBank.BankID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataBank  objData = new DataBank();
		return  objData.DL_SearchByField_Bank(FieldName,value);
	}

}// End Class
