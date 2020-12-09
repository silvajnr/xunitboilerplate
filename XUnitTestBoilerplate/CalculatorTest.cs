using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestBoilerplate
{
    public class CalculatorTest
    {
        private readonly Calculator _sut;

        public CalculatorTest()
        {
            _sut = new Calculator();
        }

        [Fact(Skip ="this test is a skip test")]
        public void Add_AddTwoNumbers_ShouldBeEqualTheirEqual()
        {
            _sut.Add(5);
            _sut.Add(8);
            Assert.Equal(13, _sut.Value);
        }
        
        [Theory]
        [InlineData(13,5,8)]
        [InlineData(0,-8,8)]
        [InlineData(0,0,0)]
        public void Add_AddTwoNumbers_ShouldBeEqualTheirEqualTheory(decimal expected, decimal first, decimal second)
        {
            _sut.Add(first);
            _sut.Add(second);
            Assert.Equal(expected, _sut.Value);
        }
        
        [Theory]
        [MemberData(nameof(TestMemberData))]
        public void Add_AddTwoNumbers_ShouldBeEqualTheirEqualTheoryMembers(decimal expected, params decimal[] values)
        {
            foreach (var value in values)
            {
                _sut.Add(value);
            }
            
            Assert.Equal(expected, _sut.Value);
        }
        
        [Theory]
        [ClassData(typeof(TestClassData))]
        public void Divide_AddTwoNumbers_ShouldBeEqualTheirEqualTheoryClass(decimal expected, params decimal[] values)
        {
            foreach (var value in values)
            {
                _sut.Divide(value);
            }
            
            Assert.Equal(expected, _sut.Value);
        }

        public static IEnumerable<object[]> TestMemberData()
        {
            yield return new object[] { 15, new decimal[] { 10, 5 } };
            yield return new object[] { 15, new decimal[] { 5, 5, 5 } };
            yield return new object[] { -10, new decimal[] { 20, -30 } };
        }
    }

    public class TestClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 30, new decimal[] { 60, 2 } };
            yield return new object[] { 0, new decimal[] { 0, 7 } };
            yield return new object[] { 1, new decimal[] { 20, 20 } };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
