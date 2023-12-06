﻿using MediatR;

namespace TurarJoy.Application.UseCases.Sales.Commands
{
    public class CreateSaleCommand : IRequest
    {
        public DateTime SaledAt { get; set; }
        public string? Cost { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public int HouseId { get; set; }
    }
}
