﻿/*
 * @version   : 2.4.0
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2013-12-17
 * @copyright : Copyright (c) 2008-2014, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : See license.txt and http://www.ext.net/license/. 
 * @website   : http://www.ext.net/
 */

using System;

namespace Ext.Net.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Verify
    {
        /// <summary>
        /// Checks if parameter is not null. Throws ArgumentNullException with name of parameter if null
        /// </summary>
        /// <param name="parameter">The parameter value to check.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        public static void IsNotNull(object parameter, string parameterName)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException(parameterName, parameterName);
            }
        }

        /// <summary>
        /// Checks if the value is a type of String object. Throws ArgumentException if value is not a String type object.  
        /// </summary>
        /// <param name="value">The object to check.</param>
        /// <param name="paramterName">The name of the parameter.</param>
        public static void IsString(object value, string paramterName)
        {
            if (!(value is string))
            {
                throw new ArgumentException(paramterName, paramterName);
            }
        }
    }
}
