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
                    Current = new StateCharacteristics
                    {
                        CombatPoints = 71,
                        HealthPoints = 143,
                        ManaPoints = 39,
                        PhysicalAttack = 4,
                        MagicalAttack = 3,
                        PhysicalDefence = 72,
                        MagicalDefence = 48,
                        PhysicalAccuracy = 37,
                        MagicalAccuracy = 20,
                        PhysicalEvasion = 37,
                        MagicalEvasion = 20,
                        CriticalPhysicalAttack = 47,
                        CriticalMagicalAttack = 33,
                        SpeedPhysicalAttack = 349,
                        SpeedMagicalAttack = 223,
                        SpeedRun = 195,
                        SpeedWalk = 142,                        
                    }
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
