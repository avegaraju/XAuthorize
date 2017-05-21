using System;

namespace XAuthorize.Entities.Tests.Builders
{
    internal class PolicySetBuilder
    {
        private string _description;
        private PolicySetDefaults _policySetDefaults;

        public PolicySet Build()
        {
            return new PolicySet(_description, _policySetDefaults);
        }
        public PolicySetBuilder WithADummyDescription()
        {
            _description = "dummy";
            return this;
        }

        public PolicySetBuilder WithDummyPolicySetDefaults(string uri)
        {
            _policySetDefaults = new PolicySetDefaults(new Uri(uri));

            return this;
        }
    }
}
