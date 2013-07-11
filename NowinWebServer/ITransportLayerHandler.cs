using System;

namespace NowinWebServer
{
    public interface ITransportLayerHandler : ILayerHandler
    {
        ITransportLayerCallback Callback { set; }
        void PrepareAccept();
        void FinishAccept(int offset, int length);
        void FinishReceive(int offset, int length);
        void FinishSend(Exception exception);
        void StartAbort();
    }
}