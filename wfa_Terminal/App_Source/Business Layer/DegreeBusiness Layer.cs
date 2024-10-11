using System.Data;
 


class BusinessDegree
{

	public int Insert(Degree  ObjDegree) 
	{
		DataDegree  objData = new DataDegree();
		return  objData.DL_Insert_Degree(ObjDegree.DegreeTitle );
	}

	public int Update(Degree  ObjDegree) 
	{
		DataDegree  objData = new DataDegree();
		return  objData.DL_Update_Degree(ObjDegree.DegreeID, ObjDegree.DegreeTitle );
	}

	public int Delete(Degree  ObjDegree) 
	{
		DataDegree  objData = new DataDegree();
		return  objData.DL_Delete_Degree(ObjDegree.DegreeID);
	}

	public  DataTable GetList( ) 
	{
		DataDegree  objData = new DataDegree();
		return  objData.DL_GetList_Degree();
	}

	public  DataTable Search(Degree  ObjDegree) 
	{
		DataDegree  objData = new DataDegree();
		return  objData.DL_Search_Degree(ObjDegree.DegreeID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataDegree  objData = new DataDegree();
		return  objData.DL_SearchByField_Degree(FieldName,value);
	}

}// End Class
