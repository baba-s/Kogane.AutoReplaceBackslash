using System.Collections.Generic;
using System.Linq;

namespace Kogane.Internal
{
    internal static class StringExtensionMethods
    {
        public static string Fix( this string self )
        {
            return self.Replace( "\\", "/" );
        }

        public static IEnumerable<string> Fix( this IEnumerable<string> self )
        {
            return self.Select( x => x.Fix() );
        }

        public static string[] Fix( this string[] self )
        {
            return self.Select( x => x.Fix() ).ToArray();
        }
    }
}