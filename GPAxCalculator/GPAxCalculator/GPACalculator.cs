using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAxCalculator
{
    internal class GPACalculator
    {
        double sum = 0;
        int n = 0;
        double max = 0;
        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa)
        {
            this.sum += gpa;
            this.n++;

            if (this.max < gpa)
                this.max = gpa;
        }
        /// <summary>
        /// Return GPAx of class
        /// </summary>
        /// <returns>GPAx</returns>
        double getGPAx(){
            double result = this.sum / this.n;
            return result;
        }
    }
}
