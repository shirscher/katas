﻿using Xunit;

namespace number_of_islands
{
    public class Tests
    {
        [Fact]
        public void Should_FindOneIsland()
        {
            var grid = new char[][] {
                new char[] { '1', '1', '1', '1', '0' },
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
            };
            var result = new Solution().NumIslands(grid);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Should_FindZeroIslands()
        {
            var grid = new char[][] {
                new char[] { '0', '0', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
            };
            var result = new Solution().NumIslands(grid);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Should_FindManySingleCellIslands()
        {
            var grid = new char[][] {
                new char[] { '1', '0', '1', '0', '1' },
                new char[] { '0', '1', '0', '1', '0' },
                new char[] { '1', '0', '1', '0', '1' },
                new char[] { '0', '1', '0', '1', '0' }
            };
            var result = new Solution().NumIslands(grid);

            Assert.Equal(10, result);
        }

        [Fact]
        public void Should_FindManyLargeIslands()
        {
            var grid = new char[][] {
                new char[] { '1', '0', '1', '1', '1' },
                new char[] { '1', '1', '0', '1', '1' },
                new char[] { '1', '1', '0', '0', '1' },
                new char[] { '0', '1', '0', '0', '1' }
            };
            var result = new Solution().NumIslands(grid);

            Assert.Equal(2, result);
        }

        [Fact]
        public void Should_HandleLargeGrid()
        {
            var grid = new char[][]
            {
                new[] { '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '0', '1', '1' },
                new[] { '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '0' },
                new[] { '1', '0', '1', '1', '1', '0', '0', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '0', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '0', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '0', '1', '1', '1', '0', '1', '1', '1' },
                new[] { '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '0', '1', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '0', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '0', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '0', '1', '1', '1', '1', '1', '0', '1', '1', '1', '0', '1', '1', '1', '1', '0', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '0' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '0', '0' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' },
                new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' }

            };

            var result = new Solution().NumIslands(grid);

            Assert.Equal(1, result);
        }
    }
}