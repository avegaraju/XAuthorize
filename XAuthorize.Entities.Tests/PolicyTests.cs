using System.Collections.Generic;

using FluentAssertions;

using XAuthorize.Entities.Tests.Builders;

using Xunit;

namespace XAuthorize.Entities.Tests
{
    public class PolicyTests
    {
        public PolicyTests()
        {
            _policySetBuilder = new PolicySetBuilder();
        }

        private const string DUMMY_URI = "http://test.com";
        private readonly PolicySetBuilder _policySetBuilder;

        [Theory]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        [InlineData(5, 5)]
        public void PolicyDocumentHasPolicySet(int policySetCount, int expectedPolicySetCount)
        {
            IEnumerable<PolicySet> policySets = CreateDummyPolicySets(policySetCount);

            var policyDocument = new PolicyDocument(policySets);

            policyDocument
                    .PolicySets
                    .Should()
                    .HaveCount(expectedPolicySetCount);
        }

        [Fact]
        public void PolicySetHasPolicySetDefaults()
        {
            var policySet = _policySetBuilder.WithADummyDescription()
                                             .WithDummyPolicySetDefaults("http://test.com")
                                             .Build();

            policySet
                    .PolicySetDefaults
                    .XPathVersion
                    .Should().Be(DUMMY_URI);
        }

        [Fact]
        public void PolicySetMayHaveAnotherPolicySet()
        {
            var policySet = _policySetBuilder
                    .WithADummyDescription()
                    .WithDummyPolicySetDefaults(DUMMY_URI)
                    .Build();

            var nestedPolicySet = _policySetBuilder
                    .WithADummyDescription()
                    .WithDummyPolicySetDefaults(DUMMY_URI)
                    .Build();

            policySet.AddItem(nestedPolicySet);

            policySet.Item.Should().BeOfType<PolicySet>();
        }

        private IEnumerable<PolicySet> CreateDummyPolicySets(int policySetCount)
        {
            IList<PolicySet> policySets = new List<PolicySet>();
            for (var policySetIndex = 0; policySetIndex < policySetCount; policySetIndex++)
            {
                var policySet = _policySetBuilder
                        .WithADummyDescription()
                        .WithDummyPolicySetDefaults(DUMMY_URI)
                        .Build();

                policySets.Add(policySet);
            }

            return policySets;
        }
    }
}