using HealthCenter.Models;
using Microsoft.AspNetCore.Identity;

namespace HealthCenter.Data
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address { get; set; }

		public DateTime DateOfBirth {  get; set; }

		public string MothersName { get; set; }

		public string FathersName {  get; set; }

		public string IdNumber { get; set; }
		//
		public int? GenderId {  get; set; }
		public SystemCodeDetail Gender { get; set; }
		//
		public int? BloodGroupId { get; set; }
		public SystemCodeDetail BloodGroup { get; set; }
		//
		public int? MaritalstatusId { get; set; }
		public SystemCodeDetail Maritalstatus { get; set; }

	}

}
