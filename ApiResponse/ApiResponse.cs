using Microsoft.AspNetCore.Mvc;

namespace ApiResponse;

public record ApiModel(int StatusCode, bool IsSuccess, string Message, object Data);

public static class ApiResponse
{
    public static OkObjectResult Success(string message = "موفقیت آمیز", object data = null)
        => new OkObjectResult(new ApiModel(200, true, message, data));

    public static OkObjectResult NotFound(string message)
        => new OkObjectResult(new ApiModel(404, false, message, null));

    public static OkObjectResult Filed(string message, int StatusCode = 400)
        => new OkObjectResult(new ApiModel(StatusCode, false, message, null));

    public static OkObjectResult ServerError(string message = "خطای سرور")
        => new OkObjectResult(new ApiModel(500, false, message, null));
}

// Sample Result :
//
// {
//   "statusCode" : 000 ( http status code ),
//   "isSuccess" : true/false,
//   "message" : "string",
//   "data" : null ( response data )
// }
//