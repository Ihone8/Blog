using System;

namespace Model
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class User
    {
        /// <summary>
        /// 属性：编号
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 属性：用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 属性：密码
        /// </summary>
        public string UserPwd { get; set; }

        /// <summary>
        /// 属性：电话号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 属性：住址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 属性：邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 属性：QQ/微信
        /// </summary>
        public string QQWeChar { get; set; }

        /// <summary>
        /// 属性：姓名
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 属性：性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 属性：身份证号码
        /// </summary>
        public string IDCard { get; set; }

        /// <summary>
        /// 属性：账号是否可用
        /// </summary>
        public int AStatusID { get; set; }

        /// <summary>
        /// 属性：密保问题
        /// </summary>
        public string SecurityQuestion { get; set; }

        /// <summary>
        /// 属性：密保答案
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// 属性：密码提示
        /// </summary>
        public string Tips { get; set; }

        /// <summary>
        /// 属性：说明
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 属性：个人简述（相当于个性签名）
        /// </summary>
        public string Autograph { get; set; }

        /// <summary>
        /// 属性：注册时间
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public User() { }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="userid">ID</param>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="phone">电话</param>
        /// <param name="address">地址</param>
        /// <param name="emial">邮箱</param>
        /// <param name="qqwechar">QQ/微信</param>
        /// <param name="fullname">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="idcard">身份证</param>
        /// <param name="astatusid">账号是否可用</param>
        /// <param name="question">密保问题</param>
        /// <param name="answer">密保答案</param>
        /// <param name="tips">密码提示</param>
        /// <param name="desc">说明</param>
        /// <param name="autograph">个性签名</param>
        /// <param name="dateTime">注册时间</param>
        public User(string userid, string name, string pwd, string phone, string address, string emial, string qqwechar,
            string fullname, string gender, string idcard, int astatusid, string question, string answer, string tips, string desc, string autograph, DateTime dateTime)
        {
            this.UserID = userid;
            this.UserName = name;
            this.UserPwd = pwd;
            this.Phone = phone;
            this.Address = address;
            this.Email = emial;
            this.QQWeChar = qqwechar;
            this.FullName = fullname;
            this.Gender = gender;
            this.IDCard = idcard;
            this.AStatusID = astatusid;
            this.SecurityQuestion = question;
            this.Answer = answer;
            this.Tips = tips;
            this.Desc = desc;
            this.Autograph = autograph;
            this.DateTime = dateTime;
        }
    }
}