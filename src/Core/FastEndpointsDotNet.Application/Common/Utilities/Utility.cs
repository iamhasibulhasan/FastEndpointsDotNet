using Microsoft.AspNetCore.Http;
using static FastEndpointsDotNet.Application.Common.Utilities.AppConstants;

namespace FastEndpointsDotNet.Application.Common.Utilities;


public static class Utility
{
    public static Result GetSuccessMsg(string message, object data = null)
    {
        return new Result
        {
            IsSuccess = true,
            StatusCode = StatusCodes.Status200OK,
            Status = ResultStatus.Success.ToString(),
            Message = message,
            Data = data
        };
    }
    public static Result GetNoContentFoundMsg(string message = "No Content Found", object data = null)
    {
        return new Result
        {
            IsSuccess = true,
            StatusCode = StatusCodes.Status204NoContent,
            Status = ResultStatus.Success.ToString(),
            Message = message,
            Data = data
        };
    }
    public static Result GetValidDataMsg(string message = "Data Valid", object data = null)
    {
        return new Result
        {
            IsSuccess = true,
            StatusCode = StatusCodes.Status200OK,
            Status = ResultStatus.Success.ToString(),
            Message = message,
            Data = data
        };
    }

    public static Result GetAlreadyExistMsg(string module = "Data")
    {
        return new Result
        {
            IsSuccess = false,
            StatusCode = StatusCodes.Status409Conflict,
            Status = ResultStatus.Canceled.ToString(),
            Message = module + " already exist!",
            Data = null
        };
    }

    public static Result GetErrorMsg(string message)
    {
        return new Result
        {
            IsSuccess = false,
            StatusCode = StatusCodes.Status400BadRequest,
            Status = ResultStatus.Canceled.ToString(),
            Message = message
        };
    }

    public static Result GetInternalServerErrorMsg(Exception ex, string customMessage = null)
    {
        if (ex.InnerException == null)
        {
            return new Result
            {
                IsSuccess = false,
                StatusCode = StatusCodes.Status500InternalServerError,
                Status = ResultStatus.Error.ToString(),
                Message = string.IsNullOrWhiteSpace(customMessage) ? (ex.Message + ("")) : customMessage,
                Data = null
            };
        }
        else
        {
            return new Result
            {
                IsSuccess = false,
                StatusCode = StatusCodes.Status500InternalServerError,
                Status = ResultStatus.Error.ToString(),
                Message = string.IsNullOrWhiteSpace(customMessage) ? (ex.Message + (" --> InnerException: " + ex.InnerException.Message)) : customMessage,
                Data = null
            };
        }
    }

    public static Result GetInternalServerErrorMsg(string message)
    {
        return new Result
        {
            IsSuccess = false,
            StatusCode = StatusCodes.Status500InternalServerError,
            Status = ResultStatus.Error.ToString(),
            Message = message,
            Data = null
        };
    }

    public static Result GetNoDataFoundMsg(string msg = "No data found!")
    {
        return new Result
        {
            IsSuccess = false,
            StatusCode = StatusCodes.Status404NotFound,
            Status = ResultStatus.Error.ToString(),
            Message = msg,
            Data = null
        };
    }

    public static Result GetUnauthenticatedMsg()
    {
        return new Result
        {
            IsSuccess = false,
            StatusCode = StatusCodes.Status401Unauthorized,
            Status = ResultStatus.Canceled.ToString(),
            Message = CommonMessages.Unauthenticated,
            Data = null
        };
    }

    public static Result GetUnauthorizedMsg(string msg = null)
    {
        return new Result
        {
            IsSuccess = false,
            StatusCode = StatusCodes.Status403Forbidden,
            Status = ResultStatus.Canceled.ToString(),
            Message = msg == null ? CommonMessages.Unauthorized : $"{CommonMessages.Unauthorized} ({msg})",
            Data = null
        };
    }

    public static Result GetValidationFailedMsg(string msg = CommonMessages.ValidationFailed)
    {
        return new Result
        {
            IsSuccess = false,
            StatusCode = StatusCodes.Status422UnprocessableEntity,
            Status = ResultStatus.Canceled.ToString(),
            Message = msg,
            Data = null
        };
    }

    public static Result GetValidationFailedMsg(List<string> msg)
    {
        return new Result
        {
            IsSuccess = false,
            StatusCode = StatusCodes.Status422UnprocessableEntity,
            Status = ResultStatus.Canceled.ToString(),
            Message = CommonMessages.ValidationFailed,
            Data = msg
        };
    }
}
