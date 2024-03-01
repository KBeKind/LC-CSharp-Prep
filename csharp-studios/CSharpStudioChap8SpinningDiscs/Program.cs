// See https://aka.ms/new-console-template for more information
using CSharpStudioChap8SpinningDiscs;


// TODO: Declare and initialize a CD and a DVD object.

// TODO: Call each CD and DVD method to verify that they work as expected.



DVD testDVD = new DVD("My DVD Stuff");

CD testCD = new CD("Music N Stuff");

testCD.AddDataItem("Music", 300);

testCD.AddDataItem("Video", 300);

testCD.AddDataItem("Documents", 200);

testDVD.SpinDisc();