using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.Assignment
{
    internal class Duration
    {
        int Hours;
        int Minutes;
        int Second;

        public Duration()
        {
        }

        public Duration(int _Hours, int _Minutes , int _Second)
        {
            Hours = _Hours;
            Minutes = _Minutes;
            Second = _Second;
        }
        public Duration(int _Second)
        {
            Hours = _Second / 60 / 60;
            Minutes = (_Second / 60) % 60;
            Second = (_Second % 60) % 60;
        }


        public override string ToString()
        {
            if (Hours == 0)
                return $"Minutes :{Minutes}, Seconds :{Second}";
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Second}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours &&
                       Minutes == other.Minutes &&
                       Second == other.Second;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Second);
        }

        public static Duration operator +(Duration Left, Duration Right)
        {
            return new Duration()
            {
                Hours = (Left.Hours) + (Right.Hours),
                Minutes = (Left.Minutes) + (Right.Minutes),
                Second = (Left.Second) + (Right.Second),
            };
        }
        public static Duration operator +(Duration Left, int Second)
        {
            return new Duration()
            {
                Hours = (Left.Hours) + (Second / 60 / 60),
                Minutes = (Left.Minutes) + ((Second / 60) % 60),
                Second = (Left.Second) + ((Second % 60) % 60),
            };
        }
        public static Duration operator +(int Second, Duration Left)
        {
            return new Duration()
            {
                Hours = (Left.Hours) + (Second / 60 / 60),
                Minutes = (Left.Minutes) + ((Second / 60) % 60),
                Second = (Left.Second) + ((Second % 60) % 60),
            };
        }
        public static Duration operator -(Duration Left, Duration Right)
        {
            return new Duration()
            {
                Hours = (Left.Hours) - (Right.Hours),
                Minutes = (Left.Minutes) - (Right.Minutes),
                Second = (Left.Second) - (Right.Second),
            };
        }
        public static Duration operator ++(Duration Left)
        {
            return new Duration()
            {
                Hours = (Left.Hours),
                Minutes = (Left.Minutes) + 1,
                Second = (Left.Second) ,

            };
        }
        public static Duration operator --(Duration Left)
        {
            return new Duration()
            {
                Hours = (Left.Hours),
                Minutes = (Left.Minutes) - 1,
                Second = (Left.Second),

            };
        }

        public static bool operator >(Duration Left, Duration Right)
        {
            if (Left?.Hours == Right?.Hours)
                if (Left?.Minutes == Right?.Minutes)
                    return Left?.Second > Right?.Second;
                else 
                    return Left?.Minutes > Right?.Minutes;
            else
                return Left?.Hours > Right?.Hours;
        }
        public static bool operator <(Duration Left, Duration Right)
        {
            if (Left?.Hours == Right?.Hours)
                if (Left?.Minutes == Right?.Minutes)
                    return Left?.Second < Right?.Second;
                else
                    return Left?.Minutes < Right?.Minutes;
            else
                return Left?.Hours < Right?.Hours;
        }

        public static bool operator >=(Duration Left, Duration Right)
        {
            if (Left?.Hours == Right?.Hours)
                if (Left?.Minutes == Right?.Minutes)
                    return Left?.Second >= Right?.Second;
                else
                    return Left?.Minutes >= Right?.Minutes;
            else
                return Left?.Hours >= Right?.Hours;
        }
        public static bool operator <=(Duration Left, Duration Right)
        {
            if (Left?.Hours == Right?.Hours)
                if (Left?.Minutes == Right?.Minutes)
                    return Left?.Second <= Right?.Second;
                else
                    return Left?.Minutes <= Right?.Minutes;
            else
                return Left?.Hours <= Right?.Hours;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Second);
        }
        public static bool operator true(Duration d)
        {
            return d.Hours>0 && d.Minutes >0 && d.Second >0;
        }
        public static bool operator false(Duration d)
        {
            return d.Hours < 0 || d.Minutes < 0 || d.Second < 0;
        }
    }
}
