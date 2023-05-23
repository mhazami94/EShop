using FluentValidation.Results;
using MediatR;

namespace Identity.Application.Core.CQRS.CommandHandling
{
    public interface ICommand<out TResult> : IRequest<TResult>
    {
        public abstract ValidationResult Validate();
    }

    public abstract record class Command<TID> : ICommand<CommandHandlerResult<TID>> where TID : struct
    {
        public ValidationResult ValidationResult { get; init; }

        public virtual ValidationResult Validate()
        {
            return ValidationResult;
        }
    }
}
