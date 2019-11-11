using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionario
{
    class Dicionario : IDicionario
    {
        private No[] hash;
        private int tamanho;

        public Dicionario()
        {
            this.hash = new No[13];
            this.tamanho = 0;
        }

        // Linear Probing
        // h(x) =x mod13
        private int lp(int k)
        {
            return k % this.hash.Length;
        }
        
        // Hashing Duplo
        private int hd(int k)
        {
            return (11 - k) % 11;
        }
        public object findElement(int k)
        {
            int i = lp(k);
            //j = p no slide
            for (int j = 0; j < this.hash.Length; j++)
            {
                // node = c no slide
                No node = this.hash[i];
                if (!(node == null))
                {
                    if (!node.isAvailable() && k == node.getK())
                    {
                        return node.getO();
                    }
                    else
                    {
                        i = (i + 1) % this.hash.Length;
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public void insertItem(int k, object o)
        {
            Console.WriteLine("Qual método deseja inserir?\n| 1 | - LinearProbing\n| 2 | - Hashing Duplo");
            int opcao = int.Parse(Console.ReadLine());

            if (this.tamanho == this.hash.Length)
            {
                Console.WriteLine("A tabela Hash encontra-se cheia");
            }

            int j = 0;
            int i = 0;
            while (true)
            {
                No node = new No();
                node.setO(o);
                node.setK(k);
                node.setAvailable(false);
                
                if (opcao == 1)
                {
                    i = j + lp(k);
                }
                else
                {
                    i = (i + k + j * hd(k)) % this.hash.Length;
                }
                j++;
                // j = p no slide

                if (this.hash[i] == null || this.hash[i].isAvailable())
                {
                    this.hash[i] = node;
                    this.tamanho++;
                    break;
                }
            }
        }

        public bool isEmpty()
        {
            return this.tamanho == 0;
        }

        public object removeElement(int k)
        {
            int i = lp(k);
            for (int j = 0; j < this.hash.Length; j++)
            {
                No node = this.hash[i];
                if (!(node == null))
                {
                    if (!node.isAvailable() && k == node.getK())
                    {
                        node.setAvailable(true);
                        this.tamanho--;
                        return node.getO();
                    }
                    else
                    {
                        i = (i + 1) % this.hash.Length;
                    }
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public int size()
        {
            return this.tamanho;
        }

        public void print()
        {
            for (int i = 0; i < hash.Length; i++)
            {
                if (this.hash[i] == null)
                {
                    Console.WriteLine("null");
                }
                // caso for removido
                else if (this.hash[i].isAvailable())
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine("| " + this.hash[i].getK() + " | " + this.hash[i].getO());
                }
            }
        }
    }
}
