using System;
using System.Collections.Generic;
using System.Text;

namespace Reconcile.Domain.Consts
{
    public static class RegexPatterns
    {
        public const string initialTag = @"<(?'tag'\w+).*>";
        public const string tagAndValue = @"<(?'tag'\w+).*>(?'text'.+)";
        public const string closeTag = @"</\k'tag'>";
    }
}
