﻿using HA4IoT.Contracts.Messaging;
using HA4IoT.Contracts.Services;
using Newtonsoft.Json.Linq;

namespace HA4IoT.Extensions.I2C
{
    public interface II2CService : IService
    {
        void MessageHandler(Message<JObject> message);
    }
}