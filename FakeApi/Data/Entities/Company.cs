using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class Company : BaseEntities
{
    public int TotalRecords { get; set; }
    public Guid CompanyId { get; set; }
    
    public string Hotline { get; set; }
    public string Emergency { get; set; }
    
    public string CompanyCode { get; set; }
    public string CompanyNameL { get; set; }
    public string CompanyNameE { get; set; }

    public string AddressL { get; set; }
    public string AddressE { get; set; }
    
    public string Tel { get; set; }
    public string Fax { get; set; }
}