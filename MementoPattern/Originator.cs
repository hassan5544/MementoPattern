using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Originator
    {
        private string _state;


        public Originator(string state)
        {
            _state = state;
        }
        public void ChangeState(string state)
        {
            Console.WriteLine("Changing State");
            _state = state;
            Console.WriteLine("State Changed");
        }

        public IMemento Save()
        {
            return new Memento(_state);
        }

        public void Restore(IMemento memento)
        {
            _state = memento.GetState();
            Console.WriteLine("Restore");
        }
    }
}
