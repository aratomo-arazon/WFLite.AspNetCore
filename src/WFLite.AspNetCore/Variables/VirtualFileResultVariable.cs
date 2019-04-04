using Microsoft.AspNetCore.Mvc;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class VirtualFileResultVariable : OutVariable<string>
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

        public VirtualFileResultVariable(IOutVariable<string> fileName, IOutVariable<string> contentType, IConverter<string> converter = null)
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
