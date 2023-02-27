using Rcl.Interop;
using Rosidl.Runtime.Interop;

namespace Rcl;

/// <summary>
/// Represents errors that occur in RCL or Rcl.NET.
/// </summary>
public class RclException : Exception
{
    /// <summary>
    /// Create a new <see cref="RclException"/> with specified error code.
    /// </summary>
    /// <param name="errorCode">
    /// </param>
    public RclException(int errorCode)
        : base(TryGetErrorMessage(errorCode))
    {
        Data[nameof(ErrorCode)] = errorCode;
    }

    /// <summary>
    /// Create a new <see cref="RclException"/> with specified message.
    /// </summary>
    /// <param name="message">Message of the error.</param>
    public RclException(string message)
        :base(message)
    {
        Data[nameof(ErrorCode)] = -1;
    }

    static unsafe string? TryGetErrorMessage(int errorCode)
    {
        if (rcutils_error_is_set())
        {
            var s = rcutils_get_error_string();
            rcutils_reset_error();
            return StringMarshal.CreatePooledString((byte*)s.str);
        }
        return $"RCL returned error code {errorCode}.";
    }

    internal static void ThrowIfNonSuccess(rcl_ret_t errorCode)
    {
        if (errorCode != 0)
            throw new RclException((int)errorCode);
    }

    /// <summary>
    /// Gets the rcl_ret_t error code. Returns -1 if the error is generated by Rcl.NET rather than RCL.
    /// </summary>
    public int ErrorCode => (int)Data[nameof(ErrorCode)]!;
}