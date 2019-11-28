using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mainList1 = new List<int>();
            List<int> mainList2 = new List<int>();
            int userInput = 0;
            int tempListVar = 0;

            for(int i=0; i<5;i++)
            {
                Console.Write("Enter int value for Set 1: ");
                if(int.TryParse(Console.ReadLine(), out tempListVar))
                {
                    if(mainList1.Contains(tempListVar))
                    {
                        Console.WriteLine("Duplicates are not allowed.");
                        i--;
                    }
                    else
                    {
                        mainList1.Add(tempListVar);
                    }
                }
                else
                {
                    Console.WriteLine("Non-integer value entered.");
                    i--;
                }
            }

            for(int i=0; i<5;i++)
            {
                Console.Write("Enter int value for Set 2: ");
                if (int.TryParse(Console.ReadLine(), out tempListVar))
                {
                    if (mainList2.Contains(tempListVar))
                    {
                        Console.WriteLine("Duplicates are not allowed.");
                        i--;
                    }
                    else
                    {
                        mainList2.Add(tempListVar);
                    }
                }
                else
                {
                    Console.WriteLine("Non-integer value entered.");
                    i--;
                }
            }

            Set set1 = new Set(mainList1);
            Set set2 = new Set(mainList2);

            do
            {
                Menu menu = new Menu();
                userInput = menu.DisplayMenu();
                switch(userInput)
                {
                    case 1:
                        //UNION
                        Set setUnion = new Set();
                        Console.Write("The Union of the sets is: ");
                        setUnion = setUnion.UnionSet(set1, set2);
                        setUnion.Print();
                        break;

                    case 2:
                        //INTERSECTION
                        Set setIntersection = new Set();
                        setIntersection = setIntersection.IntersectionSet(set1, set2);
                        Console.Write("The result of set intersection is: ");
                        setIntersection.Print();
                        break;

                    case 3:
                        //DIFFERENCE
                        Set setDifference = new Set();
                        Console.WriteLine("What set would you like to get the difference for?");
                        Console.WriteLine("1: Set1 - Set2");
                        Console.WriteLine("2: Set2 - Set1");
                        int uInput = 0;
                        if (int.TryParse(Console.ReadLine(), out uInput))
                        {
                            switch (uInput)
                            {
                                case 1:
                                    setDifference = setDifference.DifferenceSet(set1, set2);
                                    Console.Write("The result of the set difference is: ");
                                    setDifference.Print();
                                    break;
                                case 2:
                                    setDifference = setDifference.DifferenceSet(set2, set1);
                                    Console.Write("The result of the set difference is: ");
                                    setDifference.Print();
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 4:
                        //CARTESIAN PRODUCT
                        Console.WriteLine("What set do you want to find the cartesian product of?");
                        Console.WriteLine("1: Set 1 X Set 1");
                        Console.WriteLine("2: Set 1 X Set 2");
                        Console.WriteLine("3: Set 2 X Set 2");
                        Console.WriteLine("4: Set 2 X Set 1");
                        Console.WriteLine();
                        int cartesianInput = 0;
                        if (int.TryParse(Console.ReadLine(), out cartesianInput))
                        {
                            Set cartesianSet = new Set();
                            switch (cartesianInput)
                            {
                                case 1:
                                    cartesianSet.CartesianProduct(set1, set1);
                                    break;
                                case 2:
                                    cartesianSet.CartesianProduct(set1, set2);
                                    break;
                                case 3:
                                    cartesianSet.CartesianProduct(set2, set2);
                                    break;
                                case 4:
                                    cartesianSet.CartesianProduct(set2, set1);
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 5:
                        //SUBSET
                        Console.WriteLine("What sets do you want to check equality of?");
                        Console.WriteLine("1: Set 1 & Set 1");
                        Console.WriteLine("2: Set 1 & Set 2");
                        Console.WriteLine("3: Set 2 & Set 1");
                        Console.WriteLine("4: Set 2 & Set 2");
                        Console.WriteLine();
                        int subsetInput = 0;
                        if (int.TryParse(Console.ReadLine(), out subsetInput))
                        {
                            Set subsetSet = new Set();
                            switch (subsetInput)
                            {
                                case 1:
                                    Console.WriteLine(subsetSet.Subset(set1, set1));
                                    break;
                                case 2:
                                    Console.WriteLine(subsetSet.Subset(set1, set2));
                                    break;
                                case 3:
                                    Console.WriteLine(subsetSet.Subset(set2, set1));
                                    break;
                                case 4:
                                    Console.WriteLine(subsetSet.Subset(set2, set2));
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 6:
                        //POWERSET
                        Console.WriteLine("What set do you want to find the power set of?");
                        Console.WriteLine("1: P(Set 1)");
                        Console.WriteLine("2: P(Set 2)");
                        Console.WriteLine();
                        int powerInput = 0;
                        Set powerSet = new Set();
                        if (int.TryParse(Console.ReadLine(), out powerInput))
                        {
                            switch (powerInput)
                            {
                                case 1:
                                    Console.Write("The power set is: ");
                                    List<List<int>> powerSetList1 = new List<List<int>>();
                                    powerSetList1.AddRange(powerSet.PowerSet(set1));
                                    powerSet.Print2d(powerSetList1);
                                    break;
                                case 2:
                                    Console.Write("The power set is: ");
                                    List<List<int>> powerSetList2 = new List<List<int>>();
                                    powerSetList2 = powerSet.PowerSet(set2);
                                    powerSet.Print2d(powerSetList2);
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 7:
                        //IS EMPTY
                        Console.WriteLine("What set do you want to check is empty?");
                        Console.WriteLine("1: Set 1");
                        Console.WriteLine("2: Set 2");
                        Console.WriteLine();
                        int checkEmptyInput = 0;
                        if (int.TryParse(Console.ReadLine(), out checkEmptyInput))
                        {
                            switch (checkEmptyInput)
                            {
                                case 1:
                                    set1.IsEmpty();
                                    break;
                                case 2:
                                    set2.IsEmpty();
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 8:
                        //IS ELEMENT
                        Console.WriteLine("What set do you want to check for an element?");
                        Console.WriteLine("1: Set 1");
                        Console.WriteLine("2: Set 2");
                        Console.WriteLine();
                        int checkElementInput = 0;
                        if (int.TryParse(Console.ReadLine(), out checkElementInput))
                        {
                            switch (checkElementInput)
                            {
                                case 1:
                                    Console.Write("The current set is: ");
                                    set1.Print();
                                    Console.Write("Enter int to check if in Set: ");
                                    int x = 0;
                                    if (int.TryParse(Console.ReadLine(), out x))
                                    {
                                        set1.IsElement(x);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non-integer value entered.");
                                    }
                                    break;
                                case 2:
                                    Console.Write("The current set is: ");
                                    set2.Print();
                                    Console.Write("Enter int to check if in Set: ");
                                    int y = 0;
                                    if (int.TryParse(Console.ReadLine(), out y))
                                    {
                                        set2.IsElement(y);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non-integer value entered.");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 9:
                        //IS EQUAL
                        Console.WriteLine("What sets do you want to check equality of?");
                        Console.WriteLine("1: Set 1 & Set 1");
                        Console.WriteLine("2: Set 1 & Set 2");
                        Console.WriteLine("3: Set 2 & Set 2");
                        Console.WriteLine();
                        int equalityInput = 0;
                        if (int.TryParse(Console.ReadLine(), out equalityInput))
                        {
                            Set equalitySet = new Set();
                            switch (equalityInput)
                            {
                                case 1:
                                    equalitySet.IsEqual(set1, set1);
                                    break;
                                case 2:
                                    equalitySet.IsEqual(set1, set2);
                                    break;
                                case 3:
                                    equalitySet.IsEqual(set2, set2);
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 10:
                        //CARDINALITY
                        Console.WriteLine("What set do you want to check the cardinality of?");
                        Console.Write("1: Set 1: ");
                        set1.Print();
                        Console.Write("2: Set 2: ");
                        set2.Print();
                        Console.WriteLine();
                        int cardinalityInput = 0;
                        if (int.TryParse(Console.ReadLine(), out cardinalityInput))
                        {
                            switch (cardinalityInput)
                            {
                                case 1:
                                    int x = set1.GetCardinality();
                                    Console.WriteLine("Cardinality of Set 1 is {0}", x);
                                    break;
                                case 2:
                                    int y = set2.GetCardinality();
                                    Console.WriteLine("Cardinality of Set 2 is {0}", y);
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 11:
                        //ADD ELEMENT
                        Console.WriteLine("What set do you want to add an element to?");
                        Console.Write("1: Set 1: ");
                        set1.Print();
                        Console.Write("2: Set 2: ");
                        set2.Print();
                        Console.WriteLine();
                        int addInput = 0;
                        if (int.TryParse(Console.ReadLine(), out addInput))
                        {
                            switch (addInput)
                            {
                                case 1:
                                    Console.Write("The current set is: ");
                                    set1.Print();
                                    Console.Write("Enter int to add to Set: ");
                                    int x = 0;
                                    if (int.TryParse(Console.ReadLine(), out x))
                                    {
                                        set1.AddElement(x);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non-integer value entered.");
                                    }
                                    break;
                                case 2:
                                    Console.Write("The current set is: ");
                                    set2.Print();
                                    Console.Write("Enter int to add to Set: ");
                                    int y = 0;
                                    if (int.TryParse(Console.ReadLine(), out y))
                                    {
                                        set2.AddElement(y);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Non-integer value entered.");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 12:
                        //REMOVE ELEMENT
                        Console.WriteLine("What set do you want to remove an element from?");
                        Console.Write("1: Set 1: ");
                        set1.Print();
                        Console.Write("2: Set 2: ");
                        set2.Print();
                        Console.WriteLine();
                        int removeInput = 0;
                        if (int.TryParse(Console.ReadLine(), out removeInput))
                        {
                            switch (removeInput)
                            {
                                case 1:
                                    Console.Write("The current set is: ");
                                    set1.Print();
                                    set1.RemoveElement();
                                    break;
                                case 2:
                                    Console.Write("The current set is: ");
                                    set2.Print();
                                    set2.RemoveElement();
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 13:
                        //CLEAR
                        Console.WriteLine("What set do you want to clear?");
                        Console.WriteLine("1: Set 1");
                        Console.WriteLine("2: Set 2");
                        Console.WriteLine();
                        int clearInput = 0;
                        Set clearSet = new Set();
                        if (int.TryParse(Console.ReadLine(), out clearInput))
                        {
                            switch (clearInput)
                            {
                                case 1:
                                    Console.Write("The current set before clearing is: ");
                                    set1.Print();
                                    clearSet.Clear(set1);
                                    Console.Write("Set Cleared.");
                                    break;
                                case 2:
                                    Console.Write("The current set before clearing is: ");
                                    set2.Print();
                                    clearSet.Clear(set2);
                                    Console.Write("Set Cleared.");
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 14:
                        //TO ARRAY
                        Console.WriteLine("What set do you want to conver to array?");
                        Console.WriteLine("1: Set 1");
                        Console.WriteLine("2: Set 2");
                        Console.WriteLine();
                        int arrayInput = 0;
                        if (int.TryParse(Console.ReadLine(), out arrayInput))
                        {
                            switch (arrayInput)
                            {
                                case 1:
                                    int[] a = set1.ToArray();
                                    Console.Write("{");
                                    for (int i = 0; i < a.Length; i++)
                                    {
                                        if (a.Length - 1 == i)
                                        {
                                            Console.Write("{0}", a[i]);
                                        }
                                        else
                                        {
                                            Console.Write("{0},", a[i]);
                                        }
                                    }
                                    Console.WriteLine("}");
                                    break;
                                case 2:
                                    int[] b = set2.ToArray();
                                    Console.Write("{");
                                    for (int i = 0; i < b.Length; i++)
                                    {
                                        if (b.Length - 1 == i)
                                        {
                                            Console.Write("{0}", b[i]);
                                        }
                                        else
                                        {
                                            Console.Write("{0},", b[i]);
                                        }
                                    }
                                    Console.WriteLine("}");
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;

                    case 15:
                        //PRINT
                        Console.WriteLine("What set do you want to print?");
                        Console.WriteLine("1: Set 1");
                        Console.WriteLine("2: Set 2");
                        Console.WriteLine("3: Both Sets");
                        Console.WriteLine();
                        int printInput = 0;
                        if (int.TryParse(Console.ReadLine(), out printInput))
                        {
                            switch (printInput)
                            {
                                case 1:
                                    Console.Write("The current set is: ");
                                    set1.Print();
                                    break;
                                case 2:
                                    Console.Write("The current set is: ");
                                    set2.Print();
                                    break;
                                case 3:
                                    Console.WriteLine("The sets are:");
                                    set1.Print();
                                    set2.Print();
                                    break;
                                default:
                                    Console.WriteLine("Integer entered is outside the bounds.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non-integer value entered.");
                        }
                        break;
                    case 16:
                        Console.WriteLine("Goodbye!");
                        break;
                    case 17:
                        Console.WriteLine("Try Again.");
                        break;
                    default:
                        Console.WriteLine("Incorrect Entry");
                        break;
                }
            } while (userInput != 16);            
        }
    }

    
}
