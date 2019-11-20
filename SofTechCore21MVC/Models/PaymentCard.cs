using System;
public class PaymentCard {
	private string paymentCardID;
	public string PaymentCardID {
		get {
			return paymentCardID;
		}
		set {
			paymentCardID = value;
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
	private CardType cardType;
	public CardType CardType {
		get {
			return cardType;
		}
		set {
			cardType = value;
		}
	}
	private string cardName;
	public string CardName {
		get {
			return cardName;
		}
		set {
			cardName = value;
		}
	}
	private string cardNumber;
	public string CardNumber {
		get {
			return cardNumber;
		}
		set {
			cardNumber = value;
		}
	}
	private int expiryMonth;
	public int ExpiryMonth {
		get {
			return expiryMonth;
		}
		set {
			expiryMonth = value;
		}
	}
	private int expiryYear;
	public int ExpiryYear {
		get {
			return expiryYear;
		}
		set {
			expiryYear = value;
		}
	}
	private int securityNumber;
	public int SecurityNumber {
		get {
			return securityNumber;
		}
		set {
			securityNumber = value;
		}
	}

	private Customer may_use;

}
