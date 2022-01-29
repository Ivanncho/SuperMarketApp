#pragma checksum "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d2303c6efbcb4917d326d817157b9b76e6f3b7b"
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
#nullable restore
#line 2 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
           [Authorize(policy: "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class ProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Products</h3>\r\n<br>");
#nullable restore
#line 11 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
 if (products != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Id</th>\r\n                <th>Product Category</th>\r\n                <th>Product Name</th>\r\n                <th>Product Qty</th>\r\n                <th>Price</th>\r\n                <th>Action</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 25 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 28 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
__builder.AddContent(7, product.ProductId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 29 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
__builder.AddContent(10, GetCategoryByIdUseCase.Execute(product.CategoryId.Value)?.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 30 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
__builder.AddContent(13, product.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 31 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
__builder.AddContent(16, product.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 32 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
__builder.AddContent(19, Math.Round(product.Price.Value,2));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "btn btn-info");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
                                                                               () => OnEditProduct(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        &nbsp;\r\n                        ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "class", "btn btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
                                                                                 () => OnDeleteProduct(product.ProductId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<br>\r\n");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
                                OnClickAddProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddContent(38, "Add Product");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\ProductsComponent.razor"
       
    private IEnumerable<Product> products;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        products = ViewProductsUseCase.Execute();


    }
    private void OnClickAddProduct()
    {
        NavigationManager.NavigateTo("/addproduct");
    }
    private void OnEditProduct(Product product)
    {
        NavigationManager.NavigateTo($"/editproduct/{product.ProductId}");
    }
    private void OnDeleteProduct(int productId)
    {
        DeleteProductUseCase.Execute(productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IDeleteProductUseCase DeleteProductUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IGetCategoryByIdUseCase GetCategoryByIdUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewProductsUseCase ViewProductsUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
