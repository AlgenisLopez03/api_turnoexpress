﻿
namespace GestorDeTurnos.Application.Dtos.Employee
{
    public class EmployeeListDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int EstablishmentId { get; set; }
        public bool Availabe { get; set; }
    }
}
