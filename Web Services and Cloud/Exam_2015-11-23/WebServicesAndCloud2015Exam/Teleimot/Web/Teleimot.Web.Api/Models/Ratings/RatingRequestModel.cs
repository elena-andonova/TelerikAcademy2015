namespace Teleimot.Web.Api.Models.Ratings
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class RatingRequestModel : IValidatableObject
    {
        public string UserId { get; set; }

        public int Value { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (0 <= Value || Value >= 6)
            {
                yield return new ValidationResult("Ratings are always between 1 and 5 (integers), inclusive!");
            }
        }        
    }
}