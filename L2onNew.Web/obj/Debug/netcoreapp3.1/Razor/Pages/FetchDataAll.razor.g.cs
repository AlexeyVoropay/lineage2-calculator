#pragma checksum "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63dede11208387c163e4bb2eee2985667f6a9fd3"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Все предметы (-50%)</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
 if (talismans == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p>group_recipe</p>\r\n    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, @"<thead>
            <tr>
                <th></th>
                <th>Идентификатор</th>
                <th>Предмет</th>
                <th>Процент</th>
                <th>Цена</th>
                <th>Тип цены</th>
                <th>Моя цена</th>
                <th>Разница</th>
                <th>Разница в %</th>
                <th>Замечен</th>
                <th>Что-то</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 32 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
             foreach (var talisman in talismans.Where(x => x.GroupName == "group_recipe"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "height", "30");
            __builder.AddAttribute(17, "width", "30");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 35 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                                                           talisman.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 36 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 37 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 38 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Percent.HasValue ? $"{talisman.Percent.ToString()}%" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 39 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 40 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          (MarkupString)GetTypeString(talisman.PriceType)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 41 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.MyPriceText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 42 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Price - talisman.MyPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 43 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.MyPrice != 0 ? $"{Math.Round((decimal)(talisman.Price - talisman.MyPrice)/(talisman.MyPrice)*100)} %" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 44 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.SpottedTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 45 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Other

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 47 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
            __builder.AddContent(54, "    ");
            __builder.AddMarkupContent(55, "<p>group_book</p>\r\n    ");
            __builder.OpenElement(56, "table");
            __builder.AddAttribute(57, "class", "table");
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.AddMarkupContent(59, @"<thead>
            <tr>
                <th></th>
                <th>Идентификатор</th>
                <th>Предмет</th>
                <th>Процент</th>
                <th>Цена</th>
                <th>Тип цены</th>
                <th>Моя цена</th>
                <th>Разница</th>
                <th>Разница в %</th>
                <th>Замечен</th>
                <th>Что-то</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(60, "tbody");
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 69 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
             foreach (var talisman in talismans.Where(x => x.GroupName == "group_book"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "                ");
            __builder.OpenElement(63, "tr");
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
            __builder.OpenElement(66, "img");
            __builder.AddAttribute(67, "height", "30");
            __builder.AddAttribute(68, "width", "30");
            __builder.AddAttribute(69, "src", 
#nullable restore
#line 72 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                                                           talisman.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 73 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 74 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 75 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Percent.HasValue ? $"{talisman.Percent.ToString()}%" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 76 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 77 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          (MarkupString)GetTypeString(talisman.PriceType)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "td");
            __builder.AddContent(87, 
#nullable restore
#line 78 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.MyPriceText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 79 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Price - talisman.MyPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, 
#nullable restore
#line 80 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.MyPrice != 0 ? $"{Math.Round((decimal)(talisman.Price - talisman.MyPrice)/(talisman.MyPrice)*100)} %" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                    ");
            __builder.OpenElement(95, "td");
            __builder.AddContent(96, 
#nullable restore
#line 81 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.SpottedTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenElement(98, "td");
            __builder.AddContent(99, 
#nullable restore
#line 82 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Other

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 84 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(102, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
            __builder.AddContent(105, "    ");
            __builder.AddMarkupContent(106, "<p>group_weapon</p>\r\n    ");
            __builder.OpenElement(107, "table");
            __builder.AddAttribute(108, "class", "table");
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.AddMarkupContent(110, @"<thead>
            <tr>
                <th></th>
                <th>Идентификатор</th>
                <th>Предмет</th>
                <th>Процент</th>
                <th>Цена</th>
                <th>Тип цены</th>
                <th>Моя цена</th>
                <th>Разница</th>
                <th>Разница в %</th>
                <th>Замечен</th>
                <th>Что-то</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(111, "tbody");
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 106 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
             foreach (var talisman in talismans.Where(x => x.GroupName == "group_weapon"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "                ");
            __builder.OpenElement(114, "tr");
            __builder.AddMarkupContent(115, "\r\n                    ");
            __builder.OpenElement(116, "td");
            __builder.OpenElement(117, "img");
            __builder.AddAttribute(118, "height", "30");
            __builder.AddAttribute(119, "width", "30");
            __builder.AddAttribute(120, "src", 
#nullable restore
#line 109 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                                                           talisman.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                    ");
            __builder.OpenElement(122, "td");
            __builder.AddContent(123, 
#nullable restore
#line 110 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                    ");
            __builder.OpenElement(125, "td");
            __builder.AddContent(126, 
#nullable restore
#line 111 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                    ");
            __builder.OpenElement(128, "td");
            __builder.AddContent(129, 
#nullable restore
#line 112 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Percent.HasValue ? $"{talisman.Percent.ToString()}%" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                    ");
            __builder.OpenElement(131, "td");
            __builder.AddContent(132, 
#nullable restore
#line 113 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.OpenElement(134, "td");
            __builder.AddContent(135, 
#nullable restore
#line 114 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          (MarkupString)GetTypeString(talisman.PriceType)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.OpenElement(137, "td");
            __builder.AddContent(138, 
#nullable restore
#line 115 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.MyPriceText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                    ");
            __builder.OpenElement(140, "td");
            __builder.AddContent(141, 
#nullable restore
#line 116 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Price - talisman.MyPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                    ");
            __builder.OpenElement(143, "td");
            __builder.AddContent(144, 
#nullable restore
#line 117 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.MyPrice != 0 ? $"{Math.Round((decimal)(talisman.Price - talisman.MyPrice)/(talisman.MyPrice)*100)} %" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                    ");
            __builder.OpenElement(146, "td");
            __builder.AddContent(147, 
#nullable restore
#line 118 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.SpottedTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                    ");
            __builder.OpenElement(149, "td");
            __builder.AddContent(150, 
#nullable restore
#line 119 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Other

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
#nullable restore
#line 121 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(153, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n");
            __builder.AddContent(156, "    ");
            __builder.AddMarkupContent(157, "<p>group_armor</p>\r\n    ");
            __builder.OpenElement(158, "table");
            __builder.AddAttribute(159, "class", "table");
            __builder.AddMarkupContent(160, "\r\n        ");
            __builder.AddMarkupContent(161, @"<thead>
            <tr>
                <th></th>
                <th>Идентификатор</th>
                <th>Предмет</th>
                <th>Процент</th>
                <th>Цена</th>
                <th>Тип цены</th>
                <th>Моя цена</th>
                <th>Разница</th>
                <th>Разница в %</th>
                <th>Замечен</th>
                <th>Что-то</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(162, "tbody");
            __builder.AddMarkupContent(163, "\r\n");
#nullable restore
#line 143 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
             foreach (var talisman in talismans.Where(x => x.GroupName == "group_armor"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(164, "                ");
            __builder.OpenElement(165, "tr");
            __builder.AddMarkupContent(166, "\r\n                    ");
            __builder.OpenElement(167, "td");
            __builder.OpenElement(168, "img");
            __builder.AddAttribute(169, "height", "30");
            __builder.AddAttribute(170, "width", "30");
            __builder.AddAttribute(171, "src", 
#nullable restore
#line 146 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                                                           talisman.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n                    ");
            __builder.OpenElement(173, "td");
            __builder.AddContent(174, 
#nullable restore
#line 147 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                    ");
            __builder.OpenElement(176, "td");
            __builder.AddContent(177, 
#nullable restore
#line 148 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                    ");
            __builder.OpenElement(179, "td");
            __builder.AddContent(180, 
#nullable restore
#line 149 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Percent.HasValue ? $"{talisman.Percent.ToString()}%" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                    ");
            __builder.OpenElement(182, "td");
            __builder.AddContent(183, 
#nullable restore
#line 150 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n                    ");
            __builder.OpenElement(185, "td");
            __builder.AddContent(186, 
#nullable restore
#line 151 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          (MarkupString)GetTypeString(talisman.PriceType)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n                    ");
            __builder.OpenElement(188, "td");
            __builder.AddContent(189, 
#nullable restore
#line 152 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.MyPriceText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                    ");
            __builder.OpenElement(191, "td");
            __builder.AddContent(192, 
#nullable restore
#line 153 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Price - talisman.MyPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n                    ");
            __builder.OpenElement(194, "td");
            __builder.AddContent(195, 
#nullable restore
#line 154 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.MyPrice != 0 ? $"{Math.Round((decimal)(talisman.Price - talisman.MyPrice) / (talisman.MyPrice) * 100)} %" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                    ");
            __builder.OpenElement(197, "td");
            __builder.AddContent(198, 
#nullable restore
#line 155 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.SpottedTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n                    ");
            __builder.OpenElement(200, "td");
            __builder.AddContent(201, 
#nullable restore
#line 156 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Other

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n");
#nullable restore
#line 158 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(204, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n");
            __builder.AddContent(207, "    ");
            __builder.AddMarkupContent(208, "<p>остальное</p>\r\n    ");
            __builder.OpenElement(209, "table");
            __builder.AddAttribute(210, "class", "table");
            __builder.AddMarkupContent(211, "\r\n        ");
            __builder.AddMarkupContent(212, @"<thead>
            <tr>
                <th></th>
                <th>Идентификатор</th>
                <th>Предмет</th>
                <th>Процент</th>
                <th>Цена</th>
                <th>Тип цены</th>
                <th>Моя цена</th>
                <th>Разница</th>
                <th>Разница в %</th>
                <th>Замечен</th>
                <th>Что-то</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(213, "tbody");
            __builder.AddMarkupContent(214, "\r\n");
#nullable restore
#line 180 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
             foreach (var talisman in talismans.Where(x => x.GroupName != "group_recipe" && x.GroupName != "group_book" && x.GroupName != "group_weapon" && x.GroupName != "group_armor"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(215, "                ");
            __builder.OpenElement(216, "tr");
            __builder.AddMarkupContent(217, "\r\n                    ");
            __builder.OpenElement(218, "td");
            __builder.OpenElement(219, "img");
            __builder.AddAttribute(220, "height", "30");
            __builder.AddAttribute(221, "width", "30");
            __builder.AddAttribute(222, "src", 
#nullable restore
#line 183 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                                                           talisman.Image

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(223, "\r\n                    ");
            __builder.OpenElement(224, "td");
            __builder.AddContent(225, 
#nullable restore
#line 184 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(226, "\r\n                    ");
            __builder.OpenElement(227, "td");
            __builder.AddContent(228, 
#nullable restore
#line 185 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(229, "\r\n                    ");
            __builder.OpenElement(230, "td");
            __builder.AddContent(231, 
#nullable restore
#line 186 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Percent.HasValue ? $"{talisman.Percent.ToString()}%" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\r\n                    ");
            __builder.OpenElement(233, "td");
            __builder.AddContent(234, 
#nullable restore
#line 187 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\r\n                    ");
            __builder.OpenElement(236, "td");
            __builder.AddContent(237, 
#nullable restore
#line 188 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          (MarkupString)GetTypeString(talisman.PriceType)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(238, "\r\n                    ");
            __builder.OpenElement(239, "td");
            __builder.AddContent(240, 
#nullable restore
#line 189 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.MyPriceText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(241, "\r\n                    ");
            __builder.OpenElement(242, "td");
            __builder.AddContent(243, 
#nullable restore
#line 190 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.Price - talisman.MyPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(244, "\r\n                    ");
            __builder.OpenElement(245, "td");
            __builder.AddContent(246, 
#nullable restore
#line 191 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                          talisman.MyPrice != 0 ? $"{Math.Round((decimal)(talisman.Price - talisman.MyPrice)/(talisman.MyPrice)*100)} %" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(247, "\r\n                    ");
            __builder.OpenElement(248, "td");
            __builder.AddContent(249, 
#nullable restore
#line 192 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.SpottedTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(250, "\r\n                    ");
            __builder.OpenElement(251, "td");
            __builder.AddContent(252, 
#nullable restore
#line 193 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
                         talisman.Other

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(254, "\r\n");
#nullable restore
#line 195 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(255, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(256, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(257, "\r\n");
#nullable restore
#line 198 "C:\Users\Zver\Desktop\lineage2-calculator\L2onNew.Web\Pages\FetchDataAll.razor"
}

#line default
#line hidden
#nullable disable
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
