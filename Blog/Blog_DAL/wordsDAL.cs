using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Blog_DAL
{
    public class wordsDAL
    {
        /// <summary>
        /// 添加留言信息方法
        /// </summary>
        /// <param name="words">留言表实体类</param>
        /// <returns>受影响的行数</returns>
        public static int AddNewWords(Model.words words)
        {
            string sql = "insert into words values(@wordID,@worddate,@UserID,@wordContent,@wordState)";
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@wordID",words.WordID),
                new SqlParameter("@worddate",words.WordState),
                new SqlParameter("@UserID",words.UserID),
                new SqlParameter("@wordContent",words.WordContent),
                new SqlParameter("@wordState",words.Worddate),
            };
            return SQLHelper.ExecuteNonQurery(sql, System.Data.CommandType.Text, sqlParameter);
        }

        /// <summary>
        /// 获取所有留言信息方法
        /// </summary>
        /// <returns>留言数据集</returns>
        public static List<Model.words> GetWordsList()
        {
            List<Model.words> list = new List<Model.words>();
            string sql = "select * from words";
            SqlDataReader sqlDataReader = SQLHelper.GetSqlDataReader(sql, CommandType.Text);
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    list.Add(new Model.words()
                    {
                        UserID = sqlDataReader["UserID"].ToString(),
                        WordContent = sqlDataReader["WordContent"].ToString(),
                        Worddate = (DateTime)sqlDataReader["Worddate"],
                        WordID = sqlDataReader["WordID"].ToString(),
                        WordState = (int)sqlDataReader["WordState"]
                    });
                }
                SQLHelper.Close();
            }
            return list;
        }

        public static int RemoveWords(string id)
        {
            string sql = "delete from words where wordID =@wordID ";
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@wordID",id)
            };
            return SQLHelper.ExecuteNonQurery(sql, CommandType.Text, sqlParameter);
        }
    }
}