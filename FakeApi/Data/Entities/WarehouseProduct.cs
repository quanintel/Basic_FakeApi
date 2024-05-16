using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class WarehouseProduct : BaseEntities
{
    public Guid StoreId { get; set; }
    public int TotalRecords { get; set; }
    public Guid StoreItemId { get; set; }
    public double PendingRefillRequestQty { get; set; }
    public Guid ItemId { get; set; }
    public double MinQty { get; set; }
    public double BackOrderQty { get; set; }
    public bool StockCheckLockedFlag { get; set; }
    public string ReplenishmentTypeRcd { get; set; }
    public bool LockedFlag { get; set; }
    public double MaxQty { get; set; }
    public double TargetQty { get; set; }
    public double InTransitQty { get; set; }
    public double QtyOnHand { get; set; }
    public double PendingIssuesIn { get; set; }
    public double ReorderPointQty { get; set; }
    public string CompanyCode { get; set; }
    public string StockUomRcd { get; set; }
    public DateTime LuUpdated { get; set; }
    public double PendingIssuesOut { get; set; }
    public double InTransitCost { get; set; }
    public string BinLocation { get; set; }
}