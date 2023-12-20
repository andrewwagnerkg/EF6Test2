using System.ComponentModel.DataAnnotations.Schema;

namespace EF6Test2.Entities
{
    public abstract class BaseRemoteEntity<T> : BaseEntity<T>
    {
        [Index(IsUnique = true)]
        public int RemoteId { get; set; }
    }
}
