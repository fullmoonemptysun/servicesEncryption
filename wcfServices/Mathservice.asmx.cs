using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Assignment5
{
    // This is a basic ASMX web service for Assignment 6.
    // It exposes two math-related functions that can be called remotely.
    [WebService(Namespace = "http://tempuri.org/")]
    public class Mathservice : WebService
    {
        // This method calculates the average of two double values.
        // It's exposed as a web method so it can be called by the frontend.
        [WebMethod]
        public double Average(double a, double b)
        {
            return (a + b) / 2;
        }

        // This method returns the square root of a given double value.
        // Also exposed via the web service.
        [WebMethod]
        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }


        [WebMethod]
        public string EncryptWebService(string input, string seed)
        {
            return FrankEncrypt.Encryptor.Encrypt(input, seed);
        }

        [WebMethod]
        public string DecryptWebService(string input, string seed)
        {
            return FrankEncrypt.Encryptor.Decrypt(input, seed);
        }
    }
}
