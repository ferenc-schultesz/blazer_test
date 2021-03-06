#pragma checksum "C:\Users\FerencSchultesz\source\repos\StripeAdmin\StripeAdmin\Pages\Invoices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d1c79e09b905c17c73cbe05ea8184860e708c8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StripeAdmin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using StripeAdmin;
    using StripeAdmin.Shared;
    using Newtonsoft.Json;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/invoices")]
    public class Invoices : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 42 "C:\Users\FerencSchultesz\source\repos\StripeAdmin\StripeAdmin\Pages\Invoices.cshtml"
            
    //IEnumerable<Invoice> invoices = 
    Dictionary<string, string> posts;

    protected override async Task OnInitAsync()
    {
        var result = await Http.GetAsync("https://jsonplaceholder.typicode.com/posts");
        if (result.IsSuccessStatusCode)
        {
            var details = await result.Content.ReadAsStringAsync();
            posts = JsonConvert.DeserializeObject<Dictionary<string, string>>(details);
        }


    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
