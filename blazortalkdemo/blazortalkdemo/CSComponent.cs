using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.RenderTree;

namespace blazortalkdemo
{
    public class CSComponent : BlazorComponent
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "I'm value in h1 tag ");
            builder.AddContent(2, (MarkupString)"<strong>I'm strong</strong>");
            builder.CloseElement();
        }
        public override void SetParameters(ParameterCollection parameters)
        {
            base.SetParameters(parameters);
        }
        //Other overrides...

        protected override void OnAfterRender()
        {
            base.OnAfterRender();
        }

        protected override Task OnAfterRenderAsync()
        {
            return base.OnAfterRenderAsync();
        }

        protected override void OnInit()
        {
            base.OnInit();
        }

        protected override Task OnInitAsync()
        {
            return base.OnInitAsync();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        protected override Task OnParametersSetAsync()
        {
            return base.OnParametersSetAsync();
        }

        protected override bool ShouldRender()
        {
            return base.ShouldRender();
        }
    }
}