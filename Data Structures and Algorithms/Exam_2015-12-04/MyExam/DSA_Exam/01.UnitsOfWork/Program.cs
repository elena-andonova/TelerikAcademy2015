using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.UnitsOfWork
{
    // Source(Inspired by) last year Exam Task 'Online Market': https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/tree/master/Exam/2014/Problem%203%20-%20Data%20Structures%20%28Doncho%29/Solution
    public class Program
    {
        const string UnitAddedSuccessFormat = "SUCCESS: {0} added!";
        const string UnitAddedErrorFormat = "FAIL: {0} already exists!";
        const string UnitRemovedSuccessFormat = "SUCCESS: {0} removed!";
        const string UnitRemovedErrorFormat = "FAIL: {0} could not be found!";
        const string FindSuccessFormat = "RESULT: {0}";

        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                var command = Command.ParseCommand(input);

                switch (command.Type)
                {
                    case (CommandType.Add):
                        var unit = Unit.ParseUnit(command.Params);
                        var addResult = Game.Add(unit);
                        string format;
                        if (addResult)
                        {
                            format = UnitAddedSuccessFormat;
                        }
                        else
                        {
                            format = UnitAddedErrorFormat;
                        }
                        Console.WriteLine(format, unit.Name);
                        break;

                    case (CommandType.Remove):
                        var unitNameToRemove = command.Params;                        
                        var removeResult = Game.Remove(unitNameToRemove);
                        if (removeResult)
                        {
                            format = UnitRemovedSuccessFormat;
                        }
                        else
                        {
                            format = UnitRemovedErrorFormat;
                        }
                        Console.WriteLine(format, unitNameToRemove);
                        break;

                    case (CommandType.Find):
                        var findByType = Game.FindUnits(command.Params);
                        if (findByType == null)
                        {
                            Console.WriteLine(FindSuccessFormat, " ");
                        }
                        else
                        {
                            Console.WriteLine(FindSuccessFormat, string.Join(", ", findByType));
                        }
                        break;

                    case (CommandType.Power):
                        var topNumber = int.Parse(command.Params);
                        var takeTopUnits = Game.PowerUnits(topNumber);
                        if (takeTopUnits == null)
                        {
                            Console.WriteLine(FindSuccessFormat, " ");
                        }
                        else
                        {
                            Console.WriteLine(FindSuccessFormat, string.Join(", ", takeTopUnits));
                        }
                        break;

                    case (CommandType.End):
                        return;
                }
            }
        }

        public class Unit : IComparable<Unit>
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int Attack { get; set; }

            public int CompareTo(Unit other)
            {
                var attackCompareResult = -1 * this.Attack.CompareTo(other.Attack);
                if (attackCompareResult == 0)
                {
                    var namesCompareResult = this.Name.CompareTo(other.Name);                    
                    return namesCompareResult;
                }
                else
                {
                    return attackCompareResult;
                }
            }

            public static Unit ParseUnit(string productString)
            {
                string[] parts = productString.Split(' ');
                var name = parts[0];                
                var type = parts[1];
                var attack = int.Parse(parts[2]);
                return new Unit()
                {
                    Name = name,                    
                    Type = type,
                    Attack = attack
                };
            }

            public override string ToString()
            {
                return string.Format("{0}[{1}]({2})", this.Name, this.Type, this.Attack);
            }
        }

        public static class Game
        {
            public static SortedSet<Unit> units = new SortedSet<Unit>();
            public static HashSet<string> unitsNames = new HashSet<string>();
            public static Dictionary<string, SortedSet<Unit>> byType = new Dictionary<string, SortedSet<Unit>>();
            public static Dictionary<string, Unit> byName = new Dictionary<string, Unit>();

            public static bool Add(Unit unit)
            {
                if (unitsNames.Contains(unit.Name))
                {
                    return false;
                }

                if (!(byType.ContainsKey(unit.Type)))
                {
                    byType[unit.Type] = new SortedSet<Unit>();                    
                }

                units.Add(unit);
                unitsNames.Add(unit.Name);
                byType[unit.Type].Add(unit);

                byName[unit.Name] = unit;

                return true; 
            }

            public static bool Remove(string unitNameToRemove)
            {
                if (!unitsNames.Contains(unitNameToRemove))
                {
                    return false;
                }
     
                var unitToRemove = byName[unitNameToRemove];
                units.Remove(unitToRemove);
                unitsNames.Remove(unitNameToRemove);
                byType[unitToRemove.Type].Remove(unitToRemove);
                byName.Remove(unitNameToRemove);
                return true;
            }

            public static IEnumerable<Unit> FindUnits(string type)
            {
                if (!(byType.ContainsKey(type)))
                {
                    return null;
                }
                return byType[type].Take(10);
            }

            public static IEnumerable<Unit> PowerUnits(int number)
            {
                var topUnits = units.Take(number).ToList();
                return topUnits;    
            }
        }

        public enum CommandType
        {
            End,
            Add,
            Remove,
            Find,
            Power
        }

        public class Command
        {
            public string Params { get; set; }

            public static Dictionary<string, CommandType> stringToCommandType;

            static Command()
            {
                stringToCommandType = new Dictionary<string, CommandType>();
                stringToCommandType["add"] = CommandType.Add;
                stringToCommandType["end"] = CommandType.End;
                stringToCommandType["remove"] = CommandType.Remove;
                stringToCommandType["find"] = CommandType.Find;
                stringToCommandType["power"] = CommandType.Power;
            }

            public CommandType Type { get; set; }

            public static Command ParseCommand(string input)
            {
                foreach (var pair in stringToCommandType)
                {
                    if (input.StartsWith(pair.Key))
                    {
                        return new Command()
                        {
                            Type = pair.Value,
                            Params = input.Substring(pair.Key.Length).Trim()
                        };
                    }
                }
                return null;
            }
        }
    }
}
