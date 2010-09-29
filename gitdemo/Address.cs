using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gitdemo
{
    public class Address
    {
        #region -- Constructors --

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
        }

        #endregion

        #region -- Properties --

        /// <summary>
        /// Gets or sets the street address.
        /// </summary>
        /// <value>The street address.</value>
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State{get;set;}

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>The zip code.</value>
        public int ZipCode { get; set; }

        #endregion

        #region -- Methods --

        public override string ToString()
        {
            return string.Concat(StreetAddress, ", ", City, ", ", State, "  ", ZipCode.ToString());
        }

        #endregion
    }
}
