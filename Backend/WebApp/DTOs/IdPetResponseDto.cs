namespace WebApp.DTOs
{
	public class IdPetDTO
	{
		public string PetId { get; set; }
		public string PetName { get; set; }
		public string PetSpecies { get; set; }
		public int PetAge { get; set; }
		public string Description { get; set; }
		public bool Available { get; set; }
		public DateTime Created { get; set; } = DateTime.UtcNow;
	}
}
