public class ChoiceTrip
{
	private int _ChoiceTripID;
	private string _ChoiceTripTicketCode;
	private int _ID_FK_tbl_Passenger;
	private int _ID_FK_tbl_Trip;
	private int _ID_FK_tbl_Bank;
	private int _ID_FK_tbl_PayType;
	private short _ChoiceTripSeatNumber;
	private decimal _ChoiceTripPrice;
	private string _ChoiceTripDateOfBook;
	private bool _ChoiceTripTicketState;



	public int ChoiceTripID
	{
		get { return _ChoiceTripID; }
		set { _ChoiceTripID = value; }
	}
	public string ChoiceTripTicketCode
	{
		get { return _ChoiceTripTicketCode; }
		set { _ChoiceTripTicketCode = value; }
	}
	public int ID_FK_tbl_Passenger
	{
		get { return _ID_FK_tbl_Passenger; }
		set { _ID_FK_tbl_Passenger = value; }
	}
	public int ID_FK_tbl_Trip
	{
		get { return _ID_FK_tbl_Trip; }
		set { _ID_FK_tbl_Trip = value; }
	}
	public int ID_FK_tbl_Bank
	{
		get { return _ID_FK_tbl_Bank; }
		set { _ID_FK_tbl_Bank = value; }
	}
	public int ID_FK_tbl_PayType
	{
		get { return _ID_FK_tbl_PayType; }
		set { _ID_FK_tbl_PayType = value; }
	}
	public short ChoiceTripSeatNumber
	{
		get { return _ChoiceTripSeatNumber; }
		set { _ChoiceTripSeatNumber = value; }
	}
	public decimal ChoiceTripPrice
	{
		get { return _ChoiceTripPrice; }
		set { _ChoiceTripPrice = value; }
	}
	public string ChoiceTripDateOfBook
	{
		get { return _ChoiceTripDateOfBook; }
		set { _ChoiceTripDateOfBook = value; }
	}
	public bool ChoiceTripTicketState
	{
		get { return _ChoiceTripTicketState; }
		set { _ChoiceTripTicketState = value; }
	}




}
//---------------------------
