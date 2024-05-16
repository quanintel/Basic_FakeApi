using FakeApi.Data.Entities.Custom;

namespace FakeApi.Data.Entities;

public class MomentType : BaseEntities
{
    public int TotalRecords { get; set; }
    public string ActiveStatus { get; set; }
    public string DescriptionE { get; set; }
    public string NameL { get; set; }
    public bool MustNotChangeFlag { get; set; }
    public bool GlVisitTypeOverrideFlag { get; set; }
    public string DescriptionL { get; set; }
    public string SourceTable { get; set; }
    public DateTime LuUpdated { get; set; }
    public string NameE { get; set; }
    public string ItemMovementTypeRcd { get; set; }
    public int Direction { get; set; }
}