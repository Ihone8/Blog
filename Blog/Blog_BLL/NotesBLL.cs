using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_BLL
{
    public class NotesBLL
    {
        /// <summary>
        /// 存储分页函数 对于心得笔记
        /// </summary>
        /// <param name="pageindex">当前页码</param>
        /// <param name="pagenum">每页显示行数</param>
        /// <param name="pageCount">总共多少页</param>
        /// <returns></returns>
        public static List<Model.Notes> PageGetNotesList(int pageindex, int pagenum, out int pageCount)
        {
            return Blog_DAL.NotesDAL.PageGetNotesList(pageindex, pagenum, out pageCount);
        }
    }
}