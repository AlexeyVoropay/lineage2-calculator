using System;
using System.Collections.Generic;
using System.Text;

namespace L2on.Data
{
    public static class MyPrices
    {
        public static List<KeyValuePair<string, long>> GetPrices()
        {
            return new List<KeyValuePair<string, long>>
            {
                //1
                new KeyValuePair<string, long>( "39634", 1250000 ),
                new KeyValuePair<string, long>( "39635", 2565789 ),
                new KeyValuePair<string, long>( "39636", 5266620 ),
                new KeyValuePair<string, long>( "39637", 10810431 ),
                //5
                new KeyValuePair<string, long>( "39638", 22189833 ),
                new KeyValuePair<string, long>( "39639", 45547552 ),
                new KeyValuePair<string, long>( "39640", 93492344 ),
                new KeyValuePair<string, long>( "39641", 191905338 ),
                new KeyValuePair<string, long>( "39642", 393910957 ),
                //10
                new KeyValuePair<string, long>( "39643", 808554070 ),
                new KeyValuePair<string, long>( "39644", 1659663617 ),
                new KeyValuePair<string, long>( "39645", 3406677952 ),
                new KeyValuePair<string, long>( "39646", 6992654744 ),
                new KeyValuePair<string, long>( "39647", 14353343948 ),
                //15
                new KeyValuePair<string, long>( "39648", 29462127052 ),
                new KeyValuePair<string, long>( "39649", 60474892371 ),
                new KeyValuePair<string, long>( "39650", 124132673815 ),
                new KeyValuePair<string, long>( "39651", 254798646253 ),
                new KeyValuePair<string, long>( "39652", 523007747572 ),
                //20
                new KeyValuePair<string, long>( "39653", 1073542218701 ),
                new KeyValuePair<string, long>( "39654", 2203586659440 ),
                new KeyValuePair<string, long>( "39655", 4523151564115 ),
                new KeyValuePair<string, long>( "39655", 9284363736868 ),
                new KeyValuePair<string, long>( "39655", 19057378196729 ),
                //25
                new KeyValuePair<string, long>( "39655", 39117776298549 ),

                // Древняя Краска Ур. 1 - СИЛ (СИЛ+3 ЛВК-2 Сопротивление огню +5)
                new KeyValuePair<string, long>( "17631", 86550 ),
                // Легендарная Краска Ур. 5 - МДР (МДР+5 ДУХ+1 Сопротивление ветру +25)
                new KeyValuePair<string, long>( "17713", 5446212 ),
                // Легендарная Краска Ур. 5 - ДУХ
                new KeyValuePair<string, long>( "17714", 5446212 ),
                // Краска Гигантов Ур. 2 - ЛВК
                new KeyValuePair<string, long>( "17644", 137212 ),
                // Краска Гигантов Ур. 3 - ВЫН
                new KeyValuePair<string, long>( "17663", 314750 ),
                // Древняя Краска Ур. 3 - СИЛ
                new KeyValuePair<string, long>( "17667", 411975 ),
                // Краска Гигантов Ур. 5 - ДУХ
                new KeyValuePair<string, long>( "17702", 4485537 ),                
            };
        }
    }
}
