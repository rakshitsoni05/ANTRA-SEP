using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repository;

namespace EntityFramework.Infrastructure.Services;

public class DepartmentService: IDepartmentService
{
    private DepartmentRepository _departmentRepository = new DepartmentRepository();
    
    public List<DepartmentResponseModel> GetAllDepartments()
    {
        var departments = _departmentRepository.GetAll();
        var departmentResponseModel = new List<DepartmentResponseModel>();
        foreach (var department in departments)
        {
            departmentResponseModel.Add(new DepartmentResponseModel()
            {
                DepartmentName = department.DepartmentName,
                Location = department.Location
            });
        }

        return departmentResponseModel;
    }

    public DepartmentResponseModel GetById(int id)
    {
        var department = _departmentRepository.GetById(id);
        if (department != null)
        {
            var departmentResponseModel = new DepartmentResponseModel()
            {
                DepartmentName = department.DepartmentName,
                Location = department.Location
            };
            return departmentResponseModel;
        }

        return null;
    }

    public int AddDepartment(DepartmentRequestModel model)
    {
        var departmentEntity = new Department()
        {
            DepartmentName = model.DepartmentName,
            Location = model.Location
        };
        return _departmentRepository.Insert(departmentEntity);
    }

    public int DeleteDepartmentById(int id)
    {
        return _departmentRepository.DeleteById(id);
    }

    public int UpdateDepartmentById(int id, DepartmentRequestModel model)
    {
        var departmentEntity = new Department()
        {
            Id = id,
            DepartmentName = model.DepartmentName,
            Location = model.Location
        };
        return _departmentRepository.Update(departmentEntity);
    }
    
}