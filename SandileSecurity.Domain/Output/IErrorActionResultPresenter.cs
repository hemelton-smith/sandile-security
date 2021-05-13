using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace SandileSecurity.Domain.Output
{
    public interface IErrorActionResultPresenter<in TError> : IErrorPresenter<TError>
    {
        public IActionResult Render();
    }
}
