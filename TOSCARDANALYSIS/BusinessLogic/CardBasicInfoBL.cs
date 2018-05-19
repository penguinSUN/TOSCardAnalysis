using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Common;
using Model;

namespace BusinessLogic
{
    public class CardBasicInfoBL
    {
        public string CardBasicData { get; set; }

        public List<CardBasicInformation> GetCardBasicInformations()
        {
            var cardBasicInformationLists = new List<CardBasicInformation>();
            var cradBasicInfos = ConvertCardBasicDataToStringList();

            foreach (var cradBasicInfo in cradBasicInfos)
            {
                cardBasicInformationLists.Add(ConvertStringToCardBasicInformation(cradBasicInfo));
            }

            return cardBasicInformationLists;
        }

        public List<string> ConvertCardBasicDataToStringList()
        {
            return StringHelper.SplitStringToList(this.CardBasicData, ',');
        }

        public CardBasicInformation ConvertStringToCardBasicInformation(string tempCradBasicInfo)
        {
            var cradBasicInfo = StringHelper.SplitStringToList(tempCradBasicInfo, '|');

            return new CardBasicInformation()
            {
                ID = Int32.Parse(cradBasicInfo[0]),
                Series = Int32.Parse(cradBasicInfo[1]),
                Race = Int32.Parse(cradBasicInfo[2]),
                Attributes = Int32.Parse(cradBasicInfo[3]),
                Stars = Int32.Parse(cradBasicInfo[4]),
                MaterialType = Int32.Parse(cradBasicInfo[9]),
                CanLiberate = Int32.Parse(cradBasicInfo[10]) == 1,
                CanEvolve = Int32.Parse(cradBasicInfo[11]) == 1,
            };
        }
    }
}