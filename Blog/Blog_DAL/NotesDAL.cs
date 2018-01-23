using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Blog_DAL
{
    public class NotesDAL
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
            List<Model.Notes> list = new List<Model.Notes>();
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@pageIndex",pageindex),
                new SqlParameter("@pageCount",pagenum),
                new SqlParameter("@pageTotalCount",SqlDbType.Int)
            };
            sqlParameter[2].Direction = ParameterDirection.Output;
            DataSet dataSet = SQLHelper.GetDataSet("NotePage", CommandType.StoredProcedure, sqlParameter);
            pageCount = Convert.ToInt32(sqlParameter[2].Value);
            foreach (DataRow item in dataSet.Tables[0].Rows)
            {
                Model.Notes notes = new Model.Notes();
                notes.NoteContent = item["NoteContent"].ToString();
                notes.UserID = item["UserID"].ToString();
                notes.NoteType = (int)item["NoteType"];
                notes.NoteTtile = item["NoteTtile"].ToString();
                notes.NoteTime = (DateTime)item["NoteTime"];
                notes.NotesImage = item["NotesImage"].ToString();
                notes.NotesID = item["NotesID"].ToString();
                list.Add(notes);
            }
            return list;
        }
    }
}