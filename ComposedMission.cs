using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public string Name { get; }
        public string Type { get; }
        private List<Function> MissionsList = new List<Function>();

        /********************
        * Function name:           ComposedMission.
        * The inputs:              String name
        * The output:              null
        * The function operation:  ComposedMission constructor.
        ********************/
        public ComposedMission(String name)
        {
            Name = name;
            Type = "Composed";
        }

        /********************
        * Function name:           Compose a function into another function.
        * The inputs:              Function function
        * The output:              this
        * The function operation:  The function composes a function into another function.
        ********************/
        public ComposedMission Add(Function function)
        {
            MissionsList.Add(function);
            return this;
        }

        /********************
        * Function name:           Calculate.
        * The inputs:              double value
        * The output:              double value
        * The function operation:  Calculates composed function value .
        ********************/
        public double Calculate(double value)
        {
            //Calculates the value of composed function.
            foreach (Function function in MissionsList)
            {
                value = function(value);
            }
            if (OnCalculate != null)
            {
                OnCalculate(this, value);
            }
            return value;
        }
    }
}