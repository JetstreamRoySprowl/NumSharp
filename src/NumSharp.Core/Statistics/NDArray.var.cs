﻿
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using NumSharp.Backends;
using NumSharp.Extensions;
using NumSharp.Utilities;

namespace NumSharp
{
    [SuppressMessage("ReSharper", "ParameterHidesMember")]
    public partial class NDArray
    {
        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="keepdims">
        ///     If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array.
        /// </param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public NDArray var(bool keepdims = false, int? ddof = null, NPTypeCode? dtype = null)
        {
            return np.var(this, keepdims, ddof, dtype);
        }

        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="axis">Axis or axes along which the standard deviation is computed. The default is to compute the standard deviation of the flattened array.</param>
        /// <param name="keepdims">
        ///     If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array.
        /// </param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public NDArray var(int axis, bool keepdims = false, int? ddof = null, NPTypeCode? dtype = null)
        {
            return np.var(this, axis, keepdims, ddof, dtype);
        }
    }
}