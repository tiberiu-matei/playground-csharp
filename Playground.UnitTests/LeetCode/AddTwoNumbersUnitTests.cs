using FluentAssertions;
using Playground.LeetCode;
using Xunit;

namespace Playground.UnitTests.LeetCode
{
    public class AddTwoNumbersUnitTests
    {
        [Fact]
        public void AddTwoNumbers_WithEqualDigitsForBothLists_ReturnsExpectedList()
        {
            var firstList = new ListNode
            {
                val = 2,
                next = new ListNode
                {
                    val = 4,
                    next = new ListNode
                    {
                        val = 3,
                        next = null
                    },
                },
            };
            var secondList = new ListNode
            {
                val = 5,
                next = new ListNode
                {
                    val = 6,
                    next = new ListNode
                    {
                        val = 4,
                        next = null
                    },
                },
            };
            var classUnderTest = new AddTwoNumbers();

            var result = classUnderTest.AddTwoNumbersTwo(firstList, secondList);

            result.val.Should().Be(7);
            result.next.val.Should().Be(0);
            result.next.next.val.Should().Be(8);
            result.next.next.next.Should().BeNull();
        }

        [Fact]
        public void AddTwoNumbers_WithOneDigitFirstList_ReturnsExpectedList()
        {
            var firstList = new ListNode { val = 8 };
            var secondList = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 2
                    },
                },
            };
            var classUnderTest = new AddTwoNumbers();

            var result = classUnderTest.AddTwoNumbersTwo(firstList, secondList);

            result.val.Should().Be(9);
            result.next.val.Should().Be(2);
            result.next.next.val.Should().Be(2);
            result.next.next.next.Should().BeNull();
        }

        [Fact]
        public void AddTwoNumbers_WithOneDigitSecondList_ReturnsExpectedList()
        {
            var firstList = new ListNode
            {
                val = 3,
                next = new ListNode
                {
                    val = 8,
                    next = new ListNode
                    {
                        val = 5,
                        next = null
                    },
                },
            };
            var secondList = new ListNode { val = 1 };
            var classUnderTest = new AddTwoNumbers();

            var result = classUnderTest.AddTwoNumbersTwo(firstList, secondList);

            result.val.Should().Be(4);
            result.next.val.Should().Be(8);
            result.next.next.val.Should().Be(5);
            result.next.next.next.Should().BeNull();
        }

        [Fact]
        public void AddTwoNumbers_WithSumOneDigitLongerThanLists_ReturnsExpectedList()
        {
            var firstList = new ListNode
            {
                val = 3,
                next = new ListNode
                {
                    val = 8,
                    next = new ListNode
                    {
                        val = 5,
                        next = null
                    },
                },
            };
            var secondList = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 7,
                        next = null
                    },
                },
            };
            var classUnderTest = new AddTwoNumbers();

            var result = classUnderTest.AddTwoNumbersTwo(firstList, secondList);

            result.val.Should().Be(4);
            result.next.val.Should().Be(0);
            result.next.next.val.Should().Be(3);
            result.next.next.next.val.Should().Be(1);
            result.next.next.next.next.Should().BeNull();
        }

        [Fact]
        public void AddTwoNumbers_WhenSumEndsInZero_ReturnsExpectedList()
        {
            var firstList = new ListNode
            {
                val = 5,
                next = new ListNode
                {
                    val = 6,
                    next = new ListNode
                    {
                        val = 5,
                        next = null
                    },
                },
            };
            var secondList = new ListNode
            {
                val = 5,
                next = new ListNode
                {
                    val = 1,
                    next = new ListNode
                    {
                        val = 7,
                        next = null
                    },
                },
            };
            var classUnderTest = new AddTwoNumbers();

            var result = classUnderTest.AddTwoNumbersTwo(firstList, secondList);

            result.val.Should().Be(0);
            result.next.val.Should().Be(8);
            result.next.next.val.Should().Be(2);
            result.next.next.next.val.Should().Be(1);
            result.next.next.next.next.Should().BeNull();
        }

        [Fact]
        public void AddTwoNumbers_WhenSumRoundsUp_ReturnsExpectedList()
        {
            var firstList = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 9,
                    next = new ListNode
                    {
                        val = 9,
                        next = new ListNode
                        {
                            val = 9,
                            next = new ListNode
                            {
                                val = 9,
                                next = new ListNode
                                {
                                    val = 9,
                                    next = new ListNode
                                    {
                                        val = 9,
                                        next = new ListNode
                                        {
                                            val = 9,
                                            next = new ListNode
                                            {
                                                val = 9,
                                                next = new ListNode
                                                {
                                                    val = 9,
                                                    next = null,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                },
            };
            var secondList = new ListNode
            {
                val = 9,
            };
            var classUnderTest = new AddTwoNumbers();

            var result = classUnderTest.AddTwoNumbersTwo(firstList, secondList);

            result.val.Should().Be(0);
            result.next.val.Should().Be(0);
            result.next.next.val.Should().Be(0);
            result.next.next.next.val.Should().Be(0);
            result.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.next.next.next.val.Should().Be(1);
            result.next.next.next.next.next.next.next.next.next.next.next.Should().BeNull();
        }

        [Fact]
        public void AddTwoNumbers_WhenSumHasLotsOfZeroes_ReturnsExpectedList()
        {
            var firstList = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 0,
                    next = new ListNode
                    {
                        val = 0,
                        next = new ListNode
                        {
                            val = 0,
                            next = new ListNode
                            {
                                val = 0,
                                next = new ListNode
                                {
                                    val = 0,
                                    next = new ListNode
                                    {
                                        val = 0,
                                        next = new ListNode
                                        {
                                            val = 0,
                                            next = new ListNode
                                            {
                                                val = 0,
                                                next = new ListNode
                                                {
                                                    val = 1,
                                                    next = null,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                },
            };
            var secondList = new ListNode
            {
                val = 5,
                next = new ListNode
                {
                    val = 6,
                    next = new ListNode
                    {
                        val = 4,
                        next = null,
                    }
                }
            };
            var classUnderTest = new AddTwoNumbers();

            var result = classUnderTest.AddTwoNumbersTwo(firstList, secondList);

            result.val.Should().Be(6);
            result.next.val.Should().Be(6);
            result.next.next.val.Should().Be(4);
            result.next.next.next.val.Should().Be(0);
            result.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.next.val.Should().Be(0);
            result.next.next.next.next.next.next.next.next.next.val.Should().Be(1);
            result.next.next.next.next.next.next.next.next.next.next.Should().BeNull();
        }
    }
}
