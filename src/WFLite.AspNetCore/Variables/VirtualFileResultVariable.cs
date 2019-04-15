/*
 * VirtualFileResultVariable.cs
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
    public class VirtualFileResultVariable : OutVariable<IActionResult>
    {
        public IOutVariable<string> FileName
        {
            private get;
            set;
        }

        public IOutVariable<string> ContentType
        {
            private get;
            set;
        }

        public VirtualFileResultVariable()
        {
        }

        public VirtualFileResultVariable(IOutVariable<string> fileName, IOutVariable<string> contentType, IConverter<IActionResult> converter = null)
            : base(converter)
        {
            this.FileName = fileName;
            this.ContentType = contentType;
        }

        protected override object getValue()
        {
            return new VirtualFileResult(this.FileName.GetValue(), this.ContentType.GetValue());
        }
    }
}
