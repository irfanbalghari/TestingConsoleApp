using Azure.Identity;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    public class Program
    {

        static async Task Main(string[] args)
        {

            //  var r = RepeatedString.action("gfcaaaecbg", 547602);
            // Console.WriteLine("test: {0}", r);

            // modiler_fizzbuzz.fizzBuzz(15);
            // RomanNumerical.Parse("I");

            /* Delegate example 
			var video = new Video() { Title = "End 1" };
			var VideoEncoder = new VideoEncoder(); // publisher
			var mailService = new MailService(); // subscriber
			var messageService = new MessageService(); // subscriber
			VideoEncoder.VideoEncoded += mailService.onVideoEncoded;
			VideoEncoder.VideoEncoded += messageService.Message;
			VideoEncoder.Encode(video);
			*/

            // uses boxing DateTime timeValue = Convert.ToDateTime("01:00 PM");
            //	DateTime timeValue = DateTime.Parse("01:00 PM");
            //Console.WriteLine(timeValue.ToString("HH:mm"));

            List<int> a = new()
            {
                7,
                71,
                67,
            };
            List<int> b = new()
            {
              8,
                71,
                99,
            };
            //Console.WriteLine("result: " + GradeRounding.gradingStudents(value));
            //Console.WriteLine("result: " + SecoundHighest.getSecondHighest(a));

            //	var result = compareTriplets.CompareTriplets(a, b);
            //	result.ForEach(x => Console.WriteLine("result: " + x));

            //DependencyInversionPrinciple.getStarted();

            // breaking changes code
            /*
            List<int> n = new()
            {
                10, 5, 20, 20, 4, 5, 2, 25, 1
            };
            var result = breakingChangesInResult.breakingRecords(n);
            Console.WriteLine(result);
            */

            //DijkstraAlgorithm
            /* //    int[,] adjacencyMatrix = {
             //    { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
             //    { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
             //    { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
             //    { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
             //    { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
             //    { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
             //    { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
             //    { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
             //    { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
             //};
               //  DijkstraAlgorithm dijkstra = new(adjacencyMatrix);
               //  dijkstra.FindShortestPath(0);
            */


            /* ref out 
            //int x;
            //int y = 0;
            //RefOut(out x, ref y);

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //void RefOut(out int a, ref int b)
            //{
            //    a = 5;
            //    b = 6;
            //}
            */


            #region AD microsoft graph api demo
            var scopes = new[] { "https://graph.microsoft.com/.default" };

            var tenantId = "e1f05777-1870-424c-9b0e-1a2949e1da9f";
            // values from app registration 

            var clientId = "0c60b17b-3b91-4df4-a637-337f90bb127e";
            var clientSecret = "Ovb8Q~UVWiXceZeQg6whWUq47-GNJ0_WU2PembDV";
            // using azure Identity

            var options = new TokenCredentialOptions
            {
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
            };
            var clientSecretCredential = new ClientSecretCredential(
                tenantId, clientId, clientSecret, options);
            var graphClient = new GraphServiceClient(clientSecretCredential, scopes);
            var tiIndicatorsResponse = await graphClient.Security.GetAsync();
            Console.WriteLine(tiIndicatorsResponse);
            /* // it should work in this way but need to see the Request method in latest version of graphapi
                var users = await graphClient.Users.Request().GetAsync();
              foreach (var user in users)
              {
                  Console.WriteLine(user.DisplayName);
              } */

            #endregion
        }

    }
}



