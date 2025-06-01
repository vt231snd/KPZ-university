# Особливості дотримання принципів програмування в моєму коді
[Soft_Lab01](https://github.com/ViktoriaDash/-Software-design/tree/main/lab-1/Soft_Lab01)

### DRY (Don't Repeat Yourself):
* The DRY principle is followed by using methods to output information about animals and workers, which avoids code duplication.
[Employee.cs (рядки 20-23)](https://github.com/ViktoriaDash/-Software-design/blob/main/lab-1/Soft_Lab01/Soft_Lab01/Employee.cs#L20-L23)

### KISS (Keep It Simple, Stupid)
* The code is simple and clear, each class performs one specific function.


### SOLID
* Single Responsibility Principle (SRP):
  **Each class has one responsibility. For example, the InformationZoo class is responsible for managing zoo information.[InformationZoo.cs](https://github.com/ViktoriaDash/-Software-design/blob/main/lab-1/Soft_Lab01/Soft_Lab01/InformationZoo.cs)
* Open/Closed Principle (OCP):
  ** Classes are open for extension but closed for modification. [Bird.cs](https://github.com/ViktoriaDash/-Software-design/blob/main/lab-1/Soft_Lab01/Soft_Lab01/Bird.cs)
* Liskov Substitution Principle (LSP):
  ** Subclasses can override base classes.[Program.cs (рядкок 18)](https://github.com/ViktoriaDash/-Software-design/blob/main/lab-1/Soft_Lab01/Soft_Lab01/Program.cs#18)
* Interface Segregation Principle (ISP):
  ** Interfaces are separated into specific ones.
* Dependency Inversion Principle (DIP):
  ** High-level modules do not depend on low-level modules. For example, the InformationZoo class does not depend on specific implementations of Animals, Employee, but works with them through abstractions.

### YAGNI (You Aren't Gonna Need It)
* Added only necessary functionality for the task.
[FoodAn.cs](https://github.com/ViktoriaDash/-Software-design/blob/main/lab-1/Soft_Lab01/Soft_Lab01/FoodAn.cs)

### Composition Over Inheritance
* Composition is used to create complex objects.
[InformationZoo.cs (рядкок 11-13)](https://github.com/ViktoriaDash/-Software-design/blob/main/lab-1/Soft_Lab01/Soft_Lab01/InformationZoo.cs#L11-13)

### Program to Interfaces not Implementations
* Code uses interfaces to interact between classes. Although interfaces are not explicitly shown in this example, the principle can be implemented by adding interfaces to Animals


### Fail Fast
* Input checks and error handling are performed at the start of execution.
