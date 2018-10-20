# Coding Style

## Table of Contents

1. [C# Style](#csharp)
    * [General Style](#csharpgeneral)
    * [Naming Standards](#csharpnaming)
    * [Imports](#csharpimports)
    * [Braces](#csharpbraces)
    * [Spacing](#csharpspacing)
    * [Indentation](#csharpindentation)
    * [Line Wrap Indentation](#csharplinewrap)
    * [Visibility](#csharpvisibility)
    * [Affirmative Conditions](#csharpaffirmative)
    * [Functions](#csharpfunctions)
2. [HTML Style](#html)
    * [Tag Name](#htmltagname)
    * [Closing Tags](#htmlclosetags)
    * [Attributes](#htmlattributes)
3. [CSS Style](#css)
    * [Rule Order](#cssruleorder)
    * [Class & Id Naming](#cssclassandid)

<span id="csharp"><h2>C# Style</h2></span>

<span id="csharp_general"><h3>General Style</h3></span>

1. Try and avoid using ```var```. While the C# type inference is impressive, I think being as explicit as possible when writing is the best route to go. Only use ```var``` if it's painfully obvious.
2. Use ```const``` as much as possible. If the value has to be cacluated at runtime, then use ```readonly```. The less we're changing variables, the easier it is to follow and debug.
3. Try to keep variables as localized as possible. For example, if a variable is only within a function, then keep it there. There is no need to make it a member. If another function/method needs it, then try and pass it from one function to another. Sometimes this is unavoidable, but try your best to do this.

___

<span id="csharpnaming"><h3>Naming Standards</h3></span>

| Nomenclature | Casing | Example |
|--------------|--------|---------|
| Namespace | PascalCase | ```GnuPlusLinux``` |
| Classes | PascalCase | ```public class HomeController``` |
| Functions & Methods | PascalCase | ```private int TotalUsers()``` |
| Public Fields | camalCase | ```public int myInt``` |
| Private/Protected Fields | camalCase w/ ```_``` prefix | ```private int _myPrivateInt``` |
| Static/Readonly/Constants | PascalCase | ```public const Title```
| Local Variables | camalCase | ``` bool myBoolean ``` |
| Function Parameters | camalCase | ``` private int GetStringLength(in int myString)``` |

___

<span id="csharpimports"><h3>Imports</h3></span>

* Imports should be ordered alphabetically and organized by .NET/external dependencies first and project imports second. 
* Only include imports that are used. If an import is not used, then please remove it.

**<span style='color: red'>Bad:</span>**
```csharp
using GnuPlusLinux;
using System.Data.SqlClient;
using System;
using System.Data;
using GnuPluxLinuxDAL;
using System.Linq;
using System.Collections.Generic;
```

**<span style='color: green'>Good:</span>**
```csharp
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using GnuPlusLinux;
using GnuPluxLinuxDAL;
```

___

<span id="csharpbraces"><h3>Braces</h3></span>

* Use [Allman Style Braces](https://en.wikipedia.org/wiki/Indentation_style#Allman_style). 

**<span style='color: red'>Bad:</span>**
```csharp
if (condition) {
    Console.WriteLine("Hello");
}

if (condition) 
    {
        Console.WriteLine("Hello");
    }

if (condition) {
        Console.WriteLine("Hello"); }
```

**<span style='color: green'>Good:</span>**
```csharp
if (condition)
{
    Console.WriteLine("Hello");
    if (nextCondition) 
    {
        Console.WriteLine(" World!");
    }
}
else 
{
    Console.WriteLine("Hello World!");
}
```

___

<span id="csharpspacing"><h3>Spacing</h3></span>

* Lines should not exceed 80 columns.

<span id="csharpindentation"><h3>Indentation</h3></span>

* Use four spaces for indentation.

**<span style='color: red'>Bad:</span>**
```csharp
public void BadSayHello() 
{
		// Two tabs
		Console.WriteLine("Hello!"); 
}

public void BadSayHelloAgain() 
{ 
  // Two spaces
  Console.WriteLine("Hello!");
}
```

**<span style='color: green'>Good:</span>**
```csharp
public void GoodSayHello()
{
    // Four spaces
    Console.WriteLine("Hello!");
}
```

___

<span id="csharplinewrap"><h3>Line Wrap Indentation</h3></span>

* Use four spaces for line wrap indentation too.

**<span style='color: red'>Bad:</span>**
```csharp
VeryVeryLongType thisLongType = LongFunctionNameToGrabType(which, takes, many, arguments).GetSomeObjectFromType();

/* OR */

VeryVeryLongType thisLongType = 
        LongFunctionNameToGrabType(which, takes, many, arguments)
        .GetSomeObjectFromType();
```

**<span style='color: green'>Good:</span>**
```csharp
VeryVeryLongType thisLongType = 
    LongFunctionNameToGrabType(which, takes, many, arguments
    .GetSomeObjectFromType();
```

___

<span id="csharpvisibility"><h3>Visibility</h3></span>

* Always specifiy the visible whenever possible, even if the default is correct.

**<span style='color: red'>Bad:</span>**
```csharp
class NewClass
{
    int x;
    int _y;
}
```

**<span style='color: green'>Good:</span>**
```csharp
internal class NewClass
{
    public int x;
    private int _y;
    protected int _z;
}
```
 
 ___

<span id="csharpaffirmative"><h3>Affirmative Conditions</h3></span>

* As best as you can, try and keep the condition checks affirmative instead of negative. It just makes it easier to follow the logic rather than having to flip the condition in your head.

**<span style='color: red'>Bad:</span>**
```csharp
if (!string.IsNullOrEmpty(myString))
{
    // Proceed with function
}
else 
{
    // Call subroutine to get myString
}
```

**<span style='color: green'>Good:</span>**
```csharp
if (string.IsNullOrEmpty(myString))
{
    // Call subroutine to get myString
}
else 
{
    // Proceed with function
}
```

___

<span id="csharpfunctions"><h3>Functions</h3></span>

* Please use the keywords ```out```, ```in```, and ```ref``` as much as possible. The more descriptive you can be in a function signature, the easier it is to follow.

**<span style='color: red'>Bad:</span>**
```csharp
private int GetStringLength(string str) 
{
    // code
}
```

**<span style='color: green'>Good:</span>**
```csharp
private int GetStringLength(in string str) 
{
    // code
}
```

* Building off #3 under the General Style, it's easier to see what's going on if you add more information to a function's signature. If a function modifies two member variables, it's good to see which variables are being modified in the function signature.

**<span style='color: red'>Bad:</span>**
```csharp
public class FancyClass
{
    private int _x;
    private int _y;

    /* ... */

    public int Calculate() 
    {
        // code to calculate _x and _y
    }
}
```

**<span style='color: green'>Good:</span>**
```csharp
public class FancyClass
{
    private int _x;
    private int _y;

    /* ... */

    public int Calculate(in int x, in int y) 
    {
        // code to calculate x and y
    }
}
```

Both of these functions above do the same thing, but the second one is arguably more explicit. If the first Calculate is called, it is called like this: ```Calculate()```. But if it's called in the second example, ```Calculate(in _x, in _y)```, you can clearly see what is being calculated: _x and _y. By explictly passing ```_x``` and ```_y``` to ```Caclate```, there is no need to hunt down the function to see what it's calculating -- we know what's being calcuatled in virtue of the arguments that are passed to it.

 By also having the ```in``` annotation, you can see that both ```_x``` and ```_y``` are not being modifed -- they're only being used as a readonly reference in the function. 

___

<span id="html"><h2>HTML Style</h2></span>

<span id="htmltagname"><h2>Tag Names</h2></span>

* Use lower case tag name

**<span style='color: red'>Bad:</span>**
```html
<DIV>
    <P>YEAH</P>
</DIV>
```

**<span style='color: green'>Good:</span>**
```html
<div>
    <p>YEAH</p>
</div>
```

___

<span id="htmlclosetags"><h2>Closing Tags</h2></span>

* Close every tag

**<span style='color: red'>Bad:</span>**
```html
<div>
    <p>YEAH
    <img src="~/my/picture/link.jpg" >
</div>
```

**<span style='color: green'>Good:</span>**
```html
<div>
    <p>YEAH</p>
    <img src="~/my/picture/link.jpg" />
</div>
```

___

<span id="htmlattributes"><h2>Attributes</h2></span>

* Use lower case attributes

**<span style='color: red'>Bad:</span>**
```html
<div CLASS="my-class">
    <p>YEAH</p>
</div>
```

**<span style='color: green'>Good:</span>**
```html
<div class="my-class">
    <p>YEAH</p>
</div>
```

___

<span id="css"><h2>CSS Style</h2></span>

<span id="cssruleorder"><h2>Rule Order</h2></span>

* CSS rules should be listed alphabetically

**<span style='color: red'>Bad:</span>**
```css
#my_id {
    width: 100%;
    color: red;
    max-width: 500px;
    background-color: black;
}
```

**<span style='color: green'>Good:</span>**
```css
#my_id {
    background-color: black;
    color: red;
    max-width: 500px;
    width: 100%;
}
```

___

<span id="cssclassandid"><h2>Class & Id Naming</h2></span>

* Classes and Ids should also be written in lower cases
* Classes should be written with hypens for spacing, and ids should be written with underscores for spacing

**<span style='color: red'>Bad:</span>**
```css
#my-ID {
    background-color: black;
}

.my__class {
    color: red;
}
```

**<span style='color: green'>Good:</span>**
```css
#my_id {
    background-color: black;
}

.my-class {
    color: red;
}
```
