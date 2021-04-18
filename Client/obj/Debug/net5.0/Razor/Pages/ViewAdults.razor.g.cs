#pragma checksum "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b3204c6d771fcf36b35a39a773716669cf25d2c"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/satish/RiderProjects/DNP/Client/_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
using Client.Data.AdultsData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAdults")]
    public partial class ViewAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search for an Adult</h3>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Filter by User Id : ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                                                        (arg)=>FilterByUserId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
 if (AdultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading ...</em></p>");
#nullable restore
#line 20 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
}else if (!AdultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>No one found...</em></p>");
#nullable restore
#line 25 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
    }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.OpenElement(11, "thead");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "<th> ID</th>\n            ");
            __builder.AddMarkupContent(14, "<th>FirstName</th>\n            ");
            __builder.AddMarkupContent(15, "<th>LastName</th>\n            ");
            __builder.AddMarkupContent(16, "<th>Haircolor</th>\n            ");
            __builder.AddMarkupContent(17, "<th>Eyecolor</th>\n            ");
            __builder.AddMarkupContent(18, "<th>Age</th>\n            ");
            __builder.AddMarkupContent(19, "<th>Weight</th>\n            ");
            __builder.AddMarkupContent(20, "<th>Height</th>\n            ");
            __builder.AddMarkupContent(21, "<th>Sex</th>\n            ");
            __builder.AddMarkupContent(22, "<th>Edit</th>\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(23);
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(25, "<th>Remove</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 45 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
         foreach (var item in AdultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 49 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 51 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 52 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 53 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 54 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 55 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 56 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 57 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 58 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                ");
            __builder.OpenElement(56, "td");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                                         () => Edit(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "<i class=\"oi oi-pencil\" style=\"color: #1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n                ");
            __builder.OpenElement(61, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(62);
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(64, "button");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
                                                        () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(66, "<i class=\"oi-oi-trash\" style=\"color: #ff0000\"></i>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "/Users/satish/RiderProjects/DNP/Client/Pages/ViewAdults.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> AdultsToShow;

   

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        int? filterbyId = null;
        try
        {
            filterbyId = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        if (filterbyId != null)
        {
            AdultsToShow = allAdults.Where(t => t.Id == filterbyId).ToList();
        }
        else
        {
            AdultsToShow = allAdults;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        allAdults = await IAdults.GetAdults();
        AdultsToShow = allAdults;
    }
   
     private void RemoveAdult(int AdultId)
    {
        Adult adultToRemove = allAdults.First(t => t.Id == AdultId);
        // IAdults.RemoveAdult(AdultId);
        allAdults.Remove(adultToRemove);
        AdultsToShow.Remove(adultToRemove);
    }

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"Edit/{id}");
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdults IAdults { get; set; }
    }
}
#pragma warning restore 1591
