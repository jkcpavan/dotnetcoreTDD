using dotnetTDDApi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetTDDApi.DAO
{
    public interface ILastNameDAO
    {
         InfoName GetLastName(string first);
    }
}
