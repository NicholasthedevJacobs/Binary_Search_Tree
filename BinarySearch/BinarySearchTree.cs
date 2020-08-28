using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearchTree
    {
        //member variables
        public Node RootNode;
        public Node LastNode;

        //constructor

        //member methods
        public void Add(Node nodeToAdd)
        {
            if(RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else if(nodeToAdd.data > RootNode.data) 
            {
                LastNode.NextNode = nodeToAdd.RightNode;
                
            }
            else
            {
                LastNode.NextNode = nodeToAdd.LeftNode;
            }
        }
        public void Search(Node nodeToSearch)
        {
            if(nodeToSearch.data > RootNode.data)
            {
                RootNode.NextNode
            }
        }
    }
}
