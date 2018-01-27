namespace BlueCafe.Core
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int BeverageId { get; set; }

        //navigate
        public virtual Beverage Beverage { get; set; }
        public virtual Order Order { get; set; }
    }
}