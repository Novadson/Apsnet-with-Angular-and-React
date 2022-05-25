using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingAngular.Domain.Entities
{
    #region TABLE
    [Table("users")]
    public class Users
    {
        #region PROPERTIES
        [Key]
        [Column("user_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column("user_name")]
        [Required(ErrorMessage = "The email address is required")]
        public string Name { get; set; }

        [Column("user_email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }
        #endregion PROPERTIES
    }
    #endregion TABLE
}
