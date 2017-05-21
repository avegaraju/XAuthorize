using System;
using System.Data;

namespace XAuthorize.Entities
{
    public class PolicySet
    {
        public PolicySet(string description, PolicySetDefaults policySetDefaults)
        {
            Description = description;
            PolicySetDefaults = policySetDefaults;
        }

        public string Description { get; }
        public PolicySetDefaults PolicySetDefaults { get; }
        public object Item { get; private set; }

        public void AddItem(object item)
        {
            Item = item;
        }
    }
}