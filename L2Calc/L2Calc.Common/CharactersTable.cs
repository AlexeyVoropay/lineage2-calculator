using L2Calc.Common.Models;

namespace L2Calc.Common
{
    public static class CharactersTable
    {
        public static Сharacter GetFirstСharacter()
        {
            return new Сharacter
            {
                Class = "Ertheia Fighter",
                Level = 1,
                Baffs = null,
                Items = null,
                Skills = new System.Collections.Generic.List<SkillCode>
                {
                    SkillCode.ErtheiaDivineWind,
                    SkillCode.ErtheiaTenacity,
                    SkillCode.ErtheiaEfficacy,
                },
                CalculatedStats = new CharacterStats
                {
                    Base = new BaseCharacteristics
                    {
                        STR = 89,
                        DEX = 52,
                        CON = 84,
                        INT = 40,
                        WIT = 37,
                        MEN = 39,
                        LUC = 34,
                        CHA = 41
                    },
                },
                StringCalculatedStats =
                "Класс: Воин Артеи" +
                "СP: 71" + "HP: 143" + "MP: 39" +
                "MaxVP: ?" + "MaxWeight: ?" +

                "СP: " + "HP: " + "MP: " +
                "СP: " + "HP: " + "MP: " +
                "Скорость: 195" + "HP: " + "MP: ",
            };
        }

    }
}
