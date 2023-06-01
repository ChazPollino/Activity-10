using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!

// Corrected By CHAZ POLLINO
namespace Activity_10
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                //The first value i not equal to the specific value the automatic value should be false
                if (val == elements[i])
                    return true;
                //else
                // return false;
                
                    
            }
            return false;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }
        // This is where a majority of the issues lie you need to create a new set in order to add new values and leave set A 
        // unchanged 
        
        public Set union(Set rhs)
        {

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                C.addElement(rhs.elements[i]);
                // You need to add this.addElement (rhs.elements[i]);
            }
            for (int i = 0; i < this.elements.Count; i++)
            {
                C.addElement(this.elements[i]);
                // Same thing here you need to add this.addElement (rhs.elements{i});
            }
            return C;
        }
    }
}


