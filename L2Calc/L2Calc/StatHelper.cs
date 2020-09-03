using System.Collections.Generic;
using System.Dynamic;
using L2Calc.Common;
using L2Calc.Common.Enums;
using L2Calc.Common.Models;

namespace L2Calc
{
    public static partial class StatHelper
    {
        /*
         персонаж
        Хар-ка        Влияние
        СИЛ (STR)     Физ. Атк.
        ЛВК (DEX)     Скор. Атк., Физ. Точность, Физ. Уклонение, шанс Физ. Крит. Атк.
        ВЫН (CON)     Макс. HP / CP и скорость восстановления HP / CP, лимит веса, объем легких, Шанс Блока Щитом.
        УДЧ (LUC)     Влияет на шанс успеха при модификации / производстве / использовании личной мастерской. Дает бонусы к умениям Оценка и Обман. Влияет на шанс успешной защиты от смертельного урона.
        ИНТ (INT)     Маг. Атк.
        МДР (WIT)     Скор. Маг., Маг. Точность, Маг. Уклонение, шанс Маг. Крит. Атк., сопротивление магии.
        ДУХ (MEN)     Маг. Защ., Макс. MP и скорость восстановления MP, шанс отмены магии.
        ХАР (CHA)     Физ. Атк., Физ. Защ., Скор. Атк., Маг. Атк., Маг. Защ., Скор. Маг, Макс. HP / MP / CP и скорость восстановления HP / MP / CP. 
         */

        public static BaseCharacteristics GetCharacteristics(CharacterType characterType)
        {
            switch (characterType)
            {
                case CharacterType.Feo:
                    //не проверено
                    return new BaseCharacteristics
                    {
                        STR = 39,
                        DEX = 30,
                        CON = 37,
                        INT = 85,
                        WIT = 77,
                        MEN = 73,
                        LUC = 32,
                        CHA = 43
                    };
                case CharacterType.Arteya:
                    //проверено
                    return new BaseCharacteristics
                    {
                        STR = 89,
                        DEX = 52,
                        CON = 84,
                        INT = 40,
                        WIT = 37,
                        MEN = 39,
                        LUC = 34,
                        CHA = 41
                    };
                default:
                    break;
            }
            return null;
        }
        public static StartCharacteristics GetBaseCharacteristics(CharacterType characterType)
        {
            switch (characterType)
            {
                case CharacterType.Feo:
                    //не проверено
                    return new StartCharacteristics
                    {
                        BaseSpeedRun = 122,
                        BaseSpeedWalk = 85,
                    };
                case CharacterType.Arteya:
                    return new StartCharacteristics
                    {
                        BaseSpeedRun = 191,
                        BaseSpeedWalk = 138,
                    };
                default:
                    break;
            }
            return null;
        }
        public static StartCharacteristics GetBaseSkills(CharacterType characterType)
        {
            switch (characterType)
            {
                case CharacterType.Feo:
                    //не проверено
                    return new StartCharacteristics
                    {
                        BaseSpeedRun = 122,
                        BaseSpeedWalk = 85,
                    };
                case CharacterType.Arteya:
                    return new StartCharacteristics
                    {
                        BaseSpeedRun = 191,
                        BaseSpeedWalk = 138,
                    };
                default:
                    break;
            }
            return null;
        }

        public static StatBonus GetStatBonuses(List<Skill> skills)
        {
            var result = new StatBonus();
            foreach (var skill in skills)
            {
                result.HpPercentBonus += skill.StatBonus.HpPercentBonus;
                result.HpStaticBonus += skill.StatBonus.HpStaticBonus;
                result.SpeedStaticBonus += skill.StatBonus.SpeedStaticBonus;
            }
            return result;
        }

        public static List<Skill> GetSkills(List<SkillCode> skillCodes)
        {
            var result = new List<Skill>();
            foreach (var skillCode in skillCodes)
            {
                result.Add(SkillsTable.GetSkill(skillCode));
            }
            return result;
        }

        public static decimal GetCpPoints(decimal baseCpPoints, decimal modifieredCon, decimal modifieredCha, decimal percentCpBonus, decimal staticCpBonus)
        {
            return baseCpPoints * modifieredCon * modifieredCha * percentCpBonus + staticCpBonus;
        }
        public static decimal GetHpPoints(decimal baseHpPoints, decimal modifieredCon, decimal modifieredCha, decimal percentHpBonus, decimal staticHpBonus)
        {
            return baseHpPoints * modifieredCon * modifieredCha * percentHpBonus + staticHpBonus;
        }
        public static decimal GetSpeed(decimal baseSpeed, decimal modifieredCon, decimal modifieredCha, decimal percentHpBonus, decimal staticHpBonus)
        {
            return baseSpeed * modifieredCon * modifieredCha * percentHpBonus + staticHpBonus;
        }
    }
}
