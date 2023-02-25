using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statistics101
{
    public class statistics
    {



        //Adjuster R Squared
        //proportion of the variation in your Y explained by X for a linear regression model
        //how the well terms fit a curve or line 
        //n nr of points in your data sample seize sample  = 50
        //k nr of independent regressors predictors sample = 5
        //R*R sample = 0.5 
        //response 0.1648

        //how to use this Radjsqr(0.5, 50, 5)
        public double Radjsqr(double R, double n, double k)
        {

            return (1 - (((1 - R * R) * (n - 1)) / (n - k - 1)));

        }

        //test the function above
        //how to use this 
        //testRadjsqr(0.5 , 50, 5 , 0.164772727272727)
        //corect 0.164772727272727
        public bool testRadjsqr(double R, double n, double k, double response)
        {

            if (this.Radjsqr(0.5, 50, 5) == response || this.Radjsqr(0.5, 50, 5) - response<0.000000001) return true;
            else { return false; }
                 
        }


    }
}
