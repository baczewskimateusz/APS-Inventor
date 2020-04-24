﻿using System;
using System.IO;

namespace WebApplication.Utilities
{
    /// <summary>
    /// Wrapper for temporary file, which is deleted on disposal.
    /// </summary>
    public class TempFile : IDisposable
    {
        /// <summary>
        /// Full filename of the temporary file.
        /// </summary>
        public string Name { get; }

        public TempFile()
        {
            Name = Path.GetTempFileName();
        }

        public void Dispose()
        {
            File.Delete(Name);
        }
    }
}
