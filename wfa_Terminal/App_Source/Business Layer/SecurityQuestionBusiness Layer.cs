using System.Data;
 


class BusinessSecurityQuestion
{

	public int Insert(SecurityQuestion  ObjSecurityQuestion) 
	{
		DataSecurityQuestion  objData = new DataSecurityQuestion();
		return  objData.DL_Insert_SecurityQuestion(ObjSecurityQuestion.SecurityQuestionTitle );
	}

	public int Update(SecurityQuestion  ObjSecurityQuestion) 
	{
		DataSecurityQuestion  objData = new DataSecurityQuestion();
		return  objData.DL_Update_SecurityQuestion(ObjSecurityQuestion.SecurityQuestionID, ObjSecurityQuestion.SecurityQuestionTitle );
	}

	public int Delete(SecurityQuestion  ObjSecurityQuestion) 
	{
		DataSecurityQuestion  objData = new DataSecurityQuestion();
		return  objData.DL_Delete_SecurityQuestion(ObjSecurityQuestion.SecurityQuestionID);
	}

	public  DataTable GetList( ) 
	{
		DataSecurityQuestion  objData = new DataSecurityQuestion();
		return  objData.DL_GetList_SecurityQuestion();
	}

	public  DataTable Search(SecurityQuestion  ObjSecurityQuestion) 
	{
		DataSecurityQuestion  objData = new DataSecurityQuestion();
		return  objData.DL_Search_SecurityQuestion(ObjSecurityQuestion.SecurityQuestionID);
	}

	public  DataTable SearchByField(string FieldName,string  value) 
	{
		DataSecurityQuestion  objData = new DataSecurityQuestion();
		return  objData.DL_SearchByField_SecurityQuestion(FieldName,value);
	}

}// End Class
