using System.Collections.Generic;

namespace ChkRestorer
{
    internal class ByteArrayComparer : IEqualityComparer<byte[]>
    {
        public bool Equals(byte[] x, byte[] y)
        {
            if (x.Equals(y)) return true;
            if (x is null || y is null) return false;
            if (!x.Length.Equals(y.Length)) return false;

            for (int i = 0; i < x.Length; i++)
                if (x[i] != y[i]) return false;

            return true;
        }

        public int GetHashCode(byte[] obj)
        {
            if (obj is null) return 0;
            int hash = 17;
            foreach (var b in obj)
            {
                hash = hash * 31 + b;
            }
            return hash;
        }
    }
}
