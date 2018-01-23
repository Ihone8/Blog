using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace Blog.SQLData
{
    /// <summary>
    /// NotesPageList 的摘要说明
    /// </summary>
    public class NotesPageList : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int pageindex = int.Parse(context.Request["pageindex"]);
            int pagenum = int.Parse(context.Request["pagenum"]);
            int pageCount = 0;
            List<Model.Notes> list = Blog_BLL.NotesBLL.PageGetNotesList(pageindex, pagenum, out pageCount);
            Dictionary<object, object> dictionary = new Dictionary<object, object>();
            dictionary.Add("result", list);
            dictionary.Add("pageCount", pageCount);
            string dcjson = (new JavaScriptSerializer()).Serialize(dictionary);
            context.Response.Write(dcjson);
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