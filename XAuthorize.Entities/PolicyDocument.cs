using System.Collections;
using System.Collections.Generic;

namespace XAuthorize.Entities
{
    public class PolicyDocument
    {
        public IEnumerable<PolicySet> PolicySets { get; }

        public PolicyDocument(IEnumerable<PolicySet> policySets)
        {
            PolicySets = policySets;
        }
    }
}
