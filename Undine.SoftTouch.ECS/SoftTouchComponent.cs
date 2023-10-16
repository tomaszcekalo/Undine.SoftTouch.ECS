using SoftTouch.ECS;
using SoftTouch.ECS.Querying;

namespace Undine.SoftTouch.ECS
{
    public struct SoftTouchComponent<T> : IWorldQuery, IEquatable<SoftTouchComponent<T>>
        where T : struct
    {
        public World World { get; set; }
        public T Value;

        public bool Equals(T other)
        {
            return this.Value.GetHashCode() == other.GetHashCode();
        }

        public bool Equals(SoftTouchComponent<T> other)
        {
            return this.GetHashCode() == other.GetHashCode();
        }
    }
}