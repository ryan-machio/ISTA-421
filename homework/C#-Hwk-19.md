# Ryan Manchanthasouk
## C# Chapter 19
## March 23, 2020
1. What is an enumerable collection?
  - An enumerable collection is a collection that implements the System.Collections.IEnumerable interface.
  - An interface defining a single method GetEnumerator() that returns an IEnumerable interface.  It is the base interface for all non-generic collections that can be enumerated.  This works for read-only access to a collection that implements. IENumerable can be used with a foreach statement.
1. What properties and methods does the IEnumerable interface contain?
  - single method: GetEnumerator, used to step through the elements of the collection.
1. What properties and methods does the IEnumerator interface contain?
  - one property: object Current { get; }
  - two methods: bool MoveSet(), void Reset()
1. What values does the MoveNext() method return? What does it do?
  - the MoveNext() method returns true if there is an item in the list and false if it doesn't.  If true, returns true again, until false, which will  allow the program to iterate through the collection.
1. What values does the Reset() method return? What does it do?
  - Returns pointer back to before the first item in the list.
1. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?
  - The types are note safe because it returns an object rather than a specific type.  You can implement type safety by using the generic IEnumerator<T> interface, which has a current property that returns a T instead.  There is also an IEnumerable<T> Interface containing a GetEnumerator method that returns an Enumerator<T> object.
1. Why don't recursive methods retain state when used with data structures like binary trees?
  - Recursive methods do not lend themselves to maintaining state information between method calls in an easily accessible manner
1. How do you define an enumerator?
  - You inherit from the class IEnumerable to access the GetEnumerator method.
1. What is an iterator?
  - An iterator is a block of code that yields an ordered sequence of values.
1. What does yield do?
  - yield indicates the value that should be returned by each iteration
