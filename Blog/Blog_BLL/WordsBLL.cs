using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_BLL
{
    public class WordsBLL
    {
        /// <summary>
        /// 添加留言信息方法
        /// </summary>
        /// <param name="words">留言表实体类</param>
        /// <returns>受影响的行数</returns>
        public static int AddNewWords(Model.words words)
        {
            return Blog_DAL.wordsDAL.AddNewWords(words);
        } /// <summary>

        /// 获取所有留言信息方法
        /// </summary>
        /// <returns>留言数据集</returns>
        public static List<Model.words> GetWordsList()
        {
            return Blog_DAL.wordsDAL.GetWordsList();
        }
    }
}