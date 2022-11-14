using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// RenewableEnergyComponentType
    /// </summary>
    public enum RenewableEnergyComponentType
    {
        /// <summary>
        /// Geothermal
        /// </summary>
        Geothermal = 0,
        /// <summary>
        /// Solar
        /// </summary>
        Solar = 1,
        /// <summary>
        /// Wind Turbine
        /// </summary>
        [Description("Wind Turbine")]
        WindTurbine = 2,
        /// <summary>
        /// Other Energy Component
        /// </summary>
        [Description("Other Energy Component")]
        OtherEnergyComponent = 3
    }
}