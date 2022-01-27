#pragma checksum "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e628d0195e2ab8ad4205f0613fd725cd1c45bcd1"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Controlls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\_Imports.razor"
using WebApp.Controlls;

#line default
#line hidden
#nullable disable
    public partial class TodayTransactionComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
 if (transactions != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, @"<thead><tr><th>Cashier's name</th>
                <th>Product Name</th>
                <th>Date Of Service</th>
                <th>Quantity Before</th>
                <th>Quantity Sold</th>
                <th>Quantity After</th>
                <th>Total balance</th></tr></thead>
        ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 19 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
             foreach(var trans in transactions)
             {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
#nullable restore
#line 22 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
__builder.AddContent(6, trans.CashierName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
#nullable restore
#line 23 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
__builder.AddContent(9, trans.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 24 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
__builder.AddContent(12, trans.TimeStamp.ToString("MM/dd hh:mm"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 25 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
__builder.AddContent(15, trans.BeforeQuantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 26 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
__builder.AddContent(18, trans.SoldQuantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 27 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
__builder.AddContent(21, trans.BeforeQuantity-trans.SoldQuantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 28 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
__builder.AddContent(24, string.Format("{0:c}",trans.Price * trans.SoldQuantity));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
             }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\TodayTransactionComponent.razor"
      
    private IEnumerable<Transaction> transactions;

    public void LoadTransactions(string cashierName)
    {
        transactions = GetTodayTransactionUseCase.Execute(cashierName);
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetTodayTransactionUseCase GetTodayTransactionUseCase { get; set; }
    }
}
#pragma warning restore 1591
