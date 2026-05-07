using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerFeedbackPortal.Helpers
{
    // This class holds our custom HTML tools
    public static class MyHtmlHelpers
    {
        // We are creating a brand new tool called "StyledInput"
        public static IHtmlContent StyledInput(this IHtmlHelper helper, string name, string placeholderText)
        {
            // This is the custom HTML it will generate. We gave it a purple border!
            string html = $"<input type='text' name='{name}' id='{name}' placeholder='{placeholderText}' style='border: 2px solid purple; padding: 8px; border-radius: 4px;' />";

            return new HtmlString(html);
        }
    }
}