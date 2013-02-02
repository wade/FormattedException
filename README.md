# FormattedException #

A formatted exception abstract base class for .NET

STATUS: Stable

NuGet Package
-------------

[http://nuget.org/packages/FormattedException](http://nuget.org/packages/FormattedException)


Overview
--------

FormattedException is a utility class library that provides a useful 
abstract base class named FormattedException that is a drop-in replacement for 
the System.Exception class that adds additional constructor overloads that 
provide built-in string formatting for the exception message while maintaining 
the capability of specifying an inner exception and the original constructor overloads.

If you've ever used String.Format() inside an exception constructor, usually when throwing, 
you'll appreciate the time saving that this class provides. This class is stable and has 
been used for many years. This is an abstract base class which means 
that it is used to create new, application or domain specific exception types which 
can take advantage of the new constructor overloads to provide message formatting convenience.

While you may build and use the FormattedException assembly in your projects, you 
can also just copy the FormattedException class into your project, if you so desire.

There's also a NuGet package if you just want to add a reference to the assembly (see below).


NuGet Package
-------------

You can quickly install FormattedException into your project using the NuGet package.
To install FormattedException, run the following command in the Package Manager Console:

`PM> Install-Package FormattedException`


Creating Derived Exception Classes
----------------------------------

A quick way to create an exception class that derives from FormattedException 
without manually creating the constructor overloads is:

- Copy the FormattedException.cs file and rename it to your new exception class' name.
- Open the file and edit it as follows:
- Change the namespace name to the proper namespace for your project.
- Perform a find-and-replace (Ctrl+H in VS), replacing "FormattedException" with your class' name.
- Change the base class from "Exception" to "FormattedException".
- Edit the code doc XML summary element for the exception class.

Tools
-----

This solution was created using Microsoft Visual Studio 2012 targeting the .NET Framework version 4.0.
The FormattedException class was originally written in Visual Studio 2005 targeting .NET 2.0.
The tests in this solution use NUnit 2.6.2.
The MSBuild project uses MSBuild Communit Tasks 1.4.0.56 and NUnit 2.6.2.
NuGet Package restore uses NuGet 2.x.
The FormattedException assembly provided by the NuGet package targets .NET 4.0.

If you need to target a different .NET Framework version, simply create a new project or just 
copy the FormattedException class into your solution as needed.
