using System;
public class Car
{
	private int _CarID;
	private string _OwnerNationalCode;
	private string _OwnerName;
	private string _OwnerLastName;
	private string _OwnerMobileNumber;
	private bool _OwnerSex;
	private string _OwnerBirthday;
	private string _OwnerEmail;
	private DateTime _CarRegister;
	private string _CarBrand;
	private int _ID_FK_tbl_CarType;
	private string _CarModel;
	private string _CarTag;
	private string _CarDateOfManufacture;
	private short _CarCapacity;



	public int CarID
	{
		get { return _CarID; }
		set { _CarID = value; }
	}
	public string OwnerNationalCode
	{
		get { return _OwnerNationalCode; }
		set { _OwnerNationalCode = value; }
	}
	public string OwnerName
	{
		get { return _OwnerName; }
		set { _OwnerName = value; }
	}
	public string OwnerLastName
	{
		get { return _OwnerLastName; }
		set { _OwnerLastName = value; }
	}
	public string OwnerMobileNumber
	{
		get { return _OwnerMobileNumber; }
		set { _OwnerMobileNumber = value; }
	}
	public bool OwnerSex
	{
		get { return _OwnerSex; }
		set { _OwnerSex = value; }
	}
	public string OwnerBirthday
	{
		get { return _OwnerBirthday; }
		set { _OwnerBirthday = value; }
	}
	public string OwnerEmail
	{
		get { return _OwnerEmail; }
		set { _OwnerEmail = value; }
	}
	public DateTime CarRegister
	{
		get { return _CarRegister; }
		set { _CarRegister = value; }
	}
	public string CarBrand
	{
		get { return _CarBrand; }
		set { _CarBrand = value; }
	}
	public int ID_FK_tbl_CarType
	{
		get { return _ID_FK_tbl_CarType; }
		set { _ID_FK_tbl_CarType = value; }
	}
	public string CarModel
	{
		get { return _CarModel; }
		set { _CarModel = value; }
	}
	public string CarTag
	{
		get { return _CarTag; }
		set { _CarTag = value; }
	}
	public string CarDateOfManufacture
	{
		get { return _CarDateOfManufacture; }
		set { _CarDateOfManufacture = value; }
	}
	public short CarCapacity
	{
		get { return _CarCapacity; }
		set { _CarCapacity = value; }
	}




}
//---------------------------
