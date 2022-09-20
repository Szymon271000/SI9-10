using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeder
{
    public static class DataStrucuturesSeeder
    {
        public static void SeedDataStructures(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataStructure>().HasData(
                new DataStructure
                {
                    Id = 1,
                    Name = "Stack",
                    Description = "A stack is an ordered series of objects just like a list, but its intended use is slightly different. " +
                "We push objectives onto the stack and pop objects off of it.Stack are like a stack of pancakes. " +
                "If we want to add one, we add it to the top, because it is much easier (and faster) than lifting the whole stack of pancakes up and adding one to the bottom." +
                "Similarly, if we want to remove one, we ALSO remove it from the top, since that is much easier (and faster) that lifting the whole stack up and removing one from the bottom.Stack are referred to as Last In First Out(LIFO). " +
                "Furthermore, the first item pushed on the stack will be the last item removed from the stack. Stack are GREAT for programs where you need to reverse things.Stacks allow you to rewind time, and retrace our steps as needed. " +
                "One place where this shines is when you get an error — aka a stack trace, which allows you to retrace your steps to see where the error occurred. If the stack is empty, the only mutable operation that is valid is push." +
                "Popping an empty stack as we just saw here will cause an error because there’s nothing to pop, there’s nothing there.",
                    BigONotationValue = "Pushing, popping, and peeking takes Constant Time — O(1)"
                },
                new DataStructure
                {
                    Id = 2,
                    Name = "Queue",
                    Description = "Queues are similar to Stacks and Lists, but with different insertions and deletion rules. " +
                    "Queues have elements inserted at the end of the queue and elements removed from the beginning of the queue. " +
                    "Queues follow a First In First Out policy(FIFO). The first item in the queue(the one you can peek at) is the next item to be dequeued. " +
                    "Just like stacks, we implement queues with a List and limit how we operate on this data to create this data structure." +
                    "In this case, we should be able to add to the back, remove from the front and access the first item without removing it." +
                    " Queues are great for storing the order of things that need to happen. " +
                    "Like with stacks, the most common error that comes up is when you try to dequeue from an empty queue because we cannot remove anything from a queue that’s empty. " +
                    "In operating systems Queues are often used for controlling access to shared system resources such as printers, files, communication lines, disks and tapes. " +
                    "They are also very commonly used in multi - threading and concurrency situations to keep track of what tasks are waiting to be performed and making sure we take them in that order.",
                    BigONotationValue = "Enqueuing to the back and dequeuing from the front is also very quick and takes constant time — O(1) because the queue has a doubly-linked list implementation."
                },
                new DataStructure
                {
                    Id=3,
                    Name = "Linked List",
                    Description= "A Linked List is a linear data structure. However, the elements of a Linked List are not stored at contiguous locations (i.e. next to each other in memory). " +
                    "Instead, we link the elements using pointers.A Linked List is similar to an array,but you MUST start with the first element of the array, which is called the Head of the List." +
                    "The elements in a Linked List are called nodes, and this first node contains data and also contains a pointer to the second node in the Linked List.The ONLY way to get to the second node is by following the pointer found in the first node." +
                    "Once you get to the second node, you can use its pointer to get to the third node, and so on. Linked lists are very useful when you need to do a lot of insertions and removals, but not too much searching, on a list of arbitrary(unknown at compile - time) length.",
                    BigONotationValue= "Adding an element to the front of the list: Linked List: O(1) " +
                    "Removing an element from the front of the list: Linked List: O(1) " +
                    "Getting an element in a known position: Linked List: O(n) - you have to walk down the list until you reach the position you want."
                },
                new DataStructure
                {
                    Id = 4,
                    Name= "Hash Table",
                    Description= "Most associative arrays, whether they are dictionaries, maps, or hashes, are implemented using a hash table. " +
                    "When a hash table iss created internally, it’s really an array - based data structure where we add extra functionality to get us past the limitations of an array. " +
                    "We use the term bucket to describe each entry or place for a key-value pair to go in a hash table." +
                    "We'll never add just a key or just a value. We'll always add a pair. " +
                    "Depending on the language, we might use the word put, add or insert to add a new key value pair.",
                    BigONotationValue = "Insertion and deletion all take Constant Time — O(1), because its runtime is consistent across any input."
                },
                new DataStructure 
                { 
                    Id = 5,
                    Name = "Binary Search Tree",
                    Description = "A Binary Search Tree (BST) adds an order contraint. " +
                    "We keep a sorted data structure by being particular about what values are in the left child, right child, and parent nodes. " +
                    "This makes the data structure more than just a collection of stuff strung together." +
                    "It stays sorted without immense amounts of reshuffling that would be needed in a basic array. " +
                    "The rule for BST’s is: A left child node must be less than its parent and a right child node must be more than its parent.",
                    BigONotationValue = "Balanced BST: Logarithmic time — O(log n) Unbalanced BST: Linear time — O(n)"
                },
                new DataStructure
                {
                    Id = 6,
                    Name = "Graph",
                    Description = "A Graph is a non-linear data structure consisting of vertices and edges. " +
                    "The vertices are sometimes also referred to as nodes and the edges are lines or arcs that connect any two nodes in the graph. " +
                    "More formally a Graph is composed of a set of vertices( V ) and a set of edges( E ). The graph is denoted by G(E, V). " +
                    "Vertices: Vertices are the fundamental units of the graph.Sometimes, vertices are also known as vertex or nodes." +
                    "Every node / vertex can be labeled or unlabelled. Edges: Edges are drawn or used to connect two nodes of the graph." +
                    "It can be ordered pair of nodes in a directed graph.Edges can connect any two nodes in any possible way." +
                    "There are no rules.Sometimes, edges are also known as arcs.Every edge can be labeled / unlabelled. " +
                    "Graphs are used to solve many real - life problems.Graphs are used to represent networks." +
                    "The networks may include paths in a city or telephone network or circuit network.Graphs are also used in social networks like linkedIn, Facebook." +
                    "For example, in Facebook, each person is represented with a vertex(or node).Each node is a structure and contains information like person id, name, gender, locale etc.",
                    BigONotationValue = "Adjacency list: Storage size:  O (|V| +|E|), Add vertex O(1), Add edge: O(1), Remove vertex: O (|V| +|E|), Remove edge: O(|E|),  Query: O(|V|)"
                }
                ) ;

        }
    }
}
