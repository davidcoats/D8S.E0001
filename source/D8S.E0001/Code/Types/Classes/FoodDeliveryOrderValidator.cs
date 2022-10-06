using System;


namespace D8S.E0001
{
    public class FoodDeliveryOrderValidator
    {
        private DeliveryAddressValidator DeliveryAddressValidator { get; }


        public FoodDeliveryOrderValidator(
                DeliveryAddressValidator deliveryAddressValidator)
        {
            this.DeliveryAddressValidator = deliveryAddressValidator;
        }

        public bool IsValid(FoodDeliveryOrder order)
        {
            // Test that all properties of the order have values, that cost is not negative, and that if the dropoff-time is not the minium value, then dropoff time is after the pickup time.

            // Also
        }
    }
}
