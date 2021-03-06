﻿namespace RefactoringToPatterns.Strategy.Step4.Strategy
{
    internal class TrainingCostCalculationStrategy : WishListItemCostCalculationStrategy
    {
        internal override decimal CalculateCost(WishListItem item)
        {
            var totalCost = item.BaseItemCost;

            if (item.SideCosts.IncludeAccommodationCost)
            {
                totalCost += item.SideCosts.AccommodationCost;
            }

            if (item.SideCosts.IncludeDailyAllowanceCost)
            {
                totalCost += item.SideCosts.DailyAllowanceCost;
            }

            if (item.SideCosts.IncludeTransportCost)
            {
                totalCost += item.SideCosts.TransportCost;
            }

            return totalCost;
        }
    }
}