using Microsoft.JSInterop;

public class JsInterop
{
    private readonly IJSRuntime _jsRuntime;

    public JsInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }
}