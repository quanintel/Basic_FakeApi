using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class WarehouseTransactionHistory : BaseEntities
{
    public Guid StoreId { get; set; }
    public int TotalRecords { get; set; }
    public double LucCost { get; set; }
    public Guid ItemId { get; set; }
    public double MovementQty { get; set; }
    public Guid ItemMovementId { get; set; }
    public double QtyOnHand { get; set; }
    public double SucCost { get; set; }
    public DateTime DateTime { get; set; }
    public Guid UserId { get; set; }
    public double ActualCost { get; set; }
    public double AucCost { get; set; }
    public Guid SourceId { get; set; }
    public string ItemMovementTypeRcd { get; set; }
}