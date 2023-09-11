using System.Dynamic;

namespace Employee_Payable;

public interface IPayable
{
    public float GetPaymentAmount(float spaymentAmount);
}
