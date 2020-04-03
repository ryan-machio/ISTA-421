# Ryan Manchanthasouk
## Core MVC Chapter 7
## March 25th, 2020
1. There are many kinds of tests, including Unit Tests. What is a unit test, and what does it enable you to do?
  - In computer programming, unit testing is a software testing method by which individual units of source code, sets of one or more computer program modules together with associated control data, usage procedures, and operating procedures, are tested to determine whether they are fit for use.
  - Unit testing is a form of testing in which individual components are isolated from the rest of the application so their behavior can be thoroughly validated.
1. What is the primary benefit of using unit tests?
  - You are able to find bugs before your users do.
1. What is the purpose of using method GetHashCode() when using Assert.Equal()?
  - GetHashCode(): This method is used to return the hash code for this instance. A hash code is a numeric value which is used to insert and identify an object in a hash-based collection. The GetHashCode method provides this hash code for algorithms that need quick checks of object equality.
  - Asserts that the result is equal to the expected outcome.
1. The book states: [T]he chain of dependencies can make it difficult to understand what causes a test to fail." Why is this statement true?
  - This statement is true because a typical repository would rely on some kind of persistent storage system, and a uniit test can acton a whole chain of complex components, any of which could be causing the problem.
1. How do unit tests isolate small parts of an application?
  - Unit tests isolate parts of an application by using interfaces.  An interface will allow a developer to update a class to implement the interface, allowing the developer to test classes that specifically derive from that interface.
1. According to the book, what is the key to isolating components?
  - Using an interface
1. Briefly discuss the nature and purpose of a fake implementation of a class. What does a fake implementation do that a real implementation cannot do?
  - A fake implementation allows the developer to only implement the property needed for testing, which will always be consistent.
1. What is test driven development? What is the development cycle for test driven development? This is not in the book.
  - TDD is a software development process that relies on the repitition of a very short development cycle: requirements are turned into very specific test cases, then the code is improved as the tests are passed.
  - Agile
1. What are parameterized tests and why would we want to use them?
  - Where the data used in a test is removed from the test so that a single method can be used for multiple tests.
1. What is a mocking framework? What is the difference between a fake object and a mock object?
  - A mocking framework is a software package for creating fake implementations of components in an application.
  - A mock object is an object that you can set expectations on, a fake object is an object with limited capabilities for the purpose of testing.
1. (Optional) Can you think of one very important drawback to writing unit tests?
  - Tests were written poorly and would fail or pass intermittently.
