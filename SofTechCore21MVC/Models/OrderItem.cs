using System;
public class OrderItem {
	private int orderItemID;
	public int OrderItemID {
		get {
			return orderItemID;
		}
		set {
			orderItemID = value;
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
	private int shoppingCartID;
	public int ShoppingCartID {
		get {
			return shoppingCartID;
		}
		set {
			shoppingCartID = value;
		}
	}

	private ShoppingCart[] contains;

	private Garment[] may_be_an;
	private Complaint[] is_featured_on;

}
