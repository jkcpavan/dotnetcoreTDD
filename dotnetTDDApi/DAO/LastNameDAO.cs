using System;
using System.Collections.Generic;
using System.Linq;
using dotnetTDDApi.models;

namespace dotnetTDDApi.DAO
{
    public class LastNameDAO
    {
        public InfoName getLastName(string first)
        {
            var result=new InfoName(first,"Not Found");
            return result;
        }
    }
}
