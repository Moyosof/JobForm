using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobForm.Models
{
    public class FormRequirement
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [DisplayName("Number of Position")]
        public int NumberOfPosition { get; set; }
        [DisplayName("Job Description")]
        public string JobDescription { get; set; }
        [DisplayName("Education Requirement")]
        public string EducationRequirement { get; set; }
        [DisplayName("Years of EXperience")]
        public int Experience { get; set; }
        public Specialization Specialization { get; set; }
        [Required]
        public DateTime ApplicationDate { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Salary Amount")]
        public double SalaryAmount { get; set; }
        [Required]
        [DisplayName("Job Type")]
        public JobType JobType { get; set; }
        [Required]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [EmailAddress]
        public String Email { get; set; }
        [DisplayName("Company Address")]
        public string CompanyAddress { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string State { get; set; }


    }
}
