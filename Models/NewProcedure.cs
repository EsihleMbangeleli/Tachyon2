using System.IO;
using System.Net;
using System.Net.Http;

namespace Tachyon.Models
{
	public class NewProcedure
	{
		//Pre-Procedure/Consultation/Referral Document
		public int ProID { get; set; }
		public string procedureName { get; set; }
		public string physicianName { get; set; }
		public string physicianSpecialty { get; set; }
		public string physicianlicenseNo { get; set; }
		public string physicianAddress { get; set; }
		public string physiciancontact { get; set; }
		public string physicianemail { get; set; }
		public string patientName { get; set; }
		public string patientGender { get; set; }
		public string patientAddress { get; set; }
		public string patientContact { get; set; }
		public DateTime? Date { get; set; }
		public string reason { get; set; }
		public string descriptionSymptoms { get; set; }
		public string prelimDiagnosis { get; set; }
		public string specificQuestion { get; set; }
		public string addNotes { get; set; }
	}
}
