using System;
using System.Collections.Generic;
using System.Text;

namespace SandileSecurity.Domain.Output
{
    public interface ISuccessOrErrorPresenter<in TSuccess, in TError> : IErrorPresenter<TError>
    {
        public void Success(TSuccess successResult);
    }
}
