using L2Calc.Common.Models;

namespace L2Calc.Common
{
    public static class SkillsTable
    {
        public static Skill GetSkill(SkillCode skillCode)
        {
            switch (skillCode)
            {
                case SkillCode.ErtheiaDivineWind:
                    return new Skill
                    {
                        Code = SkillCode.ErtheiaDivineWind,
                        Name = "Воля ветра Lv 1",
                        Image = "SkillPictures/Skill_30400.jpg",
                        StatBonus = new StatBonus
                        {
                            HpPercentBonus = 0,
                            HpStaticBonus = 0,
                            SpeedStaticBonus = 0,
                        }
                    };
                case SkillCode.ErtheiaTenacity:
                    return new Skill
                    {
                        Code = SkillCode.ErtheiaTenacity,
                        Name = "Крепкое тело Lv 1",
                        Image = "SkillPictures/Skill_30401.jpg",
                        StatBonus = new StatBonus
                        {
                            HpPercentBonus = 1,
                            HpStaticBonus = 0,
                            SpeedStaticBonus = 4,
                        }
                    };
                case SkillCode.ErtheiaEfficacy:
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}