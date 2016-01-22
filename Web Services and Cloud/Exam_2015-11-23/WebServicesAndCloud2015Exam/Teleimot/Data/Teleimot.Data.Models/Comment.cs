namespace Teleimot.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        //[Required] we don't need it, because if not correctly provided - will break anyways
        public int RealEstateId { get; set; }

        public virtual RealEstate RealEstate { get; set; }      
    }
}
