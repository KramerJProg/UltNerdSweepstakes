using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltNerdSweepstakes.Models
{
    /// <summary>
    /// Represents any contestant who enters the sweepstake
    /// </summary>
    public class Contestant
    {
        /// <summary>
        /// The first and last name of the contestant
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The priamry email address of the contestant.
        /// For example JaneDoe@email.com
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The primary 10-digit contact phone number of the contestant
        /// </summary>
        public string Phone { get; set; }
    }
}