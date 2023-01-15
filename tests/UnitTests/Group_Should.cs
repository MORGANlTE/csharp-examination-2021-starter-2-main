using Domain.Groups;
using Domain.Members;
using Xunit;
using Shouldly;
using System;

namespace UnitTests
{
    public class Group_Should
    {
        [Fact]
        public void Have_one_member_after_adding_member()
        {
            var g = new Group("Sharks");
            g.AddMember(new MemberFaker());
            g.Members.Count.ShouldBe(1);
        }

        [Fact]
        public void Cannot_add_duplicate_member()
        {
            var g = new Group("Sharks");
            Member member = new MemberFaker();
            g.AddMember(member);
            Should.Throw<ArgumentException>(() => g.AddMember(member));
        }

        [Fact]
        public void Cannot_add_invalid_member()
        {
            var g = new Group("Sharks");
            Should.Throw<ArgumentException>(() => g.AddMember(null));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void Cannot_be_created_with_invalid_name(string name)
        {
			Should.Throw<ArgumentException>(() => new Group(name));
		}
    }
}
