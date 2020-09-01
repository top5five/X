using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace XCode.Membership
{
    /// <summary>用户</summary>
    [Serializable]
    [DataObject]
    [Description("用户")]
    [BindIndex("IU_User2_Name", true, "Name")]
    [BindIndex("IX_User2_RoleID", false, "RoleID")]
    [BindTable("User2", Description = "用户", ConnName = "test", DbType = DatabaseType.None)]
    public partial class User2
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public Int32 ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

        private String _Name;
        /// <summary>名称。登录用户名</summary>
        [DisplayName("名称")]
        [Description("名称。登录用户名")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("Name", "名称。登录用户名", "", Master = true)]
        public String Name { get => _Name; set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } } }

        private String _Password;
        /// <summary>密码</summary>
        [DisplayName("密码")]
        [Description("密码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Password", "密码", "")]
        public String Password { get => _Password; set { if (OnPropertyChanging("Password", value)) { _Password = value; OnPropertyChanged("Password"); } } }

        private String _DisplayName;
        /// <summary>昵称</summary>
        [DisplayName("昵称")]
        [Description("昵称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("DisplayName", "昵称", "")]
        public String DisplayName { get => _DisplayName; set { if (OnPropertyChanging("DisplayName", value)) { _DisplayName = value; OnPropertyChanged("DisplayName"); } } }

        private SexKinds _Sex;
        /// <summary>性别。未知、男、女</summary>
        [DisplayName("性别")]
        [Description("性别。未知、男、女")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Sex", "性别。未知、男、女", "")]
        public SexKinds Sex { get => _Sex; set { if (OnPropertyChanging("Sex", value)) { _Sex = value; OnPropertyChanged("Sex"); } } }

        private String _Mail;
        /// <summary>邮件</summary>
        [DisplayName("邮件")]
        [Description("邮件")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Mail", "邮件", "")]
        public String Mail { get => _Mail; set { if (OnPropertyChanging("Mail", value)) { _Mail = value; OnPropertyChanged("Mail"); } } }

        private String _Mobile;
        /// <summary>手机</summary>
        [DisplayName("手机")]
        [Description("手机")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Mobile", "手机", "")]
        public String Mobile { get => _Mobile; set { if (OnPropertyChanging("Mobile", value)) { _Mobile = value; OnPropertyChanged("Mobile"); } } }

        private String _Code;
        /// <summary>代码。身份证、员工编号等</summary>
        [DisplayName("代码")]
        [Description("代码。身份证、员工编号等")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Code", "代码。身份证、员工编号等", "")]
        public String Code { get => _Code; set { if (OnPropertyChanging("Code", value)) { _Code = value; OnPropertyChanged("Code"); } } }

        private String _Avatar;
        /// <summary>头像</summary>
        [DisplayName("头像")]
        [Description("头像")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Avatar", "头像", "")]
        public String Avatar { get => _Avatar; set { if (OnPropertyChanging("Avatar", value)) { _Avatar = value; OnPropertyChanged("Avatar"); } } }

        private Int32 _RoleID;
        /// <summary>角色。主要角色</summary>
        [DisplayName("角色")]
        [Description("角色。主要角色")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("RoleID", "角色。主要角色", "")]
        public Int32 RoleID { get => _RoleID; set { if (OnPropertyChanging("RoleID", value)) { _RoleID = value; OnPropertyChanged("RoleID"); } } }

        private String _RoleIDs;
        /// <summary>角色组。次要角色集合</summary>
        [DisplayName("角色组")]
        [Description("角色组。次要角色集合")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("RoleIDs", "角色组。次要角色集合", "")]
        public String RoleIDs { get => _RoleIDs; set { if (OnPropertyChanging("RoleIDs", value)) { _RoleIDs = value; OnPropertyChanged("RoleIDs"); } } }

        private Boolean _Online;
        /// <summary>在线</summary>
        [DisplayName("在线")]
        [Description("在线")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Online", "在线", "")]
        public Boolean Online { get => _Online; set { if (OnPropertyChanging("Online", value)) { _Online = value; OnPropertyChanged("Online"); } } }

        private Boolean _Enable;
        /// <summary>启用</summary>
        [DisplayName("启用")]
        [Description("启用")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Enable", "启用", "")]
        public Boolean Enable { get => _Enable; set { if (OnPropertyChanging("Enable", value)) { _Enable = value; OnPropertyChanged("Enable"); } } }

        private Int32 _Logins;
        /// <summary>登录次数</summary>
        [DisplayName("登录次数")]
        [Description("登录次数")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Logins", "登录次数", "")]
        public Int32 Logins { get => _Logins; set { if (OnPropertyChanging("Logins", value)) { _Logins = value; OnPropertyChanged("Logins"); } } }

        private DateTime _LastLogin;
        /// <summary>最后登录</summary>
        [DisplayName("最后登录")]
        [Description("最后登录")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("LastLogin", "最后登录", "")]
        public DateTime LastLogin { get => _LastLogin; set { if (OnPropertyChanging("LastLogin", value)) { _LastLogin = value; OnPropertyChanged("LastLogin"); } } }

        private String _LastLoginIP;
        /// <summary>最后登录IP</summary>
        [DisplayName("最后登录IP")]
        [Description("最后登录IP")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("LastLoginIP", "最后登录IP", "")]
        public String LastLoginIP { get => _LastLoginIP; set { if (OnPropertyChanging("LastLoginIP", value)) { _LastLoginIP = value; OnPropertyChanged("LastLoginIP"); } } }

        private DateTime _RegisterTime;
        /// <summary>注册时间</summary>
        [DisplayName("注册时间")]
        [Description("注册时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("RegisterTime", "注册时间", "")]
        public DateTime RegisterTime { get => _RegisterTime; set { if (OnPropertyChanging("RegisterTime", value)) { _RegisterTime = value; OnPropertyChanged("RegisterTime"); } } }

        private String _RegisterIP;
        /// <summary>注册IP</summary>
        [DisplayName("注册IP")]
        [Description("注册IP")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("RegisterIP", "注册IP", "")]
        public String RegisterIP { get => _RegisterIP; set { if (OnPropertyChanging("RegisterIP", value)) { _RegisterIP = value; OnPropertyChanged("RegisterIP"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "ID": return _ID;
                    case "Name": return _Name;
                    case "Password": return _Password;
                    case "DisplayName": return _DisplayName;
                    case "Sex": return _Sex;
                    case "Mail": return _Mail;
                    case "Mobile": return _Mobile;
                    case "Code": return _Code;
                    case "Avatar": return _Avatar;
                    case "RoleID": return _RoleID;
                    case "RoleIDs": return _RoleIDs;
                    case "Online": return _Online;
                    case "Enable": return _Enable;
                    case "Logins": return _Logins;
                    case "LastLogin": return _LastLogin;
                    case "LastLoginIP": return _LastLoginIP;
                    case "RegisterTime": return _RegisterTime;
                    case "RegisterIP": return _RegisterIP;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID": _ID = value.ToInt(); break;
                    case "Name": _Name = Convert.ToString(value); break;
                    case "Password": _Password = Convert.ToString(value); break;
                    case "DisplayName": _DisplayName = Convert.ToString(value); break;
                    case "Sex": _Sex = (SexKinds)value.ToInt(); break;
                    case "Mail": _Mail = Convert.ToString(value); break;
                    case "Mobile": _Mobile = Convert.ToString(value); break;
                    case "Code": _Code = Convert.ToString(value); break;
                    case "Avatar": _Avatar = Convert.ToString(value); break;
                    case "RoleID": _RoleID = value.ToInt(); break;
                    case "RoleIDs": _RoleIDs = Convert.ToString(value); break;
                    case "Online": _Online = value.ToBoolean(); break;
                    case "Enable": _Enable = value.ToBoolean(); break;
                    case "Logins": _Logins = value.ToInt(); break;
                    case "LastLogin": _LastLogin = value.ToDateTime(); break;
                    case "LastLoginIP": _LastLoginIP = Convert.ToString(value); break;
                    case "RegisterTime": _RegisterTime = value.ToDateTime(); break;
                    case "RegisterIP": _RegisterIP = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得用户字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName("ID");

            /// <summary>名称。登录用户名</summary>
            public static readonly Field Name = FindByName("Name");

            /// <summary>密码</summary>
            public static readonly Field Password = FindByName("Password");

            /// <summary>昵称</summary>
            public static readonly Field DisplayName = FindByName("DisplayName");

            /// <summary>性别。未知、男、女</summary>
            public static readonly Field Sex = FindByName("Sex");

            /// <summary>邮件</summary>
            public static readonly Field Mail = FindByName("Mail");

            /// <summary>手机</summary>
            public static readonly Field Mobile = FindByName("Mobile");

            /// <summary>代码。身份证、员工编号等</summary>
            public static readonly Field Code = FindByName("Code");

            /// <summary>头像</summary>
            public static readonly Field Avatar = FindByName("Avatar");

            /// <summary>角色。主要角色</summary>
            public static readonly Field RoleID = FindByName("RoleID");

            /// <summary>角色组。次要角色集合</summary>
            public static readonly Field RoleIDs = FindByName("RoleIDs");

            /// <summary>在线</summary>
            public static readonly Field Online = FindByName("Online");

            /// <summary>启用</summary>
            public static readonly Field Enable = FindByName("Enable");

            /// <summary>登录次数</summary>
            public static readonly Field Logins = FindByName("Logins");

            /// <summary>最后登录</summary>
            public static readonly Field LastLogin = FindByName("LastLogin");

            /// <summary>最后登录IP</summary>
            public static readonly Field LastLoginIP = FindByName("LastLoginIP");

            /// <summary>注册时间</summary>
            public static readonly Field RegisterTime = FindByName("RegisterTime");

            /// <summary>注册IP</summary>
            public static readonly Field RegisterIP = FindByName("RegisterIP");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得用户字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>名称。登录用户名</summary>
            public const String Name = "Name";

            /// <summary>密码</summary>
            public const String Password = "Password";

            /// <summary>昵称</summary>
            public const String DisplayName = "DisplayName";

            /// <summary>性别。未知、男、女</summary>
            public const String Sex = "Sex";

            /// <summary>邮件</summary>
            public const String Mail = "Mail";

            /// <summary>手机</summary>
            public const String Mobile = "Mobile";

            /// <summary>代码。身份证、员工编号等</summary>
            public const String Code = "Code";

            /// <summary>头像</summary>
            public const String Avatar = "Avatar";

            /// <summary>角色。主要角色</summary>
            public const String RoleID = "RoleID";

            /// <summary>角色组。次要角色集合</summary>
            public const String RoleIDs = "RoleIDs";

            /// <summary>在线</summary>
            public const String Online = "Online";

            /// <summary>启用</summary>
            public const String Enable = "Enable";

            /// <summary>登录次数</summary>
            public const String Logins = "Logins";

            /// <summary>最后登录</summary>
            public const String LastLogin = "LastLogin";

            /// <summary>最后登录IP</summary>
            public const String LastLoginIP = "LastLoginIP";

            /// <summary>注册时间</summary>
            public const String RegisterTime = "RegisterTime";

            /// <summary>注册IP</summary>
            public const String RegisterIP = "RegisterIP";
        }
        #endregion
    }
}