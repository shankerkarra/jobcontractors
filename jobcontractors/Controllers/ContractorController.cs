using Microsoft.AspNetCore.Mvc;
using jobcontractors.Services;
using System;
using System.Collections.Generic;

namespace jobcontractors.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContractorController : ControllerBase
  {
    private readonly ContractorService _cs;

    public ContractorController(ContractorService cs)
    {
      _cs = cs;
    }

    [HttpGet]
    public ActionResult<List<Contractor>> GetAll()
    {
      try
      {
        List<Contractor> Contractors = _cs.GetAll();
        return Ok(Contractors);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
    {
      try
      {
        Contractor created = _cs.Create(newContractor);
        return Ok(created);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPut("{id}")]

    public ActionResult<Contractor> Update(int id, [FromBody] Contractor editedContractor)
    {
      try
      {
        editedContractor.Id = id;
        Contractor contractor = _cs.Update(editedContractor);
        return Ok(contractor);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]

    public ActionResult<Contractor> Delete(int id)
    {
      try
      {
        Contractor Contractor = _cs.Delete(id);
        return Ok(Contractor);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

  }
}