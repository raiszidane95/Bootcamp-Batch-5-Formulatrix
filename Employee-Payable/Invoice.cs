namespace Employee_Payable;

public class Invoice : IPayable
{

    public string? partNumber;
    public string? partDescription;
    public int quantity;
    public float pricePerItem;
    public float GetPaymentAmount(float paymentAmount)
    {
        return paymentAmount;
    }

}
