using System;

namespace Layers.API.Models
{
    public class EntityBase
    {
        public EntityBase()
        {
            this.Ident = GenerateIdentifier();
        }

        public EntityBase(String ident)
        {
            this.Ident = ident;
        }

        public String Ident { get; }

        private String GenerateIdentifier()
        {
            return Guid.NewGuid().ToString("N").Substring(1, 10);
        }

    }

}