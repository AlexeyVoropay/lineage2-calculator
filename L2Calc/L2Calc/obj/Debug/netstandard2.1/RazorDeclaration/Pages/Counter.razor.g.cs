#pragma checksum "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e2e6be74a90836dd4a59df5a5331784b93c8ceb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Zver\Desktop\L2Calc\L2Calc\L2Calc\Pages\Counter.razor"
       
    private Characteristics characteristics => StatHelper.GetCharacteristics(StatHelper.CharacterType.Arteya);
    private StatBonus StatBonus => StatHelper.GetStatBonuses(StatHelper.GetSkills(new List<SkillCode> { SkillCode.ErtheiaTenacity }));
    private int currentCount = 0;

    private decimal cpPoints = 0;
    private decimal hpPoints = 0;
    private decimal mpPoints = 0;

    private int strength = 39;
    private int dexterity = 30;
    private int endurance = 37;

    private int intelligence = 85;
    private int wisdom = 77;
    private int spirit = 73;

    private int lucky = 32;
    private int charisma = 43;


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
