using CleanArchAPI.Domain.Common;

namespace CleanArchAPI.Domain.Entities
{
    public class ToDo : BaseEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}
