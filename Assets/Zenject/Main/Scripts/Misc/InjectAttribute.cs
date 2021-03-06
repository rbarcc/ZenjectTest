using System;

namespace Zenject
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class InjectAttribute : Attribute
    {
        public InjectAttribute(object identifier)
        {
            Identifier = identifier;
        }

        public InjectAttribute()
        {
        }

        public object Identifier
        {
            get;
            private set;
        }
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class InjectOptionalAttribute : Attribute
    {
        public InjectOptionalAttribute(object identifier)
        {
            Identifier = identifier;
        }

        public InjectOptionalAttribute()
        {
        }

        public object Identifier
        {
            get;
            private set;
        }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class PostInjectAttribute : Attribute
    {
    }
}

