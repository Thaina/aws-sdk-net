/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the GetGeoLocation operation.
    /// To retrieve a single geo location, send a <code>GET</code> request to the <code>/<i>Route
    /// 53 API version</i>/geolocation</code> resource with one of these options: continentcode
    /// | countrycode | countrycode and subdivisioncode.
    /// </summary>
    public partial class GetGeoLocationRequest : AmazonRoute53Request
    {
        private string _continentCode;
        private string _countryCode;
        private string _subdivisionCode;

        /// <summary>
        /// Gets and sets the property ContinentCode. 
        /// <para>
        /// The code for a continent geo location. Note: only continent locations have a continent
        /// code.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>AF</code> | <code>AN</code> | <code>AS</code> | <code>EU</code>
        /// | <code>OC</code> | <code>NA</code> | <code>SA</code>
        /// </para>
        ///  
        /// <para>
        /// Constraint: Specifying <code>ContinentCode</code> with either <code>CountryCode</code>
        /// or <code>SubdivisionCode</code> returns an <a>InvalidInput</a> error.
        /// </para>
        /// </summary>
        public string ContinentCode
        {
            get { return this._continentCode; }
            set { this._continentCode = value; }
        }

        // Check to see if ContinentCode property is set
        internal bool IsSetContinentCode()
        {
            return this._continentCode != null;
        }

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The code for a country geo location. The default location uses '*' for the country
        /// code and will match all locations that are not matched by a geo location.
        /// </para>
        ///  
        /// <para>
        /// The default geo location uses a <code>*</code> for the country code. All other country
        /// codes follow the ISO 3166 two-character code.
        /// </para>
        /// </summary>
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property SubdivisionCode. 
        /// <para>
        /// The code for a country's subdivision (e.g., a province of Canada). A subdivision code
        /// is only valid with the appropriate country code.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Specifying <code>SubdivisionCode</code> without <code>CountryCode</code>
        /// returns an <a>InvalidInput</a> error.
        /// </para>
        /// </summary>
        public string SubdivisionCode
        {
            get { return this._subdivisionCode; }
            set { this._subdivisionCode = value; }
        }

        // Check to see if SubdivisionCode property is set
        internal bool IsSetSubdivisionCode()
        {
            return this._subdivisionCode != null;
        }

    }
}