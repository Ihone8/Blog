using System;

namespace Model
{
    /// <summary>
    /// 文章发布实体类
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 属性：文章ID
        /// </summary>
        public string ArticleID { get; set; }

        /// <summary>
        /// 属性：用户ID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 属性：发表时间
        /// </summary>
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// 属性：文章标题
        /// </summary>
        public string ArticleTitle { get; set; }

        /// <summary>
        /// 属性：文章类型
        /// </summary>
        public int ArticleTypeID { get; set; }

        /// <summary>
        /// 属性：文章内容
        /// </summary>
        public string ArticleContent { get; set; }

        /// <summary>
        /// 属性：相关图片
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 属性：相关视频
        /// </summary>
        public string Video { get; set; }

        /// <summary>
        /// 属性：阅读（点击）量
        /// </summary>
        public int ReadCount { get; set; }

        /// <summary>
        /// 属性：作者名称
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// 属性：文章分类名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Article() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">文章编号</param>
        /// <param name="userid">用户ID</param>
        /// <param name="dateTime">发布时间</param>
        /// <param name="title">文章标题</param>
        /// <param name="typeid">文章类型ID</param>
        /// <param name="content">文章内容</param>
        /// <param name="image">图片</param>
        /// <param name="video">视频</param>
        /// <param name="readcount">阅读量</param>
        public Article(string id, string userid, DateTime dateTime, string title,
            int typeid, string content, string image, string video, int readcount, string username, string typename)
        {
            this.ArticleID = id;
            this.UserID = userid;
            this.PublishTime = dateTime;
            this.ArticleTitle = title;
            this.ArticleTypeID = typeid;
            this.ArticleContent = content;
            this.Image = image;
            this.Video = video;
            this.ReadCount = readcount;
            this.userName = userName;
            this.TypeName = typename;
        }
    }
}