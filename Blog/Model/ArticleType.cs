namespace Model
{
    /// <summary>
    /// 文章类型实体类
    /// </summary>
    public class ArticleType
    {
        /// <summary>
        /// 属性：类型编号
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 属性：类型名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public ArticleType() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">编号</param>
        /// <param name="typename">类型名称</param>
        public ArticleType(int id, string typename)
        {
            this.ID = id;
            this.TypeName = typename;
        }
    }
}