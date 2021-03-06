﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name ="Full Name:")]
        [Required(ErrorMessage ="To enter, you must provide your Full Name!")]
        public string FullName { get; set; }

        /// <summary>
        /// The priamry email address of the contestant.
        /// For example JaneDoe@email.com
        /// </summary>
        [Display(Name ="E-mail:")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "To enter, you must provide your E-mail address!")]
        public string Email { get; set; }

        /// <summary>
        /// The primary 10-digit contact phone number of the contestant
        /// </summary>
        [Display(Name ="Primary Phone:")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="To contact you if you won, we need your phone number!")]
        public string Phone { get; set; }
    }
}