using System.Linq;

var target = Argument("target", "Default");
    
Task("Default")
    .Does(() => 
    {
        throw new InvalidOperationException("Just an exception to see if error propagation is properly done.");
    });
    
RunTarget(target);