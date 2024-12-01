namespace Talabat.Entities.entities
{
    public class BaseEntity : IEntityCreationTime,IEntityCreatedByUser,ISoftDeletable,IEntityModificationHistory
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedByUserId { get; set; }
        public bool IsSoftDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public int? DeletedByUserId { get; set; }
        public DateTime? FirstUpdatedTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public int? FirstUpdatedByUserId { get; set; }
        public int? LastUpdatedByUserId { get; set; }
    }
}
