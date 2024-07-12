using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces;

namespace EntityFramework.Infrastructure.Repository;

public class DepartmentRepository: BaseRepository<Department>, IDepartmentRepository<Department>
{
    
}