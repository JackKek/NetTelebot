﻿using NetTelebot.Interface;

namespace NetTelebot.Type
{
    /// <summary>
    /// This object represents the contents of a file to be uploaded. 
    /// </summary>
    public class NewFile : IFile
    {
        /// <summary>
        /// Gets or sets the content of the file.
        /// </summary>
        /// <value>
        /// The content of the file.
        /// </value>
        public byte[] FileContent { get; set; }
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }
    }
}
