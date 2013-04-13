using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileDashboardContracts.Entities
{
    public interface IProject
    {
         int ID { get; set; }
         string Name { get; set; }
    }
}
