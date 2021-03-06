#pragma checksum "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f62d816149e9e94151eff7bcda74a8fcca158395"
// <auto-generated/>
#pragma warning disable 1591
namespace Hackernews.Components
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
    public partial class News : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                 SearchRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                         FormSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "container mx-auto flex justify-end my-10 px-10 md:px-0");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "class", "w-full md:w-2/3 px-3 py-2 border border-gray-200 shadow-lg");
                __builder2.AddAttribute(8, "id", "searchQuery");
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                           SearchRequest.QueryString

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SearchRequest.QueryString = __value, SearchRequest.QueryString))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SearchRequest.QueryString));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n    <input type=\"submit\" class=\"border border-gray-200 px-3 py-2 shadow-lg\" value=\"Search\" id=\"searchBtn\">\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\n\n");
            __builder.OpenElement(14, "div");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 7 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
     if(data == null)
    {
       

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<div class=\"content\">\n   <div class=\"loaders\">\n    <div class=\"triangle\"></div>\n    <div class=\"rect\"></div>\n    <div class=\"circle\"></div>\n    <div class=\"kite\"></div>\n   </div>\n </div>\n");
#nullable restore
#line 18 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
    }
    else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "         ");
            __builder.OpenElement(18, "section");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "container mx-auto");
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "class", "container text-center");
            __builder.AddMarkupContent(25, "\n                    Showing new results on ");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "text-xl italic");
            __builder.AddContent(28, 
#nullable restore
#line 23 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                                                         Query

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "id", "card");
            __builder.AddAttribute(33, "class", "flex flex-wrap justify-center");
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 26 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                     foreach (var article in data.articles)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                         if (article.author == null)
                        {
                            article.author = "Anon";
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                        ");
            __builder.OpenComponent<Hackernews.Components.Card>(36);
            __builder.AddAttribute(37, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                      article.title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "UrlToImage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                         article.urlToImage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "Url", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                  article.url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Description", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                           article.description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "Author", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                       article.author

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "Source", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                      article.source.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                                    article.publishedAt.ToLongDateString()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\n");
#nullable restore
#line 39 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
#nullable restore
#line 43 "/Users/simi/Documents/repos/blazor_projects/Hackernews/Components/News.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
