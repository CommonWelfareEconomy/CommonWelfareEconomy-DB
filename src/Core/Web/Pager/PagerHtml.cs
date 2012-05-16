using System.IO;
using System.Text;
using System.Web.Mvc;

namespace GwoDb
{
    public static class PagerHtml
    {
        public static MvcHtmlString Pager(this HtmlHelper html, PagerModel pager)
        {
            if (pager == null)
                return new MvcHtmlString("");

            var newViewContext =
                new ViewContext(html.ViewContext,
                html.ViewContext.View,
                new ViewDataDictionary(pager),
                html.ViewContext.TempData,
                html.ViewContext.Writer);


            ViewEngineResult result = ViewEngines.Engines.FindPartialView(
                html.ViewContext, "~/Views/Shared/_Pager.cshtml");

            var stringBuilder = new StringBuilder();
            var stringWriter = new StringWriter(stringBuilder);
            result.View.Render(newViewContext, stringWriter);
            stringWriter.Flush();


            return new MvcHtmlString(stringBuilder.ToString());
        }
    }
}
