using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Business
{
    public class AnalsisService : IAnalsisService
    {
        public object GetAnalsisResult(AnalysisInputModel value)
        {
            var CardBasicInformationList = new List<CardBasicInformation>();
            List<string> cradBasicInfos = value.CradBasicInfo.Split(',').ToList();
            foreach(var cradBasicInfo in cradBasicInfos)
            {
                List<string> tempCradBasicInfos  = cradBasicInfo.Split('|').ToList();
                CardBasicInformationList.Add(new CardBasicInformation()
                {
                    ID = Int32.Parse(tempCradBasicInfos[0]),
                    Series = Int32.Parse(tempCradBasicInfos[1]),
                    Race = Int32.Parse(tempCradBasicInfos[2]),
                    Attributes = Int32.Parse(tempCradBasicInfos[3]),
                    Stars = Int32.Parse(tempCradBasicInfos[4]),
                    MaterialType = Int32.Parse(tempCradBasicInfos[9]),
                    CanLiberate = Int32.Parse(tempCradBasicInfos[10]) == 1,
                    CanEvolve = Int32.Parse(tempCradBasicInfos[11]) == 1,
                });
            }


            return null;
        }
    }
}