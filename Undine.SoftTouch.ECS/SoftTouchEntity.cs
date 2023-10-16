using SoftTouch.ECS;
using SoftTouch.ECS.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;

namespace Undine.SoftTouch.ECS
{
    public struct SoftTouchEntity : IUnifiedEntity
    {
        public EntityCommands EntityCommands;

        public void AddComponent<A>(in A component) where A : struct
        {
            //((Entity)EntityCommands).Set(new SoftTouchComponent<A>()
            //{
            //    Value = component
            //});

            EntityCommands.With(new SoftTouchComponent<A>()
            {
                Value = component
            });
        }

        public ref A GetComponent<A>() where A : struct
        {
            throw new NotImplementedException();
        }
    }
}
