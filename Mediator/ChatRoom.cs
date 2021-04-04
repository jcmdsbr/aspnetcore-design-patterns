﻿using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    public class ChatRoom
    {
        private readonly List<Person> people = new();

        public void Broadcast(string source, string message)
        {
            foreach (var p in people.Where(p => p.Name != source))
                p.Receive(source, message);
        }

        public void Join(Person p)
        {
            var joinMsg = $"{p.Name} joins the chat";
            Broadcast("room", joinMsg);

            p.Room = this;
            people.Add(p);
        }

        public void Message(string source, string destination, string message)
        {
            people.FirstOrDefault(p => p.Name == destination)?.Receive(source, message);
        }
    }
}