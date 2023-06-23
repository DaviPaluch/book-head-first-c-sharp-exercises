using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_a_cabeca_cap_08
{
    internal class Duck 
    {
        public int Size;
        public KindOfDuck Kind;

        public Duck(int size, KindOfDuck kind)
        {
            Size = size;
            Kind = kind;
        }

        public string ToString()
        {
            return (this.Kind.ToString() + " " + this.Size.ToString());
        }

        
    }

    public class DuckComparer_bySize : IComparer<Duck>
    {
        int IComparer<Duck>.Compare(Duck x, Duck y)
        {
            if (x.Size < y.Size)
                return -1;
            if (x.Size > y.Size)
                return 1;
            return 0;
        }
    }
    public class DuckComparer_byKind : IComparer<Duck>
    {
        int IComparer<Duck>.Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
                return -1;
            if (x.Kind > y.Kind)
                return 1;
            return 0;
        }
    }

    public class DuckComparer : IComparer<Duck>
    {
        public enum SortCriteria
        {
            SizeThenKind,
            KindThenSize

        }
        public SortCriteria SortBy = SortCriteria.SizeThenKind;


        int IComparer<Duck>.Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size < y.Size)
                    return -1;
                else if (x.Size > y.Size)
                    return 1;
                else
                {
                    if (x.Kind > y.Kind)
                        return 1;
                    else if(x.Kind < y.Kind)
                        return -1;
                    else
                        return 0;
                }
            }
            else
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if(x.Kind < y.Kind)
                    return -1;
                else 
                    return 0;
            }

        }

    }






    public enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }
}
