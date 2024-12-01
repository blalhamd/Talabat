using System.Runtime.Serialization;

namespace Talabat.Entities.entities.Order
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")] // معلقه
        Pending,
       
        [EnumMember(Value = "Payment Received")]
        PaymentReceived,
        
        [EnumMember(Value ="Payment Failed")]
        PaymentFailed,
    }
}
