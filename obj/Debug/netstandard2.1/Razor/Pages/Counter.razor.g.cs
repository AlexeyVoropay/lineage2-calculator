#pragma checksum "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1699819fdaff1029a68ef6d8c37026fe70e8fadc"
// <auto-generated/>
#pragma warning disable 1591
namespace L2Calc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using L2Calc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\_Imports.razor"
using L2Calc.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
using L2Calc.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
using L2Calc.Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
using L2Calc.Common.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "CP: ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
        character.CalculatedStats.Current.CombatPoints

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " HP: ");
            __builder.AddContent(4, 
#nullable restore
#line 3 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                            character.CalculatedStats.Current.HealthPoints

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " MP: ");
            __builder.AddContent(6, 
#nullable restore
#line 3 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                                                                character.CalculatedStats.Current.ManaPoints

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.AddMarkupContent(8, "<p style=\"font-weight:bold\">Характеристики</p>\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "Физ.Атк.: ");
            __builder.AddContent(11, 
#nullable restore
#line 5 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
              character.CalculatedStats.Current.PhysicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, " Маг.Атк.: ");
            __builder.AddContent(13, 
#nullable restore
#line 5 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                          character.CalculatedStats.Current.MagicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "p");
            __builder.AddMarkupContent(16, "Физ.Защ.: ");
            __builder.AddContent(17, 
#nullable restore
#line 6 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
              character.CalculatedStats.Current.PhysicalDefence

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, " Маг.Защ.: ");
            __builder.AddContent(19, 
#nullable restore
#line 6 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                           character.CalculatedStats.Current.MagicalDefence

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "Физ.Точность: ");
            __builder.AddContent(23, 
#nullable restore
#line 7 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                  character.CalculatedStats.Current.PhysicalAccuracy

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, " Маг.Точность.: ");
            __builder.AddContent(25, 
#nullable restore
#line 7 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                                     character.CalculatedStats.Current.MagicalAccuracy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "p");
            __builder.AddMarkupContent(28, "Физ.Уклонение: ");
            __builder.AddContent(29, 
#nullable restore
#line 8 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                   character.CalculatedStats.Current.PhysicalEvasion

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, " Маг.Уклонение: ");
            __builder.AddContent(31, 
#nullable restore
#line 8 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                                     character.CalculatedStats.Current.MagicalEvasion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.OpenElement(33, "p");
            __builder.AddMarkupContent(34, "Физ.Крит.Атк.: ");
            __builder.AddContent(35, 
#nullable restore
#line 9 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                   character.CalculatedStats.Current.CriticalPhysicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, " Маг.Крит.Атк.: ");
            __builder.AddContent(37, 
#nullable restore
#line 9 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                                            character.CalculatedStats.Current.CriticalMagicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.OpenElement(39, "p");
            __builder.AddMarkupContent(40, "Скорость Атк.: ");
            __builder.AddContent(41, 
#nullable restore
#line 10 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                   character.CalculatedStats.Current.SpeedPhysicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, " Скорость Маг.: ");
            __builder.AddContent(43, 
#nullable restore
#line 10 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                                         character.CalculatedStats.Current.SpeedMagicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenElement(45, "p");
            __builder.AddMarkupContent(46, "Скорость: ");
            __builder.AddContent(47, 
#nullable restore
#line 11 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
              character.CalculatedStats.Current.SpeedRun

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.AddMarkupContent(49, "<p style=\"font-weight:bold\">Базовые характеристики</p>\r\n");
            __builder.OpenElement(50, "p");
            __builder.AddMarkupContent(51, "СИЛ: ");
            __builder.AddContent(52, 
#nullable restore
#line 13 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
         character.CalculatedStats.Base.STR

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, " ЛВК: ");
            __builder.AddContent(54, 
#nullable restore
#line 13 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                  character.CalculatedStats.Base.DEX

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(55, " ВЫН: ");
            __builder.AddContent(56, 
#nullable restore
#line 13 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                                           character.CalculatedStats.Base.CON

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenElement(58, "p");
            __builder.AddMarkupContent(59, "ИНТ: ");
            __builder.AddContent(60, 
#nullable restore
#line 14 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
         character.CalculatedStats.Base.INT

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(61, " МДР: ");
            __builder.AddContent(62, 
#nullable restore
#line 14 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                  character.CalculatedStats.Base.WIT

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, " ДУХ: ");
            __builder.AddContent(64, 
#nullable restore
#line 14 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                                                           character.CalculatedStats.Base.MEN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.OpenElement(66, "p");
            __builder.AddMarkupContent(67, "УДЧ: ");
            __builder.AddContent(68, 
#nullable restore
#line 15 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
         character.CalculatedStats.Base.LUC

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(69, " ХАР: ");
            __builder.AddContent(70, 
#nullable restore
#line 15 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                                  character.CalculatedStats.Base.CHA

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n<img src=\"SkillPictures/Skill_30400.jpg\" asp-append-version=\"true\" alt=\"First slide\">\r\n<br>\r\n");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-primary");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.AddMarkupContent(77, "<p style=\"font-weight:bold\">StatBonus</p>\r\n");
            __builder.OpenElement(78, "p");
            __builder.AddContent(79, "HpPercentBonus: ");
            __builder.AddContent(80, 
#nullable restore
#line 20 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                    StatBonus.HpPercentBonus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.OpenElement(82, "p");
            __builder.AddContent(83, "HpStaticBonus: ");
            __builder.AddContent(84, 
#nullable restore
#line 21 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                   StatBonus.HpStaticBonus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.OpenElement(86, "p");
            __builder.AddContent(87, "SpeedStaticBonus: ");
            __builder.AddContent(88, 
#nullable restore
#line 22 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                      StatBonus.SpeedStaticBonus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n");
            __builder.AddMarkupContent(90, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(91, "p");
            __builder.AddContent(92, "Current count: ");
            __builder.AddContent(93, 
#nullable restore
#line 26 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n<p></p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
       

    private L2Calc.Common.Models.Сharacter character => CharactersTable.GetFirstСharacter();
    private BaseCharacteristics characteristics => StatHelper.GetCharacteristics(CharacterType.Arteya);
    private StatBonus StatBonus => StatHelper.GetStatBonuses(StatHelper.GetSkills(new List<SkillCode> { SkillCode.ErtheiaTenacity }));
    private int currentCount = 0;

    private decimal cpPoints = 0;
    private decimal hpPoints = 0;
    private decimal mpPoints = 0;

    //private int strength = 39;
    //private int dexterity = 30;
    //private int endurance = 37;

    //private int intelligence = 85;
    //private int wisdom = 77;
    //private int spirit = 73;

    //private int lucky = 32;
    //private int charisma = 43;


    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
