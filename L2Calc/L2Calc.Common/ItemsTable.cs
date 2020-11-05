using L2Calc.Common.Models;

namespace L2Calc.Common
{
    public static class ItemsTable
    {
        public static Item GetItem(string itemId)
        {
            switch (itemId)
            {
                case "47556":
                    return new Item
                    {
                        Id = "47556",
                        Name = "Звездная Пыль",
                        EngName = "",
                        Note = "",
                        Description = "Позволяет создать Браслет Семени Низкого Качества.",
                        Code = ItemCode.None,
                        Weight = 1,
                        Lifetime = 0,
                        Price = 1000000,
                        GreenPrice = 3500000,
                        RedPrice = 3000000,
                    };
                case "3031":
                    return new Item
                    {
                        Id = "3031",
                        Name = "Руда Духов",
                        EngName = "",
                        Note = "",
                        Description = "",
                        Code = ItemCode.None,
                        Weight = 0,
                        Lifetime = 0,
                        Price = 400,
                        GreenPrice = 460,
                        RedPrice = 460,
                    };
                case "736":
                    return new Item
                    {
                        Id = "736",
                        Name = "Свиток Телепорта",
                        EngName = "",
                        Note = "",
                        Description = "",
                        Code = ItemCode.None,
                        Weight = 10,
                        Lifetime = 0,
                        Price = 400,
                        GreenPrice = 460,
                        RedPrice = 460,
                    };
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

                #region Краска
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
                case "17707":
                    return new Item
                    {
                        Id = "17707",
                        Name = "Древняя Краска Ур. 5 - МДР",
                        EngName = "",
                        Note = "",
                        Description = "",
                        Code = ItemCode.None,
                        Weight = 150,
                        Lifetime = 0,
                        Price = 9931750,
                        GreenPrice = 9931750,
                        RedPrice = 4965875,
                    };
                case "17713":
                    return new Item
                    {
                        Id = "17713",
                        Name = "Легендарная Краска Ур. 5 - МДР",
                        EngName = "",
                        Note = "",
                        Description = "",
                        Code = ItemCode.None,
                        Weight = 150,
                        Lifetime = 0,
                        Price = 10892425,
                        GreenPrice = 10892425,
                        RedPrice = 5446212,
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
                #endregion Краска
                                   
                default:
                    break;
            }
            return null;
        }
    }
}