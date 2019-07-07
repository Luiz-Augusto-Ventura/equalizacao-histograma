using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Histograma
    {
        private int[] k;
        private int[] nk;
        private float[] prk;
        private int[] novoK;

        public int[] K
        {
            get
            {
                return k;
            }

            set
            {
                k = value;
            }
        }

        public int[] Nk
        {
            get
            {
                return nk;
            }

            set
            {
                nk = value;
            }
        }

        public float[] Prk
        {
            get
            {
                return prk;
            }

            set
            {
                prk = value;
            }
        }

        public int[] NovoK
        {
            get
            {
                return novoK;
            }

            set
            {
                novoK = value;
            }
        }

        public int getMax()
        {
            int aux = 0;
            for (int i = 0; i < k.Length; i++)
            {
                if (k[i] > aux)
                    aux = k[i];
            }
            return aux;
        }

        public Histograma()
        {
            k = new int[256];
            nk = new int[256];
            prk = new float[256];
            novoK = new int[256];
        }

       
    }
}
