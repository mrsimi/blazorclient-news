#pragma checksum "/Users/simi/Documents/repos/blazor_projects/Hackernews/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "818e19ab12dd05c57d914657e3b3bc0722fc1ca8"
// <auto-generated/>
#pragma warning disable 1591
namespace Hackernews.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Hackernews;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Hackernews.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Hackernews.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using Hackernews.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/simi/Documents/repos/blazor_projects/Hackernews/_Imports.razor"
using NewsApi.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddMarkupContent(1, "\n      ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container mx-auto px-10");
            __builder.AddMarkupContent(4, "\n          ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "flex justify-between h-16 items-center uppercase");
            __builder.AddMarkupContent(7, "\n              ");
            __builder.AddMarkupContent(8, "<div>NewsApi.BlazorClient</div>\n              ");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "\n                  ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Shared/NavMenu.razor"
                                    ToggleBtn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "px-3 py-3 border border-gray-200");
            __builder.AddMarkupContent(14, "\n                      Switch Theme\n                  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n              ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Shared/NavMenu.razor"
      
    private async Task ToggleBtn()
    {
        await JSRuntime.InvokeVoidAsync("toggleClass");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
