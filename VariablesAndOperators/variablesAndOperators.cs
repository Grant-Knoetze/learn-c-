using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int userAge = 20; /* Declaration statement first takes the data type(type of data the variable will store),
                  followed by the name of the variable. After declaration, cpu will allocate storage space 
				  to store this data. Access and modify this data by referring to its name.*/ 
				  
//Data types in C:

//int = integer
int userAge2 = 35;
//byte = integral numbers with narrow range of 0 - 255
byte testByte = 255;/*If programming for a machine with limited memory space, use  byte if certain
                    that the value of variable will not exceed 0 to 255 range*/
//float = Floating point numbers with decimal places.
float testFloat = 12.65;//Uses 8 bytes of storage, has precision of approx 7 digits.
/*double = double is also a floating point number, but can store a much wider range of numbers, has
precision of 15 to 16 digits. Default floating point data type in C#.*/
double testDouble = 56.45;
/*Decimal = stores a decimal number smaller than float or double. It has a greater precision of 28 to 29 digits.
Use decimal if program requires high degree of precision when storing non integral numbers.*/
decimal testDecimal = 0.11354687;
/*char = store single unicode characters, when initializing, enclose character in single quotes.*/
char testChar = '@';
//bool = true or false 
bool testBool = true;
//Use camel case or underscores to name.
//Initialize the variable either at the point of declaration OR initialize in a separate statement...
//Cannot use byte or int to store decimal values.
//Can use double, float, and decimal to store intgral numbers.
//Because defaul data type for a decimal number is double, use f and m suffix to change, ie:
float hourlyRate = 60.5f;
decimal income = 15335.65m;
//Initialize multiple variables of the same data type in the same statement.
byte level = 2, userExperience = 5;




namespace userAge
{

    class Program
    {

    }
}
