using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperTest.TagHelpers
{
    public class StrongUnderlineTagHelper : EmailLinkTagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            string origin = (await output.GetChildContentAsync()).GetContent();
            string result = $"<u>{origin}</u>";
            output.TagName = "strong";
            output.Content.AppendHtml(result);
        }
    }
}
