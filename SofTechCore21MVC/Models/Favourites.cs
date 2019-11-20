using System;
public class Favourites {
	private int favouritesID;
	public int FavouritesID {
		get {
			return favouritesID;
		}
		set {
			favouritesID = value;
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

	private Customer[] may_add_Garments_to;

	private Garment may_be_part_of;

}
