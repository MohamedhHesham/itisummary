////////////////////////////////// Mohamed Hesham Mohamed Ghonem

////////////////////////////////using Gem.Models.Vechile;
////////////////////////////////using Gem.Truck;

////////////////////////////////Truck truck = new Truck("Red", "Volvo", 2.5f, 3.5f, 6.0f, 120.0f, "Diesel", 50.0f);

////////////////////////////////Console.WriteLine("Specifications: ");
////////////////////////////////string specifications = truck.ShowSpecifications();
////////////////////////////////Console.WriteLine(specifications);
////////////////////////////////Console.WriteLine();
////////////////////////////////Console.WriteLine(truck.ShowSpecifications());
////////////////////////////////Console.WriteLine();
////////////////////////////////Console.WriteLine("Full Specifications: ");
////////////////////////////////string fullspec= truck.ShowSpecifications("full");
////////////////////////////////Console.WriteLine(fullspec);
////////////////////////////////Console.WriteLine();
////////////////////////////////Console.WriteLine(truck.ShowSpecifications("full"));
////////////////////////////////Console.WriteLine();
////////////////////////////////Console.WriteLine("Brief Specifications: ");
////////////////////////////////truck.ShowSpecifications("brief");
////////////////////////////////string briefspec = truck.ShowSpecifications("brief");
////////////////////////////////Console.WriteLine(briefspec);
////////////////////////////////Console.WriteLine();
////////////////////////////////Console.WriteLine(truck.ShowSpecifications("brief"));

////////////////////////////////Vechile vechile = new Vechile("Blue", "Toyota", 2.0f, 1.5f, 4.0f, 180.0f, "Petrol");

//////////////////////////////using Gem.Helpers;
//////////////////////////////using Gem.Models;
//////////////////////////////using System.Globalization;

////////////////////////////////Product product = new Product
////////////////////////////////{
////////////////////////////////    Id = 1,
////////////////////////////////    Name = "Laptop",
////////////////////////////////    Price = 999.99m
////////////////////////////////};

////////////////////////////////Console.WriteLine( product.ToString()); 
//////////////////////////////////Console.WriteLine( product.GetType());

////////////////////////////////Truck.Country = "Egypt";
////////////////////////////////Console.WriteLine("Truck Country is : " + Truck.Country);

////////////////////////////////Truck.Manfucturer = "Volvo";
////////////////////////////////Console.WriteLine("Truck Manufucturer is : " + Truck.Manfucturer);
////////////////////////////////Console.WriteLine("Truck.GreetVisitor(): "+ Truck.GreetVisitor());

////////////////////////////////Utilites.language = "C#";
////////////////////////////////Console.WriteLine("Utility.language: " + Utilites.language);
////////////////////////////////Utilites.HeadOfficeAddress = "123 Main St, City, Country";
////////////////////////////////Console.WriteLine("Utility.HeadOfficeAddress: "+ Utilites.HeadOfficeAddress);
////////////////////////////////Console.WriteLine("Utility.GreetVisitor(): "+ Utilites.GreetVisitor());

//////////////////////////////float firstNo = 2.75f;

////////////////////////////////Culture
//////////////////////////////Console.WriteLine(
//////////////////////////////    "\nar-EG: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("ar-EG")) +
//////////////////////////////    "\nar-KW: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("ar-KW")) +
//////////////////////////////    "\nen-US: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")) +
//////////////////////////////    "\nen-GB: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("en-GB"))
//////////////////////////////);

//////////////////////////////Extension Methods
////////////////////////////using Gem.Helpers;

////////////////////////////string iti = "Information Technology Institute";
////////////////////////////iti.WriteToConsoleInParentheses();

////////////////////////////decimal julySales = 275.35m;
////////////////////////////Console.WriteLine("julySales.FormatAsEgyptianCurrency(): " +
////////////////////////////    julySales.FormatAsEgyptianCurrency());

////////////////////////////Console.WriteLine("julySales.FormatAsBritishCurrency(): " +
////////////////////////////    julySales.FormatAsBritishCurrency());

////////////////////////////DateTime firstApplicantDOB = new DateTime(2009, 8, 1);
////////////////////////////Console.WriteLine("firstApplicantDOB.IsAllowedHiringBirthDate(): " +
////////////////////////////    firstApplicantDOB.IsAllowedHiringBirthDate());

////////////////////////////DateTime secondApplicantDOB = new DateTime(2008, 8, 1);
////////////////////////////Console.WriteLine("secondApplicantDOB.IsAllowedHiringBirthDate(): " +
////////////////////////////    secondApplicantDOB.IsAllowedHiringBirthDate());


//////////////////////////using Gem;
//////////////////////////using Gem.Models;
//////////////////////////using System.Drawing;


//////////////////////////ProductDescriptionCard productDescriptionCard = new ProductDescriptionCard
//////////////////////////{
//////////////////////////    Name = "Laptop",
//////////////////////////    Size = 9,
//////////////////////////    Color = "red."
//////////////////////////};

//////////////////////////productDescriptionCard.showdescription();

////////////////////////// Anonymous Object
////////////////////////var train1 = new { Model = "MT 17", Classification = "VIP", Coaches = 15 };

////////////////////////Console.WriteLine($"{{Train}})\nModel\t\t: {train1.Model}\nClassification\t: {train1.Classification}\nCoaches\t\t: {train1.Coaches}");
////////////////////////Console.WriteLine("train1.GetType(): " + train1.GetType());

//////////////////////// Exception Handling
//////////////////////bool CheckApplicantData()
//////////////////////{
//////////////////////    try
//////////////////////    {
//////////////////////        // Code to connect to an external server
//////////////////////        Console.WriteLine("Server connection opened.");
//////////////////////        Console.Write("Enter your birth year: ");
//////////////////////        int birthYear = Convert.ToInt16(Console.ReadLine());

//////////////////////        // Code to send the birth year to the external server
//////////////////////        Console.WriteLine("Data sent to server successfully.");
//////////////////////        return true;
//////////////////////    }
//////////////////////    catch (FormatException formatEx) 
//////////////////////    {
//////////////////////        Console.WriteLine("You have not entered a valid numeric format.");
//////////////////////        return false;
//////////////////////    }
//////////////////////    catch (OverflowException overflowEx) 
//////////////////////    {
//////////////////////        Console.WriteLine("You have entered a very large or very small year.");
//////////////////////        return false;
//////////////////////    }
//////////////////////    catch (Exception ex) 
//////////////////////    {
//////////////////////        Console.WriteLine(ex.Message);
//////////////////////        return false;
//////////////////////    }
//////////////////////    finally
//////////////////////    {
//////////////////////        Console.WriteLine("Finally: Server connection closed.");
//////////////////////    }
//////////////////////}

//////////////////////for (; ; )
//////////////////////{
//////////////////////    CheckApplicantData();
//////////////////////}

////////////////////int city1 = 10;

////////////////////Nullable<int> city2 = null;
////////////////////city2 = 50;
////////////////////int? city3 = 10000;
////////////////////city3 = null; ;

//////////////////using System;

//////////////////       float no1 = 10;
//////////////////        float no2 = 2;

//////////////////        CalculateTwoNumbers calculateTwoNumbers = Add;
//////////////////        Console.WriteLine("calculateTwoNumbers(no1, no2) [Add]\t\t: " + calculateTwoNumbers(no1, no2));

//////////////////        calculateTwoNumbers = Subtract;
//////////////////        Console.WriteLine("calculateTwoNumbers(no1, no2) [Subtract]\t: " + calculateTwoNumbers(no1, no2));

//////////////////        calculateTwoNumbers = Multiply;
//////////////////        Console.WriteLine("calculateTwoNumbers(no1, no2) [Multiply]\t: " + calculateTwoNumbers(no1, no2));

//////////////////        calculateTwoNumbers = Divide;
//////////////////        Console.WriteLine("calculateTwoNumbers(no1, no2) [Divide]\t\t: " + calculateTwoNumbers(no1, no2));



//////////////////    delegate float CalculateTwoNumbers(float firstNo, float secondNo);
////////////////using Gem.Delegates;
////////////////using Gem.Models;

////////////////float Add(float a, float b) => a + b;
////////////////float Subtract(float a, float b) => a - b;
////////////////float Multiply(float a, float b) => a * b;
////////////////float Divide(float a, float b) => a / b;

//////////////////float CalcAndPrint(float firstNo, float secondNo, CalculateTwoNumbers calculateTwoNumbers)
//////////////////{
//////////////////    return calculateTwoNumbers(firstNo,secondNo);
//////////////////}
//////////////////float CalcAndPrint1(float No, CalculateOneNumber calculateOneNumber)
//////////////////{
//////////////////    return calculateOneNumber(No);
//////////////////}
//////////////////Console.WriteLine("15 + 3 : ");
//////////////////Console.WriteLine(CalcAndPrint(15,3,(x,y) => x + y).ToString("N2")) ;
//////////////////Console.WriteLine("15 - 3 : ");
//////////////////Console.WriteLine(CalcAndPrint(15,3,(x,y) => x - y).ToString("N2")) ;
//////////////////Console.WriteLine("15 * 3 : ");
//////////////////Console.WriteLine(CalcAndPrint(15,3,(x,y) => x * y).ToString("N2")) ;
//////////////////Console.WriteLine("15 / 3 : ");
//////////////////Console.WriteLine(CalcAndPrint(15,3,(x,y) => x / y).ToString("N2")) ;
//////////////////Console.WriteLine(CalcAndPrint1(15,x=>x*x));

////////////////void GreetMorning(string userName) => Console.WriteLine($"Good Morning, {userName}!");
////////////////void GreetAfternoon(string userName) => Console.WriteLine($"Good Afternoon, {userName}!" );

////////////////void GreetEvening(string userName) => Console.WriteLine($"Good Evening, {userName}!");

//////////////////Greet greet = GreetMorning;
//////////////////greet += GreetAfternoon;
//////////////////greet += GreetEvening;

//////////////////greet("Hossam");

//////////////////greet -= GreetAfternoon;

//////////////////greet("Ashraf");


//////////////////Func<string, string> greet = GreetMorning;
//////////////////greet("Mohamed");


//////////////////Func<float, float, float> calculateTwoNumber;
//////////////////calculateTwoNumber = Add;

//////////////////Console.WriteLine("10 + 2 = " + calculateTwoNumber(10,2));
//////////////////calculateTwoNumber = Subtract;
//////////////////Console.WriteLine("10 - 2 = " + calculateTwoNumber(10,2));
//////////////////calculateTwoNumber = Multiply;
//////////////////Console.WriteLine("10 * 2 = " + calculateTwoNumber(10,2));
//////////////////calculateTwoNumber = Divide;
//////////////////Console.WriteLine("10 / 2 = " + calculateTwoNumber(10,2));

////////////////bool IsAllowedHiring(DateTime birthDate)
////////////////{
////////////////      return birthDate.AddYears(18) <= DateTime.Now;
////////////////}

////////////////bool IsAllowedSchool(DateTime birthDate)
////////////////{
////////////////    return birthDate.AddYears(6) <= DateTime.Now;
////////////////}

////////////////Predicate<DateTime> isAllowedHiring = IsAllowedHiring;
////////////////Console.WriteLine("Is allowed age of hiring for mohamed 22 years old ? " + IsAllowedHiring(new DateTime(2004,6,24)));
////////////////Console.WriteLine("Is allowed age of hiring for Eyad 16 years old ? " + IsAllowedHiring(new DateTime(2010,7,29)));
////////////////Console.WriteLine();
////////////////Predicate<DateTime> isAllowedSchool= IsAllowedSchool;
////////////////Console.WriteLine("Is allowed age of hiring for moaz 2 years old ? " + IsAllowedSchool(new DateTime(2024,6,24)));
////////////////Console.WriteLine("Is allowed age of hiring for ahmed 7 years ? " + IsAllowedSchool(new DateTime(2019,7,29)));




//////////////using System;
//////////////// Mohamed Hesham Mohamed Ghonem

//////////////WeekDay today = WeekDay.Wednesday;
//////////////        Console.WriteLine("\n((((((WeekDay enum))))))" +
//////////////            "\n\ntoday.GetType()\t\t: " + today.GetType() +
//////////////            "\n\ntoday\t\t\t: " + today +
//////////////            "\n\ntoday\t\t\t: " + (byte)today +
//////////////            "\nConvert.ToByte(today)\t: " + Convert.ToByte(today) +
//////////////            "\n(WeekDay)3\t\t\t: " + (WeekDay)3);

//////////////        PrimaryColor writingColor = PrimaryColor.Blue;
//////////////        Console.WriteLine("\n((((((PrimaryColor enum))))))" +
//////////////            "\n\nwritingColor.GetType()\t\t: " + writingColor.GetType() +
//////////////            "\n\nwritingColor\t\t\t: " + writingColor +
//////////////            "\n(int)writingColor\t\t: " + (int)writingColor +
//////////////            "\nConvert.ToInt32(writingColor)\t: " + Convert.ToInt32(writingColor) +
//////////////            "\n(PrimaryColor)1\t\t\t: " + (PrimaryColor)1);

//////////////enum WeekDay : byte
//////////////{
//////////////    Sunday = 1,
//////////////    Monday ,
//////////////    Tuesday ,
//////////////    Wednesday ,
//////////////    Thursday ,
//////////////    Friday ,
//////////////    Saturday , 
//////////////}

//////////////enum PrimaryColor
//////////////{
//////////////    Red,
//////////////    Green,
//////////////    Blue
//////////////}


////////////void Move(Direction direction)
////////////{
////////////    if (direction == Direction.East)
////////////        Console.WriteLine("\u2192"); 
////////////    else if (direction == Direction.West)
////////////        Console.WriteLine("\u2190");
////////////    else if (direction == Direction.North)
////////////        Console.WriteLine("\u2191");
////////////    else if (direction == Direction.South)
////////////        Console.WriteLine("\u2193");
////////////}

////////////Console.Write("\nMove(Direction.North)\t: ");
////////////Move(Direction.North);

////////////Console.Write("\nMove((Direction)0)\t: ");
////////////Move((Direction)0);

////////////Console.Write("\nMove(Direction.East)\t: ");
////////////Move(Direction.East);

////////////Console.Write("\nMove((Direction)2)\t: ");
////////////Move((Direction)2);

////////////enum Direction
////////////{
////////////    North,
////////////    South,
////////////    East,
////////////    West
////////////}

//////////using Gem.Models;

//////////Bus bus = new Bus();
//////////Console.WriteLine( bus.GetDescription());

////////using Gem.Models;

////////MultiTrailerTruck multiTrailerTruck = new MultiTrailerTruck("White", "Mercedes-Benz", 2.5f, 3.5f, 12.0f, 100.0f, "Diesel", 80.0f, 3);

////////Console.WriteLine("MultiTrailerTruck.ShowSpecifications(\"full\"): ");
////////Console.WriteLine(multiTrailerTruck.ShowSpecifications("full"));


//////using Gem.Helpers;
//////using Gem.Records;

//////Department department = new Department
//////    (1, "Human Resources", "Handles employee relations and recruitment.", 50000.00m);

//////Console.WriteLine($"Id: {department.Id}, Name: {department.Name}," +
//////    $" Description: {department.Description}," +
//////    $" Budget: {department.Budget.FormatAsEgyptianCurrency()}");

//////test x = test.e;
//////x += 1;
//////Console.WriteLine(x);

//////enum test
//////{
//////    a, b, c, d, e
////}





//using Gem.Models;

//Def def1 = new Def();
//def1.Id = 1040;
//def1.Name = "QA";
//def1.Description = "Quality Assurance";
//def1.Budget = 297000m;


//Def def2 = new Def()
//{
//    Id = 2010,
//    Name = "HR",
//    Description = "Human Resources",
//    Budget = 299000m
//};

using Gem.Models;

Console.WriteLine("Employee Specifications: \n");

Employee employee = new Employee(1, "John Doe", "123 Main St", 
    "Software Engineer", 75000.00m, "abc@gmail.com");

Console.WriteLine($"Id: {employee.Id}, Fullname: {employee.FullName}, Address: {employee.Address},  " +
    $"Position: {employee.Position}, Salary {employee.Salary}, Email: {employee.Email} ");