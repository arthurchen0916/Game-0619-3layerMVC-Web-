using System;

namespace Game.Common.Entities
{
    public partial class Monster :BaseEntity
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int ATK { get; set; }
        public int Exp { get; set; }
    }
}
