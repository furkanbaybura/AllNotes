using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASP3Tekrar.CustomTagHelper
{
    [HtmlTargetElement("ne")]
    public class GoogleTagHelper : TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            output.Content.SetContent("Googlea gitmek için tıklayınız");

            output.Attributes.SetAttribute("href", "https://www.google.com");
        }
    }
}
