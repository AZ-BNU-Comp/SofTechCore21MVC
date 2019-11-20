using System;
public class Complaint {
	private int complaintID;
	public int ComplaintID {
		get {
			return complaintID;
		}
		set {
			complaintID = value;
		}
	}
	private int garmentID;
	public int GarmentID {
		get {
			return garmentID;
		}
		set {
			garmentID = value;
		}
	}
	private int customerID;
	public int CustomerID {
		get {
			return customerID;
		}
		set {
			customerID = value;
		}
	}
	private string garmentName;
	public string GarmentName {
		get {
			return garmentName;
		}
		set {
			garmentName = value;
		}
	}
	private string statement;
	public string Statement {
		get {
			return statement;
		}
		set {
			statement = value;
		}
	}
	private bool containsPicture;
	public bool ContainsPicture {
		get {
			return containsPicture;
		}
		set {
			containsPicture = value;
		}
	}
	private int complaintDate;
	public int ComplaintDate {
		get {
			return complaintDate;
		}
		set {
			complaintDate = value;
		}
	}

	private OrderItem may_have;
	private Customer[] may_make;

}
