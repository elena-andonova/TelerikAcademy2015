namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserProfile
    {
        private ICollection<ChatMessage> chatMessages;
        private ICollection<Image> images;
        private ICollection<Post> posts;

        public UserProfile()
        {
            this.chatMessages = new HashSet<ChatMessage>();
            this.images = new HashSet<Image>();
            this.posts = new HashSet<Post>();
        }
        public int UserProfileId { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(4)]
        [MaxLength(20)]
        public string Username { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<ChatMessage> ChatMessages
        {
            get
            {
                return this.chatMessages;
            }
            set
            {
                this.chatMessages = value;
            }
        }

        public virtual ICollection<Image> Images
        {
            get
            {
                return this.images;
            }
            set
            {
                this.images = value;
            }
        }

        public virtual ICollection<Post> Posts
        {
            get
            {
                return this.posts;
            }
            set
            {
                this.posts = value;
            }
        }
    }
}
