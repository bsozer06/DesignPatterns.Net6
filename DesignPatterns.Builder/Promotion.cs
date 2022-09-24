namespace DesignPatterns.Builder
{
    /// <summary>
    /// product
    /// </summary>
    public class Promotion
    {
        public string ProductName { get; set; }
        public int PromotionNumber { get; set; }
        public string EmployeeProfile { get; set; }
        public override string ToString()
        {
            Console.WriteLine($"{PromotionNumber} numaralı {ProductName} promosyonu {EmployeeProfile} calışanlarına verilmiştir.");
            return "";
        }
    }
}
