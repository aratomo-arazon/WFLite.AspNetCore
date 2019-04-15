/*
 * FileContentResultVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.AspNetCore.Mvc;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class FileContentResultVariable : OutVariable<IActionResult>
    {
        public IOutVariable<byte[]> FileContents
        {
            private get;
            set;
        }

        public IOutVariable<string> ContentType
        {
            private get;
            set;
        }

        public FileContentResultVariable()
        {
        }

        public FileContentResultVariable(IOutVariable<byte[]> fileContents, IOutVariable<string> contentType, IConverter<IActionResult> converter = null)
            : base(converter)
        {
            this.FileContents = fileContents;
            this.ContentType = contentType;
        }

        protected override object getValue()
        {
            return new FileContentResult(this.FileContents.GetValue(), this.ContentType.GetValue());
        }
    }
}
