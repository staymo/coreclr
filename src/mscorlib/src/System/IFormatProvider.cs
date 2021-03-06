// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*============================================================
**
**
**
** Purpose: Notes a class which knows how to return formatting information
**
**
============================================================*/
namespace System {
    
    using System;

    [System.Runtime.InteropServices.ComVisible(true)]
    public interface IFormatProvider
    {
        // Interface does not need to be marked with the serializable attribute
        Object GetFormat(Type formatType);
    }
}
