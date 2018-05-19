using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace BusinessLogic
{
    public class AnalsisService : IAnalsisService
    {
        public object GetAnalsisResult(AnalysisInputModel value)
        {
            var CardBasicInformationList = new CardBasicInfoBL()
            {
                CardBasicData = value.CradBasicData
            }.GetCardBasicInformations();

            return null;
        }
    }
}