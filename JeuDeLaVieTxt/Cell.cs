﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLaVieTxt
{

    public class Cell
    {
        private bool _isAlive;
        public bool isAlive { get { return _isAlive; } set { _isAlive = value; } }
        private bool _nextState;
        public bool nextState { get { return _nextState; } set { _nextState = value; } }

        public Cell(bool state)
        {
            isAlive = state;
        }

        public void ComeAlive()
        {
            nextState = true;
        }

        public void PassAway()
        {
            nextState = false;
        }

        public void Update()
        {
            isAlive = nextState;
        }
    }
}
