#pragma checksum "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa7c7451b4d3dedbd841f9d66f086412284e574e"
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
#line 52 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
using L2Calc.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
using L2Calc.Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
using L2Calc.Common.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<L2Calc.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group row");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<label class=\"control-label col-md-12\">Язык</label>\r\n        ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                DoStuff

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "0");
            __builder.AddMarkupContent(17, "Выберите язык");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 14 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                             (int)CharacterType.Arteya

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, "Arteya");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 15 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                             (int)CharacterType.Feo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, "Feo");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, 
#nullable restore
#line 20 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
    CharacterType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, "CP: ");
            __builder.AddContent(35, 
#nullable restore
#line 22 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
        character.CalculatedStats.Current.CombatPoints

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, " HP: ");
            __builder.AddContent(37, 
#nullable restore
#line 22 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                            character.CalculatedStats.Current.HealthPoints

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, " MP: ");
            __builder.AddContent(39, 
#nullable restore
#line 22 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                                                                character.CalculatedStats.Current.ManaPoints

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.AddMarkupContent(41, "<p style=\"font-weight:bold\">Характеристики</p>\r\n");
            __builder.OpenElement(42, "p");
            __builder.AddMarkupContent(43, "Физ.Атк.: ");
            __builder.AddContent(44, 
#nullable restore
#line 24 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
              character.CalculatedStats.Current.PhysicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, " Маг.Атк.: ");
            __builder.AddContent(46, 
#nullable restore
#line 24 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                          character.CalculatedStats.Current.MagicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.OpenElement(48, "p");
            __builder.AddMarkupContent(49, "Физ.Защ.: ");
            __builder.AddContent(50, 
#nullable restore
#line 25 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
              character.CalculatedStats.Current.PhysicalDefence

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, " Маг.Защ.: ");
            __builder.AddContent(52, 
#nullable restore
#line 25 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                           character.CalculatedStats.Current.MagicalDefence

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.OpenElement(54, "p");
            __builder.AddMarkupContent(55, "Физ.Точность: ");
            __builder.AddContent(56, 
#nullable restore
#line 26 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                  character.CalculatedStats.Current.PhysicalAccuracy

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, " Маг.Точность.: ");
            __builder.AddContent(58, 
#nullable restore
#line 26 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                                     character.CalculatedStats.Current.MagicalAccuracy

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.OpenElement(60, "p");
            __builder.AddMarkupContent(61, "Физ.Уклонение: ");
            __builder.AddContent(62, 
#nullable restore
#line 27 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                   character.CalculatedStats.Current.PhysicalEvasion

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(63, " Маг.Уклонение: ");
            __builder.AddContent(64, 
#nullable restore
#line 27 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                                     character.CalculatedStats.Current.MagicalEvasion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.OpenElement(66, "p");
            __builder.AddMarkupContent(67, "Физ.Крит.Атк.: ");
            __builder.AddContent(68, 
#nullable restore
#line 28 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                   character.CalculatedStats.Current.CriticalPhysicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(69, " Маг.Крит.Атк.: ");
            __builder.AddContent(70, 
#nullable restore
#line 28 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                                            character.CalculatedStats.Current.CriticalMagicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.OpenElement(72, "p");
            __builder.AddMarkupContent(73, "Скорость Атк.: ");
            __builder.AddContent(74, 
#nullable restore
#line 29 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                   character.CalculatedStats.Current.SpeedPhysicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(75, " Скорость Маг.: ");
            __builder.AddContent(76, 
#nullable restore
#line 29 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                                         character.CalculatedStats.Current.SpeedMagicalAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.OpenElement(78, "p");
            __builder.AddMarkupContent(79, "Скорость: ");
            __builder.AddContent(80, 
#nullable restore
#line 30 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
              character.CalculatedStats.Current.SpeedRun

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.AddMarkupContent(82, "<p style=\"font-weight:bold\">Базовые характеристики</p>\r\n");
            __builder.OpenElement(83, "p");
            __builder.AddMarkupContent(84, "СИЛ: ");
            __builder.AddContent(85, 
#nullable restore
#line 32 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
         character.CalculatedStats.Base.STR

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(86, " ЛВК: ");
            __builder.AddContent(87, 
#nullable restore
#line 32 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                  character.CalculatedStats.Base.DEX

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(88, " ВЫН: ");
            __builder.AddContent(89, 
#nullable restore
#line 32 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                                           character.CalculatedStats.Base.CON

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
            __builder.OpenElement(91, "p");
            __builder.AddMarkupContent(92, "ИНТ: ");
            __builder.AddContent(93, 
#nullable restore
#line 33 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
         character.CalculatedStats.Base.INT

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(94, " МДР: ");
            __builder.AddContent(95, 
#nullable restore
#line 33 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                  character.CalculatedStats.Base.WIT

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(96, " ДУХ: ");
            __builder.AddContent(97, 
#nullable restore
#line 33 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                                                           character.CalculatedStats.Base.MEN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.OpenElement(99, "p");
            __builder.AddMarkupContent(100, "УДЧ: ");
            __builder.AddContent(101, 
#nullable restore
#line 34 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
         character.CalculatedStats.Base.LUC

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(102, " ХАР: ");
            __builder.AddContent(103, 
#nullable restore
#line 34 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                                  character.CalculatedStats.Base.CHA

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n<br>\r\n");
            __builder.OpenElement(105, "button");
            __builder.AddAttribute(106, "class", "btn btn-primary");
            __builder.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(108, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.OpenElement(110, "button");
            __builder.AddAttribute(111, "class", "btn btn-primary");
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                                          Reculculate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(113, "Reculculate");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
            __builder.AddMarkupContent(115, "<p style=\"font-weight:bold\">StatBonus</p>\r\n");
            __builder.OpenElement(116, "p");
            __builder.AddContent(117, "HpPercentBonus: ");
            __builder.AddContent(118, 
#nullable restore
#line 43 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                    StatBonus.HpPercentBonus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
            __builder.OpenElement(120, "p");
            __builder.AddContent(121, "HpStaticBonus: ");
            __builder.AddContent(122, 
#nullable restore
#line 44 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                   StatBonus.HpStaticBonus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
            __builder.OpenElement(124, "p");
            __builder.AddContent(125, "SpeedStaticBonus: ");
            __builder.AddContent(126, 
#nullable restore
#line 45 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                      StatBonus.SpeedStaticBonus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n");
            __builder.AddMarkupContent(128, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(129, "p");
            __builder.AddContent(130, "Current count: ");
            __builder.AddContent(131, 
#nullable restore
#line 49 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n<p></p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Index.razor"
       

    private L2Calc.Common.Models.Сharacter character { get; set; }
    private BaseCharacteristics characteristics => StatHelper.GetCharacteristics(CharacterType.Arteya);
    private StatBonus StatBonus => StatHelper.GetStatBonuses(StatHelper.GetSkills(new List<SkillCode> { SkillCode.ErtheiaTenacity }));
    private int currentCount = 0;

    private decimal cpPoints = 0;
    private decimal hpPoints = 0;
    private decimal mpPoints = 0;

    private CharacterType CharacterType { get; set; }

    //private int strength = 39;
    //private int dexterity = 30;
    //private int endurance = 37;

    //private int intelligence = 85;
    //private int wisdom = 77;
    //private int spirit = 73;

    //private int lucky = 32;
    //private int charisma = 43;

    protected override void OnInitialized()
    {
        character = CharactersTable.GetStartСharacter(CharacterType.Arteya);
    }

    //    Чтобы выполнить асинхронную операцию, переопределите OnInitializedAsync и используйте в операции оператор await.    //    C#    //Копировать
    //protected override async Task OnInitializedAsync()
    //    {
    //        await ...
    //}

    private void IncrementCount()
    {
        currentCount++;
    }
    private void Reculculate()
    {
        character.ReculculateStats();
    }

    protected void DoStuff(ChangeEventArgs e)
    {
        if (int.TryParse(e.Value.ToString(), out var intValue))
        {
            CharacterType = (CharacterType)intValue;
            character = CharactersTable.GetStartСharacter(CharacterType);
            //RefreshItemList(PageNumber);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
