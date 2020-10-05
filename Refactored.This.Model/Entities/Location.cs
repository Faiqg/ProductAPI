using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refactored.This.Model.Entities
{
    public class Location : IBaseEntity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string UrlFormSixtyTwo { get; set; }
        public string LegalAssessment { get; set; }
        public string StructureAssessment { get; set; }
    }
}
