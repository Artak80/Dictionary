using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Elements<Tkey, Tvalue> : IElements<Tkey, Tvalue>
    {
        int count;
        Tkey[] key = null;
        Tvalue[] value = null;

        public Elements()
        {
            count = 0;
            key = new Tkey[4];
            value = new Tvalue[4];
        }

        public Tvalue this[Tkey keyEX]
        {
            get
            {
                int index = -1;
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i].Equals(keyEX))
                    {
                        index = i;
                        break;
                    }
                }
                if (index == -1)
                {
                    Console.Write("Wrong Key");
                    return default(Tvalue);
                }
                return value[index];
            }
        }

        //Метод, который добавляет в коллекцию пару "ключ-значение".
        public void AddbyKeyFirst(Tkey k, Tvalue v)
        {
            //Проверка на переполнения
            if (count >= key.Length)
            {
                Tkey[] keylong = new Tkey[2 * key.Length];

                for (int i = 0; i < count; i++)
                {
                    keylong[i + 1] = key[i];
                }

                key = keylong;
                key[0] = k;

                Tvalue[] valuelong = new Tvalue[2 * key.Length];

                for (int i = 0; i < count; i++)
                {
                    valuelong[i + 1] = value[i];
                }

                value = valuelong;
                value[0] = v;

                count++;
            }
            else
            {
                Tkey[] keylong = new Tkey[key.Length];

                for (int i = 0; i < count; i++)
                {
                    keylong[i + 1] = key[i];
                }
                key = keylong;
                key[0] = k;

                Tvalue[] valuelong = new Tvalue[key.Length + 1];

                for (int i = 0; i < count; i++)
                {
                    valuelong[i + 1] = value[i];
                }

                value = valuelong;
                value[0] = v;

                count++;
            }
        }

        //Метод, который добавляет в коллекцию "значение" по "ключу".
        public Tkey AddbyKey(Tkey z, Tvalue s)
        {
            //Проверка на переполнения.
            if (count < key.Length)
            {
                Tkey[] keylong = new Tkey[key.Length];

                for (int i = 0; i < count; i++)
                {
                    if (Convert.ToInt32(z) == i)
                    {
                        keylong[i] = z;
                    }
                    else { keylong[i] = key[i]; }
                }


                Tvalue[] valuelong = new Tvalue[key.Length];

                for (int i = 0; i < count; i++)
                {
                    if (Convert.ToInt32(z) == i)
                    {
                        valuelong[i] = s;
                    }
                    else { valuelong[i] = value[i]; }
                }

                value = valuelong;
                key = keylong;

                count++;
                return key[Convert.ToInt32(z)];
            }
            else
            {
                Tkey[] keylong = new Tkey[2 * key.Length];

                for (int i = 0; i < count; i++)
                {
                    if (Convert.ToInt32(z) == i)
                    {
                        keylong[i] = z;
                    }
                    else { keylong[i] = key[i]; }
                }

                Tvalue[] valuelong = new Tvalue[2 * key.Length];

                for (int i = 0; i < count; i++)
                {
                    if (Convert.ToInt32(z) == i)
                    {
                        valuelong[i] = s;
                    }
                    else { valuelong[i] = value[i]; }
                }

                value = valuelong;
                key = keylong;

                count++;
                return key[Convert.ToInt32(z)];
            }

        }
    }
}
