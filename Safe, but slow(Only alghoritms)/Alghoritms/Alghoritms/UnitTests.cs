using Xunit;
using AlgorithmsLib;
using Xunit.Sdk;

namespace AlgorithmsUnitTests
{
    public static class UnitTests
    {
        static int[] oneToNineArray = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        static char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f',
                                                'g', 'h', 'i', 'j', 'k', 'l',
                                                'm', 'n', 'o', 'p', 'q', 'r',
                                                's', 't', 'u', 'v', 'w', 'x',
                                                'y', 'z', };

        public static class BinarSearchTests
        {
            public static class IntArrayTests
            {
                [Fact]
                public static void MinusTwo()
                {
                    Assert.Equal(-1, Algorithms.BinarSearch<int>(oneToNineArray, -2));
                }

                [Fact]
                public static void MinusOne()
                {
                    Assert.Equal(-1, Algorithms.BinarSearch<int>(oneToNineArray, -1));
                }

                [Fact]
                public static void Zero()
                {
                    Assert.Equal(-1, Algorithms.BinarSearch<int>(oneToNineArray, 10));
                }

                [Fact]
                public static void One()
                {
                    Assert.Equal(0, Algorithms.BinarSearch<int>(oneToNineArray, 1));
                }

                [Fact]
                public static void Two()
                {
                    Assert.Equal(1, Algorithms.BinarSearch<int>(oneToNineArray, 2));
                }

                [Fact]
                public static void Three()
                {
                    Assert.Equal(2, Algorithms.BinarSearch<int>(oneToNineArray, 3));
                }

                [Fact]
                public static void Four()
                {
                    Assert.Equal(3, Algorithms.BinarSearch<int>(oneToNineArray, 4));
                }

                [Fact]
                public static void Five()
                {
                    Assert.Equal(4, Algorithms.BinarSearch<int>(oneToNineArray, 5));
                }

                [Fact]
                public static void Six()
                {
                    Assert.Equal(5, Algorithms.BinarSearch<int>(oneToNineArray, 6));
                }

                [Fact]
                public static void Seven()
                {
                    Assert.Equal(6, Algorithms.BinarSearch<int>(oneToNineArray, 7));
                }

                [Fact]
                public static void Eight()
                {
                    Assert.Equal(7, Algorithms.BinarSearch<int>(oneToNineArray, 8));
                }

                [Fact]
                public static void Nine()
                {
                    Assert.Equal(8, Algorithms.BinarSearch<int>(oneToNineArray, 9));
                }

                [Fact]
                public static void Ten()
                {
                    Assert.Equal(-1, Algorithms.BinarSearch<int>(oneToNineArray, 10));
                }
            }

            public static class AlphabetTests
            {
                [Fact]
                public static void A()
                {
                    Assert.Equal(0, Algorithms.BinarSearch<char>(alphabet, alphabet[0]));
                }

                [Fact]
                public static void B()
                {
                    Assert.Equal(1, Algorithms.BinarSearch<char>(alphabet, alphabet[1]));
                }

                [Fact]
                public static void C()
                {
                    Assert.Equal(2, Algorithms.BinarSearch<char>(alphabet, alphabet[2]));
                }

                [Fact]
                public static void D()
                {
                    Assert.Equal(3, Algorithms.BinarSearch<char>(alphabet, alphabet[3]));
                }

                [Fact]
                public static void E()
                {
                    Assert.Equal(4, Algorithms.BinarSearch<char>(alphabet, alphabet[4]));
                }

                [Fact]
                public static void F()
                {
                    Assert.Equal(5, Algorithms.BinarSearch<char>(alphabet, alphabet[5]));
                }

                [Fact]
                public static void G()
                {
                    Assert.Equal(6, Algorithms.BinarSearch<char>(alphabet, alphabet[6]));
                }

                [Fact]
                public static void H()
                {
                    Assert.Equal(7, Algorithms.BinarSearch<char>(alphabet, alphabet[7]));
                }

                [Fact]
                public static void I()
                {
                    Assert.Equal(8, Algorithms.BinarSearch<char>(alphabet, alphabet[8]));
                }

                [Fact]
                public static void J()
                {
                    Assert.Equal(9, Algorithms.BinarSearch<char>(alphabet, alphabet[9]));
                }

                [Fact]
                public static void K()
                {
                    Assert.Equal(10, Algorithms.BinarSearch<char>(alphabet, alphabet[10]));
                }

                [Fact]
                public static void L()
                {
                    Assert.Equal(11, Algorithms.BinarSearch<char>(alphabet, alphabet[11]));
                }

                [Fact]
                public static void M()
                {
                    Assert.Equal(12, Algorithms.BinarSearch<char>(alphabet, alphabet[12]));
                }

                [Fact]
                public static void N()
                {
                    Assert.Equal(13, Algorithms.BinarSearch<char>(alphabet, alphabet[13]));
                }

                [Fact]
                public static void O()
                {
                    Assert.Equal(14, Algorithms.BinarSearch<char>(alphabet, alphabet[14]));
                }

                [Fact]
                public static void P()
                {
                    Assert.Equal(15, Algorithms.BinarSearch<char>(alphabet, alphabet[15]));
                }

                [Fact]
                public static void Q()
                {
                    Assert.Equal(16, Algorithms.BinarSearch<char>(alphabet, alphabet[16]));
                }

                [Fact]
                public static void R()
                {
                    Assert.Equal(17, Algorithms.BinarSearch<char>(alphabet, alphabet[17]));
                }

                [Fact]
                public static void S()
                {
                    Assert.Equal(18, Algorithms.BinarSearch<char>(alphabet, alphabet[18]));
                }

                [Fact]
                public static void T()
                {
                    Assert.Equal(19, Algorithms.BinarSearch<char>(alphabet, alphabet[19]));
                }

                [Fact]
                public static void U()
                {
                    Assert.Equal(20, Algorithms.BinarSearch<char>(alphabet, alphabet[20]));
                }

                [Fact]
                public static void V()
                {
                    Assert.Equal(21, Algorithms.BinarSearch<char>(alphabet, alphabet[21]));
                }

                [Fact]
                public static void W()
                {
                    Assert.Equal(22, Algorithms.BinarSearch<char>(alphabet, alphabet[22]));
                }

                [Fact]
                public static void X()
                {
                    Assert.Equal(23, Algorithms.BinarSearch<char>(alphabet, alphabet[23]));
                }

                [Fact]
                public static void Y()
                {
                    Assert.Equal(24, Algorithms.BinarSearch<char>(alphabet, alphabet[24]));
                }

                [Fact]
                public static void Z()
                {
                    Assert.Equal(25, Algorithms.BinarSearch<char>(alphabet, alphabet[25]));
                }

                [Fact]
                public static void EqualSymbol()
                {
                    Assert.Equal(-1, Algorithms.BinarSearch<char>(alphabet, '='));
                }
            }

            public static class BooleanTests
            {
                [Fact]
                public static void BooleanTest1()
                {
                    Assert.Equal(3, Algorithms.BinarSearch<bool>(new bool[4] { false, false, false, true }, true));
                }

                [Fact]
                public static void BooleanTest2()
                {
                    Assert.Equal(-1, Algorithms.BinarSearch<bool>(new bool[4] { false, false, false, false }, true));
                }

                [Fact]
                public static void BooleanTest3()
                {
                    Assert.Equal(0, Algorithms.BinarSearch<bool>(new bool[4] { false, false, true, true }, false));
                }
            }
        }

        public static class QuickSortTests
        {
            public static class IntTests
            {
                [Fact]
                public static void TenTests()
                {
                    //Arange
                    int[] array = new int[10];
                    Random random = new Random();

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(11);
                    }

                    int[] expected = new int[array.Length];
                    Array.Copy(array, expected, array.Length);
                    Array.Sort(expected);

                    //Act
                    Algorithms.QuickSort(array);

                    //Assert
                    Assert.Equal(expected, array);
                }

                [Fact]
                public static void ThousandTest()
                {
                    //Arange
                    int[] array = new int[1000];
                    Random random = new Random();

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(1001);
                    }

                    int[] expected = new int[array.Length];
                    Array.Copy(array, expected, array.Length);
                    Array.Sort(expected);

                    //Act
                    Algorithms.QuickSort(array);

                    //Assert
                    Assert.Equal(expected, array);
                }

                [Fact]
                public static void MillionTest()
                {
                    //Arange
                    int[] array = new int[1000000];
                    Random random = new Random();

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = random.Next(1000001);
                    }

                    int[] expected = new int[array.Length];
                    Array.Copy(array, expected, array.Length);
                    Array.Sort(expected);

                    //Act
                    Algorithms.QuickSort(array);

                    //Assert
                    Assert.Equal(expected, array);
                }
            }
        }
    }
}