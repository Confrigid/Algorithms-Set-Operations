using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAssignment1
{
    public class Set
    {
        private List<int> tempList = new List<int>();

        public List<int> TempList { get => tempList; set => tempList = value; }

        public Set()
                {

                }

            public Set(List<int> tList)
            {
                TempList = tList;
            }

            public Set UnionSet(Set one, Set two)
            {
                Set settemp = new Set(TempList);
                settemp.TempList.AddRange(two.TempList);
                foreach (int n in one.TempList)
                {
                    if (!two.TempList.Contains(n))
                    {
                        settemp.TempList.Add(n);
                    }
                }
                settemp.TempList.Sort();
                return settemp;
            }

            public Set IntersectionSet(Set one, Set two)
            {
                Set tempSet = new Set(TempList);

                foreach (int n in one.TempList)
                {
                    if (two.TempList.Contains(n) == true)
                    {
                        tempSet.TempList.Add(n);
                    }
                }

                return tempSet;
            }

            public Set DifferenceSet(Set one, Set two)
            {
                Set tempSet = new Set(TempList);
                tempSet.TempList.AddRange(one.TempList);

                foreach (int n in one.TempList)
                {
                    if (two.TempList.Contains(n) == true)
                    {
                        tempSet.TempList.Remove(n);
                    }
                }

                return tempSet;
            }

            public void CartesianProduct(Set set1, Set set2)
            {
                Console.Write("{");
                foreach (int x in set1.TempList)
                {
                    foreach (int y in set2.TempList)
                    {
                        Console.Write("{{{0},{1}}},", x, y);
                    }
                }
                Console.WriteLine("}");
            }

            public bool Subset(Set set1, Set set2)
            {
                bool isSubset = true;
                foreach (var element in set2.TempList)
                {
                    if (!set1.TempList.Contains(element))
                    {
                        isSubset = false;
                        break;
                    }
                }
                return isSubset;
            }

            public List<List<int>> PowerSet(Set inputSet)
            {
                var result = new List<List<int>>();
                for (int i = 0; i < (1 << inputSet.TempList.Count); i++)
                {
                    var sublist = new List<int>();
                    for (int j = 0; j < inputSet.TempList.Count; j++)
                    {
                        if ((i & (1 << j)) != 0)
                        {
                            sublist.Add(inputSet.TempList[j]);
                        }
                    }
                    result.Add(sublist);
                }
                return result;
            }

            public void IsEmpty()
            {
                if (this.TempList.Count > 0)
                {
                    Console.WriteLine("The Set is not empty.");
                }
                else
                {
                    Console.WriteLine("The Set is empty.");
                }
            }

            public void IsElement(int x)
            {
                if (this.TempList.Contains(x))
                {
                    Console.WriteLine("{0} is an element of the Set.", x);
                }
                else
                {
                    Console.WriteLine("{0} does not exist within the Set.", x);
                }
            }

            public void IsEqual(Set set1, Set set2)
            {
                if (set1.TempList.Count == set2.TempList.Count)
                {
                    bool test = true;
                    for (int i = 0; i < set1.TempList.Count; i++)
                    {
                        if (set1.TempList[i] != set2.TempList[i])
                        {
                            test = false;
                        }
                    }
                    if (test == false)
                    {
                        Console.WriteLine("The two sets are not equal.");
                    }
                    else
                    {
                        Console.WriteLine("The two sets are equal.");
                    }
                }
                else
                {
                    Console.WriteLine("The two sets are not equal.");
                }
            }

            public int GetCardinality()
            {
                int x = this.TempList.Count();
                return x;
            }

            public void AddElement(int x)
            {
                if (this.TempList.Contains(x) == true)
                {
                    Console.WriteLine("Duplicate entry detected, try again.");
                }
                else
                {
                    this.TempList.Add(x);
                }
            }

            public void RemoveElement()
            {
                int tempRemove;
                Console.Write("Enter the element you would like to remove: ");
                if (int.TryParse(Console.ReadLine(), out tempRemove))
                {
                    if (this.TempList.Contains(tempRemove))
                    {
                        this.TempList.Remove(tempRemove);
                    }
                    else
                    {
                        Console.WriteLine("Set does not contain that value.");
                    }
                }
                else
                {
                    Console.WriteLine("Non-integer value entered.");
                }
            }

            public void Clear(Set x)
            {
                x.TempList.Clear();
            }

            public int[] ToArray()
            {
                int[] temp = new int[this.TempList.Count];
                for (int i = 0; i < this.TempList.Count; i++)
                {
                    temp[i] = this.TempList[i];
                }
                return temp;
            }

            public void Print()
            {
                Console.Write("{");
                for (int i = 0; i < this.TempList.Count; i++)
                {
                    if (this.TempList.Count - 1 == i)
                    {
                        Console.Write("{0}", this.TempList[i]);
                    }
                    else
                    {
                        Console.Write("{0},", this.TempList[i]);
                    }
                }
                Console.WriteLine("}");
            }

            public void Print2d(List<List<int>> list)
            {
                Console.WriteLine();
                foreach (var sublist in list)
                {
                    Console.Write("{");
                    foreach (var value in sublist)
                    {
                        Console.Write(value);
                        Console.Write(' ');
                    }
                    Console.Write("}");
                    Console.WriteLine();
                }
            }
        }
}
