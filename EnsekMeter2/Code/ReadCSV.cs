using EnsekMeter2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnsekMeter2.Code
{
    public static class ReadCSV
    {
        public static List<CSVMeterReading> Readfile(string SourceFile)
        {
            // Reading a CSV file from the api is defeating me at the moment - this is a stopgap measure 
            List<CSVMeterReading> workingData = new();

            CSVMeterReading c1 = new CSVMeterReading { AccountId = "2344", MeterReadingDateTime = "22/04/2019  09:24:00", MeterReadingValue = "1002" }; workingData.Add(c1);
            CSVMeterReading c2 = new CSVMeterReading { AccountId = "2233", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "323" }; workingData.Add(c2);
            CSVMeterReading c3 = new CSVMeterReading { AccountId = "8766", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "3440" }; workingData.Add(c3);
            CSVMeterReading c4 = new CSVMeterReading { AccountId = "2344", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "1002" }; workingData.Add(c4);
            CSVMeterReading c5 = new CSVMeterReading { AccountId = "2345", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "45522" }; workingData.Add(c5);
            CSVMeterReading c6 = new CSVMeterReading { AccountId = "2346", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "999999" }; workingData.Add(c6);
            CSVMeterReading c7 = new CSVMeterReading { AccountId = "2347", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "54" }; workingData.Add(c7);
            CSVMeterReading c8 = new CSVMeterReading { AccountId = "2348", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "123" }; workingData.Add(c8);
            CSVMeterReading c9 = new CSVMeterReading { AccountId = "2349", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "VOID" }; workingData.Add(c9);
            CSVMeterReading c10 = new CSVMeterReading { AccountId = "2350", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "5684" }; workingData.Add(c10);
            CSVMeterReading c11 = new CSVMeterReading { AccountId = "2351", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "57579" }; workingData.Add(c11);
            CSVMeterReading c12 = new CSVMeterReading { AccountId = "2352", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "455" }; workingData.Add(c12);
            CSVMeterReading c13 = new CSVMeterReading { AccountId = "2353", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "1212" }; workingData.Add(c13);
            CSVMeterReading c14 = new CSVMeterReading { AccountId = "2354", MeterReadingDateTime = "22/04/2019  12:25:00", MeterReadingValue = "889" }; workingData.Add(c14);
            CSVMeterReading c15 = new CSVMeterReading { AccountId = "2355", MeterReadingDateTime = "06/05/2019  09:24:00", MeterReadingValue = "1" }; workingData.Add(c15);
            CSVMeterReading c16 = new CSVMeterReading { AccountId = "2356", MeterReadingDateTime = "07/05/2019  09:24:00", MeterReadingValue = "0" }; workingData.Add(c16);
            CSVMeterReading c17 = new CSVMeterReading { AccountId = "2344", MeterReadingDateTime = "08/05/2019  09:24:00", MeterReadingValue = "0X765" }; workingData.Add(c17);
            CSVMeterReading c18 = new CSVMeterReading { AccountId = "6776", MeterReadingDateTime = "09/05/2019  09:24:00", MeterReadingValue = "-6575" }; workingData.Add(c18);
            CSVMeterReading c19 = new CSVMeterReading { AccountId = "6776", MeterReadingDateTime = "10/05/2019  09:24:00", MeterReadingValue = "23566" }; workingData.Add(c19);
            CSVMeterReading c20 = new CSVMeterReading { AccountId = "4534", MeterReadingDateTime = "11/05/2019  09:24:00", MeterReadingValue = "" }; workingData.Add(c20);
            CSVMeterReading c21 = new CSVMeterReading { AccountId = "1234", MeterReadingDateTime = "12/05/2019  09:24:00", MeterReadingValue = "9787" }; workingData.Add(c21);
            CSVMeterReading c22 = new CSVMeterReading { AccountId = "1235", MeterReadingDateTime = "13/05/2019  09:24:00", MeterReadingValue = "" }; workingData.Add(c22);
            CSVMeterReading c23 = new CSVMeterReading { AccountId = "1236", MeterReadingDateTime = "10/04/2019  19:34:00", MeterReadingValue = "8898" }; workingData.Add(c23);
            CSVMeterReading c24 = new CSVMeterReading { AccountId = "1237", MeterReadingDateTime = "15/05/2019  09:24:00", MeterReadingValue = "3455" }; workingData.Add(c24);
            CSVMeterReading c25 = new CSVMeterReading { AccountId = "1238", MeterReadingDateTime = "16/05/2019  09:24:00", MeterReadingValue = "0" }; workingData.Add(c25);
            CSVMeterReading c26 = new CSVMeterReading { AccountId = "1239", MeterReadingDateTime = "17/05/2019  09:24:00", MeterReadingValue = "45345" }; workingData.Add(c26);
            CSVMeterReading c27 = new CSVMeterReading { AccountId = "1240", MeterReadingDateTime = "18/05/2019  09:24:00", MeterReadingValue = "978" }; workingData.Add(c27);
            CSVMeterReading c28 = new CSVMeterReading { AccountId = "1241", MeterReadingDateTime = "11/04/2019  09:24:00", MeterReadingValue = "436" }; workingData.Add(c28);
            CSVMeterReading c29 = new CSVMeterReading { AccountId = "1242", MeterReadingDateTime = "20/05/2019  09:24:00", MeterReadingValue = "124" }; workingData.Add(c29);
            CSVMeterReading c30 = new CSVMeterReading { AccountId = "1243", MeterReadingDateTime = "21/05/2019  09:24:00", MeterReadingValue = "77" }; workingData.Add(c30);
            CSVMeterReading c31 = new CSVMeterReading { AccountId = "1244", MeterReadingDateTime = "25/05/2019  09:24:00", MeterReadingValue = "3478" }; workingData.Add(c31);
            CSVMeterReading c32 = new CSVMeterReading { AccountId = "1245", MeterReadingDateTime = "25/05/2019  14:26:00", MeterReadingValue = "676" }; workingData.Add(c32);
            CSVMeterReading c33 = new CSVMeterReading { AccountId = "1246", MeterReadingDateTime = "25/05/2019  09:24:00", MeterReadingValue = "3455" }; workingData.Add(c33);
            CSVMeterReading c34 = new CSVMeterReading { AccountId = "1247", MeterReadingDateTime = "25/05/2019  09:24:00", MeterReadingValue = "3" }; workingData.Add(c34);
            CSVMeterReading c35 = new CSVMeterReading { AccountId = "1248", MeterReadingDateTime = "26/05/2019  09:24:00", MeterReadingValue = "3467" }; workingData.Add(c35);

            return workingData;
        }
        public static List<MeterReading> ValidateData(List<CSVMeterReading> inputData)
        {
            List<MeterReading> outputData = new();

            foreach (CSVMeterReading meterData in inputData)
            {
                int acNo = 0;
                DateTime acDate;
                int acValue = 0;

                if (int.TryParse(meterData.AccountId, out acNo))
                {
                    if (DateTime.TryParse(meterData.MeterReadingDateTime, out acDate))
                    {
                        if (int.TryParse(meterData.MeterReadingValue, out acValue))
                        {
                     // max reading is NNNNN, ie 99999, I assume negative are ok as they could be an adjustment
                           if (acValue <= 99999)
                            {
                                MeterReading outData = new MeterReading { AccountId = acNo, MeterReadingDateTime = acDate, MeterReadingValue = acValue };
                                outputData.Add(outData);
                            }
                        }
                    }
                }
            }
            return outputData;
        }
    }
}
