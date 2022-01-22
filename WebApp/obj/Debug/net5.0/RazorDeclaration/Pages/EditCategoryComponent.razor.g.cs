// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcategory/{categoryId}")]
    public partial class EditCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\jasmi\source\repos\SupermarketManager\WebApp\Pages\EditCategoryComponent.razor"
       

    [Parameter]
    public string CategoryId { get; set; }

    private Category category;
    protected override void OnInitialized()
    {
        base.OnInitialized();
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (int.TryParse(this.CategoryId, out int iCategoryId))
        {
            this.category = GetCategoryByIdUseCase.Execute(iCategoryId);

        }

    }

    private void OnValidSubmit()
    {
        EditCategoryUseCase.Execute(this.category);
        NavigationManager.NavigateTo("/categories");
    }
    private void OnCancel()
    {
        NavigationManager.NavigateTo("/categories");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IEditCategoryUseCase EditCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IGetCategoryByIdUseCase GetCategoryByIdUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IAddCategoryUseCase AddCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
