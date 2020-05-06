using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyLinkedLists
{
    public class Neighbor
    {
        public int vertexNum;
        public Neighbor next;

        public Neighbor(int vnum, Neighbor nbr)
        {
            vertexNum = vnum;
            next = nbr;
        }
    }

    public class Vertex
    {
        public string name;
        public Neighbor adjList;

        public Vertex(string strName, Neighbor neighbor)
        {
            name = strName;
            adjList = neighbor;
        }
    }
    class Graph
    {
        public Vertex[] adjList;

        public Graph(string file)
        {
            StreamReader sr = new StreamReader(file);
            string line;
            string graphType = sr.ReadLine();
            adjList = new Vertex[Convert.ToInt32(sr.ReadLine())];
            for (int i = 0; i < adjList.Length; i++)
            {
                adjList[i] = new Vertex(sr.ReadLine(), null);
            }

            while ((line = sr.ReadLine()) != null)
            {
                int v1 = indexForName(line.Split(' ')[0]);
                int v2 = indexForName(line.Split(' ')[1]);

                adjList[v1].adjList = new Neighbor(v2, adjList[v1].adjList);
                if (graphType.Equals("undirected"))
                    adjList[v2].adjList = new Neighbor(v1, adjList[v2].adjList);
            }
        }

        ////depth first search using recursion
        private void dfs(int v, bool[] visited)
        {
            visited[v] = true;
            Console.WriteLine("\nVisiting "+adjList[v].name);
            for (var nbr = adjList[v].adjList; nbr != null; nbr = nbr.next)
            {
                if (!visited[nbr.vertexNum])
                {
                    Console.WriteLine(adjList[v].name+"--"+adjList[nbr.vertexNum].name);
                    dfs(nbr.vertexNum,visited);
                }
            }
        }

        public void dfs()
        {
            bool[] visited = new bool[adjList.Length];
            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i])
                {
                    Console.WriteLine("\nStarting at " + adjList[i].name);
                    dfs(i, visited);
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < adjList.Length; i++)
            {
                Console.Write(adjList[i].name);
                for (var nbr = adjList[i].adjList; nbr != null; nbr = nbr.next)
                {
                    Console.Write("-->" + adjList[nbr.vertexNum].name);
                }
                Console.Write("\n");
            }
        }

        int indexForName(string name)
        {
            for (int i = 0; i < adjList.Length; i++)
            {
                if (adjList[i].name.Equals(name))
                    return i;
            }
            return -1;
        }
    }
}
