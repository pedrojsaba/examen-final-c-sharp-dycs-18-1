using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi
{
    public class Undergraduate : IStudent
    {
        public List<string> View()
        {
            return new List<string>
            {
                "Hugo",
                "Paco",
                "Luis"
            };
        }
    }
}