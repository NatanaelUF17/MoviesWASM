// Invoking a C# static method from javascript function
function getCurrentCountFromDotnet() {
    DotNet.invokeMethodAsync("MoviesWASM.Client", "GetCurrentCount")
        .then(result => {
            console.log(`Counting from javascript: ${result}`);
        });
}

// Invoking a C# instance method from javascript function
function testDotnetInstance(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}