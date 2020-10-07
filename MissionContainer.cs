using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double Function(double value);

    public class FunctionsContainer
    {
        //Functions dictionary.
        private Dictionary<string, Function> m_dictionary;

        /********************
        * Function name:           FunctionsContainer.
        * The inputs:              null
        * The output:              null
        * The function operation:  FunctionsContainer constructor.
        ********************/
        public FunctionsContainer()
        {
            this.m_dictionary = new Dictionary<string, Function>();
        }

        /********************
        * Function name:           Function.
        * The inputs:              string f
        * The output:              Function
        * The function operation:  Returns a function by name.
        ********************/
        public Function this[string f]
        {
            get
            {
                //If the function exists in the dictionary, we will return it.
                if (m_dictionary.ContainsKey(f))
                {
                    return m_dictionary[f];
                }
                else
                {
                    //If the function does not exist, we will create a default function: f[x]=x and return it.
                    m_dictionary[f] = value => value;
                    return m_dictionary[f];
                }
            }
            set { m_dictionary[f] = value; }
        }

        /********************
        * Function name:           getAllMissions.
        * The inputs:              null
        * The output:              List<string> functionsList
        * The function operation:  Returns a list of all the functions (by name) in the container.
        ********************/
        public List<string> getAllMissions()
        {
            List<string> functionsList = new List<string>();
            //Iterate over all the functions names in the container and add it into a list.
            foreach (String function in m_dictionary.Keys)
            {
                functionsList.Add(function);
            }
            return functionsList;
        }
    }
}