using System.Collections.Generic;
using Grid;
using UnityEngine;

namespace Grid
{
    public class Pathfinder
    {
        private GridManager _gridManager;

        public List<Node> FindPath(Node startNode, Node goalNode)
        {

            // 1. Reset node costs
            _gridManager.ResetNodeCosts();
            
            // 2. Initialize openSet and closedSet
            List<Node> openSet = new List<Node>();
            HashSet<Node> closedSet = new HashSet<Node>();
            
            // 3. Set gCost and hCost for startNode
            startNode.GCost = 0;
            startNode.HCost = HeuristicCost(startNode, goalNode);
            openSet.Add(startNode);
            
            // 4. Loop until openSet is empty:
            // - pick node with lowest fCost
            // - if this is goalNode, reconstruct and return path
            // - otherwise, move it to closedSet
            // - for each neighbour:
            // - skip if null, not walkable, or in closedSet
            // - compute tentativeG = current.gCost + stepCost
            // - if tentativeG < neighbour.gCost:
            // - update neighbour.parent, gCost, hCost
            // - ensure neighbour is in openSet
            while (openSet.Count > 0)
            {
                Node currentNode = openSet[0];
                for (int i = 1; i < openSet.Count; i++)
                {
                    if (openSet[i].HCost < currentNode.HCost)
                    {
                        currentNode = openSet[i];
                    }
                }

                if (currentNode == goalNode)
                {
                    
                }
                
            }
            
            return null;
        }

        private float HeuristicCost(Node startNode, Node goalNode)
        {
            throw new System.NotImplementedException();
        }
    }
}
