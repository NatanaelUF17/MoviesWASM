using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWASM.Client.Pages
{
    public partial class Counter : ComponentBase
    {
        // This is the way how we inject a service into the component base class
        [Inject] protected IJSRuntime JS { get; set; }

        IJSObjectReference module;

        private int currentCount = 0;
        static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            module = await JS.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");

            await module.InvokeVoidAsync("showAlert", "Hello World!");

            currentCount++;
            currentCountStatic++;
            // Using a javascript function from an external js file 
            await JS.InvokeVoidAsync("getCurrentCountFromDotnet");
        }

        protected async Task IncrementCountJavascript()
        {
            await JS.InvokeVoidAsync("testDotnetInstance", 
                                        DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
