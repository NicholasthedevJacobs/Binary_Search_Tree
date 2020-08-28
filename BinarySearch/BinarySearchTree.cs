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
            else
            {
                Node currentNode = RootNode;
                while (true)
                {

                }
            }

        }
        public void Search(Node nodeToSearch)
        {
            Node currentNode = RootNode;
            //bool goLeft = true;
            while (true)
            {
                if (nodeToSearch.data > currentNode.data)
                {
                    currentNode = currentNode.RightNode;

                }
                else if (nodeToSearch.data < currentNode.data)
                {
                    currentNode = currentNode.LeftNode;
                    //goLeft = true;                
                }
                else
                {
                    nodeToSearch = currentNode;
                    break;
                }
            }                     
        }
    }
}
