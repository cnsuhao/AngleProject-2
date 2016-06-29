using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleProject
{
    class Angle
    {
        public int _degree;
        public int _minute;
        public int _second;

        public Angle() { }
        public Angle(int degree, int minute, int second)
        {
            _degree = degree;
            _minute = minute;
            _second = second;
        }

        public static Angle NormilizeAngle(Angle myAngle)
        {
            int restSecond = 0;
            int restMinute = 0;
            int restDegree = 0;

            if (myAngle._second > 60)
            {
                restSecond = myAngle._second / 60;
                myAngle._second %= 60;
            }

            if (myAngle._minute > 60)
            {
                restMinute = myAngle._minute / 60;
                myAngle._minute %= 60;
                myAngle._minute += restSecond;
            }

            myAngle._degree += restMinute;

            if (myAngle._degree > 360)
            {
                restDegree = myAngle._degree % 360;
                myAngle._degree = restDegree;
            }

            return myAngle;

        }

        public static Angle NormilizeNegativeAngle(Angle myAngle)
        {
            int restSecond = 0;
            int restMinute = 0;
            int restDegree = 0;

            if (myAngle._second < -60)
            {
                restSecond = myAngle._second / 60;
                myAngle._second %= 60;
            }

            if (myAngle._minute < -60)
            {
                restMinute = myAngle._minute / 60;
                myAngle._minute %= 60;
                myAngle._minute += restSecond;
            }

            myAngle._degree += restMinute;

            if (myAngle._degree < -360)
            {
                restDegree = myAngle._degree % 360;
                myAngle._degree = restDegree;
            }

            return myAngle;

        }
        public static Angle NegativeToPositive(Angle myAngle)
        {
           if (myAngle._degree < 0 && myAngle._minute < 0 && myAngle._second < 0)
           {
                Angle.NormilizeNegativeAngle(myAngle);
                myAngle._degree = 360 + myAngle._degree;
                myAngle._minute = 60 + myAngle._minute;
                myAngle._second = 60 + myAngle._second;

            }

            return myAngle;
        }
        public static int ToSeconds(Angle myAngle)
        {
            return (myAngle._degree * 3600) + (myAngle._minute * 60) + myAngle._second;
        }
        public static Angle Compliment(Angle myAngle)
        {
            if (myAngle._degree > 0 && myAngle._minute > 0 && myAngle._second > 0)
            {
                Angle.NormilizeAngle(myAngle);
                myAngle._degree = myAngle._degree - 360;
                myAngle._minute = myAngle._minute - 60;
                myAngle._second = myAngle._second - 60;

            }

            Angle temp = new Angle();
            temp._second = Math.Abs(myAngle._second);
            temp._minute = Math.Abs(myAngle._minute);
            temp._degree = Math.Abs(myAngle._degree);



            return temp;
        }
        public static Angle operator+(Angle lhs, Angle rhs)
        {   
            if (lhs._degree < 0 && lhs._minute < 0 && lhs._second < 0)
            {
                Angle.NegativeToPositive(lhs);
            }

            if (rhs._degree < 0 && rhs._minute < 0 && rhs._second < 0)
            {
                Angle.NegativeToPositive(rhs);
            }

            int totalSecond = lhs._second + rhs._second;
            int totalMinute = lhs._minute + rhs._minute;
            int totalDegree = lhs._degree + rhs._degree;

            Angle result = new Angle(totalDegree, totalMinute, totalSecond);
            result = NormilizeAngle(result);

            return result;
        }

        public static Angle operator-(Angle lhs, Angle rhs)
        {

            Angle temp = new Angle();
            temp = Angle.Compliment(rhs);

            int totalSecond =  temp._second + lhs._second;
            int totalMinute = temp._minute + lhs._minute;
            int totalDegree =  temp._degree + lhs._degree;


            Angle result = new Angle(totalDegree, totalMinute, totalSecond);
            Angle r =  Angle.Compliment(result);
            return r;
        }

        public static bool operator==(Angle lhs, Angle rhs)
        {
            int lhsSeconds = Angle.ToSeconds(lhs);
            int rhsSeconds = Angle.ToSeconds(rhs);

            if (lhsSeconds == rhsSeconds)
                return true;
            else
                return false;
        }

        public static bool operator !=(Angle lhs, Angle rhs)
        {
            int lhsSeconds = Angle.ToSeconds(lhs);
            int rhsSeconds = Angle.ToSeconds(rhs);

            if (lhsSeconds != rhsSeconds)
                return true;
            else
                return false;
        }

        public static bool operator <(Angle lhs, Angle rhs)
        {
            int lhsSeconds = Angle.ToSeconds(lhs);
            int rhsSeconds = Angle.ToSeconds(rhs);

            if (lhsSeconds < rhsSeconds)
                return true;
            else
                return false;
        }

        public static bool operator >(Angle lhs, Angle rhs)
        {
            int lhsSeconds = Angle.ToSeconds(lhs);
            int rhsSeconds = Angle.ToSeconds(rhs);

            if (lhsSeconds > rhsSeconds)
                return true;
            else
                return false;
        }

        public static bool operator <=(Angle lhs, Angle rhs)
        {
            int lhsSeconds = Angle.ToSeconds(lhs);
            int rhsSeconds = Angle.ToSeconds(rhs);

            if (lhsSeconds <= rhsSeconds)
                return true;
            else
                return false;
        }

        public static bool operator >=(Angle lhs, Angle rhs)
        {
            int lhsSeconds = Angle.ToSeconds(lhs);
            int rhsSeconds = Angle.ToSeconds(rhs);

            if (lhsSeconds >= rhsSeconds)
                return true;
            else
                return false;
        }

        public static Angle Scalar(Angle myAngle, int scalar)
        {
            myAngle._degree *= scalar;
            myAngle._minute *= scalar;
            myAngle._second *= scalar;

           return Angle.NormilizeAngle(myAngle);
        }
       

        public override string ToString()
        {
            return _degree + " " + _minute + "\'" + _second + "\"";
        }


    }
}
