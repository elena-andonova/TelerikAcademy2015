namespace Teleimot.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class RealEstate
    {
        private ICollection<Comment> comments;

        public RealEstate()
        {
            this.comments = new HashSet<Comment>();
        }            
         
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Index]
        public RealEstateType RealEstateType { get; set; }

        // Should be >= 1800
        public string ConstructionYear { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Contact { get; set; }

        public bool CanBeSold { get; set; }

        public string SellingPrice { get; set; }

        public bool CanBeRented { get; set; }

        public string RentingPrice { get; set; }

        public DateTime CreatedOn { get; set; }
       
        public string UserId { get; set; }
    
        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
