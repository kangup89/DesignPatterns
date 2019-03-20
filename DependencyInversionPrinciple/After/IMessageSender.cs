﻿namespace DependencyInversionPrinciple.After
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}