using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class Product : BaseEntities
{
    public int TotalRecords { get; set; }
    
    public Guid ItemId { get; set; }
    public string ItemCode { get; set; }
    public Guid ItemGroupId { get; set; }
    public string ItemTypeRcd { get; set; }
    
    public string SubItemTypeRcd { get; set; }
    public string UomRcd { get; set; }

    public string NameL { get; set; }
    public string NameE { get; set; }
    
    public bool MandatoryCaregiverFlag { get; set; }
    public bool UserChargeableFlag { get; set; }
    public bool OpdChargeableFlag { get; set; }
    public bool ActiveFlag { get; set; }
    public bool IpdChargeableFlag { get; set; }
    public bool VariablePriceFlag { get; set; }
    
    public DateTime LuUpdated { get; set; }
}