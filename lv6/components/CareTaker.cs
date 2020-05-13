using System;
using System.Collections.Generic;
using System.Text;

namespace lv6.components
{
    //class CareTaker
    //{
    //    public List<Memento> states;

    //    public CareTaker()
    //    {
    //        states = new List<Memento>();
    //    }

    //    public void AddState(Memento memento)
    //    {
    //        states.Add(memento);
    //    }

    //    public void RemoveState(Memento memento)
    //    {
    //        states.Remove(memento);
    //    }

    //    public void ShowItems()
    //    {
    //        foreach (Memento memento in states)
    //        {
    //            Console.WriteLine(memento.Title + "," + memento.Text + "," + memento.TimeDue + "," + memento.CreationTime);
    //        }
    //    }
    //}

    class CareTaker
    {
        public List<Memento> states;

        public CareTaker()
        {
            states = new List<Memento>();
        }

        public void AddState(Memento memento)
        {
            states.Add(memento);
        }

        public void RemoveState(Memento memento)
        {
            states.Remove(memento);
        }

        public void ShowItems()
        {
            foreach (Memento memento in states)
            {
                Console.WriteLine(memento.ownerName + "," + memento.ownerAddress + "," + memento.balance + "," + memento.CreationTime);
            }
        }
    }
}
