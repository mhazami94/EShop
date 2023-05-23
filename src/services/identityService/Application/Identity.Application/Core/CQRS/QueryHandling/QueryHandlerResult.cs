using FluentValidation.Results;

namespace Identity.Application.Core.CQRS.QueryHandling
{
    public record class QueryHandlerResult<TResult>
    {
        public ValidationResult ValidationResult { get; }
        public TResult Result { get; set; }
        public QueryHandlerResult(IQuery<QueryHandlerResult<TResult>> query)
        {
            ValidationResult = query.Validate();
        }
    }
}
