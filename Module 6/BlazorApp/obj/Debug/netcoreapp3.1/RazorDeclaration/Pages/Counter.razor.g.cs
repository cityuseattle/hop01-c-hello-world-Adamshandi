#pragma checksum "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98280d952a04a5420c8bb879e22200355c629fee"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/Pages/Counter.razor"
       
    private int currentCount = 0;
    private int userInput=0;

     private string CurrentValue {get;set;} = "";

    [Parameter]
    public int IncrementAmount{get; set; }=1;
    public int DecrementAmount{get; set;}=1;

    private void IncrementCount()
    {
        currentCount+=IncrementAmount;
    }

    private void DecrementCount()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/adamshandi/Desktop/GRAD_SCHOOL/CS504-Software-engineering/handson/hop01-c-hello-world-Adamshandi/Module 6/BlazorApp/Pages/Counter.razor"
                                    
        currentCount-=Int32.Parse(this.CurrentValue);
    }
protected void Submit()
{

    Console.WriteLine(this.CurrentValue);
}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
