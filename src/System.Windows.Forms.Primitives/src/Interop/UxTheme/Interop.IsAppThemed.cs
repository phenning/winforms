﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    public static partial class UxTheme
    {
        [LibraryImport(Libraries.UxTheme)]
        public static partial BOOL IsAppThemed();
    }
}
