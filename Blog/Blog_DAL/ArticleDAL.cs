using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Blog_DAL
{
    public class ArticleDAL
    {
        /// <summary>
        /// 获取文章信息
        /// </summary>
        /// <returns>文章信息数据集</returns>
        public static List<Model.Article> GetArticleList()
        {
            List<Model.Article> Articlelist = new List<Model.Article>();
            string sql = "select U.UserName,T.TypeName,A.* from [Article] A left join ArticleType T on A.ArticleTypeID=T.ID left join [User] U on A.UserID=A.UserID";
            SqlDataReader dataReader = SQLHelper.GetSqlDataReader(sql, CommandType.Text);
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    Articlelist.Add(new Model.Article()
                    {
                        ArticleContent = dataReader["ArticleContent"].ToString(),
                        ArticleID = dataReader["ArticleID"].ToString(),
                        ArticleTitle = dataReader["ArticleTitle"].ToString(),
                        ArticleTypeID = (int)dataReader["ArticleTypeID"],
                        Image = dataReader["Image"].ToString(),
                        PublishTime = DateTime.Parse(dataReader["PublishTime"].ToString()),
                        ReadCount = int.Parse(dataReader["ReadCount"].ToString()),
                        TypeName = dataReader["TypeName"].ToString(),
                        UserID = dataReader["UserID"].ToString(),
                        userName = dataReader["userName"].ToString(),
                        Video = dataReader["Video"].ToString()
                    });
                }
                SQLHelper.Close();
            }
            return Articlelist;
        }
    }
}