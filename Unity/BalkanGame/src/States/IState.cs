using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalkanGame.States
{
    public interface IState
    {
        public void Start();
        public void Destroy();
    }
}