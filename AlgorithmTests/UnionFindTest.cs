using Algorithms.UnionFind;
using Algorithms.UnionFind.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AlgorithmTests
{
    [TestClass]
    public class UnionFindTest
    {
        IUF quickFind;         

        [TestMethod]
        public void QuickFindTest()
        {
            var lines = File.ReadAllLines("InputData/UnionFind/inputs.txt");
            int n = int.Parse(lines[0]);
            quickFind = new QuickFindUF(n);
            for(int i = 1; i < lines.Length; i++)
            {
                string[] elements = lines[i].Split(" ");
                string operation = elements[0];
                switch (operation)
                {
                    case "Union":
                        quickFind.Union(int.Parse(elements[1]), int.Parse(elements[2]));
                        break;
                    case "Connected":
                        var result = quickFind.Connected(int.Parse(elements[1]), int.Parse(elements[2]));
                        switch(elements[3])
                        {
                            case "False":
                                Assert.IsFalse(result);
                                break;
                            case "True":
                                Assert.IsTrue(result);
                                break;
                        }
                        break;
                }
            }
        }

        [TestMethod]
        public void QuickUnionTest()
        {
            var lines = File.ReadAllLines("InputData/UnionFind/inputs.txt");
            int n = int.Parse(lines[0]);
            quickFind = new QuickUnionUF(n);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] elements = lines[i].Split(" ");
                string operation = elements[0];
                switch (operation)
                {
                    case "Union":
                        quickFind.Union(int.Parse(elements[1]), int.Parse(elements[2]));
                        break;
                    case "Connected":
                        var result = quickFind.Connected(int.Parse(elements[1]), int.Parse(elements[2]));
                        switch (elements[3])
                        {
                            case "False":
                                Assert.IsFalse(result);
                                break;
                            case "True":
                                Assert.IsTrue(result);
                                break;
                        }
                        break;
                }
            }
        }

        [TestMethod]
        public void WeightedQuickUnionTest()
        {
            var lines = File.ReadAllLines("InputData/UnionFind/inputs.txt");
            int n = int.Parse(lines[0]);
            quickFind = new WeightedQuickUnionUF(n);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] elements = lines[i].Split(" ");
                string operation = elements[0];
                switch (operation)
                {
                    case "Union":
                        quickFind.Union(int.Parse(elements[1]), int.Parse(elements[2]));
                        break;
                    case "Connected":
                        var result = quickFind.Connected(int.Parse(elements[1]), int.Parse(elements[2]));
                        switch (elements[3])
                        {
                            case "False":
                                Assert.IsFalse(result);
                                break;
                            case "True":
                                Assert.IsTrue(result);
                                break;
                        }
                        break;
                }
            }
        }
    }
}
