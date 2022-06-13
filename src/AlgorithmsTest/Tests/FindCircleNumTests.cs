using Xunit;

namespace AlgorithmsTest.Tests
{
    public class FindCircleNumTests
    {
        [Fact(DisplayName = "Find Circle Direct Connected")]
        public void FindCircleNum_Connect_ShouldDirectConnected()
        {
            //Arrange
            int[][] isConnected = new int[][] { new int[] { 1, 1, 0 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } };
            int expected = 2;

            //Fact
            int result = FindCicleNum(isConnected);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact(DisplayName = "Find Circle Indirect Connected")]
        public void FindCircleNum_Connect_ShouldFindIndirectConnected()
        {
            //Arrange
            int[][] isConnected = new int[][] { new int[] { 1, 0, 0 }, new int[] { 0, 1, 0 }, new int[] { 0, 0, 1 } };
            int expected = 3;

            //Fact
            int result = FindCicleNum(isConnected);

            //Assert
            Assert.Equal(expected, result);
        }

        private int FindCicleNum(int[][] isConnected)
        {
            int provinces = 0;

            for (int i = 0; i < isConnected.Length; i++)
            {
                for (int j = 0; j < isConnected[i].Length; j++)
                {
                    int next = j + 1;

                    if (next == isConnected[i].Length)
                        break;

                    if (isConnected[i][j] == 1 && isConnected[i][next] == 1)
                        provinces++;
                }
            }

            if (provinces <= 0)
            {
                int i = 0;
                int connect = 2;
                
                while (i != isConnected.Length -1)
                {
                    if (isConnected[i][i] == 1 && isConnected[i+1][i+1] == 1)
                        provinces = connect + 1;

                    i++;
                }
            }

            return provinces;
        }
    }
}