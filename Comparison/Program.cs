using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace Comparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            ArrayList Collection = ArrayListCollection.ArrayListCreation(10000);
            ArrayListCollection.AddToArrayList(10000, ref Collection);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("ArrayList add time is: " + elapsedTime);

            Stopwatch stopWatchSearch = new Stopwatch();
            stopWatchSearch.Start();
            ArrayListCollection.SearchArrayList(10000, ref Collection);
            stopWatchSearch.Stop();
            TimeSpan tsSearch = stopWatchSearch.Elapsed;
            string elapsedTimeSearch = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsSearch.Hours, tsSearch.Minutes, tsSearch.Seconds, tsSearch.Milliseconds * 10);
            Console.WriteLine("ArrayList search time is: " + elapsedTimeSearch);

			Stopwatch stopWatchTxtRead = new Stopwatch();
			stopWatchTxtRead.Start();
			ArrayListCollection.ReadingFromTxt(ref Collection);
			stopWatchTxtRead.Stop();
			TimeSpan tsTxtRead = stopWatchTxtRead.Elapsed;
			string elapsedTimeTxtRead = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
			tsTxtRead.Hours, tsTxtRead.Minutes, tsTxtRead.Seconds, tsTxtRead.Milliseconds * 10);
			Console.WriteLine("ArrayList reading from txt file time is: " + elapsedTimeTxtRead);
			Console.WriteLine("Press any key to compare to the LinkedList.");
			Console.ReadKey();

			Stopwatch stopWatchDelete = new Stopwatch();
            stopWatchDelete.Start();
            ArrayListCollection.DeleteArrayList(10000, ref Collection);
            stopWatchDelete.Stop();
            TimeSpan tsDelete = stopWatchDelete.Elapsed;
            string elapsedTimeDelete = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsDelete.Hours, tsDelete.Minutes, tsDelete.Seconds, tsDelete.Milliseconds * 10);
            Console.WriteLine("ArrayList delete time is: " + elapsedTimeDelete);
            Console.WriteLine("Press any key to compare to the LinkedList.");
            Console.ReadKey();

			

			//Linked List
			Stopwatch stopWatchLinkedAdd = new Stopwatch();
            stopWatchLinkedAdd.Start();
            LinkedList<int> CollectionLinkedList = LinkedListCollection.LinkedListCreation(10000);
            LinkedListCollection.AddToLinkedList(10000, ref CollectionLinkedList);
            stopWatchLinkedAdd.Stop();
            TimeSpan tsLinkedAdd = stopWatchLinkedAdd.Elapsed;
            string elapsedTimeLinkedAdd = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsLinkedAdd.Hours, tsLinkedAdd.Minutes, tsLinkedAdd.Seconds, tsLinkedAdd.Milliseconds * 10);
            Console.WriteLine("LinkedList add time is: " + elapsedTimeDelete);

            Stopwatch stopWatchLinkedSearch = new Stopwatch();
            stopWatchLinkedSearch.Start();
            LinkedListCollection.SearchLinkedList(10000, ref CollectionLinkedList);
            stopWatchLinkedSearch.Stop();
            TimeSpan tsLinkedSearch = stopWatchLinkedSearch.Elapsed;
            string elapsedTimeLinkedSearch = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsLinkedSearch.Hours, tsLinkedSearch.Minutes, tsLinkedSearch.Seconds, tsLinkedSearch.Milliseconds * 10);
            Console.WriteLine("LinkedList search time is: " + elapsedTimeLinkedSearch);

            Stopwatch stopWatchLinkedDelete = new Stopwatch();
            stopWatchLinkedDelete.Start();
            LinkedListCollection.DeleteLinkedList(10000, ref CollectionLinkedList);
            stopWatchLinkedDelete.Stop();
            TimeSpan tsLinkedDelete = stopWatchLinkedDelete.Elapsed;
            string elapsedTimeLinkedDelete = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsLinkedDelete.Hours, tsLinkedDelete.Minutes, tsLinkedDelete.Seconds, tsLinkedDelete.Milliseconds * 10);
            Console.WriteLine("LinkedList delete time is: " + elapsedTimeLinkedDelete);
            Console.WriteLine("Press any key to compare stack and queue.");
            Console.ReadKey();

            //Stack
            Stopwatch stopWatchStackAdd = new Stopwatch();
            stopWatchStackAdd.Start();
            Stack<int> CollectionStack = StackCollection.StackCreation(10000);
            StackCollection.AddToStack(10000, ref CollectionStack);
            stopWatchStackAdd.Stop();
            TimeSpan tsStackAdd = stopWatchStackAdd.Elapsed;
            string elapsedTimeStack = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsStackAdd.Hours, tsStackAdd.Minutes, tsStackAdd.Seconds, tsStackAdd.Milliseconds * 10);
            Console.WriteLine("Stack add time is: " + elapsedTimeStack);

            Stopwatch stopWatchStackSearch = new Stopwatch();
            stopWatchStackSearch.Start();
            StackCollection.SearchStack(10000, ref CollectionStack);
            stopWatchStackSearch.Stop();
            TimeSpan tsStackSearch = stopWatchStackAdd.Elapsed;
            string elapsedTimeStackSearch = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsStackSearch.Hours, tsStackSearch.Minutes, tsStackSearch.Seconds, tsStackSearch.Milliseconds * 10);
            Console.WriteLine("Stack search time is: " + elapsedTimeStackSearch);

            Stopwatch stopWatchStackDelete = new Stopwatch();
            stopWatchStackDelete.Start();
            StackCollection.DeleteStack(10000, ref CollectionStack);
            stopWatchStackDelete.Stop();
            TimeSpan tsStackDelete = stopWatchStackAdd.Elapsed;
            string elapsedTimeStackDelete = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsStackDelete.Hours, tsStackDelete.Minutes, tsStackDelete.Seconds, tsStackDelete.Milliseconds * 10);
            Console.WriteLine("Stack delete time is: " + elapsedTimeStackDelete);
            Console.WriteLine("Press any key to compare to the queue.");
            Console.ReadKey();

            //Queue
            Stopwatch stopWatchQueueAdd = new Stopwatch();
            stopWatchQueueAdd.Start();
            Queue<int> CollectionQueue = QueueCollection.QueueCreation(10000);
            QueueCollection.AddToQueue(10000, ref CollectionQueue);
            stopWatchQueueAdd.Stop();
            TimeSpan tsQueueAdd = stopWatchQueueAdd.Elapsed;
            string elapsedTimeQueue = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsQueueAdd.Hours, tsQueueAdd.Minutes, tsQueueAdd.Seconds, tsQueueAdd.Milliseconds * 10);
            Console.WriteLine("Queue add time is: " + elapsedTimeQueue);

            Stopwatch stopWatchQueueSearch = new Stopwatch();
            stopWatchQueueSearch.Start();
            QueueCollection.SearchQueue(10000, ref CollectionQueue);
            stopWatchQueueSearch.Stop();
            TimeSpan tsQueueSearch = stopWatchQueueSearch.Elapsed;
            string elapsedTimeQueueSearch = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsQueueSearch.Hours, tsQueueSearch.Minutes, tsQueueSearch.Seconds, tsQueueSearch.Milliseconds * 10);
            Console.WriteLine("Queue add time is: " + elapsedTimeQueueSearch);

            Stopwatch stopWatchQueueDelete = new Stopwatch();
            stopWatchQueueDelete.Start();
            QueueCollection.DeleteQueue(10000, ref CollectionQueue);
            stopWatchQueueDelete.Stop();
            TimeSpan tsQueueDelete = stopWatchQueueSearch.Elapsed;
            string elapsedTimeQueueDelete = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsQueueDelete.Hours, tsQueueDelete.Minutes, tsQueueDelete.Seconds, tsQueueDelete.Milliseconds * 10);
            Console.WriteLine("Queue delete time is: " + elapsedTimeQueueDelete);
            Console.WriteLine("Press any ket to compare dictionary and hashtable");
            Console.ReadKey();

            //Dictionary:
            Stopwatch stopWatchDictionaryAdd = new Stopwatch();
            stopWatchDictionaryAdd.Start();
            Dictionary<int, int> CollectionDictionary = DictionaryCollection.DictionaryCreation(10000);
            DictionaryCollection.AddToDictionary(10000, ref CollectionDictionary);
            stopWatchDictionaryAdd.Stop();
            TimeSpan tsDictionaryAdd = stopWatchDictionaryAdd.Elapsed;
            string elapsedTimeDictionary = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsDictionaryAdd.Hours, tsDictionaryAdd.Minutes, tsDictionaryAdd.Seconds, tsDictionaryAdd.Milliseconds * 10);
            Console.WriteLine("Dictionary add time is: " + elapsedTimeDictionary);

            Stopwatch stopWatchDictionarySearch = new Stopwatch();
            stopWatchDictionarySearch.Start();
            DictionaryCollection.SearchDictionary(10000, ref CollectionDictionary);
            stopWatchDictionarySearch.Stop();
            TimeSpan tsDictionarySearch = stopWatchDictionarySearch.Elapsed;
            string elapsedTimeDictionarySearch = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsDictionarySearch.Hours, tsDictionarySearch.Minutes, tsDictionarySearch.Seconds, tsDictionarySearch.Milliseconds * 10);
            Console.WriteLine("Dictionary search time is: " + elapsedTimeDictionarySearch);

            Stopwatch stopWatchDictionaryDelete = new Stopwatch();
            stopWatchDictionaryDelete.Start();
            DictionaryCollection.SearchDictionary(10000, ref CollectionDictionary);
            stopWatchDictionaryDelete.Stop();
            TimeSpan tsDictionaryDelete = stopWatchDictionaryDelete.Elapsed;
            string elapsedTimeDictionaryDelete = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsDictionaryDelete.Hours, tsDictionaryDelete.Minutes, tsDictionarySearch.Seconds, tsDictionaryDelete.Milliseconds * 10);
            Console.WriteLine("Dictionary delete time is: " + elapsedTimeDictionaryDelete);
            Console.WriteLine("Press any key to compare to the hashtable.");
            Console.ReadKey();

            //Hashtable
            Stopwatch stopWatchHashtableAdd = new Stopwatch();
            stopWatchHashtableAdd.Start();
            Hashtable CollectionHashtable = HashTableCollection.HashtableCreation(10000);
            HashTableCollection.AddToHashtable(10000, ref CollectionHashtable);
            stopWatchHashtableAdd.Stop();
            TimeSpan tsHashtableAdd = stopWatchHashtableAdd.Elapsed;
            string elapsedTimeHashtable = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsHashtableAdd.Hours, tsHashtableAdd.Minutes, tsHashtableAdd.Seconds, tsHashtableAdd.Milliseconds * 10);
            Console.WriteLine("Hashtable add time is: " + elapsedTimeHashtable);

            Stopwatch stopWatchHashtableSearch = new Stopwatch();
            stopWatchHashtableSearch.Start();
            HashTableCollection.SearchHashtable(10000, ref CollectionHashtable);
            stopWatchHashtableSearch.Stop();
            TimeSpan tsHashtableSearch = stopWatchHashtableSearch.Elapsed;
            string elapsedTimeHashtableSearch = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsHashtableSearch.Hours, tsHashtableSearch.Minutes, tsHashtableSearch.Seconds, tsHashtableSearch.Milliseconds * 10);
            Console.WriteLine("Hashtable search time is: " + elapsedTimeHashtableSearch);

            Stopwatch stopWatchHashtableDelete = new Stopwatch();
            stopWatchHashtableDelete.Start();
            HashTableCollection.DeleteHashtable(10000, ref CollectionHashtable);
            stopWatchDelete.Stop();
            TimeSpan tsHashtableDelete = stopWatchHashtableDelete.Elapsed;
            string elapsedTimeHashtableDelete = String.Format("{0:00}:{1:00}:{2:00}.{3:000000}",
            tsHashtableDelete.Hours, tsHashtableDelete.Minutes, tsHashtableDelete.Seconds, tsHashtableDelete.Milliseconds * 10);
            Console.WriteLine("Hashtable delete time is: " + elapsedTimeHashtableDelete);
            Console.ReadKey();
        }
    }
}
