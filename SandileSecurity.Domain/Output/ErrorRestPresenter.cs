using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace SandileSecurity.Domain.Output
{
    public class ErrorRestPresenter<T> : IErrorActionResultPresenter<T>
    {
        private T _error;

        public void Error(T error)
        {
            _error = error;
        }

        public IActionResult Render()
        {
            if (_error == null) return new OkResult();

            return new BadRequestObjectResult(_error);
        }
    }
}
