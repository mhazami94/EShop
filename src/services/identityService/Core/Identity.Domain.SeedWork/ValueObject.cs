using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Domain.SeedWork
{
    public abstract class RoleId<T> where T : RoleId<T>
    {
        public override bool Equals(object? obj)
        {
            var valueObjetc = obj as T;
            if (ReferenceEquals(valueObjetc, null))
                return false;
            return EqualsCore(valueObjetc);
        }

        public static bool operator ==(RoleId<T> a, RoleId<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(RoleId<T> a, RoleId<T> b) => !(a == b);

        public override int GetHashCode() => GetHashCodeCore();

        protected abstract bool EqualsCore(T other);
        protected abstract int GetHashCodeCore();
    }
}
