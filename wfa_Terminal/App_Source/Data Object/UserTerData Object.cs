using System; 
public class UserTer
     {
private int _UserID ;
private string _UserNamePersian ;
private string _UserLastNamePersian ;
private string _UserName ;
private int _ID_FK_tbl_Permission ;
private int _ID_FK_tbl_SecurityQuestion ;
private string _UserAnswer ;



public  int  UserID {
		 get{  return _UserID ; }
		 set{_UserID =  value;}
	}
public  string  UserNamePersian {
		 get{  return _UserNamePersian ; }
		 set{_UserNamePersian =  value;}
	}
public  string  UserLastNamePersian {
		 get{  return _UserLastNamePersian ; }
		 set{_UserLastNamePersian =  value;}
	}
public  string  UserName {
		 get{  return _UserName ; }
		 set{_UserName =  value;}
	}
public  int  ID_FK_tbl_Permission {
		 get{  return _ID_FK_tbl_Permission ; }
		 set{_ID_FK_tbl_Permission =  value;}
	}
public  int  ID_FK_tbl_SecurityQuestion {
		 get{  return _ID_FK_tbl_SecurityQuestion ; }
		 set{_ID_FK_tbl_SecurityQuestion =  value;}
	}
public  string  UserAnswer {
		 get{  return _UserAnswer ; }
		 set{_UserAnswer =  value;}
	}




}
//---------------------------