// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace L2onNew.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using L2onNew.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\_Imports.razor"
using L2onNew.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
using L2onNew.Web.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/all")]
    public partial class FetchDataAll : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 200 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
       

    private L2on.Data.Models.MyItem[] talismans;

    private string GetTypeString(L2Calc.Common.Enums.PriceType type)
    {
        switch (type)
        {
            case L2Calc.Common.Enums.PriceType.None:
                return "";
            case L2Calc.Common.Enums.PriceType.Green:
                return "<p style=\"color: green\">Green</p>";
            case L2Calc.Common.Enums.PriceType.Yellow:
                return "<p style=\"color: orange\">Yellow</p>";
            case L2Calc.Common.Enums.PriceType.Red:
                return "<p style=\"color: red\">Red</p>";
            default:
                break;
        }
        return "";
    }

    protected override async Task OnInitializedAsync()
    {
        talismans = ForecastService.GetAll(-50);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
