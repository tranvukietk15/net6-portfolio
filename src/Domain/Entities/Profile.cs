using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Profiles")]
    public class Profile : Aggregrator
    {
        public Profile(Guid id) : base(id)
        {
        }

        public Profile(string fullName, string nickName, string degree, string phoneNumber, string address, string email, string avatarUrl, string aboutMe, DateTime birthday) : base(Guid.NewGuid())
        {
            FullName = fullName;
            NickName = nickName;
            Degree = degree;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            AvatarUrl = avatarUrl;
            AboutMe = aboutMe;
            Birthday = birthday;
        }

        public static Profile NewInstance()
        {
            return new Profile(Guid.NewGuid());
        }

        public string FullName { get; private set; }
        public string NickName { get; private set; }
        public string Degree { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public string Email { get; private set; }
        public string AvatarUrl { get; private set; }
        public string AboutMe { get; private set; }

        public DateTime Birthday { get; private set; }
    }
}
