using System;

namespace XAuthorize.Entities
{
    public class PolicySetDefaults
    {
        public Uri XPathVersion { get; }

        public PolicySetDefaults(Uri xPathVersion)
        {
            XPathVersion = xPathVersion;
        }
    }
}