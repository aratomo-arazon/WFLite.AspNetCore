using Microsoft.AspNetCore.Mvc;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.AspNetCore.Variables
{
    public class PhysicalFileResultVariable : OutVariable<string>
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

        public PhysicalFileResultVariable(IOutVariable<string> fileName, IOutVariable<string> contentType, IConverter<string> converter = null)
            : base(converter)
        {
            this.FileName = fileName;
            this.ContentType = contentType;
        }

        protected override object getValue()
        {
            return new PhysicalFileResult(this.FileName.GetValue(), this.ContentType.GetValue());
        }
    }
}
