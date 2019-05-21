namespace Templates.DataAccess.Core
{
    using System;

    public partial class User
    {
        public Guid Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Ipaddress { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
