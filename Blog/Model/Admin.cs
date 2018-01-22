namespace Model
{
    /// <summary>
    /// 管理员实体类
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// 属性：ID
        /// </summary>
        public int AID { get; set; }

        /// <summary>
        ///属性：管理员姓名
        /// </summary>
        public string AName { get; set; }

        /// <summary>
        /// 属性：管理员用户名
        /// </summary>
        public string ALoginName { get; set; }

        /// <summary>
        /// 属性：管理员密码
        /// </summary>
        public string ALoginPwd { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Admin() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">姓名</param>
        /// <param name="loginname">用户名</param>
        /// <param name="pwd">密码</param>
        public Admin(int id, string name, string loginname, string pwd)
        {
            this.AID = id;
            this.AName = name;
            this.ALoginName = loginname;
            this.ALoginPwd = pwd;
        }
    }
}