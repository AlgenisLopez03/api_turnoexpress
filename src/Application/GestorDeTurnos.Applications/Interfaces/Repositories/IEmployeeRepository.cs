﻿
using GestorDeTurnos.Domain.Entities;

namespace GestorDeTurnos.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository : IAsyncRepository<Employees>
    {
    }
}