﻿namespace SandileSecurity.Domain.Output
{
    public interface IErrorPresenter<in T>
    {
        public void Error(T error);
    }
}
