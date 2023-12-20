using System.Collections.Generic;

namespace EF6Test2.Entities
{
    public abstract class BaseTransalatableRemoteEntity<TId, TCol> : BaseRemoteEntity<TId>
    {
        public ICollection<TCol> Translations { get; set; }
    }
}
