# XpathChecker

This application has been created to allow Xpath testing within Internet Explorer.

Enter the URL of the Application Under Test (herafter AUT)
![alt text](https://i.imgur.com/oYjwHzT.png)


This will open Internext Explorer to the AUT
![alt text](https://i.imgur.com/iDeBXMf.png)

There are 3 Find Behaviours

1) default
  This will search for the xpath provided and list how many elements found.
2) Check Within Frames
  In order to use this you will need to provide an Xpath which includes all Frames using the same notation as Xpath.
  ie. //frame[@name='firstFrame']//input[@type='Search']
  This will report how many xpath matches are within the frame specified
3) Scan all Frames
  This will recursively scan through all frames on the Webpage and report how many times the xpath matched.
  Feel free to grab the recursive code, I have included the methods to get all Elements as well as the more useful method which will return   the matching Element and leave the WebDriver in the required Frame.
  
General Usage:
Windows can be switched to by clicking Get Windows, selecting the window title of choice, and then clicking Switch.
Attributes of a specified element can be found by selecting the element from the list and clicking Attributes, this will open a new Dialog with ALL the attributes of the element.

The Shutdown button will close the IEDriverServer and the Internet Explorer instance.
The Reset will return the count to 0, and clear the xpath information.
