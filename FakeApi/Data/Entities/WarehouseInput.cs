using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class WarehouseInput : BaseEntities
{
    public Guid StoreId { get; set; }
    public int TotalRecords { get; set; }
    public bool TrackedFlag { get; set; }
    public Guid StoreItemId { get; set; }
    public Guid ItemId { get; set; }
    public double MinQty { get; set; }
    public double BackOrderQty { get; set; }
    public bool StockCheckLockedFlag { get; set; }
    public bool LockedFlag { get; set; }
    public double MaxQty { get; set; }
    public double TargetQty { get; set; }
    public double QtyOnHandCost { get; set; }
    public double QtyOnHand { get; set; }
    public Guid LuUserId { get; set; }
    public double LeadTimeDays { get; set; }
    public double ReorderPointQty { get; set; }
    public string CompanyCode { get; set; }
    public string StockUomRcd { get; set; }
    public double AverageUnitCost { get; set; }
    public DateTime LuUpdated { get; set; }
    public double InTransitCost { get; set; }
}