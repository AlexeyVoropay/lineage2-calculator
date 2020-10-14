namespace L2Calc.Common.Models
{
    using System.Collections.Generic;
    using L2Calc.Common.Enums;

    public class Сharacter
    {
        public string Class { get; set; }

        public int Level { get; set; }

        public List<SkillCode> CodeSkills { get; set; }

        public string Items { get; set; }

        public string Baffs { get; set; }

        public CharacterStats CalculatedStats { get; set; }

        public string StringCalculatedStats { get; set; }

        public void ReculculateStats()
        {
            CalculatedStats.Current.SpeedRun = GetSpeedRun();
        }

        public decimal GetSpeedRun()
        {
            var skills = StatHelper.GetSkills(CodeSkills);
            var statBonuses = StatHelper.GetStatBonuses(skills);
            switch (Class)
            {
                case "Ertheia Fighter":
                    return StatHelper.GetSpeed(194, 1, 1, 1, statBonuses.SpeedStaticBonus);
                default:
                    break;
            }
            return 0;
        }
    }
}
