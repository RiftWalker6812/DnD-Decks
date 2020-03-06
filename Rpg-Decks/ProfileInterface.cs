using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Decks
{
     interface ProfileInterface
    {
        string ProfileName { get; set; }
        string HitDie { get; set; }
        string RpgClass { get; set; }
        int Level { get; set; }
        float XpValue { get; set; }
        int HpValue { get; set; }
        int HpMax { get; set; }
        int Proficiency { get; set; }
        int Ac { get; set; }
    }
}
