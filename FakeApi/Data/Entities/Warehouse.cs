using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class Warehouse : BaseEntities
{
    public Guid StoreId { get; set; }
    public string StoreCode { get; set; }
    public int TotalRecords { get; set; }
    public bool AllowSalesFlag { get; set; }
    public string NameL { get; set; }
    public double CostcentreCode { get; set; }
    public bool AutomaticStoreIssueReceiptFlag { get; set; }
    public Guid CostcentreId { get; set; }
    public bool ActiveFlag { get; set; }
    public string NameE { get; set; }
    public bool LockDuringStockCheckFlag { get; set; }
    public string CompanyCode { get; set; }
    public bool AllowNegativeStockFlag { get; set; }
    public DateTime LuUpdated { get; set; }
    public string StoreTypeRcd { get; set; }
}