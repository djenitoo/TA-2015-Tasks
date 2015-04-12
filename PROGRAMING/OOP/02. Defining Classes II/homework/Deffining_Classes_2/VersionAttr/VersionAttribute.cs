namespace Deffining_Classes_2
{
    using System;
    [AttributeUsage(AttributeTargets.Struct |
      AttributeTargets.Class | AttributeTargets.Interface |
      AttributeTargets.Enum | AttributeTargets.Method)]

    public class VersionAttribute : Attribute
    {
        public string Version {get; private set;}

        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public override string ToString()
        {
            return string.Format("Version: " + this.Version);
        }
    }
}
