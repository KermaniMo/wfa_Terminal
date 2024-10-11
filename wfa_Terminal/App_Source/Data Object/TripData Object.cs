using System; 
public class Trip
     {
private int _TripID ;
private int _fi_ID_FK_tbl_Driver ;
private int _se_ID_FK_tbl_Driver ;
private int _Or_ID_FK_tbl_City ;
private int _De_ID_FK_tbl_City ;
private int _ID_FK_tbl_Car ;
private decimal _TripPrice ;
private short _TripCapacity ;
private string _TripDateOfMove ;
private string _TripDateOfArrive ;
private bool _TripStatus ;
private string _TripDescription ;



public  int  TripID {
		 get{  return _TripID ; }
		 set{_TripID =  value;}
	}
public  int  fi_ID_FK_tbl_Driver {
		 get{  return _fi_ID_FK_tbl_Driver ; }
		 set{_fi_ID_FK_tbl_Driver =  value;}
	}
public  int  se_ID_FK_tbl_Driver {
		 get{  return _se_ID_FK_tbl_Driver ; }
		 set{_se_ID_FK_tbl_Driver =  value;}
	}
public  int  Or_ID_FK_tbl_City {
		 get{  return _Or_ID_FK_tbl_City ; }
		 set{_Or_ID_FK_tbl_City =  value;}
	}
public  int  De_ID_FK_tbl_City {
		 get{  return _De_ID_FK_tbl_City ; }
		 set{_De_ID_FK_tbl_City =  value;}
	}
public  int  ID_FK_tbl_Car {
		 get{  return _ID_FK_tbl_Car ; }
		 set{_ID_FK_tbl_Car =  value;}
	}
public  decimal  TripPrice {
		 get{  return _TripPrice ; }
		 set{_TripPrice =  value;}
	}
public  short  TripCapacity {
		 get{  return _TripCapacity ; }
		 set{_TripCapacity =  value;}
	}
public  string  TripDateOfMove {
		 get{  return _TripDateOfMove ; }
		 set{_TripDateOfMove =  value;}
	}
public string TripDateOfArrive {
		 get{  return _TripDateOfArrive ; }
		 set{_TripDateOfArrive =  value;}
	}
public  bool  TripStatus {
		 get{  return _TripStatus ; }
		 set{_TripStatus =  value;}
	}
public  string  TripDescription {
		 get{  return _TripDescription ; }
		 set{_TripDescription =  value;}
	}




}
//---------------------------