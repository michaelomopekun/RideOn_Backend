namespace RideOn.Infrastructure.Exceptions;

public class EnvVarNotSetException : Exception
{
    public EnvVarNotSetException(string key)
        : base($"Environment variable '{key}' is not set.")
    {
    }
}


