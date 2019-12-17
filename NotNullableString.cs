using System;
using System.Collections.Generic;
using System.Text;

namespace GetInfra.WebApi.Abstractions
{
    public struct NotNullableString
    {
        public NotNullableString(string value)
       : this()
        {
            Value = value ?? "N/A";
        }

        public string Value
        {
            get;
            private set;
        }

        public static implicit operator NotNullableString(string value)
        {
            return new NotNullableString(value);
        }

        public static implicit operator string(NotNullableString value)
        {
            return value.Value;
        }
    }
}
