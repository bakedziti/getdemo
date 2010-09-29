using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gitdemo
{
    public class Person
    {
        #region -- Constructors --

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
        }

        #endregion

        #region -- Properties --

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        #endregion

        #region -- Methods --

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Concat(FirstName, " ", LastName);
        }

        #endregion
    }
}
