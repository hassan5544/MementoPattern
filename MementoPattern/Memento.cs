﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Memento : IMemento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }
        public string GetState()
        {
            return _state;
        }
    }
}
