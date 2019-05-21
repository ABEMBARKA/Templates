namespace Templates.DataAccess.Core
{
    using System;

    public partial class UserProfile
    {
        public Guid Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Ipaddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual User IdNavigation { get; set; }
    }
}
