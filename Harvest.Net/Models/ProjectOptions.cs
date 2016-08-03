﻿using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest.Net.Models
{
    [SerializeAs(Name = "project")]
    public class ProjectOptions
    {
        public long? ClientId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public bool? Active { get; set; }

        public bool? Billable { get; set; }

        public BillingMethod? BillBy { get; set; }

        public decimal? HourlyRate { get; set; }

        public decimal? Budget { get; set; }

        public BudgetMethod? BudgetBy { get; set; }

        public bool? NotifyWhenOverBudget { get; set; }

        public decimal? OverBudgetNotificationPercentage { get; set; }

        public bool? ShowBudgetToAll { get; set; }

        public decimal? Estimate { get; set; }

        public EstimateMethod? EstimateBy { get; set; }

        public string Notes { get; set; }

        public decimal? CostBudget { get; set; }

        public bool? CostBudgetIncludeExpenses { get; set; }

        public DateTime? StartsOn { get; set; }
        
        public DateTime? EndsOn { get; set; }
    }
}
