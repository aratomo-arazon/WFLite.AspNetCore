using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class FileContentResultVariable : OutVariable<byte[]>
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

        public FileContentResultVariable(IOutVariable<byte[]> fileContents, IOutVariable<string> contentType, IConverter<byte[]> converter = null)
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
