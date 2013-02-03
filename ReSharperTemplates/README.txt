ClassDerivedFromFormattedException.DotSettings
----------------------------------------------

This is a ReSharper file template that is used to create a new class that is 
derived directly or indirectly from the FormattedException class. 
This template was created using ReSharper 7.1.

This template may be used with the FormattedException class that is installed 
from the compiled assembly (via NuGet package or otherwise) or if the C# 
source code file is copied into another project. 

NOTE: An additional namespace may need to be imported with a namespace using 
statement after the new class is created fromt he template if the namespace 
of the FormattedException class is customized.

------------------------------------------------------------------------------

How To Install
--------------

First and foremost, you must have ReSharper installed and in a working state. 
Because this template was created using ReSharper 7.1, it is assumed that it 
will work with ReSharper version 7 or greater. It is not known if this template 
is usable with earlier versions of ReSharper, but feel free to try it out.

* In Visual Studio, click the ReSharper menu and then click the 
  "Templates Explorer..." menu item. The "Templates Explorer" window will open.

* Click the "File Templates" tab within the "Templates Explorer" window.

* Choose the desired layer value in the Layer drop down list located just above 
  the "Scopes" section at the top-left of the "Templates Explorer" window.
  If you're unsure what to select, choose the "Smart" value.

* Choose the desired scope in the "Scopes" section located in the left area of 
  the "Templates Explorer" window.
  If you're unsure what to select, click to highlight the "C#" scope.

* Click the Import icon from the menu at the top of the "Templates Explorer" 
  window. This icon looks like a document with a down arrow in its top-right 
  corner and when hovered over with display the tooltip text, "Import..."
  This will open the "Open Templates File" dialog window.

* Browse to and select the ClassDerivedFromFormattedException.DotSettings 
  file and click the "Open" button at the bottom of the dialog window.

You have successfully imported the file template!

If you chose the "Smart" layer, the template will be located in the 
"Templates in C# scope" main section unedr the "Not in quicklist" 
heading. You can drag-and-drop the template up to the "In quicklist" 
section in the order that you prefer. Once you do this, you can then 
navigate to the place in your project within the "Solution Explorer" in 
Visual Studio and click to highlight the node under which you choose to 
place your new FormattedException-drevied class. Press ALT-INSERT to open the
ReSharper "Generate" quicklist and you will see the new template in the list 
named "Class derived from FormattedException". Click that item in the list and 
then provide the name of your new exception class in the dialog box that opens 
and then click the "OK" button and your new class will be generated and will 
have all of the same constructor overloads as FormattedException which call the 
base implementation. The new class will, by default, inherit from 
FormattedException. If your new class is supposed to derive from a different 
class that directly or indirectly inherits from FormattedException, simply change 
the base class name " : FormattedException" to the desired class name.
