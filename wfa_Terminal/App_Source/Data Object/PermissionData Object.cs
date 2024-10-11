using System; 
public class Permission
     {
private int _PermissionID ;
private string _PermissionUserState ;
private bool _AddPassenger ;
private bool _EditPassenger ;
private bool _RemovePassenger ;
private bool _AddDriver ;
private bool _EditDriver ;
private bool _RemoveDriver ;
private bool _AddTrip ;
private bool _EditTrip ;
private bool _RemoveTrip ;
private bool _BookTicket ;
private bool _ExtraditionTicket ;
private bool _AddCar ;
private bool _EditCar ;
private bool _RemoveCar ;
private bool _InputOutput ;
private bool _ManageDriver ;



public  int  PermissionID {
		 get{  return _PermissionID ; }
		 set{_PermissionID =  value;}
	}
public  string  PermissionUserState {
		 get{  return _PermissionUserState ; }
		 set{_PermissionUserState =  value;}
	}
public  bool  AddPassenger {
		 get{  return _AddPassenger ; }
		 set{_AddPassenger =  value;}
	}
public  bool  EditPassenger {
		 get{  return _EditPassenger ; }
		 set{_EditPassenger =  value;}
	}
public  bool  RemovePassenger {
		 get{  return _RemovePassenger ; }
		 set{_RemovePassenger =  value;}
	}
public  bool  AddDriver {
		 get{  return _AddDriver ; }
		 set{_AddDriver =  value;}
	}
public  bool  EditDriver {
		 get{  return _EditDriver ; }
		 set{_EditDriver =  value;}
	}
public  bool  RemoveDriver {
		 get{  return _RemoveDriver ; }
		 set{_RemoveDriver =  value;}
	}
public  bool  AddTrip {
		 get{  return _AddTrip ; }
		 set{_AddTrip =  value;}
	}
public  bool  EditTrip {
		 get{  return _EditTrip ; }
		 set{_EditTrip =  value;}
	}
public  bool  RemoveTrip {
		 get{  return _RemoveTrip ; }
		 set{_RemoveTrip =  value;}
	}
public  bool  BookTicket {
		 get{  return _BookTicket ; }
		 set{_BookTicket =  value;}
	}
public  bool  ExtraditionTicket {
		 get{  return _ExtraditionTicket ; }
		 set{_ExtraditionTicket =  value;}
	}
public  bool  AddCar {
		 get{  return _AddCar ; }
		 set{_AddCar =  value;}
	}
public  bool  EditCar {
		 get{  return _EditCar ; }
		 set{_EditCar =  value;}
	}
public  bool  RemoveCar {
		 get{  return _RemoveCar ; }
		 set{_RemoveCar =  value;}
	}
public  bool  InputOutput {
		 get{  return _InputOutput ; }
		 set{_InputOutput =  value;}
	}
public  bool  ManageDriver {
		 get{  return _ManageDriver ; }
		 set{_ManageDriver =  value;}
	}




}
//---------------------------