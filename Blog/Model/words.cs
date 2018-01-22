using System;

namespace Model
{
    /// <summary>
    /// 留言实体类
    /// </summary>
    public class words
    {
        /// <summary>
        /// 属性：留言ID
        /// </summary>
        public string wordID { get; set; }

        /// <summary>
        /// 属性：留言时间
        /// </summary>
        public DateTime worddate { get; set; }

        /// <summary>
        /// 属性：留言人ID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 属性：留言内容
        /// </summary>
        public string wordContent { get; set; }

        /// <summary>
        /// 属性：留言是否正确
        /// </summary>
        public int wordState { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public words() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">留言id</param>
        /// <param name="dateTime">留言时间</param>
        /// <param name="userid">留言人id</param>
        /// <param name="content">留言信箱</param>
        /// <param name="wordstate">留言是否正确</param>
        public words(string id, DateTime dateTime, string userid, string content, int wordstate)
        {
            this.UserID = id;
            this.worddate = dateTime;
            this.UserID = userid;
            this.wordContent = content;
            this.wordState = wordState;
        }
    }
}