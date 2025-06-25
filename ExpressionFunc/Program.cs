using ExpressionFunc;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        IEnumerable<Order> orders = new List<Order>
        {
            new Order
            {
                Id = Guid.NewGuid(),
                Name = "Laptop",
                Amount = 2,
                ReleaseDate = new DateTime(2025, 6, 1)
            },
            new Order
            {
                Id = Guid.NewGuid(),
                Name = "Mouse",
                Amount = 10,
                ReleaseDate = new DateTime(2025, 6, 15)
            },
            new Order
            {
                Id = Guid.NewGuid(),
                Name = "Keyboard",
                Amount = 5,
                ReleaseDate = new DateTime(2025, 5, 20)
            }
        };
        Expression<Func<Order, bool>> filter = o => o.Amount > 100 && o.Name == "Paid";

        orders.Where(filter.Compile());
    }
}