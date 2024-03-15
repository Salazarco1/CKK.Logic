using CKK.Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        private int id {  get; set; } 
        private string name {  get; set; }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if(value >= 0)
                {
                    id = value;
                }
                else if (value < 0)
                {
                    throw new InvalidIdException();
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
        }
    }
}
