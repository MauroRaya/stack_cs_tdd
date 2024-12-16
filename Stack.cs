using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests {
    public class Stack {
        int[] elementos = new int[2];
        int count = 0;

        public bool EstaVazia() {
            return count == 0 ? true : false;
        }

        public void Push(int elemento) {
            elementos[count++] = elemento;
        }

        public int Pop() {
            if (EstaVazia()) {
                throw new Exception("A pilha está vazia.");
            }
            return elementos[--count];
        }
    }
}
