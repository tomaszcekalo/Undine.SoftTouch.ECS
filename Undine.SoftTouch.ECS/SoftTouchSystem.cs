using SoftTouch.ECS;
using SoftTouch.ECS.Processors;
using SoftTouch.ECS.Querying;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Undine.Core;

namespace Undine.SoftTouch.ECS
{
    public class SoftTouchSystem<A> : Processor<Query<Read<SoftTouchComponent<A>>>>, ISystem
        where A:struct
    {
        public SoftTouchSystem(World world, UnifiedSystem<A> system) : base(world)
        {
            System = system;
        }

        public UnifiedSystem<A> System { get; set; }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            foreach (var entity in Query)
            {
                var  a = entity.Get<SoftTouchComponent<A>>();
                System.ProcessSingleEntity(0, ref a.Value);
            }
        }
    }
    public class SoftTouchSystem<A, B> : Processor<Query<Read<SoftTouchComponent<A>, SoftTouchComponent<B>>>>, ISystem
        where A : struct
        where B : struct
    {

        public UnifiedSystem<A, B> System { get; internal set; }
        public SoftTouchSystem(World world) : base(world)
        {
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            foreach (var entity in Query)
            {
                var a = entity.Get<SoftTouchComponent<A>>();
                var b = entity.Get<SoftTouchComponent<B>>();
                System.ProcessSingleEntity(0, ref a.Value, ref b.Value);
            }
        }
    }
    public class SoftTouchSystem<A, B, C> : Processor<Query<Read<SoftTouchComponent<A>, SoftTouchComponent<B>, SoftTouchComponent<C>>>>, ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public UnifiedSystem<A, B, C> System { get; internal set; }
        public SoftTouchSystem(World world) : base(world)
        {
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            foreach (var entity in Query)
            {
                var a = entity.Get<SoftTouchComponent<A>>();
                var b = entity.Get<SoftTouchComponent<B>>();
                var c = entity.Get<SoftTouchComponent<C>>();
                System.ProcessSingleEntity(0, ref a.Value, ref b.Value, ref c.Value);
            }
        }
    }
    public class SoftTouchSystem<A, B, C, D> : Processor<Query<Read<SoftTouchComponent<A>, SoftTouchComponent<B>, SoftTouchComponent<C>, SoftTouchComponent<D>>>>, ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public UnifiedSystem<A, B, C, D> System { get; internal set; }
        public SoftTouchSystem(World world) : base(world)
        {
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            foreach (var entity in Query)
            {
                var a = entity.Get<SoftTouchComponent<A>>();
                var b = entity.Get<SoftTouchComponent<B>>();
                var c = entity.Get<SoftTouchComponent<C>>();
                var d = entity.Get<SoftTouchComponent<D>>();
                System.ProcessSingleEntity(0, ref a.Value, ref b.Value, ref c.Value, ref d.Value);
            }
        }
    }

    public record Read<A, B>() : IReadComponent
    where A : struct
    where B : struct
    {
        public static ImmutableSortedSet<Type> TypesRead { get; } = ImmutableSortedSet.Create(Comparer<Type>.Create(static (a, b) => a.Name.CompareTo(b.Name)), typeof(A), typeof(B));
        public static ImmutableSortedSet<Type> TypesWrite { get; } = ImmutableSortedSet<Type>.Empty;

        public ImmutableSortedSet<Type> ImplRead => TypesRead;
        public ImmutableSortedSet<Type> ImplWrite => TypesWrite;
    }
    public record Read<A, B, C>() : IReadComponent
    where A : struct
    where B : struct
    where C : struct
    {
        public static ImmutableSortedSet<Type> TypesRead { get; } = ImmutableSortedSet.Create(Comparer<Type>.Create(static (a, b) => a.Name.CompareTo(b.Name)), typeof(A), typeof(B), typeof(C));
        public static ImmutableSortedSet<Type> TypesWrite { get; } = ImmutableSortedSet<Type>.Empty;

        public ImmutableSortedSet<Type> ImplRead => TypesRead;
        public ImmutableSortedSet<Type> ImplWrite => TypesWrite;
    }
    public record Read<A, B, C, D>() : IReadComponent
    where A : struct
    where B : struct
    where C : struct
    where D : struct
    {
        public static ImmutableSortedSet<Type> TypesRead { get; } = ImmutableSortedSet.Create(Comparer<Type>.Create(static (a, b) => a.Name.CompareTo(b.Name)), typeof(A), typeof(B), typeof(C), typeof(D));
        public static ImmutableSortedSet<Type> TypesWrite { get; } = ImmutableSortedSet<Type>.Empty;

        public ImmutableSortedSet<Type> ImplRead => TypesRead;
        public ImmutableSortedSet<Type> ImplWrite => TypesWrite;
    }
}
