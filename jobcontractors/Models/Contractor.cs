using System.ComponentModel.DataAnnotations;

public class Contractor
{
  public int Id { get; set; }
  [Required]
  public string Name { get; set; }

}

public class ContractorJobContractViewModel : Contractor
{
  public int JobContractId { get; set; }
}