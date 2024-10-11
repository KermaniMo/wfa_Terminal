using System.Data;
 


class BusinessInputOutput
{

	public int Insert(InputOutput  ObjInputOutput) 
	{
		DataInputOutput  objData = new DataInputOutput();
		return  objData.DL_Insert_InputOutput(ObjInputOutput.ID_FK_tbl_Driver, ObjInputOutput.InputOutputStatus, ObjInputOutput.InputOutputDateTime, ObjInputOutput.InputOutputDescription );
	}

	public int Update(InputOutput  ObjInputOutput) 
	{
		DataInputOutput  objData = new DataInputOutput();
		return  objData.DL_Update_InputOutput(ObjInputOutput.InputOutputID, ObjInputOutput.ID_FK_tbl_Driver, ObjInputOutput.InputOutputStatus, ObjInputOutput.InputOutputDateTime, ObjInputOutput.InputOutputDescription );
	}

	public int Delete(InputOutput  ObjInputOutput) 
	{
		DataInputOutput  objData = new DataInputOutput();
		return  objData.DL_Delete_InputOutput(ObjInputOutput.InputOutputID);
	}

	public  DataTable GetList( ) 
	{
		DataInputOutput  objData = new DataInputOutput();
		return  objData.DL_GetList_InputOutput();
	}

	public  DataTable Search(InputOutput  ObjInputOutput) 
	{
		DataInputOutput  objData = new DataInputOutput();
		return  objData.DL_Search_InputOutput(ObjInputOutput.InputOutputID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataInputOutput  objData = new DataInputOutput();
		return  objData.DL_SearchByField_InputOutput(FieldName,value);
	}

}// End Class
