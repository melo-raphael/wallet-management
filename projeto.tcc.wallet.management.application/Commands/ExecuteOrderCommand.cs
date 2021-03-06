﻿using System;
using FluentValidation.Results;
using MediatR;
using projeto.tcc.wallet.management.application.Validations;

namespace projeto.tcc.wallet.management.application.Commands
{
    public class ExecuteOrderCommand : Command, IRequest<bool>
    {
        public Guid UserId { get; set; }

        public AssetDTO Asset { get; set; }
        public bool IsCloseOrder { get; set; }
        public int Ammount { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new ExecuteOrderCommandValidation().Validate(this);

            return ValidationResult.IsValid;
        }
    }

    public class AssetDTO
    {
        public string Symbol { get; set; }
        public decimal StartPrice { get; set; }
    }
}