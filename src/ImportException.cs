// Copyright (C) 2016 Dmitry Yakimenko (detunized@gmail.com).
// Licensed under the terms of the MIT license. See LICENCE for details.

using System;

namespace Dashlane
{
    public class ImportException: BaseException
    {
        public enum FailureReason
        {
            ProfileNotFound,
            InvalidFormat,
            IncorrectPassword,
        }

        public ImportException(FailureReason reason, string message): base(message)
        {
            Reason = reason;
        }

        public ImportException(FailureReason reason, string message, Exception innerException):
            base(message, innerException)
        {
            Reason = reason;
        }

        public FailureReason Reason { get; private set; }
    }
}
