using System;


namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        private Function m_function;
        public string Name { get; }
        public string Type { get; }
        
        /********************
        * Function name:           SingleMission.
        * The inputs:              Function function, String functionName
        * The output:              null
        * The function operation:  SingleMission constructor.
        ********************/
        public SingleMission(Function function, String functionName)
        {
            Name       = functionName;
            Type       = "Single";
            m_function = function;
        }

        /********************
        * Function name:           Calculate.
        * The inputs:              Function function, String functionName
        * The output:              null
        * The function operation:  SingleMission constructor.
        ********************/
        public double Calculate(double value)
        {
            double nValue = m_function(value);
            if (OnCalculate != null)
            {
                OnCalculate(this, nValue);
            }
            return nValue;
        }
    }
}
