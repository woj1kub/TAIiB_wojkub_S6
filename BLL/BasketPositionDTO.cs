namespace BLL
{
    public class BasketPositionDTO
    {
        public int Id { get; init; }
        public int ProductID { get; init; }
        public int UserID { get; init; }
        public int Amount { get; set; }
    }
}
