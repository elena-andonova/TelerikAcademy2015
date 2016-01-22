namespace Teleimot.Web.Api.Controllers
{
    using System.Linq;
    using Services.Data.Contracts;
    using System.Web.Http;
    using Models.Comments;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNet.Identity;
    using Infrastructure.Validation;

    public class CommentsController : ApiController
    {
        private ICommentsService comments;

        public CommentsController(ICommentsService comments)
        {
            this.comments = comments;
        }

        public IHttpActionResult Get(int id, int skip = 0, int take = 10)
        {
            var result = this.comments.GetRealEstateComments(id, skip, take).ProjectTo<CommentResponseModel>().ToList();

            return this.Ok(result);
        }

        [HttpGet]
        [Route("api/Comments/ByUser/{userName}")]
        [Authorize]
        public IHttpActionResult Get(string userName, int skip = 0, int take = 10)
        {
            var result = this.comments.GetCommentsByUser(userName, skip, take).ProjectTo<CommentResponseModel>().ToList();

            return this.Ok(result);
        }

        [Authorize]
        [ValidateModel]
        public IHttpActionResult Post(CommentRequestModel model)
        {
            var newComment = this.comments.CreateComment(model.RealEstateId, model.Content, this.User.Identity.GetUserId());

            var newRealEstateResult = comments
                .GetComment(newComment.Id)
                .ProjectTo<CommentResponseModel>()
                .FirstOrDefault();

            return this.Created(string.Format("/api/Comments/{0}/{1}", model.RealEstateId, newComment.Id),
                newRealEstateResult);
        }
    }
}