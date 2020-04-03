# Ryan Manchanthasouk
## C# Chapter 20
## March 24, 2020
1. What is a delegate? Explain delegates in terms of pointers and reference types.
  - A delegate is a reference to a method.
1. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
  - DelegateName variablename = new DelegateName();
1. How do you create instances of delegates and assign values to the instance? What are the values?
  - Del delegate = DelegateMethod
1. How do you invoke a method that has been added to a delegate?
  - Delegate.MethodInvoke(value);
1. What is an event? Why do we have events?
  - An event enables a class or object to notify other classes or objects when something of interest occurs.
  - We have events in GUI programming such as UWP apps; events are used to run code when the user clicks a button or types something in a field.
1. How do you declare events?
  - event delegateTypeName eventName
1. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
  - Delegates recognize event subscriptions by attaching the delegate instance to the event by using the += operator.
  class MyEventHandlingClass
    - {
    - private MyClass myClass = new MyClass();
    -  ...
    -  public void Start()
    -   {
    -  myClass.MyEvent +=
    -  new myClass.MyDelegate (this.eventHandlingMethod);
    -  }
    -  private void eventHandlingMethod()
    -  {
    -  ...
    -  }
      }
You can also
  - Use the -= operator instead of using the += operator
1. How do you raise an event? How do you declare code that raises an event?
  - Use the same syntax as a method call. You must supply arguments to match the type of
the parameters expected by the delegate referenced by the event. Don’t forget to check whether the event is null. For example:
    - class MyClass
    - {
    - public event myDelegate MyEvent;
    - ...
    - private void RaiseEvent()
    - {
    - if (this.MyEvent != null)
    - {
    - this.MyEvent();
    - }
    - }
    - ...
    - }
1. Explain with specificity what happens when an event fires and that event has been attached to a delegate
  - Delegate type events are generated whose signature has a voide return type with two arguments.  The first argument is the sender, and the second event is an EventArgs argument.
