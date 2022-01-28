#pragma checksum "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1014996a39359022c9e7a8154c901eb44cc91f"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/transaction")]
    public partial class TransactionReportComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-4");
            __builder.AddMarkupContent(4, "<label for=\"cashier\">Cashier Name</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "id", "cashier");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
                                                                          cashierName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cashierName = __value, cashierName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-3");
            __builder.AddMarkupContent(14, "<label for=\"startdate\">Start Date</label>\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "date");
            __builder.AddAttribute(17, "id", "startdate");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
                                                                            startDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => startDate = __value, startDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-3");
            __builder.AddMarkupContent(24, "<label for=\"enddate\">End date</label>\r\n        ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "date");
            __builder.AddAttribute(27, "id", "enddate");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
                                                                          endDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => endDate = __value, endDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-2");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
                                                                LoadTransactions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n<br>");
#nullable restore
#line 25 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
 if (transactions != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "table");
            __builder.AddAttribute(41, "class", "table");
            __builder.AddMarkupContent(42, @"<thead><tr><th>Date Of Service</th>
                <th>Cashier's name</th>
                <th>Product Name</th>
                <th>Quantity Before</th>
                <th>Quantity Sold</th>
                <th>Quantity After</th>
                <th>Price</th></tr></thead>
        ");
            __builder.OpenElement(43, "tbody");
#nullable restore
#line 40 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
             foreach (var trans in transactions)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "tr");
            __builder.OpenElement(45, "td");
#nullable restore
#line 43 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
__builder.AddContent(46, trans.TimeStamp.ToString("yyyy/MM/dd hh:mm"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
#nullable restore
#line 44 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
__builder.AddContent(49, trans.CashierName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
#nullable restore
#line 45 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
__builder.AddContent(52, trans.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
#nullable restore
#line 46 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
__builder.AddContent(55, trans.BeforeQuantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
#nullable restore
#line 47 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
__builder.AddContent(58, trans.SoldQuantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
#nullable restore
#line 48 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
__builder.AddContent(61, trans.BeforeQuantity-trans.SoldQuantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "td");
#nullable restore
#line 49 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
__builder.AddContent(64, string.Format("{0:c}",trans.Price * trans.SoldQuantity));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "tfoot");
            __builder.OpenElement(67, "tr");
            __builder.AddMarkupContent(68, "<td colspan=\"5\">&nbsp;</td>\r\n                ");
            __builder.AddMarkupContent(69, "<td style=\"font-weight:bold\">Total Balance</td>\r\n                ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "style", "font-weight:bold");
#nullable restore
#line 57 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
__builder.AddContent(72, string.Format("{0:c}",transactions.Sum(x => x.Price * x.SoldQuantity)));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\TransactionReportComponent.razor"
       
    private string cashierName;
    private DateTime startDate = DateTime.Today;
    private DateTime endDate= DateTime.Today;
    private IEnumerable<Transaction> transactions;

    private void LoadTransactions()
    {
        transactions = GetTransactionsUseCase.Execute(cashierName, startDate, endDate);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetTransactionsUseCase GetTransactionsUseCase { get; set; }
    }
}
#pragma warning restore 1591
