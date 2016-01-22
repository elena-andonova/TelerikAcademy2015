namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Post
    {
        private ICollection<UserProfile> userProfiles;

        public Post()
        {
            this.userProfiles = new HashSet<UserProfile>();
        }

        public int PostId { get; set; }

        [MinLength(10)]
        public string Content { get; set; }

        public DateTime PostingDate { get; set; }

        public virtual ICollection<UserProfile> UserProfiles
        {
            get
            {
                return this.userProfiles;
            }
            set
            {
                this.userProfiles = value;
            }
        }
    }
}
