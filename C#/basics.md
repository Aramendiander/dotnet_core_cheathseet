# C# Basics

## Data types
### Numeric
#### Bytes
```cs
byte myUnsignedByte = 8; // Size: 8 bits  | Range: 0 to 255
sbyte mySignedByte = -8; // Size: 8 bits  | Range: -128 to +127
```
#### Unsigned Integers
```cs
ushort myUnsignedShort = 16; // Size: 16 bits  | Range: 0 to 65535
uint myUnsignedInt = 32; // Size: 32 bits  | Range: 0 to 2^32-1
ulong myUnsignedLong = 64; // Size: 64 bits  | Range: 0 to 2^64-1
```
#### Signed Integers
```cs
short mySignedShort = 16; // Size: 16 bits  | Range: -32768 to +32767
int mySignedInt = 32; // Size: 32 bits  | Range: -2^31  to +2^31-1
long mySignedLong = -64; // Size: 64 bits  | Range: -2^63  to +2^63-1
```
#### Floating point values
```cs
float myFloat = 3.14F; // Size: 32 bits  | Range: 7 digits of precision | Fastest but most "unprecise"
double myDouble = 3.14D; // Size: 64 bits  | Range: 15-16 digits of precision
decimal myDecimal = 3.14M; // Size: 128 bits | Range: 28-29 digits of precision | Slowest but most precise, used for finance
```

### Text
```cs
char myChar = 'a'; // Size: 16 bits
```
```cs
string myString = "Hello World!"
```

### Arrays
#### Single dimensional arrays
```cs
int[] array1 = new int[5]; // Declares a one dimensional array, stores 5 integers
```
```cs
int[] array2 = {1, 2, 3, 4, 5, 6}; // Declares and sets values to the array
```
#### Two dimensional arrays
```cs
int[,] multiDimensionalArray1 = new int[2, 3]; // Declares a multi dimensional array, in this case it has 2 rows and three values
```
```cs
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } }; // Same as above but also setting the values
```
#### Three dimensional arrays
```cs
int[,,] threeDimensionalArray1 = new int[2, 3, 4]; // Declares a three dimensional array, in this case it has 2 sets, each with 3 rows and four values
```
```cs
// Same as above but also setting the values
int[,,] threeDimensionalArray2 = { 
    { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } }, 
    { { 13, 14, 15, 16 }, { 17, 18, 19, 20 }, { 21, 22, 23, 24 } } 
};
```
#### Jagged Arrays - Array of arrays
```cs
int[][] jaggedArray1 = new int[2][]; // Declares a jagged array with 2 rows
jaggedArray1[0] = new int[3]; // The first row has 3 columns
jaggedArray1[1] = new int[5]; // The second row has 5 columns
```
```cs
// Declares and sets values to the jagged array
int[][] jaggedArray2 = new int[][] 
{ 
    new int[] {1, 2, 3}, 
    new int[] {4, 5, 6, 7, 8} 
};
```

### Array methods
[Documentation](#https://learn.microsoft.com/en-us/dotnet/api/system.array.constrainedcopy?view=net-7.0)
#### Max, Min, Average and Sum
```cs
myArray.Max();
myArray.Min();
myArray.Sum();
myArray,Average();
```

#### ForEach
```cs
Array.ForEach(myArr, element => Console.WriteLine(element);
// Alternate multi line
Array.ForEach(myArr, element => {
    Console.WriteLine(element);
};
```

#### Sort
```cs
Array.Sort(myArray);
```
#### Exists
Returns BOOLEAN value if the array has a value with the specificed condition
```cs
Array.Exists(myArray, element => condition );
// Example
bool result = Array.Exists(myArray, element => element > 3); // If the array contains a number higher than 3 returns true
```
#### Find
Returns first element that matches the conditions
```cs
Array.Find(myArr, value => value > 3);
```

#### FindAll
Returns all elements that matches the conditions in an Array.
```cs
Array.FindAll(myArr, value => value > 3);
```

#### IndexOf
Returns the position of the first occurence of the searched element in an array
```cs
Array.IndexOf(myArr, "dog");
```
#### LasIndexOf
Returns the position of the last occurence of the searched element in an array
```cs
Array.LastIndexOf(myArr, "dog");
```

#### Resize
Changes the number of elements of a one-dimensional array to the specified new size
If resizing to a larger size, new values will be empty unless values are assigned
If resizing to a smaller, removes content from the end of the array
```cs
Array.Resize(ref myArr, 4);
```

#### Reverse
Reverse the array
```cs
Array.Reverse(myArr);
```

#### Clear
Clear contents of array
```cs
Array.Clear(myArr); // Clears entire array
Array.Clear(MyArr, startIndex, length); // Clears range between starting index and number of elements to clear
```

## String manipulation

### Escaping
```cs
string fooString = "\"escape\" quotes and add \n (new lines) and \t (tabs)";
string verbatimPath = @"C:\Users\User\Desktop"; //Escape the whole string
```
### String interpolation
```cs
string myName = "John Doe";
Console.WriteLine($"My name is: {myName}.");
```

### Replace
Replaces value in string
```cs
text = text.Replace("This", "That"); 
```

### Contains
Return true if text contains value
```cs
string myText = "Hello World!";
myText.Contains("Hello"); //Returns true
```
