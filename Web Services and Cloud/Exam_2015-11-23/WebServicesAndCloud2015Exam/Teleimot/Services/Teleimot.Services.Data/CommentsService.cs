namespace Teleimot.Services.Data
{
    using System;
    using System.Linq;
    using Teleimot.Data.Models;
    using Teleimot.Data.Repositories;
    using Teleimot.Services.Data.Contracts;

    public class CommentsService : ICommentsService
    {
        private IRepository<Comment> comments;

        public CommentsService(IRepository<Comment> comments)
        {
            this.comments = comments;
        }

        public IQueryable<Comment> GetRealEstateComments(int id, int skip = 0, int take = 10)
        {
            return this.comments
                .All()
                .Where(c => c.RealEstateId == id)
                .OrderBy(c => c.CreatedOn)
                .Skip(skip * take)
                .Take(take);
        }

        public IQueryable<Comment> GetCommentsByUser(string userName, int skip = 0, int take = 10)
        {
            return this.comments
                .All()
                .Where(c => c.User.UserName == userName)
                .OrderBy(c => c.CreatedOn)
                .Skip(skip * take)
                .Take(take);
        }

        public IQueryable<Comment> GetComment(int id)
        {
            return this.comments
                .All()
                .Where(c => c.Id == id);
        }

        public Comment CreateComment(int id, string content, string userId)
        {
            var newComment = new Comment
            {
                RealEstateId = id,
                Content = content,
                UserId = userId,
                CreatedOn = DateTime.UtcNow
            };

            this.comments.Add(newComment);
            this.comments.SaveChanges();

            return newComment;
        }
    }
}
