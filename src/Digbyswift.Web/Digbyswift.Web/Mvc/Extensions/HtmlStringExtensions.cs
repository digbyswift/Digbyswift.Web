﻿#if NET462
using System;
using System.Web;
using System.Web.Mvc;

namespace Digbyswift.Web.Mvc.Extensions
{
    public static class HtmlStringExtensions
    {
        public static bool IsNullOrWhiteSpace(IHtmlString instance)
        {
            if (instance == null)
            {
                return true;
            }

            if (instance is MvcHtmlString mvcHtmlString)
            {
                return string.IsNullOrWhiteSpace(mvcHtmlString.ToHtmlString());
            }

            if (instance is HtmlString htmlString)
            {
                return string.IsNullOrWhiteSpace(htmlString.ToHtmlString());
            }

            throw new NotImplementedException($"{instance.GetType().FullName} not supported.");
        }

        public static bool IsNullOrEmpty(IHtmlString instance)
        {
            if (instance == null)
            {
                return true;
            }

            if (instance is MvcHtmlString mvcHtmlString)
            {
                return string.IsNullOrWhiteSpace(mvcHtmlString.ToHtmlString());
            }

            if (instance is HtmlString htmlString)
            {
                return string.IsNullOrWhiteSpace(htmlString.ToHtmlString());
            }

            throw new NotImplementedException($"{instance.GetType().FullName} not supported.");
        }
    }
}
#endif
