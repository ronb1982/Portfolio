using System;
using System.Net;
using System.Security.AccessControl;
using System.Web;
using System.Web.Caching;

namespace MVCPortfolio.Models.HigherOrLower
{
    public class Card
    {
        public int CardId { get; set; }
        public int CardValue { get; set; }
        public string FileName { get; set; }
               
    }
}