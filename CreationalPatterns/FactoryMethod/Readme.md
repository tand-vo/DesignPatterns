### Factory Method

- Define an interface for creating an object, but let subclasses decide which class to instantiate

![Class Diagram](./Factory%20Method%20-%20Class%20Diagram.png)

- Application subclasses redefine an abstraction CreateDocument operation on Application to return the appropriate Document subclass. Once an Application subclass is instantiate, it can then instantiate application-specific Documents without knowing their class. ***We call CreateDocument a factory method because it's responsible for "manufacturing" an object.***