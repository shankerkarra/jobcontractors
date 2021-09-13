using System.ComponentModel.DataAnnotations;

public class JobContract
{
  public int Id { get; set; }
  [Required]
  public int ContractorId { get; set; }
  [Required]
  public int CompanyId { get; set; }
}