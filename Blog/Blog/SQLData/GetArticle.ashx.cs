using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json; //把数据序列化Json对象到前台

namespace Blog.SQLData
{
    /// <summary>
    /// GetArticle 的摘要说明
    /// </summary>
    public class GetArticle : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            List<Model.Article> list = Blog_BLL.ArticleBLL.GetArticleList();
            DataContractJsonSerializer dataContractJson = new DataContractJsonSerializer(typeof(List<Model.Article>));
            dataContractJson.WriteObject(context.Response.OutputStream, list);
            //context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}