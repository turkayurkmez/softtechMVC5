using SimpleStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SimpleStoreApplication.HtmlHelpers
{
    public static class PagingHtmlHelper
    {
        public static MvcHtmlString Pagination(this HtmlHelper helper, PageInfo pageInfo, Func<int, string> url)
        {
            /*

    <ul class="pagination">       
        <li class="page-item"><a class="page-link" href="#">1</a></li>
        <li class="page-item"><a class="page-link" href="#">2</a></li>
        <li class="page-item"><a class="page-link" href="#">3</a></li>      
    </ul>

             */
            StringBuilder stringBuilder = new StringBuilder();
            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("pagination");
            for (int i = 1; i <= pageInfo.TotalPages; i++)
            {
                TagBuilder li = new TagBuilder("li");
                li.AddCssClass("page-item");
                if (i == pageInfo.CurrentPage)
                {
                    li.AddCssClass("active");
                }
                TagBuilder a = new TagBuilder("a");
                a.AddCssClass("page-link");
                a.MergeAttribute("href", url(i));
                a.InnerHtml = i.ToString();
                li.InnerHtml = a.ToString();
                ul.InnerHtml += li.ToString();

            }
            stringBuilder.Append(ul);
            return MvcHtmlString.Create(stringBuilder.ToString());


        }
    }
}