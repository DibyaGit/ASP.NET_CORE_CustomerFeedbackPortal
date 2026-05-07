using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomerFeedbackPortal.TagHelpers
{
    // This tells ASP.NET that <star-rating> is a new HTML tag we just invented!
    public class StarRatingTagHelper : TagHelper
    {
        // This catches the number we pass in
        public int Rating { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; // Wraps the stars in a standard div box

            string stars = "";
            for (int i = 1; i <= 5; i++)
            {
                if (i <= Rating)
                    stars += "★ "; // Adds a filled star
                else
                    stars += "☆ "; // Adds an empty star
            }

            // This puts the stars onto the screen, styled to be big and yellow
            output.Attributes.SetAttribute("style", "color: gold; font-size: 24px;");
            output.Content.SetContent(stars);
        }
    }
}