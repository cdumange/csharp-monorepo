namespace Result;

public class Result<T> : Result
{
    public T? Value { get; init; }

    public static Result<T> FromValue(T value)
    {
        return new Result<T> { Value = value };
    }
}

public class Result
{
    public Error? Error { get; init; }

    public bool IsError => Error is not null;
    public bool IsOK => Error is null;

    public static Result Ok() { return new Result(); }
    public static Result FromError(Error error)
    {
        return new Result { Error = error };
    }
}

