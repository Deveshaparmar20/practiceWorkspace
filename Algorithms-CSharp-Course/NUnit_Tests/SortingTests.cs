﻿using System;
using Algorithms_DataStruct_Lib;
using NUnit.Framework;

namespace Algorithms.DataStruct.Lib.Tests
{
    [TestFixture]
    public class SortingTests
    {
        private int[][] Samples()
        {
            int[][] samples = new int[1][];
            //samples[0] = new[] { 1 };
            //samples[1] = new[] { 2, 1 };
            //samples[2] = new[] { 2, 1, 3 };
            //samples[3] = new[] { 1, 1, 1 };
            //samples[4] = new[] { 2, -1, 3, 3 };
            //samples[5] = new[] { 4, -5, 3, 3 };
            //samples[6] = new[] { 0, -5, 3, 3 };
            //samples[7] = new[] { 0, -5, 3, 0 };
            //samples[8] = new[] { 3, 2, 5, 5, 1, 0, 7, 8, 91, 23, 56, 76, 89, 34 };
            samples[0] = new[] { 33, 22, 11, 00, 44, 77, 99, 55, 88, 66 };
            return samples;
        }

        private void RunTestsForSortAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples())
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private void PrintOut(int[] array)
        {
            TestContext.WriteLine("-----TRACE-----\n");
            foreach (var el in array)
            {
                TestContext.Write(el + " ");
            }
            TestContext.WriteLine("\n----------------------\n");
        }

        [Test]
        public void BubbleSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(Sorting.BubbleSort);
        }

        [Test]
        public void SelectionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(Sorting.SelectionSort);
        }

        [Test]
        public void InsertionSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(Sorting.InsertionSort);
        }

        [Test]
        public void ShellSort_ValidInput_SortedOutput()
        {            
            RunTestsForSortAlgorithm(Sorting.ShellSort);
        }

        [Test]
        public void MergeSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(Sorting.MergeSort);
        }

        [Test]
        public void QuickSort_ValidInput_SortedOutput()
        {
            RunTestsForSortAlgorithm(Sorting.QuickSort);
        }
    }
}
