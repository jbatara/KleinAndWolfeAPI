namespace kleinandwolfeapi.Models
{
  public class OrderProduct
  {
    public int OrderProductId { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }

    public Order Order { get; set; }
    public Product Product { get; set; }
  }
}