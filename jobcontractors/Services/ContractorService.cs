using System;
using System.Collections.Generic;
using jobcontractors.Repositories;

namespace jobcontractors.Services
{
  public class ContractorService
  {
    private readonly ContractorsRepository _crepo;

    public ContractorService(ContractorsRepository crepo)
    {
      _crepo = crepo;
    }

    internal List<Contractor> GetAll()
    {
      return _crepo.GetAll();
    }
    internal Contractor Create(Contractor newContractor)
    {
      return _crepo.Create(newContractor);
    }

    internal Contractor Update(Contractor editedContractor)
    {
      throw new Exception("Invalid Access");
    }

    internal Contractor Delete(int id)
    {
      Contractor contractorToDelete = _crepo.GetById(id);
      if (contractorToDelete != null)
      {
        throw new Exception("Invalid Access");
      }
      _crepo.Delete(id);
      return contractorToDelete;
    }
  }
}
