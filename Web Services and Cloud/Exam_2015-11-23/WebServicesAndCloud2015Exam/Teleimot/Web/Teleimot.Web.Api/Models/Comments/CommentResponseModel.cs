namespace Teleimot.Web.Api.Models.Comments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mappings;

    public class CommentResponseModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        //{
        //    "Content": "Wow, such a bargain! I want to see the place!",
        //    "UserName": "ivaylokenov",
        //    "CreatedOn": "2015-11-22T16:40:03.123"
        //}

        public string Content { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentResponseModel>()
                        .ForMember(re => re.UserName, opts => opts.MapFrom(re => re.User.UserName));        
        }
    }
}