using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fitbit.Api;
using Fitbit.Models;

namespace FitbitAuthorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Authenticator authorizer = new Authenticator("a57cf7b1e3f34405a9d80b9e520c50ec", "53d618141c5c4b6f929506ef41d9611f",
                "http://api.fitbit.com/oauth/request_token",
                "http://api.fitbit.com/oauth/access_token",
                "http://www.fitbit.com/oauth/authorize");

            string url = authorizer.GetAuthUrlToken();

            Console.WriteLine("Authorization URL: " + url);

            string tempAuthToken;
            string verifier;

            Console.Write("oauth_token: ");
            tempAuthToken = Console.ReadLine();

            Console.Write("oauth_verifier: ");
            verifier = Console.ReadLine();

            AuthCredential credential = authorizer.ProcessApprovedAuthCallback(tempAuthToken, verifier);

            Console.WriteLine("access_token: " + credential.AuthToken);
            Console.WriteLine("access_secret: " + credential.AuthTokenSecret);

            Console.ReadLine();
        }
    }
}
