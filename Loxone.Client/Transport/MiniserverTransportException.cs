﻿// ----------------------------------------------------------------------
// <copyright file="MiniserverTransportException.cs">
//     Copyright (c) The Loxone.NET Authors.  All rights reserved.
// </copyright>
// <license>
//     Use of this source code is governed by the MIT license that can be
//     found in the LICENSE.txt file.
// </license>
// ----------------------------------------------------------------------

namespace Loxone.Client.Transport
{
    using System;

    [Serializable]
    public class MiniserverTransportException : MiniserverException
    {
        public MiniserverTransportException()
        {
        }

        public MiniserverTransportException(string message)
            : base(message)
        {
        }

        public MiniserverTransportException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if NETFX
        protected MiniserverTransportException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}