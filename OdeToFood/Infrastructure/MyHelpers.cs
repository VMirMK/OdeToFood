using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Infrastructure
{
    public static class MyHelpers
    {
        public static MvcHtmlString Image(this HtmlHelper helper,string src,string altText)
        {
            TagBuilder builder = new TagBuilder("img");
            builder.MergeAttribute("src", src);
            builder.MergeAttribute("alt", altText);
            //return builder.ToString(TagRenderMode.SelfClosing);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}