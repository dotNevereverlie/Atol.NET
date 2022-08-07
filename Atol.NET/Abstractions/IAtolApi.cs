﻿using Atol.NET.Models;
using Atol.NET.Models.Responses;

namespace Atol.NET.Abstractions;

public interface IAtolApi
{
    KktResponse<KktGeneralInfo> GetGeneralInfo();
    KktBaseResponse PowerOff();
    KktBaseResponse Reboot();
    KktBaseResponse Beep();
    KktBaseResponse Beep(int frequency, int duration);
    IAtolViewSerializer Serializer { get; }
    bool IsConnected { get; }
}