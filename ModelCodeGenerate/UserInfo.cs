//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelCodeGenerate
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserInfo()
        {
            this.UserPermission = new HashSet<UserPermission>();
            this.Role = new HashSet<Role>();
            this.UserGroup = new HashSet<UserGroup>();
        }
    
        public System.Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SaltKey { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public int ClientAppId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPermission> UserPermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserGroup> UserGroup { get; set; }
        public virtual ClientApp ClientApp { get; set; }
    }
}
