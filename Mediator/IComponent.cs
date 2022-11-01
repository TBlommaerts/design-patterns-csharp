using System;

namespace Mediator
{
    public interface IComponent
    {
        void SetMediator(IMediator mediator);
        String GetName();
    }
}
