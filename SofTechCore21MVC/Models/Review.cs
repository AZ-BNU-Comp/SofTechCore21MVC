using System;
public class Review {
	private int reviewID;
	public int ReviewID {
		get {
			return reviewID;
		}
		set {
			reviewID = value;
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
	private int garmentID;
	public int GarmentID {
		get {
			return garmentID;
		}
		set {
			garmentID = value;
		}
	}
	private string title;
	public string Title {
		get {
			return title;
		}
		set {
			title = value;
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
	private float rating;
	public float Rating {
		get {
			return rating;
		}
		set {
			rating = value;
		}
	}
	private int reviewDate;
	public int ReviewDate {
		get {
			return reviewDate;
		}
		set {
			reviewDate = value;
		}
	}

	private OrderItem[] may_have;

	private Customer[] may_leave;

}
