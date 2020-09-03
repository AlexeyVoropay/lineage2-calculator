namespace L2Calc.Common
{
    using System.Collections.Generic;
    using System.Linq;
    using L2Calc.Common.Models;

    public static class SampleCharacterStats
    {
        public static string GetSampleCharacterStats(Сharacter character)
        {
            var skills1 = new List<SkillCode>
                {
                    SkillCode.ErtheiaDivineWind,
                    SkillCode.ErtheiaTenacity,
                    SkillCode.ErtheiaEfficacy,
                };
            if (character.Level == 1 &&
                character.Items == null &&
                character.Baffs == null &&
                character.Class == "Ertheia Fighter" &&
                character.Skills.All(x => skills1.Any(y => y == x)) &&
                skills1.All(x => character.Skills.Any(y => y == x))
                )
            {
                return null;
            }
            return null;
        }
    }
}
