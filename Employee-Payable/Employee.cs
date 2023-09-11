namespace Employee_Payable;

public abstract class Employee : IPayable
{
    public string? firstName;
    public string? lastName;
    public string? socialSecurityNumber;
    public float GetPaymentAmount(float paymentAmount)
    {
        return paymentAmount;
    }
}
