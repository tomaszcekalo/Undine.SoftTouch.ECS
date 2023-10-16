using SoftTouch.ECS;
using Undine.Core;

namespace Undine.SoftTouch.ECS
{
    public class SoftTouchContainer : EcsContainer
    {
        public App App { get; }

        public SoftTouchContainer()
        {
            App = new App();
        }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            var result = new SoftTouchSystem<A>(App.World, system);
            App.AddProcessor(result);
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            var result = new SoftTouchSystem<A,B>(App.World)
            {
                System = system
            };
            App.AddProcessor(result);
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            var result = new SoftTouchSystem<A, B, C>(App.World)
            {
                System = system
            };
            App.AddProcessor(result);
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            var result = new SoftTouchSystem<A, B, C, D>(App.World)
            {
                System = system
            };
            App.AddProcessor(result);
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            var ec=App.World.Commands.Spawn();
            return new SoftTouchEntity()
            {
                EntityCommands = ec
            };

        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new SoftTouchSystem<A>(App.World, system);
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new SoftTouchSystem<A, B>(App.World)
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new SoftTouchSystem<A, B, C>(App.World)
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new SoftTouchSystem<A, B, C, D>(App.World)
            {
                System = system
            };
        }

        public override void Run()
        {
            App.Update();
        }
    }
}