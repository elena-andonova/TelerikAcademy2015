namespace Teleimot.Services.Data.Contracts
{
    using System.Linq;
    using Teleimot.Data.Models;

    public interface ICommentsService
    {
        IQueryable<Comment> GetRealEstateComments(int id, int skip = 0, int take = 10);

        IQueryable<Comment> GetCommentsByUser(string userName, int skip = 0, int take = 10);

        IQueryable<Comment> GetComment(int id);

        Comment CreateComment(int id, string content, string userId);       
    }
}
