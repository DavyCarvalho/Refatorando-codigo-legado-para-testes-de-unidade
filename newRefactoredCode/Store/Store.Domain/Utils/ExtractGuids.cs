using Store.Domain.Commands;

namespace Store.Domain.Utils
{
    public class ExtractGuids
    {
        public static IEnumerable<Guid> Extract(IList<CreateOrderItemCommand> items)
        {
            var guids = new List<Guid>();
            foreach (var item in items)
                guids.Add(item.Product);
            return guids;
        }
    }
}
