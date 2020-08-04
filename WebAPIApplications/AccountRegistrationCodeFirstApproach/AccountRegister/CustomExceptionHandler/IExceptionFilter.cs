using Microsoft.AspNetCore.Mvc.Filters;

namespace AccountRegister.CustomExceptionHandler
{
    public interface IExceptionFilter : IFilterMetadata
    {
        void OnException(ExceptionContext context);
    }
}
