using System; 
public class City
     {
private int _CityID ;
private string _CityName ;
private int _ID_FK_tbl_Province ;



public  int  CityID {
		 get{  return _CityID ; }
		 set{_CityID =  value;}
	}
public  string  CityName {
		 get{  return _CityName ; }
		 set{_CityName =  value;}
	}
public  int  ID_FK_tbl_Province {
		 get{  return _ID_FK_tbl_Province ; }
		 set{_ID_FK_tbl_Province =  value;}
	}




}
//---------------------------