using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents what prize is for the given place
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier of the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The numeric identifier of the place
        /// </summary>
        public int PlaceNuber { get; set; }

        /// <summary>
        /// Friendly name for the place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earns or zero if it is not used
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The number that represents the percentage of the overall take or zero if it is not used
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
