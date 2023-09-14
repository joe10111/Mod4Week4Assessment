# Week 4 Assessment

### Setup
* Fork and clone this repository
* Open your forked repo in Visual Studio.
* Complete the two exercises and the questions

## Exercise 1: Inheritance and Dependency Injection (8 points)

Open up `Program.cs` and run your program. It should run with no errors, if you get an error reach out to your instructor.

This exercise involves some refactoring and some new features.

**Step 1:** Currently there are two classess `Student` and `Teacher` that have a lot of repeated code between them. Create a new class `Person` that will be the base class. Then update `Student` and `Teacher` to be derived from `Person`. Include as much in your `Person` class as you can to keep your code DRY (Don't Repeat Yourself). 

**Testing Step 1:** Uncomment the code under "Step 1:" in the Main method. That code should now run without error.

**Step 2:** Implement a new class called `School` that uses dependency injection and takes in a list of people as a dependency. Implement a method called `ListBirthdays` in your school class that calls the `GetBirthday` method and prints to the console each student and teacher's birthday.

**Testing Step 2:** Uncomment the code under "Step 2:" in the Main method. That code should now run without error and output a bunch of names and birthdays.

Ungraded extra challenge: If you have time, improve the way the birthdays are output. Can you group them by month or by Student/Teacher?

### Exercise 2: Interfaces (4 points)
Open up `InterfacePractice.cs`. You should not need to run this file, you will just edit it.

**Step 1:** Take a look at the two classes `Car` and `Bicycle`. They both implement an interface called `InterfaceNameHere`. Replace all three uses of `InterfaceNameHere` with a fitting name for this interface.

**Step 2:** The interface has already been created for you on line 5. Fill in the details for any methods and/or properties that make sense based on the two classes implementing this interface.

## Questions (8 points)

Edit this file with your answers.

1. What are some of the benefits of using inheritance? (1 point)
    * Inheritance helps us avoid copying the same code over and over. You can abstract shared code into a parent class, making the child class simpler.
    This means if you have a method in the parent class, the child class can use it without needing to write it again.

2. What might be some of the disadvantages of using inheritance? (1 point)
    * Even though abstracting code into a parent class can clean things up, it might make things tricky if the child class is already simple.
      If you move a lot of stuff into a big parent class, it might get confusing. Also, if you want to change a method from the parent class just for one child class,
      you have to do extra work. Keeping things straightforward often works best.

3. How would you describe the difference between the base class and the derived class when working with inheritance? (1 point)
	- Imagine joining a new company as a junior developer. When you walk in on your first day, they give you an ID card, assign you a job title, and allocate tasks to you. This is similar to when a derived class (like a junior developer) inherits certain properties and methods from a base class.
	- Now, think of a senior developer at the same company. The senior developer also has an ID card, a job title, and allocated tasks. These shared attributes and responsibilities can be seen as the common properties and methods provided by the base class. The senior developer, however, has been with the company for a while and has some additional or different responsibilities. This is similar to the derived class overriding specific methods and properties from the base class.

4.  What happens if you define the same method in the parent class and the child class? (1 point)
	* If you just re-define the method in both the child and parent class then the complier will most likely throw an error that its hiding the base class method. But if you override the child class method, instead you will be able to redefine the implementation in the child class with out an complier error. 

5. In your own words, how would you define an Interface? (1 point)
    * An interface acts as a contract. It outlines specific properties and methods without actually implementing them. When a class adopts this interface, it commits to providing concrete implementations for all of those outlined elements. In essence, an interface sets a standard that any adopting class must follow.

6. Does a class implementing an interface need to implement all of the methods in that interface? Why or why not? (1 point)
    * Yes, in C# when a class adopts an interface, it's got to implement all the methods that the interface defines. This is because the interface itself doesn't actually do any implementation; it just lays out the rules. So, the class has to step up and fill in the details to make it all work.

7. Both Inheritance and Interfaces use the `:` symbol after a class name. If you're looking at a class, what's one thing that can help you determine if the class is implementing an interface of extending a base class? (1 point)
	* If the programmer is following correct naming standards then if the name after the `:` symbol starts with `I`  it is an interface, if not then it is a class. This is because the naming standard specifies that you need to start interface names with an I to help identify them in code. 

8. If asked in an interview, how would you describe the purpose of the IOC container in a .NET application? (1 point)
	* In a .NET ASP app, the IOC (Inversion of Control) container is like the manager. Instead of letting classes go out and find or make the stuff they need, the IOC container passes / gives it to them. This makes sure everything fits together well and keeps the code organized.

## Rubric

This assessment has a total of 20 points.  A score of 15 or higher is a pass.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
