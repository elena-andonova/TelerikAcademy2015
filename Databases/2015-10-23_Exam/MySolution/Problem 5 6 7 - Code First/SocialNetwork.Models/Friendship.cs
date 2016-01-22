namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;

    public class Friendship
    {
        private ICollection<ChatMessage> chatMessages;

        public Friendship()
        {
            this.chatMessages = new HashSet<ChatMessage>();
        }

        public int FriendshipId { get; set; }
        public bool ApprovalStatus { get; set; }

        public DateTime DateOfApproval { get; set; }

        public int FirstUserProfileId { get; set; }

        public virtual UserProfile FirstUserProfile { get; set; }

        public int SecondUserProfileId { get; set; }

        public virtual UserProfile SecondUserProfile { get; set; }

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
    }
}
