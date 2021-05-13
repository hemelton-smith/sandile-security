using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace SandileSecurity.Domain.Output
{
    public interface ISuccessOrErrorActionResultPresenter<in TSuccess, in TError> : ISuccessOrErrorPresenter<TSuccess, TError>
    {
        public IActionResult Render();
    }
}
