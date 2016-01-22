using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OfficeSpace
{
    public class Program
    {

        private static Dictionary<int, List<int>> graph;

        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            graph = new Dictionary<int, List<int>>(number);
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var countConnections = 0;

            foreach (var num in numbers)
            {
                int first = num;
                var second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (!graph.ContainsKey(first))
                {
                    graph[first] = new List<int>();
                }


                foreach (var conn in second)
                {
                    var index = conn - 1;
                    if (index >= 0)
                    {
                        //if (!graph.ContainsKey(numbers[index]))
                        //{
                        //    graph[numbers[index]] = new List<int>();
                        //}
                        //graph[numbers[index]].Add(first);

                        if (!graph.ContainsKey(first))
                        {
                            graph[first] = new List<int>();
                        }
                        graph[first].Add(numbers[index]);
                    }
                    else
                    {
                        countConnections++;
                    }
                }
            }

            if (numbers.Length == countConnections)
            {
                Console.WriteLine(numbers.Max());
                return;
            }


            //foreach (var node in graph)
            //{
            //    Console.Write(node.Key + " -> ");

            //    foreach (int neighbors in node.Value)
            //    {
            //        Console.Write(neighbors + " ");
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine("---------------------------");

            foreach (var num in numbers)
            {
                Solve(num);

                //Console.WriteLine(string.Join(" -> ", path));
                //Console.WriteLine(countNodes);

                if (numbers.Length != countNodes)
                {
                    path.Clear();
                    countNodes = 0;
                }
                if (numbers.Length == countNodes)
                {
                    var pathValue = path.Sum();
                    paths.Add(pathValue);
                }
            }

            if (paths.Count > 0)
            {
                Console.WriteLine(paths.Min());
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        private static List<int> path = new List<int>();
        private static int countNodes;
        private static List<int> paths = new List<int>();

        public static void Solve(int node)
        {
            //countNodes += graph[node].Count;
            if (path.Count > 0 && node == path[0])
            {
                return;
            }

            if (graph[node].Count != 0)
            {
                if (!path.Contains(node))
                {
                    path.Add(node);

                    countNodes += 1;
                }
                countNodes += graph[node].Count;


                var maxNode = graph[node].Max();

                if (!path.Contains(maxNode))
                {
                    path.Add(maxNode);
                }
                Solve(maxNode);
            }
        }
    }
}

