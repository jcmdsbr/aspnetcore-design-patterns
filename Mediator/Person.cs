using System.Collections.Generic;
using static System.Console;

namespace Mediator
{
    public class Person
    {
        private readonly List<string> chatLog = new List<string>();
        public string Name;
        public ChatRoom Room;

        public Person(string name)
        {
            Name = name;
        }

        public void Receive(string sender, string message)
        {
            var s = $"{sender}: '{message}'";
            WriteLine($"[{Name}'s chat session] {s}");
            chatLog.Add(s);
        }

        public void Say(string message)
        {
            Room.Broadcast(Name, message);
        }

        public void PrivateMessage(string who, string message)
        {
            Room.Message(Name, who, message);
        }
    }
}