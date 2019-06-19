using System;

namespace Game.Common.Entities
{
    public partial class Item : BaseEntity
    {
        public string Name { get; set; }
        public Nullable<int> Weight { get; set; }
    }
}
