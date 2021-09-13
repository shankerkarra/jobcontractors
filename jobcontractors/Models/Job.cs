using System.ComponentModel.DataAnnotations;

public class Job
{
  public int Id { get; set; }
  [Required]
  public int Name { get; set; }

}


public class JobJobContractViewModel : Job
{
  public int JobContractId { get; set; }
}