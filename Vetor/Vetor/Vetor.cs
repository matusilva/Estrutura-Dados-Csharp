using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    class Vetor
    {
        private Object[] vetor; //array
        private int n;          //tamanho do vetor
        public Vetor()
        {
            vetor = new Object[1];
            this.n = 0;
        }
        public int size()
        {
            return n;
        }
        public bool isEmpty()
        {
            return n == 0;
        }
        public Object elemAtRank(int rank)
        {
            if (isEmpty())
            {
                Console.WriteLine("Vetor Vazio");
                return "";
            }
            else
            {
                return vetor[rank];
            }
        }
        public void insertAtRank(int rank, Object element)
        {
            if (this.n == this.vetor.Length)
            {
                Object[] novoVetor = new Object[vetor.Length * 2];
                for (int i = 0; i < n; i++)
                {
                    novoVetor[i] = this.vetor[i];
                }
                this.vetor = novoVetor;
            }

            for (int i = n-1; i >= rank; i--)
            {
                //this.vetor[i] = this.vetor[i + 1];
                this.vetor[i + 1] = this.vetor[i];
            }

            this.vetor[rank] = element;
            n++;
        }
        public Object removeAtRank(int rank)
        {
            if (isEmpty())
            {
                Console.WriteLine("Vetor Vazio");
                return "";
            }

            else
            {
                Object temp = vetor[rank];
                for (int i = rank; i < n - 1; i++)
                {
                    this.vetor[i] = this.vetor[i + 1];
                    this.vetor[i + 1] = null;
                }

                n--;
                return temp;
            }
        }
        public Object replaceAtRank(int rank, Object element)
        {
            if (isEmpty())
            {
                Console.WriteLine("Vetor Vazio");
                return "";
            }

            else
            {
                this.vetor[rank] = element;
                return element;
            }
        }
        public String toString()
        {
            //int s = size();
            string saida = "size:" + n + "\t ";

            for (int i = 0; i < n; i++)
            {
                saida += vetor[i] + " ";
            }
            return saida;
        }
        public String imprimir()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            return " ";
        }
    }
}
