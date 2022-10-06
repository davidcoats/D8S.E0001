using System;


namespace D8S.E0001
{
    public class FoodDeliveryOrder_AsService
    {
        public string RestaurantName { get; set; }
        public string DeliveryAddress { get; set; }
        public double Cost { get; set; }
        public DateTime PickupTime { get; set; }
        public DateTime DropoffTime { get; set; }


        public FoodDeliveryOrder_AsService()
        {
        }
    }
}
