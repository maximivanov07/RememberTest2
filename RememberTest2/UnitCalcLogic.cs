using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace UtitCalc
{
    public class UnitCalcLogic
    {
        //sagen

        public float sagenInKilometer;
        public float sagenInMeter;
        public float sagenInSantimeter;
        public float sagenInMilimeter;
       
        public float sagenInArshin;
        public float sagenInPyad;
        public float sagenInVershok;
        public float sagenInVersta;

        public float sagenInInch;
        public float sagenInFoot;
        public float sagenInYard;
        public float sagenInMile;

        //meter
        public float meterInKilometer;
        public float meterInSantimeter;
        public float meterInMilimeter;

        public float meterInVersta;
        public float meterInArshin;
        public float meterInPyad;
        public float meterInVershok;

        public float meterInInch;
        public float meterInFoot;
        public float meterInYard;
        public float meterInMile;

        //inch
        public float inchInFoot;
        public float inchInYard;
        public float inchInMile;

        public UnitCalcLogic()
        {
        
        float userInput = float.Parse(Console.ReadLine());

        //sagen
        sagenInKilometer = 0.0021336F * userInput;
        sagenInMeter = 2.1366F * userInput;
        sagenInSantimeter = 213.36F * userInput;
        sagenInMilimeter = 2133.6F * userInput;

        sagenInArshin = userInput * 3;
        sagenInPyad = userInput * (userInput / 12);
        sagenInVershok = userInput * (userInput / 48);
        sagenInVersta = userInput * 0.002F;

        sagenInInch = 84 * userInput;
        sagenInFoot = 7 * userInput;
        sagenInYard = 2.33333F * userInput;
        sagenInMile = 0.00132576F * userInput;
        
        //meter
        meterInKilometer = userInput / 1000;
        meterInSantimeter = userInput * 100;
        meterInMilimeter = userInput * 1000;

        meterInVersta = userInput * 0.000937383F;
        meterInArshin = userInput * 0.468691F;
        meterInPyad = userInput * 4.37445F;
        meterInVershok = userInput * 22.49719F;

        meterInInch = userInput * 39.3701F;
        meterInFoot = userInput * 3.28084F;
        meterInYard = userInput * 1.09361F;
        meterInMile = userInput * 0.000621371F;
        
        //inch
        inchInFoot = userInput * 12;
        inchInYard = userInput * 36;
        inchInMile = userInput * 63360;

        }
    }
}

