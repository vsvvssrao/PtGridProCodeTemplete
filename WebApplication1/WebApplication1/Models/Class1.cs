using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public static class Class1
    {
        public static IHtmlString ClassName<TModel, TProperty>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty>> ex)
        {
            var metaData = ModelMetadata.FromLambdaExpression(ex, html.ViewData);
            if (metaData.AdditionalValues.ContainsKey("metric"))
            {
                var metric = metaData.AdditionalValues["metric"] as string;
                return new HtmlString(html.Encode(metric));
            }
            return MvcHtmlString.Empty;
        }


        public static String GetPropertyName<TModel, TValue>(this HtmlHelper<IEnumerable<TModel>> html, Expression<Func<TModel, TValue>> expression)
        {
            var operant = (MemberExpression)((UnaryExpression)expression.Body).Operand;
            return operant.Member.Name;

        }
    }
}