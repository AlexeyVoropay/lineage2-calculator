using L2Calc.Common.Models;

namespace L2Calc.Common
{
    public static class ItemsTable
    {
        public static Item GetItem(string itemId)
        {
            switch (itemId)
            {
                //48568	Фрагмент Агатиона Стража	-65%	150000		0	150000		час назад
                case "48568":
                    return new Item
                    {
                        Id = "48568",
                        Name = "Фрагмент Агатиона Стража",
                        EngName = "",
                        Note = "",
                        Description = "",
                        Code = ItemCode.None,
                        Weight = 1,
                        Lifetime = 0,
                        Price = 0,
                        GreenPrice = 650000,
                        RedPrice = 200000,
                    };
                case "17408":
                    return new Item
                    {
                        Id = "17408",
                        Name = "Туника Кадейры",
                        EngName = "",
                        Note = "",
                        Description = "",
                        Code = ItemCode.None,
                        Weight = 1750,
                        Lifetime = 0,
                        Price = 153308000,
                        GreenPrice = 153308000,
                        RedPrice = 100000000,
                    };
                case "37780":
                    return new Item
                    {
                        Id = "37780",
                        Name = "Свиток Благословения - Доспех R95",
                        EngName = "",
                        Note = "",
                        Description = "",
                        Code = ItemCode.None,
                        Weight = 100,
                        Lifetime = 0,
                        Price = 31920000,
                        GreenPrice = 31920000,
                        RedPrice = 1500000,
                    };
                case "17631":
                    return new Item
                    {
                        Id = "17631",
                        Name = "Древняя Краска Ур. 1 - СИЛ",
                        EngName = "",
                        Note = "",
                        Description = "Если отдать 10 флаконов этой краски Торговцу Красками, то персонаж получит татуировку, изменяющую его характеристики. Требования: Все классы после перерождения и 3-го освобождения.",
                        Code = ItemCode.None,
                        Weight = 150,
                        Lifetime = 0,
                        Price = 173100,
                        GreenPrice = 173100,
                        RedPrice = 86550,
                    };
                case "17714"://ItemCode.LegendaryMenDyeLv5:
                    return new Item
                    {
                        Id = "17714",
                        Name = "Легендарная Краска Ур. 5 - ДУХ",
                        EngName = "Legendary MEN Dye Lv. 5",
                        Note = "ДУХ+5 ИНТ+1 Сопротивление святости +25",
                        Description = "Если отдать 10 флаконов этой краски Торговцу Красками, то персонаж получит татуировку, изменяющую его характеристики. Требования: Все классы после перерождения и 3-го освобождения.",
                        Code = ItemCode.LegendaryMenDyeLv5,
                        Weight = 150,
                        Lifetime = 0,
                        Price = 10892425,
                        GreenPrice = 10892425,
                        RedPrice = 5446212,
                    };
                case "17644":
                    return new Item
                    {
                        Id = "17644",
                        Name = "Краска Гигантов Ур. 2 - ЛВК",
                        EngName = "Giant's DEX Dye Lv. 2",
                        Note = "",
                        Description = "Если отдать 10 флаконов этой краски Торговцу Красками, то персонаж получит татуировку, изменяющую его характеристики. Требования: Все классы после перерождения и 3-го освобождения.",
                        Code = ItemCode.None,
                        Weight = 150,
                        Lifetime = 0,
                        Price = 274425,
                        GreenPrice = 274425,
                        RedPrice = 137212,
                    };
               //case SkillCode.ErtheiaTenacity:
               //    return new Skill
               //    {
               //        Code = SkillCode.ErtheiaTenacity,
               //        Name = "Крепкое тело Lv 1",
               //        Image = "SkillPictures/Skill_30401.jpg",
               //        StatBonus = new StatBonus
               //        {
               //            HpPercentBonus = 1,
               //            HpStaticBonus = 0,
               //            SpeedStaticBonus = 4,
               //        }
               //    };
               //case SkillCode.ErtheiaEfficacy:
               //    return new Skill
               //    {
               //        Code = SkillCode.ErtheiaTenacity,
               //        Name = "",
               //        Image = "SkillPictures/Skill_30402.jpg",
               //        StatBonus = new StatBonus
               //        {
               //            HpPercentBonus = 0,
               //            HpStaticBonus = 0,
               //            SpeedStaticBonus = 0,
               //        }
               //    };
               default:
                    break;
            }
            return null;
        }
    }
}


//MP +31, Физ./ Маг. Точность +4,
//сила Физ. Крит. Атк./ сила Крит. Атк. маг. умений +15%,
//Скор. Атк./ Скор Маг. +5%,
//шанс и сопротивление замешательству/ помехам +25%.
//MP +31, Физ./ Маг. Точность +4, 
//шанс Физ. Крит. Атк./ шанс Крит. Атк. маг. умений +20,
//сила Физ./ Маг. Крит. Атк. +15%, 
//шанс и сопротивление замешательству/ заражению +25%.
// Кольцо Души Королевы Муравьев