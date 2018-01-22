using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_BLL
{
    public class ArticleBLL
    {
        /// <summary>
        /// 获取文章信息
        /// </summary>
        /// <returns>文章信息数据集</returns>
        public static List<Model.Article> GetArticleList()
        {
            return Blog_DAL.ArticleDAL.GetArticleList();
        }
    }
}