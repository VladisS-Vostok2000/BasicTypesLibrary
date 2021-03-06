using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypesLibrary {
    public sealed class ReadOnlyDoubleDemensionArray<T> {
        private readonly T[,] array;



        public T this[int y, int x] => array[y, x];



        public ReadOnlyDoubleDemensionArray(T[,] array) => this.array = array;

    }
}
