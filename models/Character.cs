using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectEf_1.models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "John ";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Mage;

        public override string ToString()
        {
            return $"[ID:{this.Id},Name:{this.Name},Hitpoints:{this.HitPoints},Strength:{this.Strength},Defence:{this.Defence},Intelligence:{this.Intelligence}]";
        }

    }
}