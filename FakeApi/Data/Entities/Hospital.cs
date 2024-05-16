using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class Hospital : BaseEntities
{
    public Guid CompanyId { get; set; }
    public string CompanyCode { get; set; }
    public string CompanyNameE { get; set; }
    public string CompanyNameL { get; set; }
    public string AddressLine1E { get; set; }
    public string AddressLine1L { get; set; }
    public string AddressLine2E { get; set; }
    public string AddressLine2L { get; set; }
    public string AddressLine3E { get; set; }
    public string AddressLine3L { get; set; }
    public string City { get; set; }
    public string PostCode { get; set; }
    public int ActiveFlag { get; set; }
    public Guid ExternalFacilityId { get; set; }
}