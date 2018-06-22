//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeysProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class ProductSold
    {
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Id is not valid.")]
        public int Id { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Customer name can only contain letters.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Customer name should be between 3 and 10 letters")]
        [DisplayName(displayName: "Customer Name")]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Product name should be between 3 and 10 letters")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Product name can only contain letters.")]
        [DisplayName(displayName: "Product Name")]
        public int ProductId { get; set; }
        [Required]
        [DisplayName(displayName: "Store Name")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Store name can only contain letters.")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Store name should be between 3 and 10 letters")]
        public int StoreId { get; set; }
        [Required]
        [DisplayName(displayName: "Date Sold")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:MM/dd/yyyy}")]
        public string DateSold { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
