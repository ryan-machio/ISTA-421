# Ryan Manchanthasouk
## C# Chapter 21
## March 24, 2020
1. What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different query languages? Does LINQ replace SQL? Does SQL make LINQ unnecessary?
  - LINQ is more flexible and can handle a wider variety of logical data structures.
  - LINQ is integrated with C#/VB, which eliminates the impedance mismatch between programming languages and databases, as well as providing a single querying interface for a multitude of data sources.
  - SQL does not make LINQ unnecessary; SQL is used universally, but LINQ is only used within .NET.  
2. What is the one essential requirement for the data structures used with LNQ? Why is this requirement important?
  - LINQ requires the data to be stored in a data structure that implements the IEnumerable/IEnumerable generic interface.  
  - LINQ requires some type of collection to query from.
3. Were does the LINQ Select() method live?
  - the Enumerable class located in the System.Linq namespace
4. (Select) Explain, token by token, each token in this line of code:
  - IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);
  - Select retrieves specific data from the array, in this cause the values in the FirstNAme field of each item in the array.  The parameter to the Select method is another method that takes a row from the customers array and returns the selected data from that row.
  - The Select method generates an IEnumerable string type object named customerFirstNames.  The customers class is given the aliase cust and the select method returns an enumearble object that will fetch the data identified by the Select method when iterated over it.
5. (Filter) Explain, token by token, each token in this line of code:
  - IEnumerable<string> usCompanies = addresses.Where(addr =>
  - String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);
  - Where expects a parameter that defines a method that filters the data according to whatever criteria you specify.
  - Where method returns an enumerable collection of rows containing every field from the original collection
  - Initiliazing IEnumearble variable type string named usCompanies.  addresses. Where filters data on a specific parameter.  In this case, the where Object String calls Method Equals, the specific parameters filtered are from the addr.Country object which returns rows that contain "United States".  Selecting from the type usComp, which is the alias for usComp.CompanyName
6. (OrderBy) Explain, token by token, each token in this line of code:
  - IEnumerable<string> companyNames = addresses.OrderBy(addr =>
  - addr.CompanyName).Select(comp => comp.CompanyName);
  -
7. (Group) Explain, token by token, each token in this line of code:
var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);
  - OrderBy expects a method as its argument.
  - This method identifies the expressions that you want to use to sort the data.
  - The GroupBy takes the method parameter, which is a lamda expression, where addrs is the alias for addrs.Country.  The companiesGroupedByCountry variable name which is of the var type is assigned this expression.
8. (Distinct) Explain, token by token, each token in this line of code:
  - int numberOfCountries = addresses.Select(addr =>
  - addr.Country).Distinct().Count();
  - The distinct method is called to elinate duplicates from the Count calculation.  The data selected is from the addresses object, where the type addr.Country, is assigned the alias addr.  The data reference is stored in the numberOfCountries variable, which is an interger type.
9. (Join) Explain, token by token, each token in this line of code:
  - var companiesAndCustomers =
  - customers.Select(c =>
  - new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs =>
  - custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) =>
  - new {custs.FirstName, custs.LastName, addrs.Country });
  - A collection named companiesAndCustomers is initialized, which is assigned a query.  The query selects the customers array, which is initializes a new array containing the FirstName, LastName, and CompanyName rows from the customers array.  This array is joined with the addresses array, where the values of CompanyName field matches the value in the CompanyName field in the addresses array.  The joined Enumerable collection is a set including rows containing the FirstName and LastName fields from the customers collection, with the Country field from the addresses collection.
10. Explain the difference between a deferred collection and a static, cached collection.
  - Deferred collections are collections that are not fetched until used.
  - Static, cached collections are collections that are always queried
