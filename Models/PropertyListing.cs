namespace AlexisAtchison.Models
{
    public class PropertyListing
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public decimal SalePrice { get; set; }

        public int Zip { get; set; }

        public int NumBedrooms { get; set; }
    }
}
