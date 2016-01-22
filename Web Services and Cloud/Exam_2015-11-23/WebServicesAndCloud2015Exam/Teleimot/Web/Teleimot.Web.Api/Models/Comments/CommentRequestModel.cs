namespace Teleimot.Web.Api.Models.Comments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Infrastructure.Mappings;
    using Data.Models;
    using AutoMapper;
    using System.ComponentModel.DataAnnotations;

    public class CommentRequestModel
    {
    //    {
    //"RealEstateId": 2,
    //"Content": "It's a trap! Don't go there!"
    //    }

        [Required]
        public int RealEstateId { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Content { get; set; }
    }
}