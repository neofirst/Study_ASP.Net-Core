using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperTest.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    public class UnixTimeConverterTagHelper : TagHelper
    {
        public string Formatter { get; set; } = "yyyy-MM-dd hh:mm:ss";
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = (await output.GetChildContentAsync()).GetContent();
            var unixTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var currentTime = unixTime.AddSeconds(Convert.ToDouble(childContent));
            output.Content.SetContent(currentTime.ToString(Formatter));
        }
    }
}
