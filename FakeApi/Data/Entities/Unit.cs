using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class Unit : BaseEntities
{
    public int TotalRecords { get; set; }
    public string ShortNameL { get; set; }
    public string NameL { get; set; }
    public string UomRcd { get; set; }
    public string ShortNameE { get; set; }
    public string DisplayNameE { get; set; }
    public string NameE { get; set; }
    public string ActiveStatus { get; set; }
    public string DisplayNameL { get; set; }
    public bool MustNotChangeFlag { get; set; }
    public DateTime LuUpdated { get; set; }
    public bool OmitDenominatorFlag { get; set; }
    public string ShortCode { get; set; }
}