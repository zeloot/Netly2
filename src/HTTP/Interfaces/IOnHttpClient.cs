﻿using System;

namespace Netly
{
    internal interface IOnHttpClient : IOn<System.Net.Http.HttpClient>
    {
        /// <summary>
        /// Handle Http Successful Request
        /// </summary>
        /// <param name="request"></param>
        void Data(Action<Request> request);
    }
}