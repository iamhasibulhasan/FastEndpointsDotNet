namespace FastEndpointsDotNet.Application.Common.Utilities;

public sealed class Result
{
    public bool IsSuccess { get; set; }
    public int StatusCode { get; set; }
    public string Status { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }
}

public sealed class Result<T>
{
    public bool IsSuccess { get; set; }
    public int StatusCode { get; set; }
    public string Status { get; set; }
    public string Message { get; set; }
    public T? Data { get; set; }
}

