﻿namespace Extensibility
{
    internal interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
