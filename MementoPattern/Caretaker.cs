using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();
        private Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("Saving Current State");
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
                throw new ArgumentException("Memento List is null");

            var memento = _mementos.Last();
            _mementos.Remove(memento);
            Console.Write("Restoring state to " + memento.GetState());

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
                throw;
            }
        }
    }
}
