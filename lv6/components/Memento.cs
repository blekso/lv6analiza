using System;
using System.Collections.Generic;
using System.Text;

namespace lv6.components
{
    //3.zad
    //class Memento
    //{
    //    public string Title { get; private set; }
    //    public string Text { get; private set; }
    //    public DateTime TimeDue { get; private set; }
    //    public DateTime CreationTime { get; private set; }
    //    public Memento(string title, string text, DateTime timeDue, DateTime creationTime)
    //    {
    //        this.Title = title;
    //        this.Text = text;
    //        this.TimeDue = timeDue;
    //        this.CreationTime = creationTime;
    //    }
    //}


    //4.zad
    class Memento
    {
        public string ownerName { get; private set; }
        public string ownerAddress { get; private set; }
        public decimal balance { get; private set; }
        public DateTime CreationTime { get; private set; }
        public Memento(string ownerName, string ownerAddress, decimal balance, DateTime creationTime)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
            this.CreationTime = creationTime;
        }
    }
}
