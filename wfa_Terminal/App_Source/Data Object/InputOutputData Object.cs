using System; 
public class InputOutput
     {
private int _InputOutputID ;
private int _ID_FK_tbl_Driver ;
private bool _InputOutputStatus ;
private string _InputOutputDateTime ;
private string _InputOutputDescription ;



public  int  InputOutputID {
		 get{  return _InputOutputID ; }
		 set{_InputOutputID =  value;}
	}
public  int  ID_FK_tbl_Driver {
		 get{  return _ID_FK_tbl_Driver ; }
		 set{_ID_FK_tbl_Driver =  value;}
	}
public  bool  InputOutputStatus {
		 get{  return _InputOutputStatus ; }
		 set{_InputOutputStatus =  value;}
	}
public  string  InputOutputDateTime {
		 get{  return _InputOutputDateTime ; }
		 set{_InputOutputDateTime =  value;}
	}
public  string  InputOutputDescription {
		 get{  return _InputOutputDescription ; }
		 set{_InputOutputDescription =  value;}
	}




}
//---------------------------