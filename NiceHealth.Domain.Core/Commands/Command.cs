using FluentValidation.Results;
using NiceHealth.Domain.Core.Events;
using System;

namespace NiceHealth.Domain.Core.Commands
{
    public abstract class Command : Event
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool isValid();
    }
}
