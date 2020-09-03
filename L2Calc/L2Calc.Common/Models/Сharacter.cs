namespace L2Calc.Common.Models
{
    using System.Collections.Generic;

    public class Сharacter
    {
        public string Class { get; set; }

        public int Level { get; set; }

        public List<SkillCode> Skills { get; set; }

        public string Items { get; set; }

        public string Baffs { get; set; }

        public CharacterStats CalculatedStats { get; set; }
        public string StringCalculatedStats { get; set; }
    }
}
