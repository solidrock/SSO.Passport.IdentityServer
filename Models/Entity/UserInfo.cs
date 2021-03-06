using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entity
{
    [Table("UserInfo")]
    public partial class UserInfo
    {
        public UserInfo()
        {
            Id = Guid.NewGuid();
            UserPermission = new HashSet<UserPermission>();
            Role = new HashSet<Role>();
            UserGroup = new HashSet<UserGroup>();
            RegisterTime = DateTime.Now;
            LastLoginTime = RegisterTime;
        }

        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name = "用户名"), Required(ErrorMessage = "用户名不能为空！")]
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Display(Name = "密码"), Required(ErrorMessage = "登录密码不能为空！")]
        public string Password { get; set; }

        /// <summary>
        /// 密码加密盐
        /// </summary>
        [Required]
        public string SaltKey { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [Display(Name = "手机号码")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [Display(Name = "电子邮箱")]
        public string Email { get; set; }

        /// <summary>
        /// 是否是预置账户
        /// </summary>
        [DefaultValue(false)]
        public bool IsPreset { get; set; }

        /// <summary>
        /// 是否是内置管理员
        /// </summary>
        [DefaultValue(false)]
        public bool IsMaster { get; set; }

        /// <summary>
        /// 锁定状态
        /// </summary>
        [DefaultValue(false)]
        public bool Locked { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string Avatar { get; set; }


        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// AccessKey
        /// </summary>
        public string AccessKey { get; set; }

        public virtual ICollection<ClientApp> ClientApp { get; set; }

        public virtual ICollection<UserPermission> UserPermission { get; set; }

        public virtual ICollection<Role> Role { get; set; }

        public virtual ICollection<UserGroup> UserGroup { get; set; }
        public virtual ICollection<LoginRecord> LoginRecords { get; set; }
    }
}