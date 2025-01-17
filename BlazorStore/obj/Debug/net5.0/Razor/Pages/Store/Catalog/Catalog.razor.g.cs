#pragma checksum "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2160c21ffdeea157b1bf9873138a16ba1a4f16606dbf680a7767ef317343ab8b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorStore.Pages.Store.Catalog
{
    #line default
    using global::System;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using System.Collections.Generic

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using System.ComponentModel.DataAnnotations

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using Microsoft.Extensions.DependencyInjection

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Shared

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Shared.Dto

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Shared.Utils

#nullable disable
    ;
#nullable restore
#line 16 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Pages.Layouts

#nullable disable
    ;
#nullable restore
#line 18 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Model.Data

#nullable disable
    ;
#nullable restore
#line 19 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Model.Services.Catalog

#nullable disable
    ;
#nullable restore
#line 20 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Model.Services.Categories

#nullable disable
    ;
#nullable restore
#line 21 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Model.Services.Products

#nullable disable
    ;
#nullable restore
#line 22 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Model.Services.Orders

#nullable disable
    ;
#nullable restore
#line 23 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\_Imports.razor"
using BlazorStore.Model.Services.Users

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
      "/catalog"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Catalog : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Catalog Page</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container my-4");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-3 border");
            __builder.AddMarkupContent(7, "<h5 class=\"mb-3\">Filtros</h5>\r\n\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mb3");
            __builder.AddMarkupContent(10, "<label for=\"searchText\" class=\"col-form-label\">Busqueda</label>\r\n                ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "id", "searchText");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "placeholder", "Ingrese Texto...");
            __builder.AddAttribute(15, "onkeypress", "HandleKeyPress");
            __builder.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                    searchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onInput", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchTerm = __value, searchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "mb-3");
            __builder.AddMarkupContent(21, "<label for=\"categorySelect\" class=\"form-label\">Categoría</label>\r\n                ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "id", "categorySelect");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                           selectedCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedCategoryId = __value, selectedCategoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(27, "option");
            __builder.AddContent(28, "All categories");
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                     if (categories != null)
                    {
                        foreach(var item in categories)
                        {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", 
#nullable restore
#line 35 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, 
#nullable restore
#line 35 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                        }
                    }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "mb-3");
            __builder.AddMarkupContent(35, "<label for=\"minPrice\" class=\"col-form-label\">Precio mínimo</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "id", "minPrice");
            __builder.AddAttribute(38, "type", "range");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "min", "0");
            __builder.AddAttribute(41, "max", "1000");
            __builder.AddAttribute(42, "step", "10");
            __builder.AddAttribute(43, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                    minPriceValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minPriceValue = __value, minPriceValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "text-muted");
            __builder.OpenElement(48, "small");
            __builder.AddContent(49, 
#nullable restore
#line 47 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                             $"Min: {minPriceValue}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "mb-3");
            __builder.AddMarkupContent(53, "<label for=\"maxPrice\" class=\"col-form-label\"> Precio máximo</label>\r\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "id", "maxPrice");
            __builder.AddAttribute(56, "type", "range");
            __builder.AddAttribute(57, "class", "form-control");
            __builder.AddAttribute(58, "min", "0");
            __builder.AddAttribute(59, "max", "1000");
            __builder.AddAttribute(60, "step", "10");
            __builder.AddAttribute(61, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                    minPriceValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minPriceValue = __value, minPriceValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "text-muted");
            __builder.OpenElement(66, "small");
            __builder.AddContent(67, 
#nullable restore
#line 57 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                             $"Max: {maxPriceValue}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "btn btn-primary w-100");
            __builder.AddAttribute(71, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                                            FilterProducts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, "Filtrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-9");
            __builder.AddMarkupContent(76, "<div class=\"d-flex justify-content-between align-items-center mb_3\"><h2>Catálogo</h2></div>\r\n\r\n            ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row");
#nullable restore
#line 73 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                 if (products == null)
                {

#line default
#line hidden
#nullable disable

            __builder.AddMarkupContent(79, "<div class=\"col-12\"><p>No products found</p></div>");
#nullable restore
#line 78 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 81 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                     foreach (Product item in products)
                    {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col-md-4  mb-4");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "card");
            __builder.OpenElement(84, "img");
            __builder.AddAttribute(85, "src", "/images/" + (
#nullable restore
#line 85 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                                   item.Image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "class", "card-img-top");
            __builder.AddAttribute(87, "alt", 
#nullable restore
#line 85 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                                                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                                ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "card-body");
            __builder.OpenElement(91, "h5");
            __builder.AddAttribute(92, "class", "card-title");
            __builder.AddContent(93, 
#nullable restore
#line 87 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                                            item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                                    ");
            __builder.OpenElement(95, "p");
            __builder.AddAttribute(96, "class", "card-text");
            __builder.AddContent(97, 
#nullable restore
#line 88 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                                          item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                    ");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "class", "btn btn-sm btn-outline-primary");
            __builder.AddAttribute(101, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                                                                                             ()=>NavigateToProduct(item.Id,item.Name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(102, " Ver detalles");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 93 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 93 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                     
                }

#line default
#line hidden
#nullable disable

            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
       
    private string searchTerm = "";
    private string selectedCategory = "";
    private int? selectedCategoryId;
    private int minPriceValue = 0;
    private int maxPriceValue = 1000;
    private List<Product> products;
    private List<Category> categories;

    protected override async Task OnInitializedAsync()
    {
        await SearchCategories();
        await SearchProducts();
    }

    private async Task SearchCategories()
    {
        var categoriesDtos = await CategoryServices.GetAllAsync();
        categories = _mapper.Map<List<Category>>(categoriesDtos);
    }
    private void NavigateToProduct(int id, string name)
    {
        NavigationManager.NavigateTo($"/catalog/product/{id}/{name}");
    }

    private async Task SearchProducts()
    {
        var criteria = new SearchCriteria
            {
                Term = searchTerm,
                CategoryId = selectedCategoryId.HasValue ? selectedCategoryId : null,
                MinPrice = minPriceValue,
                MaxPrice = maxPriceValue,
                CategoryName = string.IsNullOrEmpty(selectedCategory) ? null : selectedCategory
            };

        var productsDtos = await CatalogServices.SearchAsync(criteria);
        products = _mapper.Map<List<Product>>(productsDtos);

    }
    private async Task FilterProducts(MouseEventArgs e)
    {
        await SearchProducts();
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
        AutoMapper.IMapper

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                           _mapper

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 3 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
        ICategoryServices

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                          CategoryServices

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
        ICatalogServices

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\hobdu\Repositorios\BlazorStore\BlazorStore\Pages\Store\Catalog\Catalog.razor"
                         CatalogServices

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
