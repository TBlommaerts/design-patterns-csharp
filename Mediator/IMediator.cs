using System;

namespace Mediator
{
    public interface IMediator
    {
        void OnCloseShutterEvent();
        void OnAlarmEvent();
        void RegisterComponent(IComponent component);
    }
}
