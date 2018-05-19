using System.Collections.Generic;
using Xunit;

namespace BusinessLogic.Common
{
    public class StringHelperTest
    {
        [Fact]
        public void Is_SplitStringToList_Correct()
        {
            //Given
            var stringList1 = new List<string>() { "1", "2", "3", "4", "5" };
            var stringList2 = new List<string>() { "a", "b", "c", "d", "e" };

            //When
            var splitString1ToList1 = StringHelper.SplitStringToList("1,2,3,4,5", ',');
            var splitString2ToList2 = StringHelper.SplitStringToList("a|b|c|d|e", '|');

            //Then
            Assert.Equal(stringList1[0], splitString1ToList1[0]);
            Assert.Equal(stringList1[1], splitString1ToList1[1]);
            Assert.Equal(stringList1[2], splitString1ToList1[2]);
            Assert.Equal(stringList1[3], splitString1ToList1[3]);
            Assert.Equal(stringList1[4], splitString1ToList1[4]);

            Assert.Equal(stringList2[0], splitString2ToList2[0]);
            Assert.Equal(stringList2[1], splitString2ToList2[1]);
            Assert.Equal(stringList2[2], splitString2ToList2[2]);
            Assert.Equal(stringList2[3], splitString2ToList2[3]);
            Assert.Equal(stringList2[4], splitString2ToList2[4]);
        }
    }
}