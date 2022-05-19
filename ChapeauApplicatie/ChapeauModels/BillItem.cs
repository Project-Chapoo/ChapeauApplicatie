namespace ChapeauModels
{
    public class BillItem
    {
        public int BillItemID{ get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Alcohol { get; set; }
    }
}
