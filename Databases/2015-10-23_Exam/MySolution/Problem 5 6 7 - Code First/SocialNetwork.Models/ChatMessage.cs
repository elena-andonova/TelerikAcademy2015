namespace SocialNetwork.Models
{
    using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    public class ChatMessage
    {
        public int ChatMessageId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime SendingTime { get; set; }

        public DateTime SeeingTime { get; set; }

        public int FriendshipId { get; set; }

        public virtual Friendship Friendship { get; set; }

        public int AuthorId { get; set; }

        public virtual UserProfile Author { get; set; }
    }
}
