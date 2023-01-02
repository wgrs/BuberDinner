using System.Net;
namespace BuberDinner.Application.Common.Errors;

public record struct DuplicateEmailError()
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMessage => "Email already exists";
}