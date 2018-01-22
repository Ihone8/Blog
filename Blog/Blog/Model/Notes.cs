using System;

namespace Model
{
    /// <summary>
    /// 心得笔记实体类
    /// </summary>
    public class Notes
    {
        /// <summary>
        /// 属性：心得笔记ID
        /// </summary>
        public string NotesID { get; set; }

        /// <summary>
        /// 属性：图片
        /// </summary>
        public string NotesImage { get; set; }

        /// <summary>
        /// 属性：标题
        /// </summary>
        public string NoteTtile { get; set; }

        /// <summary>
        /// 属性：发布时间
        /// </summary>
        public DateTime NoteTime { get; set; }

        /// <summary>
        /// 属性：作者
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 属性：文章类型
        /// </summary>
        public int NoteType { get; set; }

        /// <summary>
        /// 属性：正文
        /// </summary>
        public string NoteContent { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Notes() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="img">图片</param>
        /// <param name="title">标题</param>
        /// <param name="dateTime">时间</param>
        /// <param name="userid">用户ID</param>
        /// <param name="typeid">类型ID</param>
        /// <param name="content">正文</param>
        public Notes(string id, string img, string title, DateTime dateTime,
            string userid, int typeid, string content)
        {
            this.NotesID = id;
            this.NotesImage = img;
            this.NoteTtile = title;
            this.NoteTime = dateTime;
            this.UserID = userid;
            this.NoteType = typeid;
            this.NoteContent = content;
        }
    }
}