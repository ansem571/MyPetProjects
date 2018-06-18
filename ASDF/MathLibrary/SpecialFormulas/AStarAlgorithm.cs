using MathLibrary.BasicFormulas;
using MathLibrary.Contracts.AStar;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MathLibrary.SpecialFormulas
{
    public class AStarAlgorithm
    {
        private readonly DistanceCalculator _distanceCalculator;

        public AStarAlgorithm(DistanceCalculator distanceCalculator)
        {
            _distanceCalculator = distanceCalculator ?? throw new ArgumentNullException(nameof(distanceCalculator));
        }

        public List<string> FindPath(AStarNode start, AStarNode end)
        {
            var openList = new List<AStarNode>();
            var closedList = new List<AStarNode>();
            var currentNode = start;

            currentNode.H = _distanceCalculator.Distance(currentNode.Location, end.Location);
            openList.Add(currentNode);

            while (openList.Count > 0)
            {
                currentNode = GetNextNode(openList);
                openList.Remove(currentNode);
                foreach (var neighbor in currentNode.Neighbors)
                {
                    if (neighbor.Location.Equals(end.Location))
                    {
                        neighbor.ParentNode = currentNode;
                        return CreatePath(neighbor);
                    }
                    var tempVal = new AStarNode(neighbor.Name, neighbor.Location)
                    {
                        G = currentNode.G + _distanceCalculator.Distance(neighbor.Location, currentNode.Location),
                        H = _distanceCalculator.Distance(neighbor.Location, end.Location)
                    };

                    var skip = openList.Any(model => model.Location.Equals(neighbor.Location) && model.F < tempVal.F);
                    if (!skip && closedList.Any(model => model.Location.Equals(neighbor.Location) && model.F < tempVal.F))
                    {
                        skip = true;
                    }
                    if (skip)
                    {
                        continue;
                    }

                    if (closedList.Any(x => x.Location.Equals(neighbor.Location)))
                    {
                        closedList.Remove(neighbor);
                    }

                    neighbor.ParentNode = currentNode;
                    neighbor.G = tempVal.G;
                    neighbor.H = tempVal.H;
                    openList.Add(neighbor);
                }
                closedList.Add(currentNode);
            }
            throw new InvalidOperationException("We were unable to calculate the A* path.");
        }

        private AStarNode GetNextNode(IReadOnlyList<AStarNode> openList)
        {
            if (openList.Any())
            {
                throw new ArgumentOutOfRangeException(nameof(openList), "There are no nodes remaining in the open list");
            }
            var nextNode = openList[0];
            foreach(var model in openList)
            {
                if(model.F < nextNode.F)
                {
                    nextNode = model;
                }
            }
            return nextNode;
        }

        private List<string> CreatePath(AStarNode node)
        {
            var list = new List<string>();
            while (node.ParentNode != null)
            {
                list.Insert(0, node.Name);
                node = node.ParentNode;
            }
            list.Insert(0, node.Name);
            list.Insert(0, "Start\r\n");
            list.Add("\r\nEnd");
            return list;
        }
    }
}
