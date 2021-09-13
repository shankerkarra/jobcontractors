using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace jobcontractors.Repositories
{

  public class ContractorsRepository
  {
    private readonly IDbConnection _db;

    public ContractorsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Contractor Create(Contractor newContractor)
    {
      string sql = @"
        INSERT INTO contractor
        (Name)
        values(@Name);
        SELECT LAST_INSERT_ID();
        ";
      int id = _db.ExecuteScalar<int>(sql, newContractor);
      return GetById(id);

    }
    public List<Contractor> GetAll()
    {
      string sql = @"
      SELECT * FROM contractor;
      ";
      return _db.Query<Contractor>(sql).ToList();
    }
    internal Contractor GetById(int id)
    {
      string sql = @"
      SELECT * FROM contractor c
      WHERE c.id = @id;
      ";
      return _db.QueryFirstOrDefault<Contractor>(sql, new { id });
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM contractor WHERE id = @id LIMIT 1;";
      _db.Execute(sql, new { id });
    }
  }
}