// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "/Users/satish/RiderProjects/DNP/Client/Pages/AddingAdults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/satish/RiderProjects/DNP/Client/Pages/AddingAdults.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/satish/RiderProjects/DNP/Client/Pages/AddingAdults.razor"
using Client.Data.AdultsData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/satish/RiderProjects/DNP/Client/Pages/AddingAdults.razor"
           [Authorize(Policy = "MustBeLoggedIn")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddingAdults")]
    public partial class AddingAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/satish/RiderProjects/DNP/Client/Pages/AddingAdults.razor"
       
    private Adult newAdult = new Adult();

    private void AddAdult()
    {
        IAdults.AddAdult(newAdult);
        NavigationManager.NavigateTo("/ViewAdults");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdults IAdults { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
