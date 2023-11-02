using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace TestingConsoleApp.File_Reading_utility
{
    public class utilityToReadAndRequest
    {

        public async Task runAsync()
        {
            string excelFilePath = "ReadFileUtility/data.xlsx"; 
           string apiEndpoint = "https://localhost:7055/OMSOrders/CreateInternalOrder"; 

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                // Load data from Excel file
                var readData = ReadIdNamePairsFromExcel(excelFilePath);

                // Make API calls for each ID and Name pair
                using (HttpClient client = new HttpClient())
                {
                    foreach (var pair in readData)
                    {
                        long id = pair.Key;
                        string orderid = pair.Value.Item1;
                        string mlsid = pair.Value.Item2;
                        string location = pair.Value.Item3;

                        var requestData = new
                        {
                            OrderId = orderid,
                            MlsId = mlsid
                        };

                        //for collection

                        //string jsonData = JsonConvert.SerializeObject($"{{\r\n          \"serviceProvider\": {{\r\n            \"spID\": \"981cefc1-decc-403e-8d0b-466e0967593c\"\r\n          }},\r\n          \"header\": {{\r\n            \"receivedCV\": \"2023-08-24T14:03:22\",\r\n            \"cvProductName\": null,\r\n            \"cvActionName\": null,\r\n            \"cvProductID\": \"\",\r\n            \"cvLSPStatus\": \"\",\r\n            \"testMode\": true,\r\n        " +
                        //    $"    \"spOrderID\": \"{requestData.OrderId}\",\r\n            \"spOrderDate\": \"2023-10-24\",\r\n            \"orderStatus\": \"go\",\r\n            \"spItemID\": \"00057151272101436391\",\r\n            \"spActionID\": \"Pickup\",\r\n            \"spLSPID\": \"00057151272101436391_Pickup\",\r\n            \"spProductID\": \"Indhentning(pakker)\",\r\n            \"lspStatus\": \"\",\r\n            \"planInstruction\": \"\",\r\n            \"actionDate\": \"2023-10-24\"\r\n          //  \"Update\":\"true\"\r\n          }},\r\n          \"shipFrom\": {{\r\n          " +
                        //    $"  \"mlsID\": \"{requestData.MlsId}\",\r\n            \"locationID\": \"7100412\",\r\n            \"spActionName\": \"Pickup\",\r\n            \"spActionID\": \"Pickup\",\r\n            \"handoverLocation\": \"West\",\r\n            \"handoverInstruction\": \"\",\r\n            \"addressObject\": {{\r\n              \"name\": \"Balghar pul\",\r\n              \"streetName\": \"Test saddar\",\r\n              \"houseNumber\":\"testing house number\",\r\n              \"zipcode\": \"TestSZip\",\r\n              \"city\": \"TestSCity\",\r\n              \"xCoordinate\": \"1\",\r\n              \"yCoordinate\": \"1\",\r\n              \"additionalInfo\": {{\r\n                \"pickupInstruction\": \"\",\r\n                \"accessCode\": \"\",\r\n                \"accessKey\": \"\"\r\n              }}\r\n            }}\r\n          }},\r\n          \"itemInfo\": {{\r\n            \"soItemName\": \"Collection baby\",\r\n            \"soItemID\": \"Collection\",\r\n            \"additionalInfo\": {{\r\n              \"quantity\": 1,\r\n              \"handlingUnit\": \"Collection box\",\r\n              \"lcc\": \"\",\r\n              \"objectNumber\": \"00057151272101436380\",\r\n              \"eLabel\": \"263053942\",\r\n              \"weight\": \"0\",\r\n              \"dimensions\": \"\",\r\n              \"soProductName\": \"Collection\"\r\n            }}\r\n          }}\r\n        }}");
                       
                        //for business parcel 

                        string jsonData = JsonConvert.SerializeObject($"{{\r\n    \"serviceProvider\": {{\r\n        \"spID\": \"981cefc1-decc-403e-8d0b-466e0967593c\"\r\n    }},\r\n    \"header\": {{\r\n        \"receivedCV\": \"2023-09-26T16:01:39\",\r\n        \"cvProductName\": null,\r\n        \"cvActionName\": null,\r\n        \"cvProductID\": \"\",\r\n        \"cvLSPStatus\": \"\",\r\n        \"testMode\": true,\r\n       " +
                            $" \"spOrderID\": \"{requestData.OrderId}\",\r\n        \"spOrderDate\": \"2023-09-26\",\r\n        \"orderStatus\": \"go\",\r\n      " +
                            $"  \"spItemID\": \"{requestData.OrderId}\",\r\n        \"spActionID\": \"Delivery\",\r\n        \"spLSPID\": \"00057151272167457257_Delivery\",\r\n        \"spProductID\": \"Business parcels\",\r\n        \"lspStatus\": \"\",\r\n        \"planInstruction\": \"\",\r\n        \"actionDate\": \"2023-09-26\"\r\n    }},\r\n    \"shipTo\": {{\r\n      " +
                            $"  \"mlsID\": \"{requestData.MlsId}\",\r\n        \"locationID\": \"12200040\",\r\n        \"jobID\": \"4040\",\r\n        \"spActionName\": \"Delivery\",\r\n        \"spActionID\": \"Delivery\",\r\n        \"handoverLocation\": \"West\",\r\n        \"handoverInstruction\": \"\",\r\n        \"addressObject\": {{\r\n            \"name\": \"Landbrugsstyrelsen\",\r\n            \"streetName\": \"Frejasvej 1\",\r\n            \"zipcode\": \"4100\",\r\n            \"city\": \"Ringsted\",\r\n            \"xCoordinate\": \"11.8026\",\r\n            \"yCoordinate\": \"55.4323\",\r\n            \"additionalInfo\": {{\r\n                \"deliveryInstruction\": \"\",\r\n                \"accessCode\": \"\",\r\n                \"accessKey\": \"\"\r\n            }}\r\n        }},\r\n        \"brickID\": null\r\n    }},\r\n    \"itemInfo\": {{\r\n        \"soItemName\": \"Parcel\",\r\n        \"soItemID\": \"Parcel\",\r\n        \"additionalInfo\": {{\r\n            \"quantity\": 1,\r\n            \"handlingUnit\": \"Box\",\r\n            \"lcc\": \"LCP0236862\",\r\n            \"objectNumber\": \"00057151272167457257\",\r\n            \"eLabel\": \"575735162\",\r\n            \"weight\": \"0\",\r\n            \"dimensions\": \"\",\r\n            \"soProductName\": \"Parcel\"\r\n        }}\r\n    }}\r\n}}");

                   var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");


                      //  var content = JsonContent.Create<ExternalInfoModel>(genericObject, new MediaTypeWithQualityHeaderValue("application/json"));
                        // Make a POST request to the API endpoint with JSON data in the body
                        HttpResponseMessage response = await client.PostAsync(apiEndpoint, content);

                        // Check if the response is successful
                        if (response.IsSuccessStatusCode)
                        {
                            // Read and display the response from the API
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            Console.WriteLine($"API Response for ID: {id}, Name: {mlsid} - {apiResponse} - {orderid}");
                        }
                        else
                        {
                            Console.WriteLine($"Error occurred for ID: {id}, Name: {mlsid}. Status Code: {response.StatusCode}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        //var worksheet = package.Workbook.Worksheets["Sheet1"];
        static Dictionary<long,(string, string, string)> ReadIdNamePairsFromExcel(string filePath)
        {
            Dictionary<long, (string, string, string)> readData = new Dictionary<long, (string, string, string)>();

            using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets["Sheet1"]; 

                int rowCount = worksheet.Dimension.Rows;

                for (int row = 1; row <= rowCount; row++)
                {
                    string orderid = worksheet.Cells[row, 1].Value?.ToString();
                    string mlsid = worksheet.Cells[row, 2].Value?.ToString();
                    string location = worksheet.Cells[row, 3].Value?.ToString();

                    if (!string.IsNullOrEmpty(orderid) && !string.IsNullOrEmpty(mlsid)) //&& !string.IsNullOrEmpty(location)
                    {
                        readData.Add(row, (orderid, mlsid, location));
                    }
                }
            }

            return readData;
        }

    }
}
