using System.ComponentModel;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// HouseholdIncomeConsumption is a submodel of model. 
/// </summary>
[DisplayName("Household income or consumption by percentage share")]
public class HouseholdIncomeConsumption
{
    
}

/// <summary>
/// Highest is  submodel of HouseholdIncomeConsumption model.
/// </summary>
public class Highest: TextEntity{}

/// <summary>
/// Lowest is  submodel of HouseholdIncomeConsumption model.
/// </summary>
public class Lowest: TextEntity{}