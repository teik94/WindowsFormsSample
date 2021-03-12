using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    public class Card
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public string Hp { get; set; }
        public string HpPerLvl { get; set; }
        public string MaxHp { get; set; }

        public string Atk { get; set; }
        public string AtkPerLvl { get; set; }
        public string MaxAtk { get; set; }

        public string Def { get; set; }
        public string DefPerLvl { get; set; }
        public string MaxDef { get; set; }

        public string CurrentExp { get; set; }
        public string ExpValue { get; set; }

        public string Cost { get; set; }
        public string Rarity { get; set; }

        public string Level { get; set; }
        public string MaxLevel { get; set; }

        public string Element { get; set; }

        //public string ActiveSkillId { get; set; }
        //public string PassiveSkillId { get; set; }

    }
}
