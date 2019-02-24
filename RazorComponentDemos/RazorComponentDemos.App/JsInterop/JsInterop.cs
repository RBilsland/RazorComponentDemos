using Microsoft.JSInterop;
using System.Threading.Tasks;
using RazorComponentDemos.App.Pages.GameOfLife;

public class JsInterop
{
    public static Task CallCheckRunningState(GameOfLife GameOfLife)
    {
        return JSRuntime.Current.InvokeAsync<object>(
            "jsFunctions.checkRunningState",
            new DotNetObjectRef(GameOfLife));
    }
}