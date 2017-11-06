namespace DeliverySystem.Models
{
    internal class Order
    {
        public int ID { get; set; }
        public string Adderss { get; set; }
        public int PostCode { get; set; }
        public int DoorNumber { get; set; }
        public enum Floor{ Basement , Groundfloor ,Firstfloor ,SecondFloor,ThirdFloor,FourthFloor,FifthFloor };
        public enum FloorSide {tv ,th , mdf }
        public bool IsPaied { get; set; }
        public enum StstusOfTheDelivery { OnTheWay,Deliverd}
        public string Time { get; set; }

    }
}