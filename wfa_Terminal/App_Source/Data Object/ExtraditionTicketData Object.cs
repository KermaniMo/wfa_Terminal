using System; 
public class ExtraditionTicket
     {
private int _ExtraditionTicketID ;
private int _ID_FK_tbl_ChoiceTrip ;
private decimal _ExtraditionTicketRefundAmount ;
private DateTime _ExtraditionTicketDateOfCancel ;



public  int  ExtraditionTicketID {
		 get{  return _ExtraditionTicketID ; }
		 set{_ExtraditionTicketID =  value;}
	}
public  int  ID_FK_tbl_ChoiceTrip {
		 get{  return _ID_FK_tbl_ChoiceTrip ; }
		 set{_ID_FK_tbl_ChoiceTrip =  value;}
	}
public  decimal  ExtraditionTicketRefundAmount {
		 get{  return _ExtraditionTicketRefundAmount ; }
		 set{_ExtraditionTicketRefundAmount =  value;}
	}
public  DateTime  ExtraditionTicketDateOfCancel {
		 get{  return _ExtraditionTicketDateOfCancel ; }
		 set{_ExtraditionTicketDateOfCancel =  value;}
	}




}
//---------------------------