#pragma checksum "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68042ab9b37114457d22f8107a6b3a3359466b7e"
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
    public partial class SellProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
 if (productToSell != null)
{


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
     if (!string.IsNullOrWhiteSpace(errorMessage))
     {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-danger");
#nullable restore
#line 12 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
__builder.AddContent(2, errorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<br>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
                     productToSell

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
                                                   SellProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label for=\"name\">Product Name</label>\r\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "id", "name");
                __builder2.AddAttribute(18, "type", "text");
                __builder2.AddAttribute(19, "readonly");
                __builder2.AddAttribute(20, "value", 
#nullable restore
#line 22 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
                                                                               productToSell.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label for=\"price\">Price</label>\r\n            ");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "id", "price");
                __builder2.AddAttribute(28, "type", "text");
                __builder2.AddAttribute(29, "readonly");
                __builder2.AddAttribute(30, "value", 
#nullable restore
#line 26 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
                                                                                 string.Format("{0:c}",productToSell.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label for=\"qty\">Quantity</label>\r\n            ");
                __Blazor.WebApp.Controlls.SellProductComponent.TypeInference.CreateInputNumber_0(__builder2, 35, 36, "qty", 37, "form-control", 38, 
#nullable restore
#line 30 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
                                                productToSell.Quantity

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productToSell.Quantity = __value, productToSell.Quantity)), 40, () => productToSell.Quantity);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.AddMarkupContent(42, "<button type=\"submit\" class=\"btn btn-primary\">Sell</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 34 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
    


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Controlls\SellProductComponent.razor"
      
    private Product productToSell;
    private string errorMessage;

    [Parameter]
    public Product SelectedProduct { get; set; }

    [Parameter]
    public EventCallback<Product> OnProductSold { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (SelectedProduct != null)
        {
            productToSell = new Product
            {
                ProductId = SelectedProduct.ProductId,
                Name = SelectedProduct.Name,
                CategoryId = SelectedProduct.CategoryId,
                Price = SelectedProduct.Price,
                Quantity = 1
            };
        }
        else
        {
            productToSell = null;
        }
    }

    private void SellProduct()
    {
        var product = GetProductByIdUseCase.Execute(productToSell.ProductId);

        if (productToSell.Quantity <= 0)
        {
            errorMessage = "The quantity has to be greater than zero.";
        }
        else if (product.Quantity >= productToSell.Quantity)
        {
            OnProductSold.InvokeAsync(productToSell);
            errorMessage = string.Empty;
            SellProductUseCase.Execute(productToSell.ProductId, productToSell.Quantity.Value);
        }
        else
        {
            errorMessage = $"{product.Name} only has {product.Quantity} left. It is not enough.";
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISellProductUseCase SellProductUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetProductByIdUseCase GetProductByIdUseCase { get; set; }
    }
}
namespace __Blazor.WebApp.Controlls.SellProductComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
